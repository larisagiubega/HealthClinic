
namespace HealthClinic
{
    using HealthClinic.DTOs;
    using HealthClinic.Exceptions;
    using HealthClinic.Interfaces;
    using HealthClinic.Localization;
    using iTextSharp.text.pdf;
    using iTextSharp.text.pdf.parser;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Resources;
    using System.Text;

    public static class UsePDF
    {
        private static ResourceManager res = HealthClinicLocalization.GetResourceManager();

        private const string PATH = @"D:\FACULTATE\Licenta\HealthClinicSolution\HealthClinic\Documents";
        private const string MOVE_TO_PATH = @"D:\FACULTATE\Licenta\HealthClinicSolution\HealthClinic\Documents\Processed invoices\";
        private const string FILE_FORMAT = "*.pdf";

        private const string MOVE_FORMAT = "dd/MM/yyyy HHmmssff";

        private const string TOTAL = "total";
        private const string DATE = "DATE: ";
        private const string FROM = "FROM: ";
        private const string INVOICE_NUMBER = "INVOICE #";

        public static List<InvoiceDto> GetValidatedInvoices(string username)
        {
            List<InvoiceDto> validatedInvoices = new List<InvoiceDto>();

            try
            {
                var allInvoices = GetAllValidPdfs();
                string invoicePath;

                foreach (var invoice in allInvoices)
                {
                    invoicePath = invoice.FullName;

                    var invoiceContent = ReadPdf(invoicePath);
                    validatedInvoices.Add(MapInvoiceContent(invoiceContent, username));
                    MoveProcessed(invoicePath);
                }
            }
            catch (Exception exception)
            {
                Logger.Log(exception.Message);
                validatedInvoices.Clear();
            }
            return validatedInvoices;
        }

        private static InvoiceDto MapInvoiceContent(string invoiceContent, string username)
        {
            var contentList = invoiceContent.Split('\n').Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

            //get all important data from the invoice regarding the date, the supplier's name, invoice number and medicine list content
            DateTime invoiceDateTime = GetInvoiceDateTime(contentList);
            string supplierName = GetSupplierName(contentList);
            string invoiceNumber = GetInvoiceNumber(contentList);

            List<MedicineDto> medicineList = GetInvoiceMedicine(contentList, invoiceDateTime);
            
            InvoiceDto invoiceDto = new InvoiceDto
            {
                ValidatedBy = username,
                MedicineList = medicineList,
                BillingDate = invoiceDateTime,
                RegistrationDate = DateTime.Now,
                SupplierName = supplierName,
                InvoiceNumber = invoiceNumber
            };

            return invoiceDto;
        }

        private static string GetInvoiceNumber(List<string> contentList)
        {
            var invoiceIndex = contentList.FindIndex(x => x.Contains(INVOICE_NUMBER));

            string invoiceNumber = contentList[invoiceIndex].Split('#')[1];

            return invoiceNumber;
        }

        private static string GetSupplierName(List<string> contentList)
        {
            var fromIndex = contentList.FindIndex(x => x.Contains(FROM));

            string supplierName = contentList[fromIndex + 1];

            return supplierName;
        }

        private static List<MedicineDto> GetInvoiceMedicine(List<string> contentList, DateTime invoiceDateTime)
        {
            List<MedicineDto> invoiceMedicine = new List<MedicineDto>();

            int totalFirstIndex = contentList.FindIndex(x => x.ToLower().Contains(TOTAL));
            int totalLastIndex = contentList.FindLastIndex(x => x.ToLower().Contains(TOTAL));

            List<string> medicineContentList = contentList.Skip(totalFirstIndex + 1).Take(totalLastIndex - totalFirstIndex - 1).ToList();

            foreach (var medicineContent in medicineContentList)
            {
                var medicine = medicineContent.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

                invoiceMedicine.Add(new MedicineDto
                {
                    LastBilling = invoiceDateTime,
                    MedicineName = String.Join(" ", medicine.Skip(1).Take(medicine.Length - 3)), // -3 because of the Quantity, Price and Total columns
                    Quantity = Convert.ToInt32(medicine[0])
                });
            }

            return invoiceMedicine;
        }

        private static DateTime GetInvoiceDateTime(List<string> contentList)
        {
            var dateString = contentList.Where(x => x.ToLower().Contains("date")).FirstOrDefault().Replace(DATE, "");

            CultureInfo culture = new CultureInfo("ro-RO"); //european
            DateTime date = Convert.ToDateTime(dateString, culture);

            return date;
        }

        private static string ReadPdf(string pdfPath)
        {
            StringBuilder content = new StringBuilder();

            try
            {
                using (PdfReader reader = new PdfReader(pdfPath))
                {
                    for (int page = 1; page <= reader.NumberOfPages; page++)
                    {
                        ITextExtractionStrategy extractionStrategy = new SimpleTextExtractionStrategy();
                        string text = PdfTextExtractor.GetTextFromPage(reader, page, extractionStrategy);
                        text = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(text)));
                        content.Append(text);
                    }
                }
            }
            catch
            {
                content.Append(string.Empty);
                Logger.Log(res.GetString(new UsePDFException().Message));
            }

            return content.ToString();
        }

        private static FileInfo[] GetAllValidPdfs()
        {
            DirectoryInfo directory = new DirectoryInfo(PATH);
            FileInfo[] files = directory.GetFiles(FILE_FORMAT);

            return files;
        }

        public static bool MoveProcessed(string fromPath)
        {
            bool success = true;

            try
            {
                File.Move(fromPath, $"{MOVE_TO_PATH}{DateTime.Now.ToString(MOVE_FORMAT)}.pdf");
            }
            catch (Exception exception)
            {
                Logger.Log(exception.Message);
                success = false;
            }

            return success;
        }
    }
}

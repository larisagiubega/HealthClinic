using HealthClinic.DTOs;
using System.Linq;
using HealthClinic.Interfaces;
using System;
using System.Resources;
using HealthClinic.Localization;

namespace HealthClinic.DAL
{
    public class InvoiceDal : IInvoiceDal
    {
        HealthClinicEntities _ctx;

        private ResourceManager res = HealthClinicLocalization.GetResourceManager();

        public InvoiceDal(HealthClinicEntities ctx)
        {
            _ctx = ctx;
        }
        public bool SaveInvoiceToDatabase(InvoiceDto invoiceDto)
        {
            bool success;

            try
            {
                INVOICE invoice = new INVOICE
                {
                    BILLING_DATE = invoiceDto.BillingDate,
                    REGISTRATION_DATE = DateTime.Now,
                    INVOICE_NUMBER = invoiceDto.InvoiceNumber,
                    SUPPLIER_NAME = invoiceDto.SupplierName,
                    VALIDATED_BY = invoiceDto.ValidatedBy
                };

                _ctx.INVOICE.Add(invoice);
                _ctx.SaveChanges();

                success = true;
            }
            catch
            {
                success = false;
                    
            }

            return success;

        }
    }
}


namespace HealthClinic
{
    using Excel = Microsoft.Office.Interop.Excel;
    using System;
    using System.Collections.Generic;
    using HealthClinic.DTOs;
    using System.Linq;
    using HealthClinic.Interfaces;
    using HealthClinic.Exceptions;
    using System.Resources;
    using HealthClinic.Localization;

    public static class UseExcel
    {
        private static ResourceManager res = HealthClinicLocalization.GetResourceManager();

        private static Excel.Application application;
        private static Excel._Workbook workbook;
        private static Excel.Sheets worksheets;
        //Excel._Worksheet sheet;
        private static Excel.Range range;

        private static object misValue = System.Reflection.Missing.Value;

        #region other variables
        //public static IUserDal userDal;

        public static IAppointmentsPresenter appointmentsPresenter; //initialized in MainForm
        #endregion

        #region appointments constants
        //must be the same order as the excel's columns

        private const string FIRST_NAME = "first name"; // equivalent to A column
        private const string LAST_NAME = "last name"; // equivalent to B column
        private const string PHONE_NUMBER = "phone number"; // equivalent to C column
        private const string APPOINTMENT_DATE = "appointment date"; // equivalent to D column
        private const string DOCTOR_NAME = "doctor name"; // equivalent to E column

        private const string APPOINTMENTS = "appointments"; // sheet's name

        #endregion

        #region appointments variables

        private static List<string> firstNameList = new List<string>(); //equivalent to A column
        private static List<string> lastNameList = new List<string>(); //equivalent to B column
        private static List<string> phoneNoList = new List<string>(); //equivalent to C column
        private static List<string> dateList = new List<string>(); //equivalent to D column
        private static List<string> doctorNameList = new List<string>(); //equivalent to E column

        private static string pathForAppointments = @"D:\FACULTATE\Licenta\HealthClinicSolution\HealthClinic\Documents\Appointments.xlsx";

        #endregion

        #region public methods

        private static List<AppointmentDto> appointments = new List<AppointmentDto>();

        public static List<AppointmentDto> GetAppointmentsFromExcel()
        {
            ReadAppointments();

            return appointments;
        }

        public static bool SaveAppointmentToExcel(AppointmentDto appointment)
        {
            var success = false;
            string[] appointmentDetails = new string[5]; //string corresponding to the values inside the object

            appointmentDetails[0] = appointment.FirstName;
            appointmentDetails[1] = appointment.LastName;
            appointmentDetails[2] = appointment.PhoneNumber;
            appointmentDetails[3] = String.Format("{0:dd/MM/yyyy HH:mm}", appointment.Date);
            appointmentDetails[4] = $"{appointment.Doctor.FirstName} {appointment.Doctor.LastName}";

            try
            {
                StartExcelAndGetObjects(pathForAppointments, visible: false);

                foreach (Excel.Worksheet worksheet in worksheets)
                {
                    if (worksheet.Name.ToLower().Equals(APPOINTMENTS))
                    {
                        var currentRange = worksheet.UsedRange;

                        char lastColumnLetter = GetLetterByNumber(currentRange.Columns.Count - 1);
                        int lastRow = currentRange.Rows.Count == 1 ? 2 : currentRange.Rows.Count;

                        worksheet.get_Range($"A{lastRow}", $"{lastColumnLetter}{lastRow}").Value = appointmentDetails;
                        success = true;
                    }
                }
            }
            catch
            {
                success = false;
                Logger.Log(res.GetString(new SaveAppointmentsException().Message));
            }
            finally
            {
                CloseExcelAndReleaseObjects();
            }

            return success;
        }

        #endregion

        #region private methods

        private static void ReadAppointments()
        {
            StartExcelAndGetObjects(pathForAppointments);

            try
            {
                foreach (Excel.Worksheet worksheet in worksheets)
                {
                    if (worksheet.Name.ToLower().Equals(APPOINTMENTS))
                    {
                        var currentRange = worksheet.UsedRange;

                        int lastColumn = currentRange.Columns.Count;
                        int lastRow = currentRange.Rows.Count;

                        GetContentsFrom(worksheet, lastColumn, lastRow);
                        DeleteContentsFromSheet(worksheet);
                        FilllHeaderOfSheet(worksheet, APPOINTMENTS);
                    }
                }

                ConvertContentToAppointments();
            }
            catch
            {
                Logger.Log(res.GetString(new ReadAppointmentsException().Message));
            }
            finally
            {
                CloseExcelAndReleaseObjects();
            }
        }

        private static void FilllHeaderOfSheet(Excel.Worksheet worksheet, string sheetName)
        {
            switch (sheetName)
            {
                case APPOINTMENTS:
                    {
                        worksheet.Cells[1, 1] = FIRST_NAME.Replace(FIRST_NAME[0], char.ToUpper(FIRST_NAME[0]));
                        worksheet.Cells[1, 2] = LAST_NAME.Replace(LAST_NAME[0], char.ToUpper(LAST_NAME[0]));
                        worksheet.Cells[1, 3] = PHONE_NUMBER.Replace(PHONE_NUMBER[0], char.ToUpper(PHONE_NUMBER[0]));
                        worksheet.Cells[1, 4] = APPOINTMENT_DATE.Replace(APPOINTMENT_DATE[0], char.ToUpper(APPOINTMENT_DATE[0]));
                        worksheet.Cells[1, 5] = DOCTOR_NAME.Replace(DOCTOR_NAME[0], char.ToUpper(DOCTOR_NAME[0]));
                        break;
                    }
                default: break;
            }
        }

        private static void DeleteContentsFromSheet(Excel.Worksheet worksheet)
        {
            worksheet.Cells.Delete();
        }

        private static void ConvertContentToAppointments()
        {
            AppointmentDto appointment;

            var listSizes = new List<int> { firstNameList.Count, lastNameList.Count, phoneNoList.Count, dateList.Count, doctorNameList.Count };
            int minSize = listSizes.Min();

            if (minSize > 0)
            {
                for (int i = 0; i < minSize; i++)
                {
                    appointment = new AppointmentDto
                    {
                        FirstName = firstNameList[i],
                        LastName = lastNameList[i],
                        PhoneNumber = phoneNoList[i],
                        Date = Convert.ToDateTime(dateList[i]),
                        Doctor = appointmentsPresenter.GetDoctorByFullName($"{doctorNameList[i]}")
                    };

                    appointments.Add(appointment);
                }
            }
            else //if any column has no data
            {
                throw new NoDataException();
            }
        }

        private static void GetContentsFrom(Excel.Worksheet worksheet, int lastColumn, int lastRow)
        {
            char columnLetter;

            for (int column = 0; column <= lastColumn; column++)
            {
                columnLetter = GetLetterByNumber(column);
                var content = worksheet.get_Range($"{columnLetter}1", $"{columnLetter}{lastRow}").Value;

                GetColumnContentsAccordingly(columnLetter, content);
            }
        }

        private static char GetLetterByNumber(int column)
        {
            return (char)(column + 65);
        }

        private static void GetColumnContentsAccordingly(char columnLetter, dynamic content)
        {
            switch (columnLetter)
            {
                case 'A':
                    GetFirstNameList(content);
                    break;
                case 'B':
                    GetLastNameList(content);
                    break;
                case 'C':
                    GetPhoneNoList(content);
                    break;
                case 'D':
                    GetAppointmentDateList(content);
                    break;
                case 'E':
                    GetDoctorNameList(content);
                    break;
                default: break;
            }
        }

        private static void StartExcelAndGetObjects(string path, bool visible = true)
        {
            application = new Excel.Application();
            application.Visible = visible;

            workbook = application.Workbooks.Open(path);
            worksheets = application.Sheets;
        }
        private static void CloseExcelAndReleaseObjects()
        {
            workbook.Close(true, misValue, misValue);
            application.Quit();

            releaseObject(workbook);
            releaseObject(application);
        }

        private static void GetFirstNameList(dynamic contents)
        {
            foreach (var content in contents)
            {
                if (content != null)
                {
                    var contentAsString = Convert.ToString(content);

                    if (!contentAsString.ToLower().Contains(FIRST_NAME))
                    {
                        firstNameList.Add(contentAsString);
                    }
                }
            }
        }
        private static void GetLastNameList(dynamic contents)
        {
            foreach (var content in contents)
            {
                if (content != null)
                {
                    var contentAsString = Convert.ToString(content);

                    if (!contentAsString.ToLower().Contains(LAST_NAME))
                    {
                        lastNameList.Add(contentAsString);
                    }
                }
            }
        }
        private static void GetPhoneNoList(dynamic contents)
        {
            foreach (var content in contents)
            {
                if (content != null)
                {
                    var contentAsString = Convert.ToString(content);

                    if (!contentAsString.ToLower().Contains(PHONE_NUMBER))
                    {
                        phoneNoList.Add(contentAsString);
                    }
                }
            }
        }
        private static void GetAppointmentDateList(dynamic contents)
        {
            foreach (var content in contents)
            {
                if (content != null)
                {
                    var contentAsString = Convert.ToString(content);

                    if (!contentAsString.ToLower().Contains(APPOINTMENT_DATE))
                    {
                        dateList.Add(contentAsString);
                    }
                }
            }
        }
        private static void GetDoctorNameList(dynamic contents)
        {
            foreach (var content in contents)
            {
                if (content != null)
                {
                    var contentAsString = Convert.ToString(content);

                    if (!contentAsString.ToLower().Contains(DOCTOR_NAME))
                    {
                        doctorNameList.Add(contentAsString);
                    }
                }
            }
        }
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }
        #endregion
    }
}

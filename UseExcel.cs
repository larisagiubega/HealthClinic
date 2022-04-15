
namespace HealthClinic
{
    using Excel = Microsoft.Office.Interop.Excel;
    using System.Reflection;
    using System;
    using System.Text;
    using System.Collections.Generic;
    using HealthClinic.DTOs;
    using System.Linq;
    using HealthClinic.Interfaces;
    using HealthClinic.DAL;

    public static class UseExcel
    {
        private static Excel.Application application;
        private static Excel._Workbook workbook;
        private static Excel.Sheets worksheets;
        //Excel._Worksheet sheet;
        private static Excel.Range range;

        private static object misValue = System.Reflection.Missing.Value;

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

        public static bool SaveAppointmentToExcel(AppointmentDto appointment) {
            return true;
        }

        #endregion

        #region private methods

        private static void ReadAppointments()
        {
            StartExcelAndGetObjects(pathForAppointments);

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
                ConvertContentToAppointments();

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

            if (minSize > 1) //the columns' first row is always the column's name
            {
                for (int i = 0; i < minSize; i++)
                {
                    appointment = new AppointmentDto
                    {
                        FirstName = firstNameList[i],
                        LastName = lastNameList[i],
                        PhoneNumber = phoneNoList[i],
                        Date = Convert.ToDateTime(dateList[i]),
                        Doctor = new UserDto
                        {
                            FirstName = doctorNameList[i].Split(' ')[0],
                            LastName = doctorNameList[i].Split(' ')[1]
                            //todo: get username by first and last name in Presenter
                        }
                    };

                    appointments.Add(appointment);
                }
            }
            else //if any column has no data
            {
                CloseExcelAndReleaseObjects();
                throw new Exception();
            }
        }

        private static void GetContentsFrom(Excel.Worksheet worksheet, int lastColumn, int lastRow)
        {
            char columnLetter;

            for (int column = 0; column <= lastColumn; column++)
            {
                columnLetter = (char)(column + 65);
                var content = worksheet.get_Range($"{columnLetter}1", $"{columnLetter}{lastRow}").Value;

                GetColumnContentsAccordingly(columnLetter, content);
            }
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

        private static void StartExcelAndGetObjects(string path)
        {
            application = new Excel.Application();
            application.Visible = true;

            workbook = application.Workbooks.Open(path);
            worksheets = application.Sheets;
        }
        private static void CloseExcelAndReleaseObjects()
        {
            workbook.Close(true, misValue, misValue);
            application.Quit();

            //releaseObject(sheet);
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
            catch (Exception ex)
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

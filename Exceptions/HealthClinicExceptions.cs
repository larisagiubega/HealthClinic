using System;
using System.Resources;

namespace HealthClinic.Exceptions
{
    #region APPOINTMENTS
    public class SaveAppointmentsException : Exception
    {
        public override string Message
        {
            get
            {
                return "AppointmentsCouldNotBeSaved";
            }
        }
    }

    public class GetAppointmentsForUserException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotGetAppointmentsForUser";
            }
        }
    }

    #endregion

    #region DISEASES/SYMPTOMS
    public class GetAllDiseasesException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotGetAllDiseases";
            }
        }
    }
    public class GetAllSymptomsException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotGetAllSymptoms";
            }
        }
    }
    public class OrderSymptomsException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotOrderSymptoms";
            }
        }
    }

    #endregion

    #region INVOICE
    #endregion

    #region MEDICINE

    public class GetAllMedicineException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotGetAllMedicine";
            }
        }
    }


    #endregion

    #region NOTICE_BOARD
    public class AddNoticeException : Exception
    {
        public override string Message
        {
            get
            {
                return "AddingNoticeUnsuccessful";
            }
        }
    }

    public class DeleteNoticeException : Exception
    {
        public override string Message
        {
            get
            {
                return "DeletingNoticeUnsuccessful";
            }
        }
    }

    public class EditNoticeException : Exception
    {
        public override string Message
        {
            get
            {
                return "EditingNoticeUnsuccessful";
            }
        }
    }
    public class GetAllNoticesException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotGetAllNotices";
            }
        }
    }

    public class LastWeekNoticesException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotGetLastWeekNotices";
            }
        }
    }

    #endregion

    #region RIGHT
    public class GetRightException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotGetRight";
            }
        }
    }

    #endregion

    #region SCHEDULE
    public class AddScheduleException : Exception
    {
        public override string Message
        {
            get
            {
                return "ScheduleCannotBeCreated";
            }
        }
    }
    public class CannotGetSchedule : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotGetSchedule";
            }
        }
    }

    #endregion

    #region SHIFT
    public class GetAllShiftsException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotGetAllShifts";
            }
        }
    }
    public class GetAllShiftsForUserException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotGetAllShiftsForUser";
            }
        }
    }
    public class GetShiftByHoursException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotGetShiftsByHour";
            }
        }
    }

    public class GetHoursException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotGetStartEndHour";
            }
        }
    }

    #endregion

    #region USER
    public class GetAllAccountsException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotGetAllAccounts";
            }
        }
    }
    public class GetAllDoctorsAccountsException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotGetAllDoctorsAccounts";
            }
        }
    }
    public class GetAllAdminsAccountsException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotGetAllAdminsAccounts";
            }
        }
    }
    public class GetUserByNameException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotGetUserByName";
            }
        }
    }
    public class GetUserByUsernameException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotGetUserByUsername";
            }
        }
    }
    public class GetFullNameException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotGetFullName";
            }
        }
    }

    #endregion

    #region MISCELLANEOUS

    public class FillByLanguageException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotFillByLanguage";
            }
        }
    }
    public class GetLanguageException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotGetLanguage";
            }
        }
    }
    public class SetLanguageException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotSetLanguage";
            }
        }
    }
    public class ReadLanguageException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotReadLanguage";
            }
        }
    }

    public class EncryptionException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotEncrypt";
            }
        }
    }


    public class DecryptionException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotDecrypt";
            }
        }
    }

    public class SendEmailException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotSendEmail";
            }
        }
    }
    public class NoDataException : Exception
    {
        public override string Message
        {
            get
            {
                return "NoDataInColumn";
            }
        }
    }
    public class ReadAppointmentsException : Exception
    {
        public override string Message
        {
            get
            {
                return "CannotReadAppointments";
            }
        }
    }

    #endregion
}


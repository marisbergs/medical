using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    /// <summary>
    /// Enumeration of supported error messages
    /// </summary>
    public enum Err
    {
        NoError = 0,

        HasErrors,
        TimeIntervalOverlap,
        InvalidDateInterval,
        InvalidVisitTime,
        InvalidDateValueLes, // {0}
        InvalidDateValueGrt, // {0}
        InvalidDecimalValueLes, // {0}
        InvalidDecimalValueGrt, // {0}
        InvalidDateInclusion,
        FutureDate,
        PastDate,
        TooBig,
        TooLong,  // max {0}
        TooShort, // min {0}
        Negative,
        ValueRequired,
        EmailNotValid,
        HasFieldErrors,
        UnhandledException,
        InvalidLoginInformation,
        HierClassifierDeleteChild,
        CouldNotSave,
        CouldNotDelete,
        RoleIsBysy,
        TemplateFileOpened
    }

    /// <summary>
    /// Enumeration of supported informational messages and queries
    /// </summary>
    public enum Msg
    {
        NoPermissionToDelete,
        QuestionMark,
        DeleteConfirmation,
        Save,
        StaleObject,
        PromptStatusChange,
        SaveNewVersion,
        CloseApp,
        ActivateConfirmation,
        EntryAlreadyDeleted,
        CantGenerateUnlessSaved,
        GenerateAgain,
        IncorrectPassword,
        UserConfirmLockout
    }
    
    /// <summary>
    /// Helper class for building localized messages
    /// </summary>
    public static class ErrMsg
    {
        /// <summary>
        /// Returns message that corresponds to code {<paramref name="prefix"/>}.{<paramref name="msgCodeObject"/>.ToString()}
        /// </summary>
        /// <param name="prefix">message code prefix</param>
        /// <param name="msgCodeObject">object, whose ToString() method will be used to generate the rest of the code</param>
        /// <param name="parameters">optional message parameters</param>
        /// <returns>Localized message string with parameters applied</returns>
        public static string GetText(string prefix, object msgCodeObject, params object[] parameters)
        {
            return Core.Localization.Instance.Translate(new StringBuilder(prefix).Append(".").Append(msgCodeObject.ToString()).ToString(), parameters);
        }
        /// <summary>
        /// Returns error message that corresponds to code ERR.{<paramref name="errMsg"/>.ToString()}
        /// </summary>
        /// <param name="msgEnum">error message enum value</param>
        /// <param name="parameters">optional message parameters</param>
        /// <returns>Localized error message string with parameters applied</returns>
        public static string GetText(Enum msgEnum, params object[] parameters)
        {
            return Core.Localization.Instance.Translate(GetCode(msgEnum), parameters);
        }

        public static String GetCode(Enum msgEnum)
        {
            return msgEnum.GetType().Name.Replace('_', '.') + "." + System.Enum.GetName(msgEnum.GetType(), msgEnum);
        }
        ///// <summary>
        ///// Returns informational message that corresponds to code MSG.{<paramref name="infoMsg"/>.ToString()}
        ///// </summary>
        ///// <param name="infoMsg">message enum value</param>
        ///// <param name="parameters">optional message parameters</param>
        ///// <returns>Localized message string with parameters applied</returns>
        //public static string GetText(Msg infoMsg, params object[] parameters)
        //{
        //    return GetText("MSG", infoMsg, parameters);
        //}
        ///// <summary>
        ///// Returns Violation description.{<paramref name="infoMsg"/>.ToString()}
        ///// </summary>
        ///// <param name="infoMsg">message enum value</param>
        ///// <param name="parameters">optional message parameters</param>
        ///// <returns>Localized message string with parameters applied</returns>
        //public static string GetText(Violation infoMsg, params object[] parameters)
        //{
        //    return GetText("Violation", infoMsg, parameters);
        //}
    }

}

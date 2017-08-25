using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Assets
{
    public static class Utils
    {
        public static string FormatDateAlone(DateTime date)
        {
            string dateNew = date.ToString("MM/dd/yyyy");
            return dateNew;
        }

        public static string FormatDateTime(DateTime date)
        {
            string dateNew = date.ToString("MM/dd/yyyy hh:mm:ss");
            return dateNew;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostLoading
{
    static class CrossCutting
    {
        public static void ChangeKeybaordToPersian()
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("fa-IR");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(culture);
        }
        
        public static string RemoveDecimalChar(this string value)
        {
            return value != null ? value.Replace(",", "") : "";
        }       


        public static long? ToLong(this string value)
        {
            return value == null ? null : (long?)Int64.Parse(value.RemoveDecimalChar());
        }

        public static double? ToDouble(this string value)
        {
            return value == null ? null : (double?)Double.Parse(value.RemoveDecimalChar());
        }

        public static int ToInt(this object value)
        {
            return value == null ? 0 : Int32.Parse(value.ToString().RemoveDecimalChar());
        }


        public static string RemoveArabicKaf(this string value)
        {
            return value.Replace("ك", "ک");
        }


        public static string ReplaceWithArabicYa(this string value)
        {
            return value.Replace("ی", "ي");
        }
    }
}

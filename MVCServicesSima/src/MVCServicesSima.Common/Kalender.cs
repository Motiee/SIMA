using System;
using System.Globalization;

namespace MVCServicesSima.Common
{
    public class Kalender
    {

        public DateTime GregorianDate(string persianDate)
        {
            DateTime dt = DateTime.Parse(persianDate, new System.Globalization.CultureInfo("fa-IR"));
            return dt;
        }

        public string PersianDate(DateTime gregorianDate, bool showShort = true)
        {
            PersianCalendar pc = new PersianCalendar();
            if (showShort)
            {
                return (string.Format("{0}/{1}/{2} {3}:{4}:{5}", pc.GetYear(gregorianDate), pc.GetMonth(gregorianDate), pc.GetDayOfMonth(gregorianDate), pc.GetHour(gregorianDate), pc.GetMinute(gregorianDate), pc.GetSecond(gregorianDate)));
            }
            else
            {
                return (string.Format("{0}/{1}/{2}", pc.GetYear(gregorianDate), pc.GetMonth(gregorianDate), pc.GetDayOfMonth(gregorianDate)));
            }

        }





        public string PersianDate(string gregorianDate)
        {
            DateTime d = DateTime.Parse(gregorianDate);
            PersianCalendar pc = new PersianCalendar();
            return (string.Format("{0}/{1}/{2} {3}:{4}:{5}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d), pc.GetHour(d), pc.GetMinute(d), pc.GetSecond(d)));
        }
    }

}

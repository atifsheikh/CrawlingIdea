using OneKey.Database.Config;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneKey.Crawler
{
    class DateManagement
    {
        public static bool TryParseDateTime(string rawDateTime, Forum f, out DateTime dateTime)
        {
            // Handle number suffixes.
            rawDateTime = rawDateTime.Replace("1st", "1");
            rawDateTime = rawDateTime.Replace("2nd", "2");
            rawDateTime = rawDateTime.Replace("3rd", "3");
            rawDateTime = rawDateTime.Replace("th", ""); // Remember (th)ursday etc.
            rawDateTime = rawDateTime.Replace("mån ", ""); // Måndag
            rawDateTime = rawDateTime.Replace("Måndag ", ""); // Måndag
            rawDateTime = rawDateTime.Replace("Mån ", ""); // Måndag
            rawDateTime = rawDateTime.Replace("M&aring;n ", ""); // Måndag
            rawDateTime = rawDateTime.Replace("Tis ", ""); // Tisdag
            rawDateTime = rawDateTime.Replace("Tisdag ", ""); // Tisdag
            rawDateTime = rawDateTime.Replace("Tor ", ""); // Torsdag
            rawDateTime = rawDateTime.Replace("Tors ", ""); // Torsdag
            rawDateTime = rawDateTime.Replace("tor ", ""); // Torsdag
            rawDateTime = rawDateTime.Replace("Torsdag ", ""); // Torsdag
            rawDateTime = rawDateTime.Replace("fre ", ""); // Fredag
            rawDateTime = rawDateTime.Replace("Fredag ", ""); // Fredag
            rawDateTime = rawDateTime.Replace("Fre ", ""); // Fredag
            rawDateTime = rawDateTime.Replace("lör ", ""); // Lördag
            rawDateTime = rawDateTime.Replace("Lör ", ""); // Lördag
            rawDateTime = rawDateTime.Replace("Lördag ", ""); // Lördag
            rawDateTime = rawDateTime.Replace("L&ouml;r ", ""); // Lördag
            rawDateTime = rawDateTime.Replace("Sön ", ""); // Söndag
            rawDateTime = rawDateTime.Replace("S&ouml;n ", ""); // Söndag
            rawDateTime = rawDateTime.Replace("sön ", ""); // Söndag
            rawDateTime = rawDateTime.Replace("Söndag ", ""); // Söndag
            rawDateTime = rawDateTime.Replace("tis ", ""); // Tisdag
            rawDateTime = rawDateTime.Replace("Tisdag ", ""); // Tisdag
            rawDateTime = rawDateTime.Replace("ons ", ""); // Onsdag
            rawDateTime = rawDateTime.Replace("Onsdag ", ""); // Onsdag
            rawDateTime = rawDateTime.Replace("Ons ", ""); // Onsdag
            rawDateTime = rawDateTime.Replace("<strong>", "");
            rawDateTime = rawDateTime.Replace("</strong>", "");
            rawDateTime = rawDateTime.Replace("&nbsp;", " ");
            rawDateTime = rawDateTime.Replace("IgÃ¥r", "Igår");
            rawDateTime = rawDateTime.Replace("I går", "Igår");
            rawDateTime = rawDateTime.Replace("\t", "");
            rawDateTime = rawDateTime.Replace("kl", "");
            rawDateTime = rawDateTime.Replace(",", "");
            rawDateTime = rawDateTime.Replace(" - ", " ");
            rawDateTime = rawDateTime.Replace("  ", " ");
            rawDateTime = rawDateTime.Trim();

            if (rawDateTime.Contains("AM") || rawDateTime.Contains("am"))
            {
                rawDateTime = rawDateTime.Replace(" AM", "");
                rawDateTime = rawDateTime.Replace(" am", "");
            }
            else if (rawDateTime.Contains("PM") || rawDateTime.Contains("pm"))
            {
                rawDateTime = rawDateTime.Replace(" PM", "");
                rawDateTime = rawDateTime.Replace(" pm", "");
                bool Result = DateTime.TryParseExact(rawDateTime, f.DateFormat + " " + f.TimeFormat, new CultureInfo(f.Culture), DateTimeStyles.None, out dateTime);
                if (Result == true)
                {
                    dateTime = dateTime.AddHours(12);
                    return true;
                }
            }

            // Ugly hack to make familjeliv work
            if (f.Type == "Familjeliv")
            {
                if (!rawDateTime.Contains("200") || !rawDateTime.Contains("201"))
                {
                    if (rawDateTime.Length == 11)
                    {
                        rawDateTime = rawDateTime.Insert(6, "2013 ");
                    }
                    if (rawDateTime.Length == 12)
                    {
                        rawDateTime = rawDateTime.Insert(6, " 2013");
                    }
                }
            }
            if (f.Name == "Byggahus.se")
            {
                rawDateTime = CommonClasses.Cleanup(rawDateTime);
            }
            var format = "";
            var rawTime = "";

            if (f.Name == "Mammapappa.com")
            {
                format = f.DateFormat + ", " + f.TimeFormat;
            }
            else if (f.Type == "Mingle")
            {
                format = f.DateFormat + f.TimeFormat;
            }
            else if (f.Name == "Minhembio.com")
            {
                format = f.DateFormat + " - " + f.TimeFormat;
            }
            else if (rawDateTime.Contains(",") && !f.DateFormat.Contains(",") && !f.TimeFormat.Contains(","))
            {
                format = f.DateFormat + ", " + f.TimeFormat;
            }
            else if (f.Type == "Episerver")
            {
                if (rawDateTime.Contains("/"))
                {
                    format = f.DateFormat + " / HH:mm";
                }
                else
                {
                    format = f.DateFormat;
                }
            }
            else
            {
                format = f.DateFormat + " " + f.TimeFormat;
            }

            if (rawDateTime.Contains("Today"))
            {
                rawTime = rawDateTime.Substring(rawDateTime.Contains(",") ? 7 : 6);
                return DateTime.TryParseExact(rawTime, f.TimeFormat, new CultureInfo("en-US"), DateTimeStyles.None, out dateTime);
            }
            if (rawDateTime.IndexOf("Idag", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                rawTime = rawDateTime.Substring(rawDateTime.Contains(",") ? 6 : 5);
                if (f.Name == "Alternativ.nu") // Can this be in any kind of attribute? 
                {
                    rawTime = rawTime.Replace(".", "");
                }
                return DateTime.TryParseExact(rawTime, f.TimeFormat, new CultureInfo("sv-SE"), DateTimeStyles.None, out dateTime);
            }

            if (f.Id == 1003)
            {
                //var litenbreak = "";
            }
            // Handle "Yesterday".
            if (rawDateTime.Contains("Yesterday"))
            {
                rawTime = rawDateTime.Substring(rawDateTime.Contains(",") ? 11 : 10);
                var hasParsed = DateTime.TryParseExact(rawTime, f.TimeFormat, new CultureInfo("en-US"), DateTimeStyles.None,
                                                       out dateTime);
                try
                {
                    dateTime = dateTime.AddDays(-1);
                }
                catch (Exception) { }
                return hasParsed;
            }
            if (rawDateTime.Contains("förrgår"))
            {
                rawTime = rawDateTime.Substring(rawDateTime.Contains(",") ? 11 : 8);
                var hasParsed = DateTime.TryParseExact(rawTime, "HH:mm", new CultureInfo("en-US"), DateTimeStyles.None,
                                                       out dateTime);
                try
                {
                    dateTime = dateTime.AddDays(-2);
                }
                catch (Exception) { }
                return hasParsed;
            }
            if (rawDateTime.IndexOf("Igår", StringComparison.OrdinalIgnoreCase) >= 0 || rawDateTime.IndexOf("igår", StringComparison.OrdinalIgnoreCase) >= 0 || rawDateTime.IndexOf("ig&aring;r", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                if (rawDateTime.Contains("&aring"))
                {
                    rawTime = rawDateTime.Substring(rawDateTime.Contains(",") ? 13 : 11);
                }
                else
                {
                    rawTime = rawDateTime.Substring(rawDateTime.Contains(",") ? 6 : 5);
                }

                if (f.Name == "Alternativ.nu") // Can this be in any kind of attribute? 
                {
                    rawTime = rawTime.Replace(".", "");
                }
                var hasParsed = DateTime.TryParseExact(rawTime, f.TimeFormat, new CultureInfo("en-US"), DateTimeStyles.None,
                                                       out dateTime);
                try
                {
                    dateTime = dateTime.AddDays(-1);
                }
                catch (Exception) { }
                return hasParsed;
            }
            //return Error(rawDateTime, out dateTime);

            if (f.Culture == "sv-SE" || rawDateTime.Contains("Maj") || rawDateTime.Contains("Okt")) // change to culture attribute in forum
            {
                try
                {
                    if (DateTime.TryParseExact(rawDateTime, format, new CultureInfo("sv-SE"), DateTimeStyles.None, out dateTime))
                    {
                        return true;
                    }
                    else if (DateTime.TryParseExact(rawDateTime, f.DateFormat, new CultureInfo("sv-SE"), DateTimeStyles.None, out dateTime))
                    {
                        return true;
                    }
                    else
                    {
                        DateTime dT = DateTime.Now;
                        dateTime = dT;
                        return false;
                    }
                }
                catch (Exception)
                {
                    DateTime dT = DateTime.Now;
                    dateTime = dT;
                    return true;
                    //return TryParseDateTime(rawDateTime, f, out dateTime);
                }
            }
            else
            {
                return DateTime.TryParseExact(rawDateTime, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);
            }


        }

        public static bool Error(string date, out DateTime dateTime)
        {
            dateTime = dateTimeConverter(date);
            return true;
        }
        public static DateTime dateTimeConverter(string date)
        {
            System.Text.RegularExpressions.Regex rgx = new System.Text.RegularExpressions.Regex("<font[^>]+>");
            date = rgx.Replace(date, "");
            date = date.Replace("\r", "");
            date = date.Replace("\n", "");
            date = date.Replace("\t", "");
            date = date.Replace("</font>", " ");
            date = date.Replace("<b>", " ");
            date = date.Replace("</b>", " ");
            date = date.Replace("För", "");
            date = date.Replace("&nbsp;", " ");
            date = date.Replace("I förrgå", "förrgå");
            date = date.Replace("I går", "Igår");
            date = date.Replace("i går", "Igår");
            date = date.Replace("IgÃ¥r", "Igår");
            date = date.Replace("igÃ¥r", "Igår");
            date = date.Replace("Ig�r", "Igår");
            date = date.Replace("ig�r", "Igår");
            date = date.Replace("i g&aring;r", "Igår");
            date = date.Replace("g & aring; r", "Igår");
            date = date.Replace("g&aring;r", "Igår");
            date = date.Replace(",", "");
            date = date.Replace(" - ", " ");
            date = date.Replace("Januari", "Jan");
            date = date.Replace("januari", "Jan");
            date = date.Replace("Februari", "Feb");
            date = date.Replace("februari", "Feb");
            date = date.Replace("Mars", "Mar");
            date = date.Replace("mars", "Mar");
            date = date.Replace("April", "Apr");
            date = date.Replace("april", "Apr");
            date = date.Replace("Maj", "May");
            date = date.Replace("maj", "May");
            date = date.Replace("maj", "May");
            date = date.Replace("Juni", "Jun");
            date = date.Replace("juni", "Jun");
            date = date.Replace("Juli", "Jul");
            date = date.Replace("juli", "Jul");
            date = date.Replace("Augusti", "Aug");
            date = date.Replace("augusti", "Aug");
            date = date.Replace("September", "Sep");
            date = date.Replace("Sepember", "Sep");
            date = date.Replace("september", "Sep");
            date = date.Replace("Sept", "Sep");
            date = date.Replace("sept", "Sep");
            date = date.Replace("Oktober", "Oct");
            date = date.Replace("oktober", "Oct");
            date = date.Replace("Octoberober", "October");
            date = date.Replace("octoberober", "October");
            date = date.Replace("Okt", "Oct");
            date = date.Replace("okt", "October");
            date = date.Replace("Fredag ", "");
            date = date.Replace("fredag ", "");
            date = date.Replace("kl", "");
            date = date.Replace("   ", " ");
            date = date.Replace("  ", " ");
            date = date.Trim();

            string[] dateString = date.Trim().Split(' ');
            DateTime _DateTime = DateTime.Now;
            //handle if the format is "less than a"
            if (date.Contains("less than a") || date.Contains("mindre än en"))
            {
                switch (dateString[3])
                {
                    case "minute": _DateTime = DateTime.Now; break;
                    case "minut": _DateTime = DateTime.Now; break;
                }
                return _DateTime;
            }

            //handle if the format is today,yesterday or mm-dd-yy
            else if (dateString.Length == 1 || date.Contains("igår") || date.Contains("idag") || date.Contains("ig&aring;r") || date.Contains("Igår") || date.Contains("Idag") || date.Contains("Ig&aring;r") || date.Contains("förrgår"))
            {
                DateTime _DateTime_Temp = DateTime.Now.Date;
                switch (dateString[0])
                {
                    case "Today":
                        _DateTime_Temp = DateTime.Today;
                        break;

                    case "idag":
                        _DateTime_Temp = DateTime.Today;
                        break;

                    case "Idag":
                        _DateTime_Temp = DateTime.Today;
                        break;

                    case "Yesterday":
                        _DateTime_Temp = DateTime.Now.Date.AddDays(-1);
                        break;

                    case "ig&aring;r":
                        _DateTime_Temp = DateTime.Now.Date.AddDays(-1);
                        break;

                    case "Ig&aring;r":
                        _DateTime_Temp = DateTime.Now.Date.AddDays(-1);
                        break;

                    case "igår":
                        _DateTime_Temp = DateTime.Now.Date.AddDays(-1);
                        break;

                    case "Igår":
                        _DateTime_Temp = DateTime.Now.Date.AddDays(-1);
                        break;

                    case "förrgår":
                        _DateTime_Temp = DateTime.Now.Date.AddDays(-2);
                        break;

                    default: string[] parts = dateString[0].Split('-');
                        DateTime tmp;
                        DateTime.TryParse(string.Format("{0}-{1}-20{2}", parts[1], parts[0], parts[2]), CultureInfo.InvariantCulture, DateTimeStyles.None, out tmp);
                        return tmp;

                }
                if (dateString.Length > 1)
                {
                    _DateTime_Temp = Convert.ToDateTime(dateString[1]);
                }
                return _DateTime_Temp;
            }
            //handle the x [months,years,weeks,days,hours] ago 
            else if (dateString.Length > 1)
            {
                int num;
                Int32.TryParse(dateString[0], out num);
                switch (dateString[1])
                {
                    case "Day": _DateTime = DateTime.Now.Date.AddDays(-num); break;
                    case "dag": _DateTime = DateTime.Now.Date.AddDays(-num); break;
                    case "Days": _DateTime = DateTime.Now.Date.AddDays(-num); break;
                    case "dagar": _DateTime = DateTime.Now.Date.AddDays(-num); break;
                    case "Week": _DateTime = DateTime.Now.Date.AddDays(-7 * num); break;
                    case "vecka": _DateTime = DateTime.Now.Date.AddDays(-7 * num); break;
                    case "Weeks": _DateTime = DateTime.Now.Date.AddDays(-7 * num); break;
                    case "veckor": _DateTime = DateTime.Now.Date.AddDays(-7 * num); break;
                    case "Month": _DateTime = DateTime.Now.Date.AddMonths(-num); break;
                    case "Months": _DateTime = DateTime.Now.Date.AddMonths(-num); break;
                    case "Hour": _DateTime = DateTime.Now.Date.AddHours(-1); break;
                    case "Hours": _DateTime = DateTime.Now.Date.AddHours(-num); break;
                    case "timme,": _DateTime = DateTime.Now.Date.AddHours(-num); break;
                    case "timme": _DateTime = DateTime.Now.Date.AddHours(-num); break;
                    case "timmar,": _DateTime = DateTime.Now.Date.AddHours(-num); break;
                    case "timmar": _DateTime = DateTime.Now.Date.AddHours(-num); break;
                    case "timma": _DateTime = DateTime.Now.Date.AddHours(-num); break;
                    case "Minutes": _DateTime = DateTime.Now.Date.AddMinutes(-num); break;
                    case "minute": _DateTime = DateTime.Now.Date.AddMinutes(-num); break;
                    case "minutes": _DateTime = DateTime.Now.Date.AddMinutes(-num); break;
                    case "minuter": _DateTime = DateTime.Now.Date.AddMinutes(-num); break;
                    case "minut": _DateTime = DateTime.Now.Date.AddMinutes(-num); break;
                    case "Second": _DateTime = DateTime.Now.Date.AddSeconds(-1); break;
                    case "Seconds": _DateTime = DateTime.Now.Date.AddSeconds(-num); break;
                    default:

                        //default
                        try
                        {
                            return DateTime.Parse(date);
                        }
                        catch (Exception)
                        {
                            //Atif
                            //Hack: to fix dates like: lÃ¶r , 
                            if (dateString.Length > 4)
                            {
                                ///////////////////////////////public static string FirstWords(string input, int numberWords)
                                {
                                    try
                                    {
                                        // Number of words we dont want to display.
                                        int words = 1;
                                        // Loop through entire summary.
                                        for (int i = 0; i < date.Length; i++)
                                        {
                                            // Increment words on a space.
                                            if (date[i] == ' ')
                                            {
                                                words--;
                                            }
                                            // If we have no more words to display, return the substring.
                                            if (words == 0)
                                            {
                                                return dateTimeConverter(date.Remove(0, i));
                                            }
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        // Log the error.
                                    }
                                    date = string.Empty;
                                }
                                ///////////////////////////////
                            }
                            else
                            {
                                Console.WriteLine("error in date : " + dateString[1]);
                                string bugLog = date;
                                // Write the string to a file.
                                DateTime now = DateTime.Now;
                                System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Logs\\" + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + ".txt");
                                file.WriteLine(bugLog);

                                file.Close();
                                return DateTime.Parse("01-01-0001");
                            }
                            Console.WriteLine("error in date : " + dateString[1]);
                            return DateTime.Parse("01-01-0001");
                        }
                }
            }
            return _DateTime;
        }
    }
}

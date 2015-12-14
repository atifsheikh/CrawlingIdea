using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace OneKey.Database
{
    public class CommonHelper
    {

        //public static bool TryParseDateTime(string rawDateTime, Forum forumDocument, out DateTime dateTime)
        //{
        //    //var f = (Forum)Globals.Db.Forum.Get(forumId);							// TODO: null? Handle it

        //    var f = forumDocument;
        //    // Handle number suffixes.
        //    rawDateTime = rawDateTime.Replace("1st", "1");
        //    rawDateTime = rawDateTime.Replace("2nd", "2");
        //    rawDateTime = rawDateTime.Replace("3rd", "3");
        //    rawDateTime = rawDateTime.Replace("th", ""); // Remember (th)ursday etc.

        //    var format = "";
        //    var rawTime = "";

        //    // Handle "Today".
        //    if (rawDateTime.Contains(",") && !f.DateFormat.Contains(",") && !f.TimeFormat.Contains(","))
        //    {
        //        format = f.DateFormat + ", " + f.TimeFormat;
        //    }
        //    else
        //    {
        //        format = f.DateFormat + " " + f.TimeFormat;
        //    }

        //    if (rawDateTime.Contains("Today"))
        //    {
        //        rawTime = rawDateTime.Substring(rawDateTime.Contains(",") ? 7 : 6);
        //        return DateTime.TryParseExact(rawTime, f.TimeFormat, new CultureInfo("en-US"), DateTimeStyles.None,
        //                                      out dateTime);
        //    }

        //    // Handle "Yesterday".
        //    if (rawDateTime.Contains("Yesterday"))
        //    {
        //        rawTime = rawDateTime.Substring(rawDateTime.Contains(",") ? 11 : 10);
        //        var hasParsed = DateTime.TryParseExact(rawTime, f.TimeFormat, new CultureInfo("en-US"),
        //                                               DateTimeStyles.None,
        //                                               out dateTime);
        //        try
        //        {
        //            dateTime = dateTime.AddDays(-1);
        //        }
        //        catch (Exception)
        //        {
        //        }
        //        return hasParsed;
        //    }
        //    // Handle default case.
        //    if (f.Id == 1003)
        //    {
        //        format = "MM-dd-yy hh:mm tt";
        //    }
        //    return DateTime.TryParseExact(rawDateTime, format, CultureInfo.InvariantCulture, DateTimeStyles.None,
        //                                  out dateTime);

        //}

        public static string Encrypt(string input)
        {
            var md5Hash = MD5.Create();
            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var stringBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (var i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return stringBuilder.ToString();
        }
        //public static string EncodeSwedishCharacters(string text)
        //{
        //    text = text.Replace("å", "%E5").Replace("Å", "%C5").Replace("Ä", "%C4").Replace("ä", "%E4").Replace("Ö", "%D6").Replace("ö", "%F6");
        //    return text;
        //}
        //public static string EncodeSwedishCharacters2(string text)
        //{
        //    text = text.Replace("å", "a").Replace("Å", "A").Replace("Ä", "A").Replace("ä", "a").Replace("Ö", "O").Replace("ö", "o");
        //    return text;
        //}
        //public static string HexStringFromBytes(byte[] bytes)
        //{
        //    var sb = new StringBuilder();
        //    foreach (byte b in bytes)
        //    {
        //        var hex = b.ToString("x2");
        //        sb.Append(hex);
        //    }
        //    return sb.ToString();
        //}
        //public static string SH1Hash(string str)
        //{
        //    byte[] bytes = Encoding.UTF8.GetBytes(str);

        //    var sha1 = SHA1.Create();
        //    byte[] hashBytes = sha1.ComputeHash(bytes);

        //    return HexStringFromBytes(hashBytes);
        //}

        public static string Match(string page, string regex)
        {
            var rgx = new Regex(regex, RegexOptions.Singleline);
            var match = rgx.Match(page);
            return match.Groups[1].ToString();
        }
        public static System.Text.RegularExpressions.Match GetAllMatches(string page, string regex)
        {
            var rgx = new Regex(regex, RegexOptions.Singleline);
            var match = rgx.Match(page);
            return match;
        }
        public static string Match2(string page, string regex)
        {
            var rgx = new Regex(regex, RegexOptions.Singleline);
            var match = rgx.Match(page);
            return match.Groups[2].ToString();
        }
        //public static GroupCollection GetGroups(string page, string regex) { 
        //    var rgx = new Regex(regex, RegexOptions.Singleline);
        //    var match = rgx.Match(page);
        //    return match.Groups;
        //}

        //static public string EncodeTo64(string toEncode)
        //{
        //    byte[] toEncodeAsBytes
        //        = Encoding.ASCII.GetBytes(toEncode);
        //    string returnValue
        //        = Convert.ToBase64String(toEncodeAsBytes);
        //    return returnValue;
        //}

        //static public string DecodeFrom64(string encodedData)
        //{
        //    byte[] encodedDataAsBytes
        //        = Convert.FromBase64String(encodedData);
        //    string returnValue =
        //        Encoding.ASCII.GetString(encodedDataAsBytes);
        //    return returnValue;
        //}

        //static public string Clean(string myDataDecoded)
        //{
        //    myDataDecoded = myDataDecoded.Replace("u003e", ">");
        //    myDataDecoded = myDataDecoded.Replace("u003c", "<");
        //    myDataDecoded = myDataDecoded.Replace("\\t", "");
        //    myDataDecoded = myDataDecoded.Replace("\\r", "");
        //    myDataDecoded = myDataDecoded.Replace("\\n", "");
        //    myDataDecoded = myDataDecoded.Replace("\\", "");
        //    return myDataDecoded;
        //}

        //internal static string Match_Get_last_match(string page, string regex)
        //{
        //    var rgx = new Regex(regex, RegexOptions.Singleline);
        //    var match = rgx.Matches(page);
        //    if (match.Count > 1)
        //        return match[match.Count - 1].Groups[1].ToString();
        //    else
        //        return null;
        //}
    }
}
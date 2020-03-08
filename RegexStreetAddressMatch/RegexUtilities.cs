using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace RegexStreetAddressMatch
{


    public class RegexUtilities
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public static bool IsValidURL(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                return false;

            try
            {
                return Regex.IsMatch(url, @"^(?<proto>\w+)://[^/]+?(?<port>:\d+)?/",
                         RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(150));

            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }
        }

        public static string FindTextFromHTML(string source)
        {
            return Regex.Replace(source, @"<(.|\n)*?>", "\n");
        }

        public static List<string> FindStreetAddress(string source)
        {
            var result = new List<string>();
            string pattern = @"(?:(?<mahalle>.+?) *(mah|mh|mahalle|mahallesi))?[. ]*
                               (?:(?<bulvar>.+?) *(?:bul|bulv|bulvar|bulvar[ıI]))?[. ]*
                               (?:(?<iskele>.+?) *(?:iskele))?[. ]*
                               (?:(?<gecit>.+?) *(?:ge[çc]i[dt]i))?[. ]*
                               (?:(?<bolge>.+?) *(?:b[oö]lge|b[oö]lgesi))?[. ]*
                               (?:(?<mevkii>.+?) *(?:mevki|mevkii))?[. ]*
                               (?:(?<cadde>.+?) *(?:cd|cad|cadde|caddesi))?[. ]*
                               (?:(?<sokak>.+?) *(?:sok|sk|sokak|soka[gğ][iıI]))?[. ]*
                               (?:(?<site>.+?) *(?:site|sitesi|siteleri))?[. ]*
                               (?:(?<blok>.+?) *(?:blok|bloklar[Iıi]|blo[gğ]u))?[. ]*
                               ((no|numara|nu)(:| :)(?<no>.+)|((?:(?<bina>.+?) *(?:bina|binas[Iıi]))))
                               +(?<il>.+)";
            Regex rgx = new Regex(pattern.Replace("\r\n                               ",string.Empty), RegexOptions.IgnoreCase);

            foreach (Match match in rgx.Matches(source))
                result.Add(match.Value.Trim());

            return result;
        }
    }
}

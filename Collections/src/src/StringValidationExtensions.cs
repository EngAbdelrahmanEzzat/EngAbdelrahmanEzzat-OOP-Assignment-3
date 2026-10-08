using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace src
{
   

   
        public static class StringValidationExtensions
        {
            public static bool IsValidEgyptianPhone(this string phoneNumber)
            {
                if (string.IsNullOrWhiteSpace(phoneNumber))
                {
                    return false;
                }

                return Regex.IsMatch(
                    phoneNumber,
                    @"^01[0125]\d{8}$|^\+201[0125]\d{8}$"
                );
            }

            public static bool IsValidEgyptianNationalId(this string nationalId)
            {
                if (string.IsNullOrWhiteSpace(nationalId))
                {
                    return false;
                }

                return Regex.IsMatch(
                    nationalId,
                    @"^[23]\d{13}$"
                );
            }
        }
    }


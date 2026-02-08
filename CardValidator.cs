using System;
using System.Text.RegularExpressions;

namespace CreditCardValidator
{
    public static class CardValidator
    {
        public static string GetCardBrand(string cardNumber)
        {
            if (Regex.IsMatch(cardNumber, @"^4\d{12}(\d{3})?$"))
                return "Visa";

            if (Regex.IsMatch(cardNumber, @"^5[1-5]\d{14}$"))
                return "MasterCard";

            if (Regex.IsMatch(cardNumber, @"^3[47]\d{13}$"))
                return "American Express";

            if (Regex.IsMatch(cardNumber, @"^6(?:011|5\d{2})\d{12}$"))
                return "Discover";

            return "Bandeira desconhecida";
        }
    }
}

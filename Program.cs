using System;

namespace CreditCardValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Identificador de Bandeira de Cartão ===");
            Console.Write("Digite o número do cartão: ");

            string cardNumber = Console.ReadLine()?.Replace(" ", "");

            if (string.IsNullOrEmpty(cardNumber))
            {
                Console.WriteLine("Número inválido.");
                return;
            }

            string brand = CardValidator.GetCardBrand(cardNumber);
            Console.WriteLine($"Bandeira identificada: {brand}");
        }
    }
}

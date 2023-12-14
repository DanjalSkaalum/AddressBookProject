using System.Diagnostics.Metrics;

namespace AddressBookProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook O1 = new AddressBook("Jan");

            O1.AddAddress(new Address("Hans Peter Nielsen", "Birkehøj 5", "2134123456"));
            O1.AddAddress(new Address("Jens Peter Larsen", "Poppelhøj 6", "2345619481"));

            Console.WriteLine(O1);

            AddressBook O2 = new AddressBook("Bo");

            O2.AddAddress(new Address("Niels Peter Hansen", "Bøgehøj 7", "213412345636"));
            O2.AddAddress(new Address("Lars Peter Jensen", "Fyrrehøj 8", "2345679801"));

            Console.WriteLine(O2);

            AddressBook O3 = new AddressBook($"{O1.Owner} and {O2.Owner}");

            O3.AddAddress(new Address("Hans Peter Nielsen", "Birkehøj 5", "2134123456"));
            O3.AddAddress(new Address("Jens Peter Larsen", "Poppelhøj 6", "2345619481"));
            O3.AddAddress(new Address("Niels Peter Hansen", "Bøgehøj 7", "213412345636"));
            O3.AddAddress(new Address("Lars Peter Jensen", "Fyrrehøj 8", "2345679801"));

            Console.WriteLine(O3);

            Console.ReadLine();
        }
    }
}

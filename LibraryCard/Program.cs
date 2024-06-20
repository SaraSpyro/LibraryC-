using System;
using System.Collections.Generic;



namespace LibraryCard
{
    class Program
    {
        static void Main(string[] args)
        {
            #region [Me]
            Specifications volunteer = new Specifications(1013, "Sara", "Farahani", new DateTime(2002, 7, 24), false);
            volunteer.Telephones = new List<Telephone>()
            {
                new Telephone() {Number = "0123456789", TelephonType = TelephonType.Mobile},
                new Telephone() {Number = "123456", TelephonType = TelephonType.Home}
            };
            volunteer.Emails = new List<Email>()
            {
                new Email() {Title = "abc.def", EmailProviders = EmailProviders.Google},
                new Email() {Title = "ghi.jkl", EmailProviders = EmailProviders.Microsoft}
            };

            Console.ForegroundColor = ConsoleColor.Cyan;
            List<Specifications> specifications = new List<Specifications>();
            specifications.Add(volunteer);

            foreach (Specifications item in specifications)
            {
                // Console.WriteLine(item.ToString());
            }
            #endregion

            #region [Public]
            Console.ResetColor();

            Console.Write("Membership number:");
            int membershipNumber = int.Parse(Console.ReadLine());

            Console.Write("Name:");
            string name = Console.ReadLine();

            Console.Write("Family:");
            string family = Console.ReadLine();

            Console.Write("Birth Date:");
            DateTime birthDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Gender:");
            bool gender = Convert.ToBoolean(Console.ReadLine());

            Console.Clear();

            Specifications specifications1 = new Specifications()
            {
                MembershipNumber = membershipNumber,
                Name = name,
                Family = family,
                BirthDate = birthDate,
                Gender = gender

            };

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(specifications1);
            Console.ReadKey();

            #endregion
        }
    }
}

using System;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A to Add new contact\nEnter E to edit a contact");
            char ch = Console.ReadLine().ToUpper()[0];
            AddressBook addressBook = new AddressBook();
            switch (ch)
            {
                case 'A':
                    addressBook.AddContact();
                    break;
                case 'E':
                    addressBook.EditContact();
                    break;
                default:
                    break;
            }
        }
    }
}

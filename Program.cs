using System;
using System.Threading;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();
            while (true)
            {
                Console.WriteLine("Enter A to Add new contact\nEnter E to edit a contact\nEnter D to Delete a Contact");
                char ch = Console.ReadLine().ToUpper()[0];
                switch (ch)
                {
                    case 'A':
                        addressBook.AddContact();
                        break;
                    case 'E':
                        addressBook.EditContact();
                        break;
                    case 'D':
                        addressBook.DeleteContact();
                        break;
                    default:
                        break;
                }
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}

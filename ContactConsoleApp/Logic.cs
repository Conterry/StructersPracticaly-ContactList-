using System;
using System.Collections.Generic;
using System.Text;

namespace ContactConsoleApp
{
    class Logic
    {
        public static void DoLogic(string Task, ref int LastPlace, ref Contact[] ContactList)
        {
            if(Task == "help")
            {
                Console.WriteLine(ReturnInstructions());
            }
            else if(Task == "add contact")
            {
                AddContact(ref ContactList[LastPlace]);
            }
        }

        public static string ReturnInstructions()
        {
            return $"write 'add contact' to add contact \n write 'search contect' to sea a contact" ;
        }

        public static void AddContact(ref Contact contact)
        {
            contact  = Contact.NewContact();
            
        }
    }
}

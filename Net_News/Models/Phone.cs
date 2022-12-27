using Net_News.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Net_News.Models
{
    public class Phone
    {
        public string Number { get; set; }
        public IProvider Provider { get; set; }
        public double Balance { get; set; }
        public List<Contact> Contacts { get; set; }

        public Phone()
        {
            this.Contacts = new List<Contact>();
        }


        public bool CheckPhoneNumber(string phoneNumber)
        {
            string regexPhone = @"^(\+[0-9]{12})$";

            return Regex.Match(phoneNumber, regexPhone).Success;
        }

        // PROVIDER CHECK FROM NUMBER
        public void checkProvider()
        { 
        
        }

        public void AddContact(string fullName, string phoneNumber)
        {
            if (fullName.Length != 0 && CheckPhoneNumber(phoneNumber))
            {
                this.Contacts.Add(new Contact(fullName, phoneNumber));

                Console.WriteLine("New contact has been added!");
            }
            else
            {
                Console.WriteLine("Incorrect data!");    
            }
        }

        public void showContactList()
        {
            if (this.Contacts.Count != 0)
            {
                this.Contacts.ForEach(contact =>
                {
                    Console.WriteLine(
                            "ID: " + contact.ID + "\n" +
                            "Fullname: " + contact.FullName + "\n" +
                            "Phone number: " + contact.Number + "\n" +
                            new String('-', 50)
                        );
                });
            }
            else 
            {
                Console.WriteLine("There is no contact on your list!");
            }
        }

        // CALL USER USING ID
        public void CallContact(int ID)
        { 
            
        }


        // DELETE CONTACT USING DI
        public void DeleteContact(int ID)
        {
            if (this.Contacts.Count != 0)
            {
                this.Contacts.RemoveAt(ID - 1);

                Console.WriteLine("User has been deleted!");
            }
            else {
                Console.WriteLine("You dont have any contact");
            }
        }

        public void showBalance()
        {
            if (this.Balance < 1)
            {
                Console.WriteLine("Your balance is: " + (int)(((decimal)this.Balance % 1) * 100) + " cent");
            }
            else 
            {
                Console.WriteLine(
                    "Your balance is: " + (int)this.Balance + " azn " +
                    (int)(((decimal)this.Balance % 1) * 100) + " cent"
                    );
            }
        }

        public void BorrowBalance(int code) 
        {
            this.Balance += this.Provider.borrowBalance(code);

            Console.WriteLine("You have borrow " + this.Provider.borrowBalance(code) + " azn");
        }





    }
}

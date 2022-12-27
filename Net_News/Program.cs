using Net_News.Models;

public class Program
{
    public static void Main()
    {
        Phone phone = new Phone();

        while (true)
        {
            Console.Write("Please enter your number: ");
            string userPhoneNumber = Console.ReadLine();

            if (userPhoneNumber != null && phone.CheckPhoneNumber(userPhoneNumber))
            {

                while (true)
                {
                    Console.Write("Please enter your balance: ");
                    double userBalance = Convert.ToDouble(Console.ReadLine());

                    if (true)
                    {
                        // Check DOUBLE DATA!

                        phone.Number = userPhoneNumber;
                        phone.Balance = userBalance;


                        while (true)
                        {
                            Console.Clear();

                            Console.WriteLine(
                                "1. Add contact \n" +
                                "2. Show contact list \n" +
                                "3. Delete Contact \n" +
                                "4. Call from contact list \n" +
                                "5. Call direct phone number \n" +
                                "6. Show balance \n" +
                                "7. Borrow balance from provider \n" +
                                "8. Close phone: "
                            );

                            string userMenuChoise = Console.ReadLine();

                            switch (userMenuChoise)
                            {
                                case "1":
                                    Console.Clear();

                                    Console.Write("Enter contact Fullname: ");
                                    string contactName = Console.ReadLine();

                                    Console.Write("Enter contact number: ");
                                    string contactNumber = Console.ReadLine();

                                    phone.AddContact(contactName, contactNumber);

                                    Console.ReadLine();

                                    break;
                                case "2":
                                    Console.Clear();

                                    phone.showContactList();

                                    Console.ReadLine();
                                    break;
                                case "3":
                                    Console.Clear();

                                    phone.showContactList();

                                    Console.Write("Please choose ID of contact which you want to delete: ");
                                    string userChoise = Console.ReadLine();

                                    // CHECK DATA CONTAINS LETTER OR NOT

                                    phone.DeleteContact(int.Parse(userChoise));

                                    Console.ReadLine();
                                    break;
                                case "4":
                                    break;
                                case "5":
                                    break;
                                case "6":
                                    break;
                                case "7":
                                    break;
                                case "8":
                                    Console.WriteLine("Thanks for using me! :D");                                
                                    Environment.Exit(0);
                                    break;
                                default:
                                    Console.WriteLine("Please choose correct section from menu!");
                                    Console.ReadLine();
                                    break;
                            }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Balance type is not correct! Please input your data with numeric characters!");
                        Console.ReadLine();
                        Console.Clear();
                    }

                }

                break;
            }
            else
            {
                Console.WriteLine("Please enter correct number. (It must start with '+' end length must be eqaul 13. +994 XX XXX XX XX)");
                Console.ReadLine();
                Console.Clear();
            }
        }







    }
}
//Aslı Kurt
//18.01.2020

using System;

namespace ClassMetotDemo
{
    /*
    aims of the project are:
    
    follow up customers in a bank
    add to customer specifications in class
    create CustomerManager class and simulate them by using add, list or delete customer methods.
    
      */

    class Program
    {
        static void Main(string[] args)
        {//process of defining customers' informations
            Customers customer1 = new Customers();
            customer1.ID = 1;
            customer1.name = "Asli ";
            customer1.surname = "Kurt ";
            customer1.address = "Eskisehir ";
            customer1.age = 21;
            customer1.totalAmount = 186;

            Customers customer2 = new Customers();
            customer2.ID = 2;
            customer2.name = "Cemile ";
            customer2.surname = "Ceylan ";
            customer2.address = "Kutahya ";
            customer2.age = 22;
            customer2.totalAmount = 1893;

            Customers customer3 = new Customers();
            customer3.ID = 3;
            customer3.name = "Metin ";
            customer3.surname = "Kiyar ";
            customer3.address = "Konya ";
            customer3.age = 23;
            customer3.totalAmount = 9346;

            Customers customer4 = new Customers();
            customer4.ID = 4;
            customer4.name = "Bahadir ";
            customer4.surname = "Aydin ";
            customer4.address = "Mersin ";
            customer4.age = 23;
            customer4.totalAmount = 6436;

            Customers customer5 = new Customers();
            customer5.ID = 5;
            customer5.name = "Sude Nur ";
            customer5.surname = "Ayaz ";
            customer5.address = "Trabzon ";
            customer5.age = 20;
            customer5.totalAmount = 0;

            Customers[] eachCustomer = new Customers[] { customer1, customer2, customer3, customer4, customer5 };
            //opens array and adds customers into it
            
            CustomerManager manage = new CustomerManager();
            //to use methods
            
            Console.WriteLine(" PRESS '0' BUTTON TO QUIT. ");
            Console.WriteLine("****************************");
            Console.WriteLine("PRESS ANY NUMBER TO CONTINUE.");
            //CHOICE MENU
            
            int choice = Convert.ToInt32(Console.ReadLine());
            //converts string to int
            
            while (choice!=0)
            {//if user press to '0' program ends
             //otherwise program starts to run

                Console.WriteLine("****************************");
                Console.WriteLine("*     1. ADD CUSTOMERS     *");
                Console.WriteLine("*     2. PRINT CUSTOMERS   *");
                Console.WriteLine("*   3. DELETE CUSTOMERS    *");
                Console.WriteLine("****************************");

                Console.WriteLine("\n\n* *  ENTER YOUR CHOICE   * *\n\n");
                //CHOICE MENU
                
                int x = Convert.ToInt32(Console.ReadLine());
                //converts string to int
                int lastChoice;
                switch (x)
                {// user make choices looking from the menu to continue 
                    case 1: //if user press to '1' program adds customers to the list
                        Console.WriteLine("\n!!ADDING CUSTOMERS!!\n");
                        manage.addCustomer(customer1);
                        manage.addCustomer(customer2);
                        manage.addCustomer(customer3);
                        manage.addCustomer(customer4);
                        manage.addCustomer(customer5);
                        
                        Console.WriteLine(" PRESS '0' BUTTON TO QUIT. ");
                        Console.WriteLine("****************************");
                        Console.WriteLine("PRESS ANY NUMBER TO CONTINUE.");

                        lastChoice = Convert.ToInt32(Console.ReadLine());
                        choice = lastChoice;
                        
                        break;

                    case 2: //if user press to '2' program prints customers from the list
                        Console.WriteLine("\n!!PRINTING CUSTOMERS!!\n");
                        manage.printCustomer(eachCustomer);
                        
                        Console.WriteLine(" PRESS '0' BUTTON TO QUIT. ");
                        Console.WriteLine("****************************");
                        Console.WriteLine("PRESS ANY NUMBER TO CONTINUE.");

                        lastChoice = Convert.ToInt32(Console.ReadLine());
                        choice = lastChoice;
                        
                        break;

                    case 3: //if user press to '3' program deletes customers from the list
                        Console.WriteLine("\n!!DELETING CUSTOMERS!!\n");
                        manage.deleteCustomer(customer1);
                        manage.deleteCustomer(customer2);
                        manage.deleteCustomer(customer3);
                        manage.deleteCustomer(customer4);
                        manage.deleteCustomer(customer5);
                        Console.WriteLine("\n!!LIST IS EMPTY!!\n");
                        
                        Console.WriteLine(" PRESS '0' BUTTON TO QUIT. ");
                        Console.WriteLine("****************************");
                        Console.WriteLine("PRESS ANY NUMBER TO CONTINUE.");

                        lastChoice = Convert.ToInt32(Console.ReadLine());
                        choice = lastChoice;
                        
                        break;

                    default: // if user press other than 1, 2 or 3, it means default case
                        Console.WriteLine("Default case");
                        break;
                }
            }
        }
    }
}

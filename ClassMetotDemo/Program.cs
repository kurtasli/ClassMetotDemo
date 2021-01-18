using System;

namespace ClassMetotDemo
{
    /*
    aims of the project are:
    
    follow up customers in a bank
    add to customer specifications in class
    create CustomerManager class and simulate tehm by using add, list or delete customer methods.
    
      */

    class Program
    {
        static void Main(string[] args)
        {
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

            CustomerManager manage = new CustomerManager();

            Console.WriteLine(" PRESS '0' BUTTON TO QUIT. ");
            Console.WriteLine("****************************");
            Console.WriteLine("PRESS ANY NUMBER TO CONTINUE.");

            int choice = Convert.ToInt32(Console.ReadLine());

            while (choice!=0)
            {

                Console.WriteLine("****************************");
                Console.WriteLine("*     1. ADD CUSTOMERS     *");
                Console.WriteLine("*     2. PRINT CUSTOMERS   *");
                Console.WriteLine("*   3. DELETE CUSTOMERS    *");
                Console.WriteLine("****************************");

                Console.WriteLine("\n\n* *  ENTER YOUR CHOICE   * *\n\n");


                int x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {

                    case 1:
                        Console.WriteLine("\n!!ADDING CUSTOMERS!!\n");
                        manage.addCustomer(customer1);
                        manage.addCustomer(customer2);
                        manage.addCustomer(customer3);
                        manage.addCustomer(customer4);
                        manage.addCustomer(customer5);
                        break;

                    case 2:
                        Console.WriteLine("\n!!PRINTING CUSTOMERS!!\n");
                        manage.printCustomer(eachCustomer);
                        break;

                    case 3:
                        Console.WriteLine("\n!!DELETING CUSTOMERS!!\n");
                        manage.deleteCustomer(customer1);
                        manage.deleteCustomer(customer2);
                        manage.deleteCustomer(customer3);
                        manage.deleteCustomer(customer4);
                        manage.deleteCustomer(customer5);
                        Console.WriteLine("\n!!LIST IS EMPTY!!\n");
                        break;

                    default:
                        Console.WriteLine("Default case");
                        break;
                }

            }

            

            
            

            
            

        }
    }
}

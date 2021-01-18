using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        //****************************************************************************************
        public void addCustomer(Customers customer)
        {//adds a customer to list
            Console.WriteLine(customer.name + customer.surname + " added to the list succesfully.\n");
        }
        //****************************************************************************************
        public void printCustomer(params Customers[] customer)
        {//prints customers that wished

            foreach (Customers person in customer)
            {
                Console.WriteLine("ID : " + person.ID);
                Console.WriteLine("Name : " + person.name);
                Console.WriteLine("Surname : " + person.surname);
                Console.WriteLine("Address : " + person.address);
                Console.WriteLine("Age : " + person.age);
                Console.WriteLine("Total Amount : " + person.totalAmount);
                Console.WriteLine("------------------------------");
            }
        }
        //****************************************************************************************
        public void deleteCustomer(Customers customer)
        {//deletes customers that wished
            Console.WriteLine(customer.name + customer.surname + " deleted from the list succesfully.");
        }
        //****************************************************************************************
    }
}

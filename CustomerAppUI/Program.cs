using CustomerAppEntity;
using System;
using System.Collections.Generic;

namespace CustomerAppUI
{
   class Program
    {
       

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args">dskdkslksd</param>
        static void Main(string[] args)
        {
            var cust1 = new Customer()
            {
                Id = id++,
                FirstName = "Bob",
                LastName = "Dylan",
                Address = "BongoStreet 202"
            };
            customers.Add(cust1);

            customers.Add(new Customer()
            {
                Id = id++,
                FirstName = "Lars",
                LastName = "Bilde",
                Address = "Ostestrasse 202"
            });

            string[] menuItems = {
                "List All Customers",
                "Add Customer",
                "Delete Customer",
                "Edit Customer",
                "Exit"
            };

            //Show Menu
            //Wait for Selection
            // - Show selection or
            // - Warning and go back to menu

            var selection = ShowMenu(menuItems);

            while (selection != 5)
            {
                switch (selection)
                {
                    case 1:
                        ListCustomers();
                        break;
                    case 2:
                        AddCustomers();
                        break;
                    case 3:
                        DeleteCustomer();
                        break;
                    case 4:
                        EditCustomer();
                        break;
                    default:
                        break;
                }
                selection = ShowMenu(menuItems);
            }
            Console.WriteLine("Bye bye!");

            Console.ReadLine();
        }

        private static void EditCustomer()
        {
            var customer = FindCustomerById();
            Console.WriteLine("FirstName: ");
            customer.FirstName = Console.ReadLine();
            Console.WriteLine("LastName: ");
            customer.LastName = Console.ReadLine();
            Console.WriteLine("Address: ");
            customer.Address = Console.ReadLine();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>kdjfjkdf</returns>
        private static Customer FindCustomerById()
        {
            Console.WriteLine("Insert Customer Id: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please insert a number");
            }

            foreach (var customer in customers)
            {
                if (customer.Id == id)
                {
                    return customer;
                }
            }
            return null;
        }

        private static void DeleteCustomer()
        {

            var customerFound = FindCustomerById();
            if (customerFound != null)
            {
                customers.Remove(customerFound);
            }
        }

        private static void AddCustomers()
        {
            Console.WriteLine("Firstname: ");
            var firstName = Console.ReadLine();

            Console.WriteLine("Lastname: ");
            var lastName = Console.ReadLine();

            Console.WriteLine("Address: ");
            var address = Console.ReadLine();

            customers.Add(new Customer()
            {
                Id = id++,
                FirstName = firstName,
                LastName = lastName,
                Address = address
            });
        }

        private static void ListCustomers()
        {
            Console.WriteLine("\nList of Customers");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Id: {customer.Id} Name: {customer.FirstName} " +
                                $"{customer.LastName} " +
                                $"Adress: {customer.Address}");
            }
            Console.WriteLine("\n");

        }

        private static int ShowMenu(string[] menuItems)
        {
            Console.WriteLine("Select What you want to do:\n");

            for (int i = 0; i < menuItems.Length; i++)
            {
                //Console.WriteLine((i + 1) + ":" + menuItems[i]);
                Console.WriteLine($"{(i + 1)}: {menuItems[i]}");
            }

            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)
                || selection < 1
                || selection > 5)
            {
                Console.WriteLine("Please select a number between 1-5");
            }

            return selection;
        }
    }
}

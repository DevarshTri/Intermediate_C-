using System;
using System.Collections.Generic;

class Program
{
    static List<Customer> customers = new List<Customer>();

    static void Main()
    {
        Console.WriteLine("------------------- Login -------------------------");
        Console.WriteLine("Select your role to login");
        Console.WriteLine("Enter 1 for Admin");
        Console.WriteLine("Enter 2 for Customer");
        Console.Write("Please Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Admin();
        }
        else if (choice == 2)
        {
            Customers();
        }
        else
        {
            Console.WriteLine("Invalid Choice");
        }
    }

    class Customer
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Balance ;

        public Customer(string email, string password, string name, int age, double balance)
        {
            Email = email;
            Password = password;
            Name = name;
            Age = age;
            Balance = balance;
        }
    }

    static void AddCustomer()
    {
        Console.Write("Enter Your Email: ");
        string email = Console.ReadLine();

        Console.Write("Enter Your Password: ");
        string password = Console.ReadLine();

        Console.Write("Enter Your Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Your Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter your Balance: ");
        double balance = double.Parse(Console.ReadLine());

        customers.Add(new Customer(email, password, name, age, balance));
        Console.WriteLine("Your Record Saved Successfully");
    }

    static void FindCustomer()
    {
        Console.Write("Enter your Age: ");
        int mAge = int.Parse(Console.ReadLine());

        Console.Write("Enter Balance: ");
        double mBalance = double.Parse(Console.ReadLine());

        var filteredCustomers = customers.FindAll(c => c.Balance >= mBalance && c.Age >= mAge);

        if (filteredCustomers.Count == 0)
        {
            Console.WriteLine("Record is Empty");
        }
        else
        {
            Console.WriteLine("Matching the criteria");
            foreach (var customer in filteredCustomers)
            {
                Console.WriteLine($"Customer Balance: {customer.Balance}");
                Console.WriteLine($"Customer Age: {customer.Age}");
            }
        }
    }

    static void Admin()
    {
        int adminChoice;
        do
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Find Customer by Balance and Age");
            Console.WriteLine("3. Go to Main Menu");
            Console.WriteLine("4. Exit");
            Console.Write("Enter Your Choice: ");
            adminChoice = int.Parse(Console.ReadLine());

            switch (adminChoice)
            {
                case 1:
                    Console.WriteLine("--------- ADD CUSTOMER ------------");
                    AddCustomer();
                    break;
                case 2:
                    Console.WriteLine("------------ FIND CUSTOMER -----------");
                    FindCustomer();
                    break;
                case 3:
                    Main();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        } while (adminChoice != 4);
    }

    static void Customers()
    {
        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        bool found = false;
        foreach (var customer in customers)
        {
            if (email == customer.Email && password == customer.Password)
            {
                Console.WriteLine("Found");
                found = true;
                CustomerMenu(customer);
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("Invalid Email or Password");
        }
    }

    static void CustomerMenu(Customer customer)
    {
        int custChoice;
        do
        {
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Edit Balance");
            Console.WriteLine("3. Go to Main Menu");
            Console.WriteLine("4. Exit");
            Console.Write("Enter Your Choice: ");
            custChoice = int.Parse(Console.ReadLine());

            switch (custChoice)
            {
                case 1:
                    Console.WriteLine($"Your Current Balance is : {customer.Balance}");
                    break;
                case 2:
                    Console.Write("Enter New Balance: ");
                    double newBalance = double.Parse(Console.ReadLine());
                    customer.Balance = newBalance;
                    Console.WriteLine("Balance Update Successfully");
                    break;
                case 3:
                    Main();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        } while (custChoice != 4);
    }
}

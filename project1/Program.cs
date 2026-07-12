using System;
using System.Collections.Generic;

namespace project1
{
    internal class Program
    {
        // Parallel Lists
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();

        static void Main(string[] args)
        {
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. List All Accounts");
                Console.WriteLine("7. Close Account");
                Console.WriteLine("8. Exit");

                Console.Write("Choose an option: ");

                int choice;

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;

                    case 2:
                        DepositMoney();
                        break;

                    case 3:
                        WithdrawMoney();
                        break;

                    case 4:
                        ShowBalance();
                        break;

                    case 5:
                        TransferAmount();
                        break;

                    case 6:
                        ListAllAccounts();
                        break;

                    case 7:
                        CloseAccount();
                        break;

                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for using Spark Bank!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        // ==========================
        // Add New Account
        // ==========================
        static void AddAccount()
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter account number: ");
            string account = Console.ReadLine();

            if (accountNumbers.Contains(account))
            {
                Console.WriteLine("Account number already exists.");
                return;
            }

            Console.Write("Enter initial deposit: ");

            double amount;

            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid amount.");
                return;
            }

            if (amount < 0)
            {
                Console.WriteLine("Balance cannot be negative.");
                return;
            }

            customerNames.Add(name);
            accountNumbers.Add(account);
            balances.Add(amount);

            Console.WriteLine("\nAccount created successfully!");
            Console.WriteLine($"Customer : {name}");
            Console.WriteLine($"Account  : {account}");
            Console.WriteLine($"Balance  : {amount}");
        }
        // Deposit Money
        // ==========================
        static void DepositMoney()
        {
            Console.Write("Enter account number: ");
            string account = Console.ReadLine();

            int index = accountNumbers.IndexOf(account);

            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.Write("Enter deposit amount: ");

            double amount;

            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid amount.");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Deposit must be greater than zero.");
                return;
            }

            balances[index] += amount;

            Console.WriteLine("Deposit successful.");
            Console.WriteLine($"New Balance = {balances[index]}");
        }
    }
    // Withdraw Money
// ==========================
static void WithdrawMoney()
        {
            Console.Write("Enter account number: ");
            string account = Console.ReadLine();

            int index = accountNumbers.IndexOf(account);

            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }

            Console.Write("Enter withdrawal amount: ");

            double amount;

            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid amount.");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Amount must be greater than zero.");
                return;
            }

            if (amount > balances[index])
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            balances[index] -= amount;

            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine($"New Balance = {balances[index]}");
        }
    }








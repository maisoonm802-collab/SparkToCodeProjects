namespace Task7
{
    internal class Program
    {
        class BankAccount
        {
            public int AccountNumber { get; set; }
            public string HolderName { get; set; }
            public double Balance { get; set; }

            public BankAccount(int accountNumber, string holderName, double balance)
            {
                AccountNumber = accountNumber;
                HolderName = holderName;
                Balance = balance;
            }

            public void Deposit(double amount)
            {
                Balance += amount;
                SendEmail();
            }

            public void Withdraw(double amount)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }

                SendEmail();
            }

            public double CheckBalance()
            {
                PrintInformation();
                return Balance;
            }

            private void PrintInformation()
            {
                Console.WriteLine("Account Number: " + AccountNumber);
                Console.WriteLine("Holder Name: " + HolderName);
                Console.WriteLine("Balance: " + Balance);
            }

            private void SendEmail()
            {
                Console.WriteLine("Email notification sent.");
            }

            public bool IsOverdrawn
            {
                get
                {
                    return Balance < 0;
                }
            }
        }



        class Student
        {
            public int Grade { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }

            private string email;
            private int age;

            private static int studentCount = 0;

            private string pin;


            public Student(string name, string address, int grade)
            {
                Name = name;
                Address = address;
                Grade = grade;

                studentCount++;
            }


            public void Register(string Email)
            {
                email = Email;
                SendEmail();
            }


            private void SendEmail()
            {
                Console.WriteLine("Registration email sent.");
            }


            public static int GetStudentCount()
            {
                return studentCount;
            }


            public string SecurityPIN
            {
                set
                {
                    pin = value;
                }
            }
        }




        class Product
        {
            public string ProductName { get; set; }
            public double Price { get; set; }
            public int StockQuantity { get; set; }


            public Product(string productName, double price, int stock)
            {
                ProductName = productName;
                Price = price;
                StockQuantity = stock;
            }


            public void Sell(int quantity)
            {
                if (StockQuantity >= quantity)
                {
                    StockQuantity -= quantity;
                }
                else
                {
                    Console.WriteLine("Not enough stock.");
                }

                LogTransaction();
            }


            public void Restock(int quantity)
            {
                StockQuantity += quantity;
                LogTransaction();
            }


            public double GetInventoryValue()
            {
                PrintDetails();
                return Price * StockQuantity;
            }


            private void PrintDetails()
            {
                Console.WriteLine("Product Name: " + ProductName);
                Console.WriteLine("Price: " + Price);
                Console.WriteLine("Stock Quantity: " + StockQuantity);
            }


            private void LogTransaction()
            {
                Console.WriteLine("Transaction logged.");
            }
        }




        internal class BankSystem
        {
            static void Main(string[] args)
            {

                BankAccount account1 =
                    new BankAccount(1163, "karim", 120);

                BankAccount account2 =
                    new BankAccount(15203, "Ali", 63);



                Student student1 =
                    new Student("Ali", "Muscat", 65);

                Student student2 =
                    new Student("Ahmed", "Muscat", 70);



                Product product1 =
                    new Product("Wireless Mouse", 5.500, 50);

                Product product2 =
                    new Product("Mechanical Keyboard", 15.750, 20);



                bool exit = false;


                while (!exit)
                {

                    Console.WriteLine("\n===== OOP BANK SYSTEM =====");

                    Console.WriteLine("1. View Account Details");
                    Console.WriteLine("2. Update Student Address");
                    Console.WriteLine("3. Make Deposit");
                    Console.WriteLine("4. Make Withdrawal");
                    Console.WriteLine("5. View Product Details");
                    Console.WriteLine("6. Register Student");
                    Console.WriteLine("7. Compare Account Balances");
                    Console.WriteLine("8. Restock Product");
                    Console.WriteLine("9. Transfer Between Accounts");
                    Console.WriteLine("10. Update Student Grade");
                    Console.WriteLine("11. Student Report Card");
                    Console.WriteLine("12. Account Health Status");
                    Console.WriteLine("13. Bulk Sale");
                    Console.WriteLine("14. Scholarship Eligibility");
                    Console.WriteLine("15. Full Balance Top-Up");
                    Console.WriteLine("16. Quick Account Opening");
                    Console.WriteLine("17. Total Students Counter");
                    Console.WriteLine("18. Overdrawn Account Check");
                    Console.WriteLine("19. Set Student Security PIN");
                    Console.WriteLine("20. Exit");


                    Console.Write("Choose: ");
                    int choice = int.Parse(Console.ReadLine());
                }
            }
        }
    }
    }

                    


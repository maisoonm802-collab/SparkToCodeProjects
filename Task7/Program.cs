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

                    switch (choice)
                    {
                        // Case 1
                        case 1:

                            Console.Write("Choose Account (1/2): ");
                            int accountChoice = int.Parse(Console.ReadLine());

                            if (accountChoice == 1)
                                account1.CheckBalance();

                            else if (accountChoice == 2)
                                account2.CheckBalance();

                            break;



                        // Case 2
                        case 2:

                            Console.Write("Choose Student (1/2): ");
                            int studentChoice = int.Parse(Console.ReadLine());

                            Console.Write("Enter new address: ");
                            string newAddress = Console.ReadLine();


                            if (studentChoice == 1)
                            {
                                student1.Address = newAddress;
                                Console.WriteLine("Address updated: " + student1.Address);
                            }

                            else if (studentChoice == 2)
                            {
                                student2.Address = newAddress;
                                Console.WriteLine("Address updated: " + student2.Address);
                            }

                            break;



                        // Case 3
                        case 3:

                            Console.Write("Choose Account (1/2): ");
                            int depositAccount = int.Parse(Console.ReadLine());

                            Console.Write("Amount: ");
                            double depositAmount = double.Parse(Console.ReadLine());


                            if (depositAccount == 1)
                            {
                                account1.Deposit(depositAmount);
                                Console.WriteLine("Balance: " + account1.Balance);
                            }

                            else if (depositAccount == 2)
                            {
                                account2.Deposit(depositAmount);
                                Console.WriteLine("Balance: " + account2.Balance);
                            }

                            break;



                        // Case 4
                        case 4:

                            Console.Write("Choose Account (1/2): ");
                            int withdrawAccount = int.Parse(Console.ReadLine());

                            Console.Write("Amount: ");
                            double withdrawAmount = double.Parse(Console.ReadLine());


                            if (withdrawAccount == 1)
                            {
                                account1.Withdraw(withdrawAmount);
                                Console.WriteLine("Balance: " + account1.Balance);
                            }

                            else if (withdrawAccount == 2)
                            {
                                account2.Withdraw(withdrawAmount);
                                Console.WriteLine("Balance: " + account2.Balance);
                            }

                            break;



                        // Case 5
                        case 5:

                            Console.Write("Choose Product (1/2): ");
                            int productChoice = int.Parse(Console.ReadLine());


                            if (productChoice == 1)
                            {
                                Console.WriteLine(
                                    "Inventory Value: " +
                                    product1.GetInventoryValue());
                            }

                            else if (productChoice == 2)
                            {
                                Console.WriteLine(
                                    "Inventory Value: " +
                                    product2.GetInventoryValue());
                            }

                            break;




                        // Case 6
                        case 6:

                            Console.Write("Choose Student (1/2): ");
                            int registerStudent = int.Parse(Console.ReadLine());

                            Console.Write("Enter Email: ");
                            string email = Console.ReadLine();


                            if (registerStudent == 1)
                                student1.Register(email);

                            else if (registerStudent == 2)
                                student2.Register(email);


                            Console.WriteLine("Registration completed.");

                            break;





                        // Case 7
                        case 7:

                            if (account1.Balance > account2.Balance)
                                Console.WriteLine("Account 1 has more money.");

                            else if (account2.Balance > account1.Balance)
                                Console.WriteLine("Account 2 has more money.");

                            else
                                Console.WriteLine("Both accounts are equal.");

                            break;





                        // Case 8
                        case 8:

                            Console.Write("Choose Product (1/2): ");
                            int restockProduct = int.Parse(Console.ReadLine());

                            Console.Write("Quantity: ");
                            int restock = int.Parse(Console.ReadLine());


                            Product restockItem;

                            if (restockProduct == 1)
                                restockItem = product1;

                            else
                                restockItem = product2;


                            restockItem.Restock(restock);



                            if (restockItem.StockQuantity < 10)
                                Console.WriteLine("Low");

                            else if (restockItem.StockQuantity <= 49)
                                Console.WriteLine("Moderate");

                            else
                                Console.WriteLine("Well Stocked");


                            break;
                        // Case 9 - Transfer Between Accounts
                        case 9:

                            Console.Write("Source Account (1/2): ");
                            int source = int.Parse(Console.ReadLine());

                            Console.Write("Destination Account (1/2): ");
                            int destination = int.Parse(Console.ReadLine());

                            Console.Write("Amount: ");
                            double transferAmount = double.Parse(Console.ReadLine());


                            BankAccount sourceAccount;
                            BankAccount destinationAccount;


                            if (source == 1)
                                sourceAccount = account1;
                            else
                                sourceAccount = account2;


                            if (destination == 1)
                                destinationAccount = account1;
                            else
                                destinationAccount = account2;



                            if (sourceAccount.Balance >= transferAmount)
                            {
                                sourceAccount.Withdraw(transferAmount);
                                destinationAccount.Deposit(transferAmount);

                                Console.WriteLine("Transfer completed successfully.");
                            }

                            else
                            {
                                Console.WriteLine("Transfer failed. Not enough balance.");
                            }

                            break;




                        // Case 10 - Update Student Grade
                        case 10:

                            Console.Write("Choose Student (1/2): ");
                            int updateStudent = int.Parse(Console.ReadLine());

                            Console.Write("Enter new grade: ");
                            string gradeInput = Console.ReadLine();


                            int grade;


                            if (int.TryParse(gradeInput, out grade) == false)
                            {
                                Console.WriteLine("Invalid grade.");
                                break;
                            }


                            if (grade < 0 || grade > 100)
                            {
                                Console.WriteLine("Grade must be between 0 and 100.");
                                break;
                            }



                            if (updateStudent == 1)
                                student1.Grade = grade;

                            else if (updateStudent == 2)
                                student2.Grade = grade;


                            Console.WriteLine("Grade updated.");

                            break;





                        // Case 11 - Student Report Card
                        case 11:

                            Console.Write("Choose Student (1/2): ");
                            int reportChoice = int.Parse(Console.ReadLine());


                            Student reportStudent;


                            if (reportChoice == 1)
                                reportStudent = student1;

                            else
                                reportStudent = student2;



                            Console.WriteLine("Name: " + reportStudent.Name);
                            Console.WriteLine("Address: " + reportStudent.Address);
                            Console.WriteLine("Grade: " + reportStudent.Grade);



                            if (reportStudent.Grade >= 60)
                                Console.WriteLine("Pass");

                            else
                                Console.WriteLine("Fail");


                            break;






                        // Case 12 - Account Health Status
                        case 12:

                            Console.Write("Choose Account (1/2): ");
                            int healthChoice = int.Parse(Console.ReadLine());


                            BankAccount healthAccount;


                            if (healthChoice == 1)
                                healthAccount = account1;

                            else
                                healthAccount = account2;



                            if (healthAccount.Balance < 50)
                                Console.WriteLine("Low Balance");

                            else if (healthAccount.Balance <= 1000)
                                Console.WriteLine("Healthy");

                            else
                                Console.WriteLine("Premium");


                            break;






                        // Case 13 - Bulk Sale
                        case 13:

                            Console.Write("Choose Product (1/2): ");
                            int saleChoice = int.Parse(Console.ReadLine());

                            Console.Write("Quantity: ");
                            int saleQuantity = int.Parse(Console.ReadLine());


                            Product saleProduct;


                            if (saleChoice == 1)
                                saleProduct = product1;

                            else
                                saleProduct = product2;



                            if (saleProduct.StockQuantity < saleQuantity)
                            {
                                int needed = saleQuantity - saleProduct.StockQuantity;

                                Console.WriteLine("Not enough stock.");
                                Console.WriteLine("Need extra units: " + needed);
                            }

                            else
                            {
                                saleProduct.Sell(saleQuantity);

                                double revenue =
                                    saleQuantity * saleProduct.Price;


                                Console.WriteLine("Revenue: " + revenue);
                            }


                            break;







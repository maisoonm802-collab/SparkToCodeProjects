namespace CsharpSession1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ===================== TASK 1 - Personal Info Card =====================
            string name = "Sara";
            int age = 21;
            double height = 1.65;
            bool isStudent = true;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Student: " + isStudent);


            // ===================== TASK 2 - Rectangle Calculator =====================
            Console.WriteLine("\n--- Task 2 ---");

            Console.Write("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);


            // ===================== TASK 3 - Even or Odd Checker =====================
            Console.WriteLine("\n--- Task 3 ---");

            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }


            // ===================== TASK 4 - Voting Eligibility =====================
            Console.WriteLine("\n--- Task 4 ---");

            Console.Write("Enter age: ");
            int voterAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Do you have valid ID (yes/no): ");
            string idInput = Console.ReadLine().ToLower();
            bool hasID = (idInput == "yes");

            if (voterAge >= 18 && hasID)
            {
                Console.WriteLine("Eligible to vote");
            }
            else
            {
                Console.WriteLine("Not eligible to vote");
            }


            // ===================== TASK 5 - Grade Letter Lookup =====================
            Console.WriteLine("\n--- Task 5 ---");

            Console.Write("Enter grade (A/B/C/D/F): ");
            char grade = Convert.ToChar(Console.ReadLine());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Pass");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }


            // ===================== TASK 6 - Temperature Converter =====================
            Console.WriteLine("\n--- Task 6 ---");

            Console.Write("Enter Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("Fahrenheit: " + fahrenheit.ToString("F2"));

            if (celsius < 10)
                Console.WriteLine("Cold");
            else if (celsius <= 30)
                Console.WriteLine("Mild");
            else
                Console.WriteLine("Hot");


            // ===================== TASK 7 - Movie Ticket Pricing =====================
            Console.WriteLine("\n--- Task 7 ---");

            Console.Write("Enter age: ");
            int movieAge = Convert.ToInt32(Console.ReadLine());

            if (movieAge <= 12)
            {
                Console.WriteLine("Child Ticket: 2.000 OMR");
            }
            else if (movieAge <= 59)
            {
                Console.WriteLine("Adult Ticket: 5.000 OMR");
            }
            else
            {
                Console.WriteLine("Senior Ticket: 3.000 OMR");
            }


            // ===================== TASK 8 - Restaurant Discount =====================
            Console.WriteLine("\n--- Task 8 ---");

            Console.Write("Enter bill amount: ");
            double bill = Convert.ToDouble(Console.ReadLine());

            Console.Write("Are you a member (yes/no): ");
            string memberInput = Console.ReadLine().ToLower();
            bool isMember = (memberInput == "yes");

            double discount = 0;

            if (bill > 20 && isMember)
            {
                discount = bill * 0.15;
            }

            double finalBill = bill - discount;

            Console.WriteLine("Original Bill: " + bill);
            Console.WriteLine("Discount: " + discount);
            Console.WriteLine("Final Bill: " + finalBill);


            // ===================== TASK 9 - Day Name Finder =====================
            Console.WriteLine("\n--- Task 9 ---");

            Console.Write("Enter day number (1-7): ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }

            // ===================== TASK 10 - Mini Calculator =====================
            Console.WriteLine("\n--- Task 10 ---");

            Console.Write("Enter first number: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+ - * / %): ");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine(n1 + n2);
                    break;
                case '-':
                    Console.WriteLine(n1 - n2);
                    break;
                case '*':
                    Console.WriteLine(n1 * n2);
                    break;
                case '/':
                    if (n2 != 0)
                        Console.WriteLine(n1 / n2);
                    else
                        Console.WriteLine("Cannot divide by zero");
                    break;
                case '%':
                    if (n2 != 0)
                        Console.WriteLine(n1 % n2);
                    else
                        Console.WriteLine("Cannot divide by zero");
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }


            // ===================== TASK 11 - Loan Eligibility =====================
            Console.WriteLine("\n--- Task 11 ---");

            Console.Write("Enter age: ");
            int loanAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter monthly income: ");
            double income = Convert.ToDouble(Console.ReadLine());

            Console.Write("Existing loan (yes/no): ");
            bool hasLoan = Console.ReadLine().ToLower() == "yes";

            if (loanAge < 21 || loanAge > 60)
            {
                Console.WriteLine("Not eligible: age out of range");
            }
            else if (income < 400)
            {
                Console.WriteLine("Not eligible: income too low");
            }
            else if (hasLoan)
            {
                Console.WriteLine("Not eligible: already has a loan");
            }
            else
            {
                Console.WriteLine("Eligible for loan");
            }


            // ===================== TASK 12 - Shipping Cost =====================
            Console.WriteLine("\n--- Task 12 ---");

            Console.Write("Enter region (A/B/C): ");
            char region = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter weight (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double baseCost = 0;
            double extra = 0;

            switch (region)
            {
                case 'A':
                    baseCost = 1.000;
                    break;
                case 'B':
                    baseCost = 3.000;
                    break;
                case 'C':
                    baseCost = 7.000;
                    break;
                default:
                    Console.WriteLine("Invalid region");
                    baseCost = -1;
                    break;
            }

            if (baseCost != -1)
            {
                if (weight > 10)
                    extra = 5.000;
                else if (weight > 5)
                    extra = 2.000;
                else
                    extra = 0;

                double totalShipping = baseCost + extra;

                Console.WriteLine("Base Cost: " + baseCost);
                Console.WriteLine("Extra Charge: " + extra);
                Console.WriteLine("Total: " + totalShipping);
            }


            // ===================== TASK 13 - Triangle Classifier =====================
            Console.WriteLine("\n--- Task 13 ---");

            Console.Write("Enter side 1: ");
            double s1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side 2: ");
            double s2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side 3: ");
            double s3 = Convert.ToDouble(Console.ReadLine());

            if (s1 + s2 > s3 && s1 + s3 > s2 && s2 + s3 > s1)
            {
                if (s1 == s2 && s2 == s3)
                    Console.WriteLine("Equilateral");
                else if (s1 == s2 || s1 == s3 || s2 == s3)
                    Console.WriteLine("Isosceles");
                else
                    Console.WriteLine("Scalene");
            }
            else
            {
                Console.WriteLine("Not a valid triangle");
            }


            // ===================== TASK 14 - Online Store Checkout =====================
            Console.WriteLine("\n--- Task 14 ---");

            Console.Write("Enter product code (1-3): ");
            int code = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());

            Console.Write("Have coupon (yes/no): ");
            bool coupon = Console.ReadLine().ToLower() == "yes";

            double price = 0;
            bool valid = true;

            switch (code)
            {
                case 1: price = 8.500; break;
                case 2: price = 12.000; break;
                case 3: price = 5.000; break;
                default:
                    Console.WriteLine("Invalid product code");
                    valid = false;
                    break;
            }

            if (valid)
            {
                double subtotal = price * qty;
                double storeDiscount = 0;

                if (coupon && subtotal > 20)
                    storeDiscount = subtotal * 0.10;

                double afterDiscount = subtotal - storeDiscount;
                double tax = afterDiscount * 0.05;
                double total = afterDiscount + tax;

                Console.WriteLine("Subtotal: " + subtotal);
                Console.WriteLine("Discount: " + storeDiscount);
                Console.WriteLine("Tax: " + tax);
                Console.WriteLine("Total: " + total);
            }


            // ===================== TASK 15 - University Admission =====================
            Console.WriteLine("\n--- Task 15 ---");

            Console.Write("Program type (S/A): ");
            char program = Convert.ToChar(Console.ReadLine());

            Console.Write("GPA: ");
            double gpa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Exam score: ");
            double score = Convert.ToDouble(Console.ReadLine());

            Console.Write("Extracurricular (yes/no): ");
            bool hasExtra = Console.ReadLine().ToLower() == "yes";

            switch (program)
            {
                case 'S':
                    if (gpa >= 3.0 && score >= 75)
                    {
                        Console.WriteLine("Admitted");
                    }
                    else if (hasExtra)
                    {
                        Console.WriteLine("Conditionally Admitted");
                    }
                    else
                    {
                        Console.WriteLine("Not Admitted");
                    }
                    break;

                case 'A':
                    if (gpa >= 2.5 && score >= 60)
                    {
                        Console.WriteLine("Admitted");
                    }
                    else if (hasExtra)
                    {
                        Console.WriteLine("Conditionally Admitted");
                    }
                    else
                    {
                        Console.WriteLine("Not Admitted");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid program type");
                    break;
            }
        }
    }
}

  

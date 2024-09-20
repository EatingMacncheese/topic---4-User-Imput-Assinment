using System.Runtime.InteropServices;

namespace topic___4_User_Imput_Assinment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tiago
            string name, lastName, login, item1, item2;
            int age, grade, studentId;
            double salary, average, num1, num2, num3, ans, item1Price, item2Price, total
                , discount, subtotal, tax, totalOwed;



            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + ". How old are you?");
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine(age + "? cool");
            Console.WriteLine("How much money do you make a mounth?");
            double.TryParse(Console.ReadLine(), out salary);
            Console.WriteLine("You make " + salary.ToString("C") + " and mounth? thats alright.");
            Console.ReadLine();

            Console.WriteLine("Please give mr you information so I can sell it :)))))");

            Console.WriteLine("First name: ");
            name = Console.ReadLine();
            Console.WriteLine("Last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Grade:");
            int.TryParse(Console.ReadLine(), out grade);
            Console.WriteLine("Student ID:");
            int.TryParse(Console.ReadLine(), out studentId);
            Console.WriteLine("Login:");
            login = Console.ReadLine();
            Console.WriteLine("Average:");
            double.TryParse(Console.ReadLine(), out average);

            Console.WriteLine("Your information:");
            Console.WriteLine("     Login:\t\t" + login);
            Console.WriteLine("     ID:\t\t" + studentId);
            Console.WriteLine("     Name:\t\t" + name + "-" + lastName);
            Console.WriteLine("     Grade:\t\t" + grade);
            Console.WriteLine("     Average:\t\t" + average);
            Console.ReadLine();

            Console.WriteLine("So " + name + ", how old are you again?");
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Well did you know that you will be " + (age + 5) + " in five years?");
            Console.WriteLine("Did you know that you would have been " + (age - 5) + " five years ago?");
            Console.ReadLine();

            Console.WriteLine("Im going to ask you for 3 numbers of your choosing");
            Console.WriteLine("Then i'll and them all and divid it by 2");
            Console.WriteLine("What should the first number be?");
            double.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Great, what will the second number be?");
            double.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine("And finally, what will the third number be?");
            double.TryParse(Console.ReadLine(), out num3);
            ans = num1 + num2 + num3;
            Console.WriteLine("All thoughs numbers added up and divided by 2 is " + ans);
            Console.ReadLine();

            Console.WriteLine("Name 2 item that you would buy");
            Console.WriteLine("First item:");
            item1 = Console.ReadLine();
            Console.WriteLine("Now give me the price for that item");
            double.TryParse(Console.ReadLine(), out item1Price);
            Console.WriteLine("Name the second item:");
            item2 = Console.ReadLine();
            Console.WriteLine("And now the price for that item");
            double.TryParse (Console.ReadLine(), out item2Price);
            Console.WriteLine("     Here is your recite");
            Console.WriteLine();
            total = item1Price + item2Price;
            discount = total * 0.20;
            subtotal = total - discount;
            tax = subtotal * 0.13;
            totalOwed = subtotal + tax;
            Console.WriteLine("Item 1: " + item1);
            Console.WriteLine("Price: " + item1Price.ToString("C"));
            Console.WriteLine("Item 2: " + item2);
            Console.WriteLine("Price: " + item1Price.ToString("C"));
            Console.WriteLine("====================");
            Console.WriteLine("Total: " + total.ToString("C"));
            Console.WriteLine("Discount (20%): " + discount.ToString("C"));
            Console.WriteLine("Subtotal: " + subtotal.ToString("C"));
            Console.WriteLine("Tax: " + tax.ToString("C"));
            Console.WriteLine("====================");
            Console.WriteLine("Total owed: " + totalOwed.ToString("C"));
            
        }
    }
}

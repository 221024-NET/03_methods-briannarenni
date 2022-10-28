using System;

namespace Methods {
    public class Program {
        public static void Main(string[] args) {
            string name = GetName();
            GreetFriend(name);

            // Calculations
            double result1 = GetNumber();
            double result2 = GetNumber();
            int action1 = GetAction();
            double result3 = DoAction(result1, result2, (double)action1);

            System.Console.WriteLine($"The result of your mathematical operation is {result3}.");

        }

        // NAME METHODS
        public static string GetName() {
            Console.WriteLine("Enter your name: ");
            return Console.ReadLine();
        }

        public static void GreetFriend(string name) {
            Console.WriteLine($"Hello, {name}. You are my friend");
        }

        // CALCULATOR METHODS
        public static double GetNumber() {
            Console.WriteLine("Please enter number: ");
            string userNum = Console.ReadLine();
            double num;
            bool isValid = Double.TryParse(userNum, out num);
            if (isValid) {
                return num;
            } else {
                throw new FormatException();
            }
        }

        public static int GetAction() {
            Console.WriteLine("Enter operation number: ");
            Console.WriteLine("1: (+) 2: (-) 3: (*) 4: (/)");
            string userChoice = Console.ReadLine();
            int oper;
            bool isValid = Int32.TryParse(userChoice, out oper);
            if (isValid) {
                return oper;
            } else {
                throw new FormatException();
            }
        }

        public static double DoAction(double x, double y, double z) {
            double result;
            if (z == 1) {
                result = x + y;
            } else if (z == 2) {
                result = x - y;
            } else if (z == 3) {
                result = x * y;
            } else if (z == 4) {
                result = x / y;
            } else {
                throw new FormatException();
            }

            return result;
        }
    }
}

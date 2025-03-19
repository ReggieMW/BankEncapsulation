namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var reggiesChecking = new BankAccount();
            do
            {
                Console.WriteLine("Hello, how can I help you?");
                Console.WriteLine("1. Make Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("5. Exit");
                string userSelection = Console.ReadLine();
                if (userSelection == "1")
                {
                    Console.WriteLine("How much would you like to deposit?");
                    double userDeposit = double.Parse(Console.ReadLine());
                    reggiesChecking.Deposit(userDeposit);
                    Console.WriteLine($"{userDeposit} is deposited.");
                }
                else if (userSelection == "2")
                {
                    Console.WriteLine("How much would you like to withdraw?");
                    double userWithdraw = double.Parse(Console.ReadLine());
                    reggiesChecking.Withdraw(userWithdraw);
                    Console.WriteLine($"{userWithdraw} is withdrawn.");
                }
                else if (userSelection == "3")
                {
                    Console.WriteLine(reggiesChecking.GetBalance());
                }
                else if (userSelection == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid selection. Please make a selection.");
                }
            } while (Console.ReadLine() != "5");
        }
    }
}

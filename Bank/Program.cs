using Bank.Entities;
using System.Globalization;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Account acc = new Account(1001, "Maria", 0.0);
            //BusinessAccount BobAccount = new BusinessAccount(2026, "Bob Brown", 100.0, 500.0);

            //Console.WriteLine(BobAccount.Balance);

            ////UPCASTING

            //Account ac1 = BobAccount;

            List<Account> accounts = new List<Account>();
            accounts.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            accounts.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            accounts.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            accounts.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (var item in accounts)
            {
                sum += item.Balance;
            }
            Console.WriteLine("Total Balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (var acc in accounts)
            {
                acc.Withdraw(10.00);
            }

            foreach (var acc in accounts)
            {
                Console.WriteLine("Updated balance for account " +
                    acc.Number +
                    ": " +
                    acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        
        }
    }
}
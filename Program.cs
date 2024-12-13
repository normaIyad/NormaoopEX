namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts = new Account[]
            {
               new FixedDepositAccount()
               {
                   balance = 1000,
                   year = 1
               },
               new FixedDepositAccount()
               {
                   balance = 1000,
                   year = 4
               },
               new SavingsAccount()
               {
                   balance = 1000 , year = 5
               }, new SavingsAccount()
               {
                   balance= 1000 , year = 6
               }

            };
            for (int i = 0; i < accounts.Length; i++)
            {
                accounts[i].CalculateInterest(accounts[i].year, accounts[i].balance);
            }


        }
    }
}

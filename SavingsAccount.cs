namespace ConsoleApp3
{
    internal class SavingsAccount : Account
    {
        public override void CalculateInterest(int years, double balance)
        {
            double res = 0;
            if (years < 3)
            {
                res = balance * .03 * years;
            }
            if (years >= 3)
            {
                res = balance * .04 * years;
            }
            Console.WriteLine("calcolate res" + res + "from saving account" + year + "years");

        }
    }
}

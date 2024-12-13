namespace ConsoleApp3
{
    internal class FixedDepositAccount : Account
    {
        public override void CalculateInterest(int years, double balance)
        {
            double res = 0;
            if (years < 2)
            {
                res = balance * .06 * years;
            }
            if (years > 2)
            {
                res = balance * .08 * years + (500 + years);
            }
            Console.WriteLine("calacolate res " + res + "from fixed account " + year + "years");

        }
    }
}

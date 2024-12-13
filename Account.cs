namespace ConsoleApp3
{
    internal abstract class Account
    {
        public double balance { get; set; }
        public int year { get; set; }

        public abstract void CalculateInterest(int years, double balance);

    }
}

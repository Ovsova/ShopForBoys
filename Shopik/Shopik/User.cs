namespace Shops
{
    public class User
    {
        public string Name { get; private set; }
        public string Adress { get; private set; }
        public double Balance { get; private set; }
        public double Spent { get; private set; }
        public int Date { get; private set; }
        public string DayOfTheWeek { get; private set; }

        public User(string name, string adress, int balance, int spent, int data, string dotw)
        {
            Name = name;
            Adress = adress;
            Balance = balance;
            Spent = spent;
            Date = data;
            DayOfTheWeek = dotw;
        }

        public void ReduceBalance(double price)
        {
            Balance -= price;
            Spent += price;
        }
    }
}
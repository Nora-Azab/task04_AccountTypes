namespace AccountTypes
{
    public class Saving : Account
    {
        public double InterestRate { get; set; }

        public Saving(string name= "Unnamed Account", double balance = 0.0, double interestRate=0.0) : base(name, balance)
        {
            this.InterestRate = interestRate;
        }
        //=========================
        public override string ToString()
        {
            return $"{base.ToString()} , interestRata: {this.InterestRate}";
        }
    }
}

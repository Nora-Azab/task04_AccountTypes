using System.ComponentModel.DataAnnotations;

namespace AccountTypes
{
    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(string name= "Unnamed Account", double balance = 0.0, double interestRate=0.0) : base(name, balance)
        {
            this.InterestRate = interestRate;
        }
        //=========================
        public override string ToString()
        {
            string baseDetails = base.ToString();
            string baseDetailsModified = baseDetails.Remove(baseDetails.Length-1);// remove the last char :)   ->  '}'
            return $"{baseDetailsModified} , interestRata: {this.InterestRate}}}";
        }
    }
}

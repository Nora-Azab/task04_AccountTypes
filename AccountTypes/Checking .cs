namespace AccountTypes
{
    public class CheckingAccount : Account
    {
        public double Fee { get;protected set; } = 1.5; //a fee of $1.50 per withdrawal transaction.
        /// protected :like private .. but can be as a "private" properity to any derived class and can use it internally :)
        /// but it's private .. the drived class cannot use it inside it :)
        /// must cannot be modified unless in its class and its derived classes:)

        public CheckingAccount(string name = "Unnamed Account", double balance=0.0):base(name,balance)
        {
        }

        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + Fee);
        }

        //============================
        public override string ToString()
        {
            string baseDetails = base.ToString();
            string baseDetailsModified = baseDetails.Remove(baseDetails.Length - 1);// remove the last char :)   ->  '}'
            return $"{baseDetailsModified} , fee: {Fee}}}";
        }

    }
}

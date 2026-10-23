namespace AccountTypes
{
    public class Checking:Account
    {
        public double Fee { get;protected set; } = 1.5; //a fee of $1.50 per withdrawal transaction.
        //protected :like private .. but can be as a "private" properity to any derived class and can use it internally :)
        //but it's private .. the drived class cannot use it inside it :)
        //must cannot be modified :)

        public Checking(string name = "Unnamed Account", double balance=0.0):base(name,balance)
        {
        }



        //============================
        public override string ToString()
        {
            return $"{base.ToString()} , fee: {Fee}";
        }

    }
}

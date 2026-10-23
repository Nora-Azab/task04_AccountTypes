using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AccountTypes
{
    public class Trust:Saving
    {
        public Trust(string name= "Unnamed Account", double balance=0.0, double interestRate=0.0):base(name , balance , interestRate)
        {
            
        }

        //deposite
        //The Trust account deposit works just like a savings account deposit
        //any deposits of $5000.00 or more will receive a $50.00 bonus deposited to the account.


        //withdraw
        //The Trust account withdrawal should only allow 3 withdrawals per year and each of these must be less than 20% of the account balance.

        public override string ToString() // كان ممكن مكتبهاش بردو
        {
            return base.ToString();
        }

    }
}

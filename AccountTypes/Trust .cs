namespace AccountTypes
{
    public class Trust:Saving
    {
        //fields :)
        bool firstTime = true;
        ///DateTime resetDate = DateTime.Now; // it's wrong لأن هتتنفذ اول ما اعمل الاوبجيكت 
        ///and then mammybe i decide to do s.things not withdrawal , so the time will not the same :)

        const int withdrawalCountPerYear = 3;//TODO:  which is right?
        //public int withdrawalCountPerYear { get; protected set; } = 3;// 3 withdrawals per year  
        int cnt = withdrawalCountPerYear;//عملت ده مستقل عشان انقص فيه براحتي ... ويكون مكان واحد بغير فيه هو ال فوق بس
        DateTime resetDate = DateTime.Now;

        //-------------------------
        //props:
        public double MaximumLimit { get; protected set; } = 0.20; //20%
        public Trust(string name= "Unnamed Account", double balance=0.0, double interestRate=0.0):base(name , balance , interestRate)
        {
            
        }

        //deposite
        //The Trust account deposit works just like a savings account deposit
        //any deposits of $5000.00 or more will receive a $50.00 bonus deposited to the account.

        public override bool Deposit(double amount)
        {
            amount = (amount >= 5000 ? amount += 50 : amount);
            return base.Deposit(amount );
        }

        //withdraw
        //The Trust account withdrawal should only allow 3 withdrawals per year
        //and each of these must be less than 20% of the account balance.
        public override bool Withdraw(double amount)
        {
            if (amount < (MaximumLimit * this.Balance))
            {
                
                if (resetDate == DateTime.Now) //to reset only ... no first time(هيكون عدى وقت) 
                    cnt = withdrawalCountPerYear;
                //------------
                if (resetDate > DateTime.Now || cnt == 0)
                    {
                        Console.WriteLine($"sorry u reached the max limit ,u can do new withdrawal at {resetDate}");
                        return false;
                    }
                //------------
                if (base.Withdraw(amount))
                {
                    cnt--;
                    if(cnt == 0)
                        resetDate = DateTime.Now.AddYears(1) ;
                    Console.WriteLine($"done u Withdraw {amount} from your account :), it's {withdrawalCountPerYear - cnt} time u withdraw in this year");
                    return true;
                }
                Console.WriteLine($"sorry u reached the max limit ,u can do new withdrawal at {resetDate}");
                return false;

            }
            Console.WriteLine("Not allowed, money must be less than 20% of the account balance :(");
             return false;
        }


        //========================
        public override string ToString() // كان ممكن مكتبهاش بردو
        {
            return base.ToString();
        }

    }
}

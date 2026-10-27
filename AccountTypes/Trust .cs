namespace AccountTypes
{
    
    //دلوقتي انا بحسب السنة ال فيها مسموح له انه يسحب 3 مرات فقط .. بداية من أول سحب عموما سواء ناجح هذا السحب أو لأ
    public class TrustAccount:SavingsAccount
    {
        //fields :)
        //const is considered that it's for the class Not an object :)   so we can't write this.(const varIABLE)
        const double Bonus = 50;
        const double MinAmountToAddBonus = 5000;
        //-------
        bool firstWithdrawal = true;
        const int WithdrawalCountPerYear = 3;//it's better than prop
        int cnt = WithdrawalCountPerYear;//عملت ده مستقل عشان انقص فيه براحتي ... ويكون مكان واحد بغير فيه هو ال فوق بس
        DateTime endOfYear = DateTime.Now;
        /// i don't init by "null" -> because this line "endOfYear = endOfYear.AddYears(1);" -> give me compile erroe

        //-------------------------
        //props:
        public const double MaximumLimit  = 0.20; //20%
        public TrustAccount(string name= "Unnamed Account", double balance=0.0, double interestRate=0.0):base(name , balance , interestRate)
        {
            
        }
        public override bool Deposit(double amount)
        {
            if (amount >= MinAmountToAddBonus)
                amount += Bonus;
            return base.Deposit(amount );
        }
        //--------------------
        public override bool Withdraw(double amount)
        {
            //DateTime now = new DateTime(2027 , 10 , 26 , 12 , 17 , 1);//10/26/2027 12:17:01 PM
            DateTime now = DateTime.Now;

            //وبكده هنحسب بداية السنة ال بيتم فيها 3 عمليات فقط بداية من أول عملية سحب عموما سواء ناجحة او لأ
            if (firstWithdrawal)
            {
                endOfYear = now.AddYears(1);
                firstWithdrawal = false;
            }
            //---------------
            //this reset :happen if the process successed or not :)
            if (endOfYear <= now)// بيحصل لما السنة تخلص .. reset ال
            { 
                cnt = WithdrawalCountPerYear;

                //عشان لو عدى سنين كتير ولسه حضرته داخل يعمل سحب فنريست التاريح صح
                ///wrong solution :)   مش بيراعي الشهور
                ///now = 5/1/2028  ,  end = 1/12/2027  -> will add 2 years
                /// endOfYear = endOfYear.AddYears((now.Year - endOfYear.Year)+1);
                /// 
                while (endOfYear <= now)
                {
                    endOfYear = endOfYear.AddYears(1);
                }
            }
            //---------------
            if (amount < (MaximumLimit * this.Balance))
            {
                //if (endOfYear > now && cnt > 0)//في فرصة اسحب
                if ( cnt > 0)//"endOfYear > now"  ->  i will not need it because (above) we checked for reset endOfYear always, so this condition always will be true ")
                {
                    if (base.Withdraw(amount)) 
                    {
                        cnt--;
                        //Console.WriteLine($"done u Withdraw {amount} from your account :), it's {WithdrawalCountPerYear - cnt} time u withdraw in this year");
                        //Console.WriteLine($"end of year: {endOfYear}"); 
                       return true;
                    }
                }
                //Console.WriteLine($"it's {WithdrawalCountPerYear - cnt} time u withdraw in this year, and 3 times only allowed during the year ,will be allowed in {endOfYear.Date} :)");
            }
            //Console.WriteLine("Not allowed, money must be less than 20% of the account balance :(");
                 return false;
        }

    }
}

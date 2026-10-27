using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AccountTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region my test cases:)

            #region test the constractors and ToString() of the classes :)
            //Account account = new Account();
            ////Console.WriteLine(account);
            //Saving saving = new Saving("nour" , 1000 , 5.0);
            ////Console.WriteLine(saving);
            //Checking checking = new Checking("Curly2", 5000);
            ////Console.WriteLine(checking);
            //Trust trust = new Trust("Batman2", 2000);
            //Console.WriteLine(trust); 
            #endregion

            #region trying test cases for withdrawal and deposit for the three accounts :)
            //Account account = new Account("noura", 0);
            //Account checking = new CheckingAccount("noha", 1000);

            /////VIP:
            /////Saving trust = new Trust("fareda", 2000);
            /////incase i used a ref from "saving" -> compiler will virtually use Deposit() of "saving" in compilation time , then in run time it will use Deposit() of "Trust"
            //Account trust = new TrustAccount("fareda", 2000);
            ///// but incase i used a ref from "Account" -> compiler will tend to use Deposit() of Account which is NOT virtual -> so will execut it and will not postpone to the run time :)
            ///// so we must start virtual from "Account"

            ////Deposit :)
            //account.Deposit(1000);
            //////Console.WriteLine(account);//1000
            //////--------------------
            //checking.Deposit(2000);
            //////Console.WriteLine(checking);//3000
            //////--------------------
            //trust.Deposit(5000);//   >=5000 -> balance+= 50         VIP :)
            ////Console.WriteLine(trust);//7050
            //Console.WriteLine($"after deposite :\n{trust}");

            ////withdraw :)
            ////account.Withdraw(50);
            ////Console.WriteLine(account);//1000-50 = 950
            //////--------------------
            ////checking.Withdraw(50);
            ////Console.WriteLine(checking);//3000-(50+1.5)=2948.5
            //////--------------------
            /////
            //Console.WriteLine();
            //trust.Withdraw(2000);//1st successful withdraw
            //Console.WriteLine(trust);//
            //Console.WriteLine();

            ////trust.Withdraw(5000);// >20%  * balance=
            ////Console.WriteLine(trust);//
            ////Console.WriteLine();
            ////-----------
            //trust.Withdraw(3000);//2nd successful withdraw
            //Console.WriteLine(trust);//
            //Console.WriteLine();

            //trust.Withdraw(500);//3rd successful withdraw
            //Console.WriteLine(trust);//
            //Console.WriteLine();
            ////-----------
            //trust.Withdraw(50);
            //Console.WriteLine(trust);

            #endregion


            //======================
            #region date and time
            //DateTime date = new DateTime();
            DateTime date = DateTime.Today;
            /// Today -> static member inside DateTime (struct) 
            ///  it's static, so i can get it without making an instance from DataTime :)
            //Console.WriteLine(date);//10/24/2026 12:00:00 AM    it's enough :)

            //Console.WriteLine(date.Day);
            //Console.WriteLine(date.Month);
            //Console.WriteLine(date.Year +1);//2027
            //Console.WriteLine($"({date.ToString("dd MMM")} {date.Year+1})");
            //-------
            //DateTime date2 = DateTime.Now;
            //Console.WriteLine(date2);//10/24/2026 8:22:30 AM 
            //Console.WriteLine(DateTime.MinValue);

            //DateTime d1 = DateTime.Now;
            //Console.WriteLine(d1);//10/24/2026 1:16:55 PM
            //Console.WriteLine(DateTime.Now - d1);//00:00:00.0148859
            //Console.WriteLine("+++++++++");
            //DateTime? d = null;
            //if(d==DateTime.Now)
            //    Console.WriteLine("yes");
            //Console.WriteLine(d.HasValue);//false
            //if(null <= DateTime.Now)
            //    Console.WriteLine("yesssss");

            #endregion

            #endregion

            
            //============================
            // Accounts
            var accounts = new List<Account>();
            accounts.Add(new Account());
            accounts.Add(new Account("Larry"));
            accounts.Add(new Account("Moe", 2000));
            accounts.Add(new Account("Curly", 5000));

            AccountUtil.Deposit(accounts, 1000);
            AccountUtil.Withdraw(accounts, 2000);

            // Savings
            var savAccounts = new List<Account>();
            //var savAccounts = new List<SavingsAccount>();
            savAccounts.Add(new SavingsAccount());
            savAccounts.Add(new SavingsAccount("Superman"));
            savAccounts.Add(new SavingsAccount("Batman", 2000));
            savAccounts.Add(new SavingsAccount("Wonderwoman", 5000, 5.0));

            AccountUtil.Deposit(savAccounts, 1000);
            AccountUtil.Withdraw(savAccounts, 2000);
               
            //AccountUtil.DepositSavings(savAccounts, 1000);
            //AccountUtil.WithdrawSavings(savAccounts, 2000);

            // Checking
            var checAccounts = new List<Account>();
            //var checAccounts = new List<CheckingAccount>();
            checAccounts.Add(new CheckingAccount());
            checAccounts.Add(new CheckingAccount("Larry2"));
            checAccounts.Add(new CheckingAccount("Moe2", 2000));
            checAccounts.Add(new CheckingAccount("Curly2", 5000));

            AccountUtil.Deposit(checAccounts, 1000);
            AccountUtil.Withdraw(checAccounts, 2000);
            AccountUtil.Withdraw(checAccounts, 2000);

            //AccountUtil.DepositChecking(checAccounts, 1000);
            //AccountUtil.WithdrawChecking(checAccounts, 2000);
            //AccountUtil.WithdrawChecking(checAccounts, 2000);

            // Trust
            var trustAccounts = new List<Account>();
            //var trustAccounts = new List<TrustAccount>();
            trustAccounts.Add(new TrustAccount());
            trustAccounts.Add(new TrustAccount("Superman2"));
            trustAccounts.Add(new TrustAccount("Batman2", 2000));
            trustAccounts.Add(new TrustAccount("Wonderwoman2", 5000, 5.0));

            AccountUtil.Deposit(trustAccounts, 1000);
            AccountUtil.Deposit(trustAccounts, 6000);
            AccountUtil.Withdraw(trustAccounts, 2000);
            AccountUtil.Withdraw(trustAccounts, 3000);
            AccountUtil.Withdraw(trustAccounts, 500);

            //AccountUtil.DepositTrust(trustAccounts, 1000);
            //AccountUtil.DepositTrust(trustAccounts, 6000);
            //AccountUtil.WithdrawTrust(trustAccounts, 2000);
            //AccountUtil.WithdrawTrust(trustAccounts, 3000);
            //AccountUtil.WithdrawTrust(trustAccounts, 500);

            Console.WriteLine();
      

}
    }
}

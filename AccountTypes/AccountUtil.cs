namespace AccountTypes
{
    public static class AccountUtil
    {
        // Utility helper functions for Account class
        public static void Deposit(List<Account> accounts, double amount)
        {
            Console.WriteLine("\n=== Depositing to Accounts =================================");
            foreach (var acc in accounts)
            {
                if (acc.Deposit(amount))
                    Console.WriteLine($"Deposited {amount} to {acc}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc}");
            }
        }

        public static void Withdraw(List<Account> accounts, double amount)
        {
            Console.WriteLine("\n=== Withdrawing from Accounts ==============================");
            foreach (var acc in accounts)
            {
                if (acc.Withdraw(amount))
                    Console.WriteLine($"Withdrew {amount} from {acc}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            }
        }

        #region become not needed :)
        //    // Helper functions for SavingsAccount
        //    public static void DepositSavings(List<SavingsAccount> accounts, double amount)
        //    {
        //        Console.WriteLine("\n=== Depositing to Savings Accounts =================================");
        //        foreach (var acc in accounts)
        //        {
        //            if (acc.Deposit(amount))
        //                Console.WriteLine($"Deposited {amount} to {acc}");
        //            else
        //                Console.WriteLine($"Failed Deposit of {amount} to {acc}");
        //        }
        //    }

        //    public static void WithdrawSavings(List<SavingsAccount> accounts, double amount)
        //    {
        //        Console.WriteLine("\n=== Withdrawing from Savings Accounts ==============================");
        //        foreach (var acc in accounts)
        //        {
        //            if (acc.Withdraw(amount))
        //                Console.WriteLine($"Withdrew {amount} from {acc}");
        //            else
        //                Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
        //        }
        //    }

        //    // Helper functions for CheckingAccount
        //    public static void DepositChecking(List<CheckingAccount> accounts, double amount)
        //    {
        //        Console.WriteLine("\n=== Depositing to Checking Accounts =================================");
        //        foreach (var acc in accounts)
        //        {
        //            if (acc.Deposit(amount))
        //                Console.WriteLine($"Deposited {amount} to {acc}");
        //            else
        //                Console.WriteLine($"Failed Deposit of {amount} to {acc}");
        //        }
        //    }

        //    public static void WithdrawChecking(List<CheckingAccount> accounts, double amount)
        //    {
        //        Console.WriteLine("\n=== Withdrawing from Checking Accounts ==============================");
        //        foreach (var acc in accounts)
        //        {
        //            if (acc.Withdraw(amount))
        //                Console.WriteLine($"Withdrew {amount} from {acc}");
        //            else
        //                Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
        //        }
        //    }

        //    // Helper functions for TrustAccount
        //    public static void DepositTrust(List<TrustAccount> accounts, double amount)
        //    {
        //        Console.WriteLine("\n=== Depositing to Trust Accounts =================================");
        //        foreach (var acc in accounts)
        //        {
        //            if (acc.Deposit(amount))
        //                Console.WriteLine($"Deposited {amount} to {acc}");
        //            else
        //                Console.WriteLine($"Failed Deposit of {amount} to {acc}");
        //        }
        //    }

        //    public static void WithdrawTrust(List<TrustAccount> accounts, double amount)
        //    {
        //        Console.WriteLine("\n=== Withdrawing from Trust Accounts ==============================");
        //        foreach (var acc in accounts)
        //        {
        //            if (acc.Withdraw(amount))
        //                Console.WriteLine($"Withdrew {amount} from {acc}");
        //            else
        //                Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
        //        }
        //    } 
        #endregion

    }



}

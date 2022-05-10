namespace CSharpLearnBankAccount;

public class InterestEarningAccount : BankAccount
{

    public InterestEarningAccount(string accountName, decimal initialBalance) : base(accountName, initialBalance)
    {
    }

    public override void PerformMonthEndTransaction()
    {
        if (Balance > 500m)
        {
            decimal interest = Balance * 0.05m;
            MakeDeposit(interest, DateTime.UtcNow, "apply monthly interest");
        }
    }
}

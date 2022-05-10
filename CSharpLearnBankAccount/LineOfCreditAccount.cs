namespace CSharpLearnBankAccount;

public class LineOfCreditAccount : BankAccount
{
    public LineOfCreditAccount(string accountName, decimal initialBalance) : base(accountName, initialBalance)
    {
    }

    public override void PerformMonthEndTransaction()
    {
        if (Balance < 0)
        {
            // Negate the balance to get a positive interest charge:
            decimal interest = -Balance * 0.07m;
            MakeWithdrawal(interest, DateTime.UtcNow, "Charge monthly interest");
        }
    }
}

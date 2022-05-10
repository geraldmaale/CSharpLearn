namespace CSharpLearnBankAccount;

public class GiftCardAccount : BankAccount
{
    private readonly decimal _monthlyDeposit = 0m;

    public GiftCardAccount(string accountName, decimal initialBalance, decimal monthlyDeposit = 0) : base(accountName, initialBalance)
    {
        _monthlyDeposit = monthlyDeposit;
    }

    public override void PerformMonthEndTransaction()
    {
        if (_monthlyDeposit != 0)
        {
            MakeDeposit(_monthlyDeposit, DateTime.UtcNow, "Add monthly deposit");
        }
    }
}

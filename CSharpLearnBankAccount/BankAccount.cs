using System.Text;

namespace CSharpLearnBankAccount;

public record Transaction(decimal Amount, DateTime Date, string Notes);

public class BankAccount
{
    public string AccountNumber { get; set; }
    public string? AccountName { get; set; }
    public List<Transaction>? AllTransactions { get; set; } = new();

    private static int accountNumberSeed = 1571000000;


    public BankAccount(string accountName, decimal initialBalance)
    {
        AccountNumber = accountNumberSeed.ToString();
        AccountName = accountName;
        accountNumberSeed++;

        MakeDeposit(initialBalance, DateTime.UtcNow, "Initial balance");
    }


    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var transaction in AllTransactions!)
            {
                balance += transaction.Amount;
            }

            return balance;
        }
    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
        }
        var deposit = new Transaction(amount, date, note);
        AllTransactions?.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
        }

        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Not enough funds for withdrawal");
        }

        var withdrawal = new Transaction(-amount, date, note);
        AllTransactions?.Add(withdrawal);
    }

    public string GetAccountHistory()
    {
        Console.WriteLine("Account history");

        var report = new StringBuilder();

        decimal balance = 0;
        report.AppendLine("Date\t\tAmount\t\tBalance\t\tNote");
        foreach (var transaction in AllTransactions!)
        {
            balance += transaction.Amount;
            report.AppendLine($"{transaction.Date.ToShortDateString()}\t{transaction.Amount.ToString("N")}\t{balance.ToString("N")}\t{transaction.Notes}");
        }

        return report.ToString();
    }

    public virtual void PerformMonthEndTransaction() { }


}

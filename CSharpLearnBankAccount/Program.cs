using CSharpLearnBankAccount;

decimal depositedAmount;
decimal withdrawalAmount;
string note;


try
{
    //var account = new BankAccount("Gerald", 1000);
    //Console.WriteLine(account.GetAccountHistory());

    //withdrawalAmount = 900;
    //note = "Rent Payment";

    //account.MakeWithdrawal(withdrawalAmount, DateTime.Now, note);
    //Console.WriteLine(account.GetAccountHistory());

    //depositedAmount = 500;
    //note = "May 2022 savings";
    //account.MakeDeposit(depositedAmount, DateTime.Now, note);
    //Console.WriteLine(account.GetAccountHistory());

    var giftCard = new GiftCardAccount("gift card", 100, 50);
    giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
    giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
    giftCard.PerformMonthEndTransaction();
    // can make additional deposits:
    giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
    Console.WriteLine(giftCard.GetAccountHistory());

    var savings = new InterestEarningAccount("savings account", 10000);
    savings.MakeDeposit(750, DateTime.Now, "save some money");
    savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
    savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
    savings.PerformMonthEndTransaction();
    Console.WriteLine(savings.GetAccountHistory());

    var lineOfCredit = new LineOfCreditAccount("line of credit", 0);
    // How much is too much to borrow?
    lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
    lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
    lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
    lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
    lineOfCredit.PerformMonthEndTransaction();
    Console.WriteLine(lineOfCredit.GetAccountHistory());


}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
    //return;
}



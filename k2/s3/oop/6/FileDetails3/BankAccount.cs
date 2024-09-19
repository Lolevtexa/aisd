
class BankAccount 
{
    private long accNo;
    public decimal accBal;
    private AccountType accType;

    public void Populate(decimal balance)
    {
        accNo = NextNumber();
        accBal = balance;
        accType = AccountType.Checking;
    }

    public long Number()
    {
        return accNo;
    }

    public decimal Balance()
    {
        return accBal;
    }

    public AccountType Type()
    {
        return accType;
    }

    private static long nextAccNo = 123;

    private static long NextNumber()
    {
        return nextAccNo++;
    }

    public decimal Deposit(decimal amount)
    {
        accBal += amount;
        return accBal;
    }

    public bool Withdraw(decimal amount)
    {
        if (accBal < amount)
            return false;

        accBal -= amount;
        return true;
    }
}

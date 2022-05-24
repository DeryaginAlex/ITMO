class BankAccount {
    public void Populate(long number, decimal balance) {
        accNo = number;
        accBal = balance;
        accType = AccountType.Checking;
    }
    public long Number() {
        return accNo;
    }
    public decimal Balance() {
        return accBal;
    }
    public AccountType Type() {
        return accType;
    }


    private long accNo;
    private decimal accBal;
    private AccountType accType;
}
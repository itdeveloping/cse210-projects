public class Account
{
    private int _balance;
    private List<int> _transactions = new List<int>();
    public Account()
    {
        _balance = 0;
    }
    public int getBalance()
    {
        foreach (int item in _transactions)
        {
            _balance += item;
        }
        return _balance;
    }
    public void Deposit(int amount)
    {
        _transactions.Add(amount);
    }
    public List<int> GetTransactionsList()
    {
        return _transactions;
    }
}
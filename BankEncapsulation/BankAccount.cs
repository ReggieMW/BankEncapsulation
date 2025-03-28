namespace BankEncapsulation;

public class BankAccount
{
    private double _balance = 0;
    private int _pinNumber = 1234;

    public double Balance
    {
        get
        {
            return _balance;
        }
        set
        {
            _balance = value;
        }
    }


    public void Deposit(double depositAmount)
    {
        _balance += depositAmount;
    }

    public void Withdraw(double withdrawAmoount)
    {
        _balance -= withdrawAmoount;
    }

    public void ChangePin(int pinNumber)
    {
        _pinNumber = pinNumber;
    }
    public double GetBalance()
    {
        return _balance;
    }
}
using static System.Console;
public class Conta {
    private double _saldo;

    public void setSaldo(double saldo)
    {

        if (saldo >= 0)
        {
            _saldo = saldo;
        }
        else
        {
            WriteLine("Saldo Invalído");
        }
    }
};
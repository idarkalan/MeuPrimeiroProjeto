using static System.Console;
public class Conta {
    private double _saldo;

    public void setSaldo(double saldo)
    {
        try { 
        if (saldo >= 0)
        {
            _saldo = saldo;
        }
        else /*Lança uma Exessão*/
        {
            throw new Exception("O Saldo não pode ser negativo!");
        }
        }catch(Exception ex) /*Lança uma Exessão de forma geral para todo tipo de erro*/
        {
            throw new Exception(ex.Message);
        }
    }
};
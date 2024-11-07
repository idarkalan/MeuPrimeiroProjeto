using static System.Console;

Conta c = new Conta();
WriteLine("informe o saldo: ");
double saldo = double.Parse(ReadLine());

c.setSaldo(saldo);
using static System.Console;

//Conta c = new Conta();
//WriteLine("informe o saldo: ");
//double saldo = double.Parse(ReadLine());

//c.setSaldo(saldo);
//try
//{
//    WriteLine("Digite um valor");
//    int valor = Convert.ToInt32(ReadLine());

//    WriteLine(valor / 0);
//}
//catch (Exception ex){
//    WriteLine("Valor informado inválido!"+ex.Message);
//}

try {
    Conta c = new Conta();
    c.setSaldo(-60);
}
catch(Exception ex) {
    WriteLine(ex.Message);
}
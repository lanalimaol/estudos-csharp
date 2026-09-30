using System.Globalization; 

//string nomeProduto = "Caixinha de Som";
//double valorFrequenciaProduto = 1.3455;
//bool possuiEntradaExtraProduto = true;
//char corProduto = 'P';
//int quantidadeProduto = 1;

//Console.WriteLine(nomeProduto);
//Console.WriteLine(possuiEntradaExtraProduto);
//Console.WriteLine(valorFrequenciaProduto.ToString("F2", CultureInfo.InvariantCulture));

//placeholder
string nome = "Maria";
int idade = 19;
double saldo = 10.987;

Console.WriteLine("{0} tem {1} anos, e possui R$ {2} na conta!", nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture));


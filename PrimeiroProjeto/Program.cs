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
//string nome = "Maria";
//int idade = 20;
//double saldo = 10.987;

////placeholder
//Console.WriteLine("{0} tem {1} anos, e possui R$ {2} na conta!", nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture));

////interpolação
//Console.WriteLine($"{nome} tem {idade} anos, ela possui {saldo:F2} reais na conta!");

////concatenação
//Console.WriteLine(nome + "tem" + idade + "anos" + "e ela possui incríveis" + saldo + "reais na conta!");

//int a = 10;
////a += 2;
//a %= 10; 

//Console.WriteLine($"{a} isso é um operador de atribução funcionando!");

////incremento e decremento 

//int b = 10;

//b++;
//b--;
//++b;
//--b;
//Console.WriteLine(b);

//int u = 4;
//int l = u++ * 2;

//Console.WriteLine(u);

//int maquinaSenha = 10;

//int minhaSenha = ++maquinaSenha;
//int senhaDaAmiga = ++maquinaSenha;
//int senhaDaAmiga2 = ++maquinaSenha;

//Console.WriteLine(maquinaSenha); 
//Console.WriteLine(minhaSenha);
//Console.WriteLine(senhaDaAmiga);
//Console.WriteLine(senhaDaAmiga2);

//código abaixo possui uma exception causada propositalmente!

//int a = 300;
//byte pequeno = checked((byte)a); 
//Console.WriteLine(pequeno);


int nota1 = 7;
int nota2 = 2;

double resultado  = nota1 / nota2;
Console.WriteLine(resultado);
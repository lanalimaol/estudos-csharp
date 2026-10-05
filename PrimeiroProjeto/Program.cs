using System;
using System.Globalization;
using PrimeiroProjeto;

#region revisao logica csharp

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


//int nota1 = 7;
//int nota2 = 2;

//double resultado  = nota1 / nota2;
//Console.WriteLine(resultado);

#endregion

#region introducao a POO e Classes
// Resolvendo um problema SEM orientação a objetos

//double xA, xB, xC, yA, yB, yC;

//Console.WriteLine("Entre com as medidas do triângulo X: ");
//xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Console.WriteLine("Entre com as medidas do triângulo Y: ");
//yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


//double p = (xA + xB + xC) / 2.0;
//double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

//p = (yA + yB + yC) / 2.0;
//double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

//Console.WriteLine($"Área de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
//Console.WriteLine($"Área de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

//if (areaX > areaY)
//{
//    Console.WriteLine("Maior área: X");
//}
//else
//{
//    Console.WriteLine("Maior área: Y");
//}

#endregion

#region isntancias de uma classe
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Lana"; 
pessoa1.Idade = 24;

pessoa1.Apresentar();

Triangulo x, y; 
x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Entre com os lados do triângulo X: ");
x.ladoA = double.Parse(Console.ReadLine());
x.ladoB = double.Parse(Console.ReadLine());
x.ladoC = double.Parse(Console.ReadLine());


Console.WriteLine("Entre com os lados do triângulo Y: ");
y.ladoA = double.Parse(Console.ReadLine());
y.ladoB = double.Parse(Console.ReadLine());
y.ladoC = double.Parse(Console.ReadLine());

Console.WriteLine("Área do Triângulo X: " + x.AreaTriangulo());
Console.WriteLine("Área do Triâgulo Y: " + y.AreaTriangulo());

#endregion

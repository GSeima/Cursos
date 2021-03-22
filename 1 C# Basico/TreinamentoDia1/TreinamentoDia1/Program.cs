using System;
using System.Globalization;

namespace TreinamentoDia1
{
    class Exercises
    {
        static void Main(string[] args)
        {

            //string product1 = "Computador";
            //string product2 = "Mesa de escrtório";

            //byte idade = 30;
            //int codigo = 5290;
            //char genero = 'M';

            //double preco1 = 2100.0;
            //double preco2 = 650.50;
            //double medida = 53.234567;

            //Console.WriteLine("Produtos:");
            //Console.WriteLine($"{product1}, cujo preço é ${preco1}");
            //Console.WriteLine($"{product2}, cujo preço é ${preco2}");
            //Console.WriteLine("");
            //Console.WriteLine($"Registro: {idade}, código {codigo} e gênero: {genero}");
            //Console.WriteLine("");
            //Console.WriteLine($"Medida com oito casas decimais: {medida}");
            //Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            //Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("");

            //----------------------Split----------------------

            //string[] vet = Console.ReadLine().Split(' ');

            //Console.WriteLine(vet[0]);
            //Console.WriteLine(vet[1]);
            //Console.WriteLine(vet[2]);

            //Console.WriteLine("Entre com seu nome completo: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Quantos quartos tem na sua casa? ");
            //int rooms = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com o preço de um produto: ");
            //double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            //string[] nameAgeWidth = Console.ReadLine().Split(' ');
            //Console.WriteLine("");

            //string vetName = nameAgeWidth[0];
            //string vetAge = nameAgeWidth[1];
            //string vetWidth = nameAgeWidth[2];

            //Console.WriteLine(name);
            //Console.WriteLine(rooms);
            //Console.WriteLine(price);
            //Console.WriteLine(vetName);
            //Console.WriteLine(vetAge);
            //Console.WriteLine(vetWidth);

            //----------------------Sequencial Structure----------------------

            //EX 1

            //Console.WriteLine("Digite o primeiro número");
            //int numero1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo número");
            //int numero2 = int.Parse(Console.ReadLine());

            //int soma;

            //soma = numero1 + numero2;

            //Console.WriteLine($"A soma dos números é {soma}");

            //EX2

            //double pi = Math.Round(Math.PI, 5);

            //Console.WriteLine("Digite o valor do raio: ");
            //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double area = pi * (raio * raio);

            //Console.WriteLine($"O valor da área é: {area:F4}");

            //Console.WriteLine($"O valor de PI é: {pi}");

            //EX3

            //Console.WriteLine("Digite o valor de a: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor de b: ");
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor de c: ");
            //int c = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor de d: ");
            //int d = int.Parse(Console.ReadLine());

            //int diferenca = ((a * b) - (c * d));

            //Console.WriteLine($"A diferença é de: {diferenca}");

            //EX4

            //Console.WriteLine("Digite o número do funcionário: ");
            //int numero = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor de horas trabalhadas: ");
            //int horas = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor que recebe por hora: ");
            //double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double salario = (horas * valor);

            //Console.WriteLine($"Número do funcionário: {numero}");
            //Console.WriteLine($"Salário: ${salario}");

            //EX5

            //Console.WriteLine("Digite o codigo da peça, número de peças e o valor unitário de cada peça: ");
            //string[] peca1 = Console.ReadLine().Split(' ');

            //Console.WriteLine("Digite o codigo da peça, número de peças e o valor unitário de cada peça: ");
            //string[] peca2 = Console.ReadLine().Split(' ');

            //int vetNumeroPeca1 = int.Parse(peca1[1]);
            //double vetValorPeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            //int vetNumeroPeca2 = int.Parse(peca2[1]);
            //double vetValorPeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            //double valor = Math.Round(((vetNumeroPeca1 * vetValorPeca1) + (vetNumeroPeca2 * vetValorPeca2)), 2);

            //Console.WriteLine($"O valor a ser pago é de: R${valor}");

            //EX6

            //Console.WriteLine("Digite o valor de A, B e C: ");
            //string[] valores = Console.ReadLine().Split(' ');

            //double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            //double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //double pi = Math.Round(Math.PI, 5);

            //double triangulo = Math.Round((a * c) / 2, 3);

            //double circulo = Math.Round(pi * (c * c), 3);

            //double trapezio = Math.Round(((a + b) * c) / 2, 3);

            //double quadrado = Math.Round(b * b, 3);

            //double retangulo = Math.Round(a * b, 3);

            //Console.WriteLine($"Área Triângulo: {triangulo}");
            //Console.WriteLine($"Área Círculo: {circulo}");
            //Console.WriteLine($"Área Trapézio: {trapezio}");
            //Console.WriteLine($"Área Quadrado: {quadrado}");
            //Console.WriteLine($"Área Retângulo: {retangulo}");

            //----------------------Conditional Structure----------------------

            //EX1

            //Console.WriteLine("Digite um número: ");
            //int number = int.Parse(Console.ReadLine());

            //if(number > 0)
            //{
            //    Console.WriteLine("Positivo");
            //}
            //else
            //{
            //    Console.WriteLine("Negativo");
            //}

            //EX2

            //Console.WriteLine("Digite um número: ");
            //int number = int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.WriteLine("Par");
            //}
            //else
            //{
            //    Console.WriteLine("Ímpar");
            //}

            //EX3

            //Console.WriteLine("Digite os valores de A e B (na mesma linha): ");
            //string[] valores = Console.ReadLine().Split(' ');

            //int a = int.Parse(valores[0]);
            //int b = int.Parse(valores[1]);

            //if(a % b == 0 || b % a == 0)
            //{
            //    Console.WriteLine("São multiplos");
            //}
            //else
            //{
            //    Console.WriteLine("Não são multiplos");
            //}

            //EX4

            //Console.WriteLine("Digite a hora inicial e a hora final do jogo (na mesma linha): ");
            //string[] horas = Console.ReadLine().Split();

            //int horaInicial = int.Parse(horas[0]);
            //int horaFinal = int.Parse(horas[1]);

            //if(horaInicial > horaFinal)
            //{
            //    int total = ((24 - horaInicial) + horaFinal);
            //    Console.WriteLine($"O jogo durou {total} hora(s)");
            //}
            //if(horaInicial == horaFinal)
            //{
            //    int total = 24;
            //    Console.WriteLine($"O jogo durou {total} hora(s)");
            //}
            //if(horaInicial < horaFinal)
            //{
            //    int total = (horaFinal - horaInicial);
            //    Console.WriteLine($"O jogo durou {total} hora(s)");
            //}

            //EX5

            //Console.WriteLine("Código |  Especificação  | Preço");
            //Console.WriteLine("   1   | Cachorro Quente | R$4.00");
            //Console.WriteLine("   2   |     X-Salada    | R$4.50");
            //Console.WriteLine("   3   |     X-Bacon     | R$5.00");
            //Console.WriteLine("   4   | Torrada Simples | R$2.00");
            //Console.WriteLine("   5   |   Refrigerante  | R$1.50");

            //Console.WriteLine("");

            //Console.WriteLine("Digite o código e a quantidade do produto (na mesma linha): ");
            //string[] codigoQuantidade = Console.ReadLine().Split();

            //int codigo = int.Parse(codigoQuantidade[0]);
            //int quantidade = int.Parse(codigoQuantidade[1]);

            //if(codigo == 1)
            //{
            //    double total = (4.00 * quantidade);
            //    Console.WriteLine($"O valor total é de: R${total}");
            //}
            //if(codigo == 2)
            //{
            //    double total = (4.50 * quantidade);
            //    Console.WriteLine($"O valor total é de: R${total}");
            //}
            //if (codigo == 3)
            //{
            //    double total = (5.00 * quantidade);
            //    Console.WriteLine($"O valor total é de: R${total}");
            //}
            //if (codigo == 4)
            //{
            //    double total = (2.00 * quantidade);
            //    Console.WriteLine($"O valor total é de: R${total}");
            //}
            //if (codigo == 5)
            //{
            //    double total = (1.50 * quantidade);
            //    Console.WriteLine($"O valor total é de: R${total}");
            //}

            //EX6

            //Console.WriteLine("Digite um valor: ");
            //double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //if( 0 <= numero && numero <= 25)
            //{
            //    Console.WriteLine("O número está entre o intervalo de 0 à 25");
            //}
            //if (25 < numero && numero <= 50)
            //{
            //    Console.WriteLine("O número está entre o intervalo de 25 à 50");
            //}
            //if (50 < numero && numero <= 75)
            //{
            //    Console.WriteLine("O número está entre o intervalo de 50 à 75");
            //}
            //if (75 < numero && numero <= 100)
            //{
            //    Console.WriteLine("O número está entre o intervalo de 75 à 100");
            //}
            //if (0 > numero || numero > 100)
            //{
            //    Console.WriteLine("O número está fora dos limites");
            //}

            //EX7

            //Console.WriteLine("     Y     ");
            //Console.WriteLine(" Q2  |  Q1 ");
            //Console.WriteLine(" --------- X ");
            //Console.WriteLine(" Q3  |  Q4 ");
            //Console.WriteLine("");

            //Console.WriteLine("Digite as coordenadas de x e y (na mesma linha): ");
            //string[] coordenadas = Console.ReadLine().Split(' ');

            //double x = double.Parse(coordenadas[0]);
            //double y = double.Parse(coordenadas[1]);

            //if( x > 0 && y > 0)
            //{
            //    Console.WriteLine("O ponto está no quadrante Q1");
            //}
            //if (x < 0 && y > 0)
            //{
            //    Console.WriteLine("O ponto está no quadrante Q2");
            //}
            //if (x < 0 && y < 0)
            //{
            //    Console.WriteLine("O ponto está no quadrante Q3");
            //}
            //if (x > 0 && y < 0)
            //{
            //    Console.WriteLine("O ponto está no quadrante Q4");
            //}
            //if (x == 0 && y != 0)
            //{
            //    Console.WriteLine("O ponto está no eixo X");
            //}
            //if (x != 0 && y == 0)
            //{
            //    Console.WriteLine("O ponto está no eixo Y");
            //}
            //if (x == 0 && y == 0)
            //{
            //    Console.WriteLine("O ponto está na origem");
            //}

            //EX8

            //Console.Write("Digite seu salário: R$ ");
            //double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double valor1, valor2, valor3, valor4, total;


            //if(salario <= 2000.00 && salario > 0)
            //{
            //    Console.WriteLine("Isento");
            //}
            //else if(salario >= 2000.01)
            //{
            //    if(salario <= 3000)
            //    {
            //        valor1 = ((salario - 2000.01) * 0.08);
            //        Console.WriteLine($"Você irá pagar R${valor1:F2}");
            //    }
            //    else if(salario >= 3000.1 && salario <= 4500.00)
            //    {
            //        valor1 = 1000 * 0.08;
            //        valor2 = (salario - 3000) * 0.18;
            //        total = valor1 + valor2;
            //        Console.WriteLine($"Você irá pagar R${total:F2}");
            //    }
            //    else
            //    {
            //        valor1 = 1000 * 0.08;
            //        valor2 = 1500 * 0.18;
            //        valor3 = (salario - 4500) * 0.28;
            //        total = valor1 + valor2 + valor3;

            //        Console.WriteLine($"Você irá pagar R${total:F2}");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Valor inválido");
            //}

            //----------------------While Structure----------------------

            //EX1

            //Console.WriteLine("Digite a senha: ");

            //int senha = int.Parse(Console.ReadLine());
            //Console.WriteLine("");

            //while (senha != 2002)
            //{
            //    Console.WriteLine("Senha Inválida");
            //    Console.WriteLine("");
            //    Console.WriteLine("Digite a senha: ");
            //    senha = int.Parse(Console.ReadLine());
            //    Console.WriteLine("");
            //}

            //Console.WriteLine("Acesso Permitido");

            //EX2

            //Console.WriteLine("     Y     ");
            //Console.WriteLine(" Q2  |  Q1 ");
            //Console.WriteLine(" --------- X ");
            //Console.WriteLine(" Q3  |  Q4 ");
            //Console.WriteLine("");


            //Console.Write("Digite uma coordenada X, Y (na mesma linha): ");
            //string[] coordenadas = Console.ReadLine().Split(' ');

            //double x = double.Parse(coordenadas[0]);
            //double y = double.Parse(coordenadas[1]);

            //while (coordenadas != null)
            //{
            //    if (x > 0  && y > 0)
            //    {
            //        Console.WriteLine("Primeiro Quadrante\n");

            //        Console.Write("Digite uma coordenada X, Y (na mesma linha): ");
            //        coordenadas = Console.ReadLine().Split(' ');
            //        Console.WriteLine();

            //        x = double.Parse(coordenadas[0]);
            //        y = double.Parse(coordenadas[1]);
            //    }
            //    else if (x < 0 && y > 0)
            //    {
            //        Console.WriteLine("Segundo Quadrante\n");

            //        Console.Write("Digite uma coordenada X, Y (na mesma linha): ");
            //        coordenadas = Console.ReadLine().Split(' ');
            //        Console.WriteLine();

            //        x = double.Parse(coordenadas[0]);
            //        y = double.Parse(coordenadas[1]);
            //    }
            //    else if (x < 0 && y < 0)
            //    {
            //        Console.WriteLine("Terceiro Quadrante\n");

            //        Console.Write("Digite uma coordenada X, Y (na mesma linha): ");
            //        coordenadas = Console.ReadLine().Split(' ');
            //        Console.WriteLine();

            //        x = double.Parse(coordenadas[0]);
            //        y = double.Parse(coordenadas[1]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Quarto Quadrante\n");

            //        Console.Write("Digite uma coordenada X, Y (na mesma linha): ");
            //        coordenadas = Console.ReadLine().Split(' ');
            //        Console.WriteLine();

            //        x = double.Parse(coordenadas[0]);
            //        y = double.Parse(coordenadas[1]);
            //    }
            //}          

            //EX3

            //Console.WriteLine("1 - Álcool");
            //Console.WriteLine("2 - Gasolina");
            //Console.WriteLine("3 - Diesel");
            //Console.WriteLine("4 - Fim");
            //Console.WriteLine("");
            //Console.WriteLine("Digite o combustível desejado:");

            //int opcao = int.Parse(Console.ReadLine());
            //Console.WriteLine("");

            //int aCount = 0;
            //int gCount = 0;
            //int dCount = 0;

            //while(opcao != 4)
            //{
            //    if(opcao == 1)
            //    {
            //        aCount++;

            //        Console.WriteLine("1 - Álcool");
            //        Console.WriteLine("2 - Gasolina");
            //        Console.WriteLine("3 - Diesel");
            //        Console.WriteLine("4 - Fim");
            //        Console.WriteLine("");
            //        Console.WriteLine("Digite o combustível desejado:");

            //        opcao = int.Parse(Console.ReadLine());
            //        Console.WriteLine("");
            //    }
            //    if (opcao == 2)
            //    {
            //        gCount++;

            //        Console.WriteLine("1 - Álcool");
            //        Console.WriteLine("2 - Gasolina");
            //        Console.WriteLine("3 - Diesel");
            //        Console.WriteLine("4 - Fim");
            //        Console.WriteLine("");
            //        Console.WriteLine("Digite o combustível desejado:");

            //        opcao = int.Parse(Console.ReadLine());
            //        Console.WriteLine("");
            //    }
            //    if (opcao == 3)
            //    {
            //        dCount++;

            //        Console.WriteLine("1 - Álcool");
            //        Console.WriteLine("2 - Gasolina");
            //        Console.WriteLine("3 - Diesel");
            //        Console.WriteLine("4 - Fim");
            //        Console.WriteLine("");
            //        Console.WriteLine("Digite o combustível desejado:");

            //        opcao = int.Parse(Console.ReadLine());
            //        Console.WriteLine("");
            //    }
            //    else
            //    {
            //        Console.WriteLine("FIM");
            //        Console.WriteLine("");
            //    }
            //}
            //Console.WriteLine("MUITO OBRIGADO");
            //Console.WriteLine($"Álcool: {aCount}");
            //Console.WriteLine($"Gasolina: {gCount}");
            //Console.WriteLine($"Diesel: {dCount}");

            //----------------------For Structure----------------------

            //EX1

            //Console.WriteLine("Digite um número inteiro");

            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Números Ímpares entre 1 e {n}");

            //for (int i = 1; i <= n; i++)
            //{
            //    if(i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //EX2

            //Console.WriteLine("Digite a quantidade de valores inteiros que serão lidos: ");

            //int quantidade = int.Parse(Console.ReadLine());

            //int inCount = 0;
            //int outCount = 0;

            //for(int i = 1; i <= quantidade; i++)
            //{
            //    Console.WriteLine($"Digite os valores inteiros: ");

            //    int valor = int.Parse(Console.ReadLine());

            //    if (valor >= 10 && valor <= 20)
            //    {
            //        inCount++;
            //    }
            //    else
            //    {
            //        outCount++;
            //    }
            //}

            //Console.WriteLine("Entre 10 e 20");
            //Console.WriteLine($"{inCount} in");
            //Console.WriteLine($"{outCount} out");

            //EX3

            //Console.WriteLine("Digite o número de casos de teste: ");
            //int n = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("Digite as notas: ");
            //    string[] valores = Console.ReadLine().Split(' ');

            //    double nota1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //    double nota2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            //    double nota3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //    double mediaPond = Math.Round(((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 10, 1);

            //    Console.WriteLine($"A média é: {mediaPond}");
            //}

            //EX4

            //Console.WriteLine("Digite a quantidade de pares para dividir: ");
            //int n = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("Digite os dois números: ");
            //    string[] valores = Console.ReadLine().Split(' ');

            //    double num1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //    double num2 = double.Parse(valores[1], CultureInfo.InvariantCulture);

            //    if (num2 == 0)
            //    {
            //        Console.WriteLine("Divisão Impossível");
            //    }
            //    else
            //    {
            //        double div = Math.Round(num1 / num2, 1);

            //        Console.WriteLine($"A divisão é: {div}");
            //    }
            //}

            //EX5

            //Console.Write("Digite um valor para saber seu fatorial: ");
            //int n = int.Parse(Console.ReadLine());

            //int inicio = n;

            //int fat = 1;

            //for (int i = 1; i < n; n = n-1)
            //{
            //    fat = fat * n;
            //}

            //Console.WriteLine($"O fatorial de {inicio} é {fat}");

            //EX6 

            Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Números divisíveis de {n}: ");

            for (int i = 1; i <= n; i++)
            {
                if (n % n == 0)
                {
                    Console.WriteLine(n);
                }
            }

            //EX7 

            //Depois

            //----------------------Orientada a Objetos----------------------

            //EX1

            //Pessoa p1 = new Pessoa();
            //Pessoa p2 = new Pessoa();

            //Console.WriteLine("Dados da primeira pessoa: ");

            //Console.Write("Nome: ");
            //p1.Nome = Console.ReadLine();

            //Console.Write("Idade: ");
            //p1.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados da segunda pessoa: ");

            //Console.Write("Nome: ");
            //p2.Nome = Console.ReadLine();

            //Console.Write("Idade: ");
            //p2.Idade = int.Parse(Console.ReadLine());

            //if (p1.Idade > p2.Idade)
            //{
            //    Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            //}
            //else
            //{
            //    Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            //}

            //EX2

            //Funcionario f1 = new Funcionario();
            //Funcionario f2 = new Funcionario();

            //Console.WriteLine("Dados do primeiro funcionário: ");

            //Console.Write("Nome: ");
            //f1.Nome = Console.ReadLine();

            //Console.Write("Salário: R$");
            //f1.Salario = double.Parse(Console.ReadLine());

            //Console.WriteLine("Dados do primeiro funcionário: ");

            //Console.Write("Nome: ");
            //f2.Nome = Console.ReadLine();

            //Console.Write("Salário: R$");
            //f2.Salario = double.Parse(Console.ReadLine());

            //double media = ((f1.Salario + f2.Salario) / 2);

            //Console.WriteLine($"O salário médio é de R${media}");


        }

    }
}

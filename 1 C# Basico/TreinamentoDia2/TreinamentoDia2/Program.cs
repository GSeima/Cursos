using System;
using System.Globalization;
using System.Collections.Generic;

namespace TreinamentoDia2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Produto p = new Produto();

            //Console.WriteLine("Entre os dados do produto: ");
            //Console.Write("Nome: ");
            //p.Nome = Console.ReadLine();

            //Console.Write("Preço: ");
            //p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Quantidade: ");
            //p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Dados do Produto: " + p);

            //Console.WriteLine("");

            //Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);

            //Console.WriteLine("");

            //Console.WriteLine("Dados atualizados do Produto: " + p);

            //Console.WriteLine("");

            //Console.Write("Digite o número de produtos a ser removido no estoque: ");
            //qte = int.Parse(Console.ReadLine());
            //if(qte < p.Quantidade)
            //{
            //    p.RemoverProdutos(qte);
            //    Console.WriteLine("");
            //    Console.WriteLine("Dados atualizados do Produto: " + p);
            //}
            //else
            //{
            //    Console.WriteLine("Não é possível remover mais produtos que o estoque");
            //}

            //EX1

            //Retangulo r = new Retangulo();

            //Console.WriteLine("Entre a largura e altura do retângulo: ");
            //r.Largura = double.Parse(Console.ReadLine());
            //r.Altura = double.Parse(Console.ReadLine());

            //Console.WriteLine("Área = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Perímetro = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Diagonal = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            //EX2

            //Funcionario f = new Funcionario();

            //Console.Write("Nome: ");
            //f.Nome = Console.ReadLine();

            //Console.Write("Salário bruto: ");
            //f.SalarioBruto = double.Parse(Console.ReadLine());

            //Console.Write("Imposto: ");
            //f.Imposto = double.Parse(Console.ReadLine());

            //Console.WriteLine(f);

            //Console.Write("Digite a porcentagem para aumentar o salário: ");
            //double porcentagem = double.Parse(Console.ReadLine());
            //f.AumentarSalario(porcentagem);

            //Console.WriteLine("Dados atualizados: " + f);

            //EX3

            //Aluno a = new Aluno();

            //Console.WriteLine("Nome do aluno: ");
            //a.Nome = Console.ReadLine();

            //Console.WriteLine("Digite as três notas do aluno: ");

            //a.Nota1 = double.Parse(Console.ReadLine());
            //if (a.Nota1 > 30)
            //{
            //    Console.WriteLine("Nota Inválida");
            //}
            //else
            //{
            //    a.Nota2 = double.Parse(Console.ReadLine());
            //    if (a.Nota2 > 35)
            //    {
            //        Console.WriteLine("Nota Inválida");
            //    }
            //    else
            //    {
            //        a.Nota3 = double.Parse(Console.ReadLine());
            //        if (a.Nota3 > 35)
            //        {
            //            Console.WriteLine("Nota Inválida");
            //        }
            //        else
            //        {
            //            if(a.NotaFinal() < 60)
            //            {
            //                Console.WriteLine("Reprovado");
            //                Console.WriteLine(a);
            //                Console.WriteLine($"Faltaram: {a.PrecisaNota()} pontos");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Aprovado");
            //                Console.WriteLine(a);
            //            }
            //        }
            //    }

            //}

            //----------------------Membros Estáticos----------------------

            //EX1

            //Console.Write("Qual é a cotação do dólar ? ");
            //double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Quantos dólares você vai comprar ? ");
            //double quantidade = int.Parse(Console.ReadLine());

            //double resultado = ConversorDeMoeda.Conversor(cotacao, quantidade); 

            //Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));

            //----------------------Construtores----------------------

            //EX1

            //ContaBancaria conta;

            //Console.Write("Digite o número da conta: ");
            //int numero = int.Parse(Console.ReadLine());

            //Console.Write("Digite o nome do titular: ");
            //string titular = Console.ReadLine();

            //Console.Write("Haverá Depósito inicial (s/n) ? ");
            //char resp = char.Parse(Console.ReadLine());

            //if (resp == 's' || resp == 'S')
            //{
            //    Console.Write("Digite o valor do depósito inicial: ");
            //    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    conta = new ContaBancaria(numero, titular, depositoInicial);
            //}
            //else
            //{
            //    conta = new ContaBancaria(numero, titular);
            //}

            //Console.WriteLine();

            //Console.WriteLine("Dados da conta: ");
            //Console.WriteLine(conta);

            //Console.WriteLine();

            //Console.Write("Digite um valor para depósito: ");
            //double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //conta.Deposito(quantia);
            //Console.WriteLine("Dados da conta atualizados: ");
            //Console.WriteLine(conta);

            //Console.WriteLine();

            //Console.Write("Digite um valor para saque: ");
            //quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //conta.Saque(quantia);
            //Console.WriteLine("Dados da conta atualizados: ");
            //Console.WriteLine(conta);

            //----------------------Vetores----------------------

            //EX1

            //Aluguel[] vet = new Aluguel[10];

            //Console.Write("Quantos quartos vão ser alugados ? ");
            //int qtd = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //for (int i = 1; i <= qtd; i++)
            //{
            //    Console.WriteLine($"Aluguel #{i}: ");

            //    Console.Write("Nome: ");
            //    string nome = Console.ReadLine();

            //    Console.Write("Email: ");
            //    string email = Console.ReadLine();

            //    Console.Write("Quarto: ");
            //    int quarto = int.Parse(Console.ReadLine());

            //    vet[quarto] = new Aluguel(nome, email);

            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //Console.WriteLine("Quartos ocupados: ");
            //for(int i = 0; i < 10; i++)
            //{
            //    if (vet[i] != null)
            //    {
            //        Console.WriteLine(i + ": " + vet[i]);
            //    }
            //}

            //----------------------Lista----------------------

            //List<string> list = new List<string>();

            //list.Add("Amanda");
            //list.Add("Ana");
            //list.Add("Maria");
            //list.Insert(2, "Bob");

            //foreach(string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            //Console.WriteLine("--------------------------------------------");

            //Console.WriteLine("Contador: " + list.Count);

            //Console.WriteLine("--------------------------------------------");

            //string s1 = list.Find(x => x[0] == 'A');
            //Console.WriteLine("Primeira pessoa com a letra 'A': " + s1);

            //string s2 = list.FindLast(x => x[0] == 'A');
            //Console.WriteLine("Ultima pessoa com a letra 'A': " + s2);

            //int pos1 = list.FindIndex(x => x[0] == 'A');
            //Console.WriteLine("Primeira posição com a letra 'A': " + pos1);

            //int pos2 = list.FindLastIndex(x => x[0] == 'A');
            //Console.WriteLine("Ultima posição com a letra 'A': " + pos2);

            //Console.WriteLine("--------------------------------------------");

            //List<string> list2 = list.FindAll(x => x.Length == 3);

            //foreach(string obj in list2)
            //{
            //    Console.WriteLine(obj);
            //}

            //Console.WriteLine("--------------------------------------------");

            //list.Remove("Maria");

            //foreach(string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            //Console.WriteLine("--------------------------------------------");

            //list.RemoveAll(x => x[0] == 'A');
            //foreach (string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            //EX1

            //List<Employee> employees = new List<Employee>();

            //Console.Write("How many employees will be registered ? ");
            //int qnt = int.Parse(Console.ReadLine());

            //List<Employee> list = new List<Employee>();

            //for(int i = 1; i <= qnt; i++)
            //{
            //    Console.WriteLine($"Employee #{i}:");

            //    Console.Write("Id: ");
            //    int id = int.Parse(Console.ReadLine());

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Salary: ");
            //    int salary = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    list.Add(new Employee(id, name, salary));

            //    Console.WriteLine();
            //}

            //Console.Write("Enter the employee id that will have salary increase: ");
            //int searchId = int.Parse(Console.ReadLine());

            //Employee emp = list.Find(x => x.Id == searchId);
            //if (emp != null)
            //{
            //    Console.Write("Enter the percentage: ");
            //    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); ;
            //    emp.IncreaseSalary(percentage);
            //}
            //else
            //{
            //    Console.WriteLine("This id does not exist!");
            //}

            //Console.WriteLine();

            //Console.WriteLine("Updated list of employees: ");
            //foreach(Employee obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            //----------------------Matrizes----------------------

            //Console.Write("Digite o número de linhas e colunas: ");

            //int n = int.Parse(Console.ReadLine());

            //double[,] mat = new double[n, n];

            //for (int i = 0; i < n; i++)
            //{
            //    string[] values = Console.ReadLine().Split(' ');
            //    for(int j = 0; j < n; j++)
            //    {
            //        mat[i, j] = int.Parse(values[j]);
            //    }
            //}

            //Console.WriteLine("Main diagonal");
            //for(int i = 0; i < n; i++)
            //{
            //    Console.Write(mat[i, i] + " ");
            //}

            //Console.WriteLine();

            //int count = 0;

            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < n; j++)
            //    {
            //        if(mat[i, j] < 0)
            //        {
            //            count++;
            //        }
            //    }
            //}

            //Console.WriteLine("Negative numbers: " + count);

            //EX1

            Console.Write("Digite o número de linhas e de colunas: ");

            string[] n = Console.ReadLine().Split(' ');

            int linha = int.Parse(n[0]);
            int coluna = int.Parse(n[1]);

            int[,] mat = new int[linha, coluna];

            for (int i = 0; i < linha; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < coluna; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Digite o número desejado: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    if (mat[i, j] == num)
                    {
                        Console.WriteLine("Posição " + i + "," + j + ":");
                        if (j> 0)
                        {
                            Console.Write("Left: ");
                            Console.WriteLine(mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.Write("Up: ");
                            Console.WriteLine(mat[i - 1, j]);
                        }
                        if (j < coluna - 1)
                        {
                            Console.Write("Right: ");
                            Console.WriteLine(mat[i, j + 1]);
                        }
                        if (i < linha - 1)
                        {
                            Console.Write("Down: ");
                            Console.WriteLine(mat[i + 1, j]);
                        }
                    }
                }
            }

        }
    }
}

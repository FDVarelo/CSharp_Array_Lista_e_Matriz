using System;
using System.Globalization;
using System.Collections.Generic;

namespace Curso_CSharp_Seção_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Iniciando Nullabe
            double? x = null;
            double? y = 10.0;

            Console.WriteLine("(GetValueOrDefault()) → Apresentar o valor da variavel, caso não tenha, apresentar valor padrão do tipo.");
            Console.WriteLine("Apresentar o Valor de X: "+x.GetValueOrDefault());
            Console.WriteLine("Apresentar o Valor de Y: "+y.GetValueOrDefault()+"\n");

            Console.WriteLine("(HasValue) → Verificando se tem valor na variavel.");
            Console.WriteLine("X tem valor? "+x.HasValue);
            Console.WriteLine("Y tem valor? "+y.HasValue+"\n");

            if (x.HasValue)
                Console.WriteLine("(Value) → Valor de X é: "+x.Value);
            else
                Console.WriteLine("X não tem valor!");

            if (y.HasValue)
                Console.WriteLine("(Value) → Valor de Y é: "+y.Value);
            else
                Console.WriteLine("Y não tem valor!");

            double? k = x ?? 20; // k = x, porém caso x não tenha valor, então k = 20
            double? z = y ?? 15; // z = y, porém caso y não tenha valor, então z = 15

            Console.WriteLine("\nValor de K: "+k); // k = 20 pois x é null
            Console.WriteLine("Valor de Z: "+z); // z = 10 pois é o valor de y, onde y não é null
            */



            /*// Iniciando Vetores
            int n = int.Parse(Console.ReadLine());
            double media = 0;
            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                media += vet[i];
            }
            Console.WriteLine("Média de valores: " + (media/n).ToString("F2", CultureInfo.InvariantCulture));
           */


            /*//Product
            int n = int.Parse(Console.ReadLine());
            Product[] vect = new Product[n];
            double sum = 0;
            for(int i = 0;i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Product { Name = name, Price = price };

                // Não funciona desta maneira ↓
                //vect[i].Name = Console.ReadLine();
                //vect[i].Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                sum += vect[i].Price;
            }
            Console.WriteLine("Average Price: " + (sum/n).ToString("F2", CultureInfo.InvariantCulture));
            */

            /* Problema do Pensionato.
            A dona de um pensionato possui dez quartos para alugar para estudantes,
            sendo esses quartos identificados pelos números 0 a 9.
            Quando um estudante deseja alugar um quarto, deve-se registrar o nome
            e email deste estudante.
            Fazer um programa que inicie com todos os dez quartos vazios, e depois
            leia uma quantidade N representando o número de estudantes que vão
            alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
            N estudantes. Para cada registro de aluguel, informar o nome e email do
            estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
            que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
            um relatório de todas ocupações do pensionato, por ordem de quarto,
            conforme exemplo.
            */
            /*
            Pensionato[] pensionato = new Pensionato[10];
            Console.Write("Quantos quartos serão alugados? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < quartos; i++)
            {
                Console.WriteLine("Aluguel #"+(i+1)+":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numQuarto = int.Parse(Console.ReadLine());
                while(numQuarto < 1 || numQuarto > 10)
                {
                    Console.WriteLine("Quarto inserido não existe, tente novamente entre o número 1 até o 10!");
                    Console.Write("Quarto: ");
                    numQuarto = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();

                pensionato[numQuarto] = new Pensionato { Name = nome, Email = email, Room = numQuarto };
            }
            Console.WriteLine("Quartos Ocupados: ");
            for(int i=0; i<pensionato.Length; i++)
            {
                //if (pensionato[i].Room>=1 && pensionato[i].Room<=10) // funciona, porém aparece uma mensagem de erro no final
                if (pensionato[i]!=null)
                    Console.WriteLine(pensionato[i]);
            }
            */

            /*//Utilizando Params

            int soma1 = Calculator.Sum(2, 3);
            int soma2 = Calculator.Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);*/

            /*//Utilizando ref

            int x = 10; // Vale ressaltar que como estamos utilizando ref, a variavel tem que inicial com algum valor
            Console.WriteLine("Valor inicial de X: "+x);
            Calculator.Triple(ref x); //utilizando ref
            Console.WriteLine("Valor de X utilizando o ref: "+x);*/

            /*//Utilizando out

            int k = 10;
            int l;
            Calculator.Double(k, out l);
            Console.WriteLine("Resultado do K: "+k+", Resultado do L, utilizando out: "+l);*/

            /*// Listas

            List<string> list = new List<string>(); // Criando uma lista vazia
            List<string> list2 = new List<string> { "Maria", "Alex", "Roberto" };

            list.Add("Maria"); // adiciona na ultima posição a string Maria
            list.Add("Alex");
            list.Add("Jorge");
            list.Add("Roberto");
            list.Add("Gabriel");
            list.Add("Gisele");
            list.Add("Marcos");
            list.Insert(3, "Joyce"); // inserir na posição 3 Joyce, e a outra string que estava na posição 3
                                     // vai passar para baixo, e as outras sucessivamente.

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("List Count: " + list.Count); // Conta quantos index(elementos/objetos) tem na lista

            string encontrarInicio = list.Find(x => x[0] == 'J'); // encontrar a primeira vez que a condição, pode ser passado funções, o retorno é true ou false
            Console.WriteLine("\nFirst person with name starting with 'J': " + encontrarInicio);
            string encontrarFim = list.FindLast(x => x[0] == 'J'); // encontrar a ultima vez que a condição for encontrada
            Console.WriteLine("Last person with name starting with 'J': " + encontrarFim);

            int primeiraPosicao = list.FindIndex(x => x[0] == 'J'); // encontra o index quando a condição for encontrada
            int ultimaPosicao = list.FindLastIndex(x => x[0] == 'J'); // encontra o index quando a ultima condição for encontrada
            Console.WriteLine("Primeira ocorrência de 'J' é no index: "+primeiraPosicao+", e a ultima é no index: "+ultimaPosicao);


            List<string> listFilter = list.FindAll(x => x.Length == 5);
            Console.WriteLine("\nThe following strings have 5 in length:");
            foreach(string s in listFilter)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Removing string Alex from the list:");
            list.Remove("Alex");
            foreach(string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\nRemoving all the strings that start with M:");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nRemoving the string in index 3:");
            list.RemoveAt(3);
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nStarting from index 2, remove the first 2 strings:");
            list.RemoveRange(2, 2);
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            */


            //Exercício de listas
            /*
            Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
            N funcionários. Não deve haver repetição de id.
            Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
            Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
            mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
            conforme exemplos.
            Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
            ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
            aumento por porcentagem dada. 
             */
            /*
            List<Employee> list = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #"+(i+1)+": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary));
                Console.WriteLine();

            }

            Console.Write("Enter the Employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee e = list.Find(x => x.Id == searchId);
            if (e != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                e.increaseSalary(percentage);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("This id does not exist!\n");
            }

            Console.WriteLine("Updated list of employees:");
            foreach(Employee i in list)
            {
                Console.WriteLine(i);
            }
            */

            //Matrizes

            //double[,] mat = new double[2, 3];
            //Console.WriteLine(mat.Length); // quantidade de entidades
            //Console.WriteLine(mat.Rank); // quantidade de linhas
            //Console.WriteLine(mat.GetLength(0)); // quantidade da primeira dimensão (linha)
            //Console.WriteLine(mat.GetLength(1)); // quantiade da segunda dimensão (coluna)

            /*
            Fazer um programa para ler um número inteiro N e uma matriz de
            ordem N contendo números inteiros. Em seguida, mostrar a diagonal
            principal e a quantidade de valores negativos da matriz.
            */
            /*
            int n = int.Parse(Console.ReadLine());
            int negative = 0;
            double[] diagonal;
            double[,] mat = new double[n, n];
            
            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i,j] = double.Parse(vet[j], CultureInfo.InvariantCulture);
                    if(mat[i,j] < 0)
                    {
                        negative++;
                    }
                }
            }
            Console.WriteLine("Main Diagonal:");
            for(int i= 0;i<n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine("\nNegative numbers: "+negative);
            */


            /*
            Fazer um programa para ler dois números inteiros M e N, e depois ler
            uma matriz de M linhas por N colunas contendo números inteiros,
            podendo haver repetições. Em seguida, ler um número inteiro X que
            pertence à matriz. Para cada ocorrência de X, mostrar os valores à
            esquerda, acima, à direita e abaixo de X, quando houver, conforme
            exemplo.
             */
            /*
            string[] matriz = Console.ReadLine().Split(' ');
            int M = int.Parse(matriz[0]);
            int N = int.Parse(matriz[1]);

            int[,] a = new int[M, N];

            for(int i = 0; i < M; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    a[i, j] = int.Parse(values[j]);
                }
            }

            int searchValue = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if(a[i, j] == searchValue)
                    {
                        if(i == 0)
                        {
                            if(j == 0)
                            {
                                Console.WriteLine("Position "+i+","+j+":");
                                Console.WriteLine("Right: " + (a[i,j+1]));
                                Console.WriteLine("Down: "+ (a[i+1,j]));
                            }else if(j == N - 1)
                            {
                                Console.WriteLine("Position " + i + "," + j + ":");
                                Console.WriteLine("Left: " + (a[i, j - 1 ]));
                                Console.WriteLine("Down: " + (a[i + 1, j]));
                            }
                            else
                            {
                                Console.WriteLine("Position " + i + "," + j + ":");
                                Console.WriteLine("Left: " + (a[i, j - 1]));
                                Console.WriteLine("Right: " + (a[i, j + 1]));
                                Console.WriteLine("Down: " + (a[i + 1, j]));
                            }
                        }else if(i == M - 1)
                        {
                            if (j == 0)
                            {
                                Console.WriteLine("Position " + i + "," + j + ":");
                                Console.WriteLine("Up: " + (a[i - 1, j]));
                                Console.WriteLine("Right: " + (a[i, j + 1]));
                            }
                            else if (j == N - 1)
                            {
                                Console.WriteLine("Position " + i + "," + j + ":");
                                Console.WriteLine("Up: " + (a[i - 1, j]));
                                Console.WriteLine("Left: " + (a[i, j - 1]));
                            }
                            else
                            {
                                Console.WriteLine("Position " + i + "," + j + ":");
                                Console.WriteLine("Up: " + (a[i - 1, j]));
                                Console.WriteLine("Left: " + (a[i, j - 1]));
                                Console.WriteLine("Right: " + (a[i, j + 1]));
                            }
                        }
                        else
                        {
                            if (j == 0)
                            {
                                Console.WriteLine("Position " + i + "," + j + ":");
                                Console.WriteLine("Up: " + (a[i - 1, j]));
                                Console.WriteLine("Right: " + (a[i, j + 1]));
                                Console.WriteLine("Down: " + (a[i + 1, j]));
                            }
                            else if (j == N - 1)
                            {
                                Console.WriteLine("Position " + i + "," + j + ":");
                                Console.WriteLine("Left: " + (a[i, j - 1]));
                                Console.WriteLine("Up: " + (a[i - 1, j]));
                                Console.WriteLine("Down: " + (a[i + 1, j]));
                            }
                            else
                            {
                                Console.WriteLine("Position " + i + "," + j + ":");
                                Console.WriteLine("Left: " + (a[i, j - 1]));
                                Console.WriteLine("Up: " + (a[i - 1, j]));
                                Console.WriteLine("Right: " + (a[i, j + 1]));
                                Console.WriteLine("Down: " + (a[i + 1, j]));
                            }
                        }
                    }
                }
            }
            */


            /* // Modelo do Prof. Dr. Nelio Alves ↓
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] == x) {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0) {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            } 
             */

        }
    }
}
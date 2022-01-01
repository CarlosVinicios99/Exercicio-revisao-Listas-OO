using System;
using System.Globalization;

namespace ExercicioRevisao
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            Console.Write("Qual o nome da empresa: ");
            string nome = Console.ReadLine();
            Empresa empresa = new Empresa(nome);

            while(opcao != 6)
            {
                Console.WriteLine("\n(1)Contratar Funcionario\n(2)Demitir Funcionario");
                Console.WriteLine("(3)Aumento de Salario\n(4)Media Salarial Da Empresa");
                Console.WriteLine("(5)Listar Funcionarios\n(6)Sair");

                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        Console.Write("Digite o id do funcionario: ");
                        int id = int.Parse(Console.ReadLine());
                        bool idExiste = empresa.FuncionarioExiste(id);

                        if(!idExiste)
                        {
                            Console.Write("Digite o nome do funcionario: ");
                            string nomeFuncionario = Console.ReadLine();

                            Console.Write("Digite o salario do funcionario: ");
                            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            
                            empresa.ContratarFuncionario(id, nomeFuncionario, salario);
                        }

                        else
                        {
                            Console.WriteLine("Id ja existe");
                        }

                        break;

                    case 2:           
                        Console.Write("Digite o id do funcionario: ");
                        id = int.Parse(Console.ReadLine());
                        idExiste = empresa.FuncionarioExiste(id);

                        if(idExiste)
                        {
                            empresa.DispensarFuncionario(id);
                        }

                        else
                        {
                            Console.WriteLine("Id nao existe");
                        }

                        break;

                    case 3:
                        Console.Write("Digite o id do funcionario: ");
                        id = int.Parse(Console.ReadLine());
                        idExiste = empresa.FuncionarioExiste(id);

                        if(idExiste)
                        {
                            Console.Write("Digite a porcentagem: ");
                            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            empresa.AumentarSalario(id, porcentagem);
                        }

                        else
                        {
                            Console.WriteLine("Id nao existe");
                        }
                        break;

                    case 4:
                        Console.WriteLine("R$" + empresa.MediaSalarial().ToString("F2", CultureInfo.InvariantCulture));
                        break;

                    case 5:
                        empresa.ListarFuncionarios();
                        break;

                    case 6:
                        Console.Write("Encerrando");
                        break;

                    default:
                        Console.WriteLine("Opcao Invalida, Tente novamente");
                        break;
                }

            }
        }
    }
}

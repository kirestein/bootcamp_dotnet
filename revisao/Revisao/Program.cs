using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a informação desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine();
            Aluno[] alunos = new Aluno[5];
            string opcaoUsuario = Console.ReadLine();

            while (opcaoUsuario.ToUpper() != "x");
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        } else {
                            throw new ArgumentException("Valor da nota deve ser decimal.");
                        }
                        
                        break;
                    case "2":
                        //todo: listar alunos
                        break;
                    case "3":
                        //todo: calcular média geral
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine("Informe a opção desejadda: ");
                Console.WriteLine("1 - Inserir novo aluno");
                Console.WriteLine("2 - Listar alunos");
                Console.WriteLine("3 - Calcular média geral");
                Console.WriteLine();

                opcaoUsuario = Console.ReadLine();
            }
            
        }
    }
}

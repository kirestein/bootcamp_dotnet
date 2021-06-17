using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
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

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        
                        break;
                    case "2":
                        foreach (var a in alunos)
                        {
                            Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                        }
                        break;
                    case "3":
                        //todo: calcular média geral
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
                
            }
            
        }
        private static string ObterOpcaoUsuario() 
        {
            Console.WriteLine();
        Console.WriteLine("Informe a opção desejadda: ");
                Console.WriteLine("1 - Inserir novo aluno");
                Console.WriteLine("2 - Listar alunos");
                Console.WriteLine("3 - Calcular média geral");
                Console.WriteLine();

                string opcaoUsuario = Console.ReadLine();
                return opcaoUsuario;
        }
    }
}

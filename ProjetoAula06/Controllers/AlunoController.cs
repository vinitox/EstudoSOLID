using ProjetoAula06.Entities;
using ProjetoAula06.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula06.Controllers
{
    public class AlunoController
    {
        //atributo
        private readonly IAlunoRepository _alunoRepository;

        public AlunoController(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public void CadastrarAluno()
        {
            try
            {
                Console.WriteLine("\nCadastro de Aluno:");

                var aluno = new Aluno();
                aluno.Id = Guid.NewGuid();

                Console.Write("Nome do aluno..........:");
                aluno.Nome = Console.ReadLine();

                Console.Write("Matricula do aluno......:");
                aluno.Matricula = Console.ReadLine();

                Console.Write("Data de nascimento.......:");
                aluno.DataNascimento = DateTime.Parse(Console.ReadLine());

                //gravando os dados do aluno
                _alunoRepository.Exportar(aluno);

                Console.WriteLine("\nAluno cadastrado com sucesso!");

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("\nErro de validação:");
                Console.WriteLine(e.Message);
            }
        }
    }
}

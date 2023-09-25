using System.Text.RegularExpressions;

namespace ProjetoAula06.Entities
{
    /// <summary>
    /// Modelo de entidade
    /// </summary>
    public class Aluno
    {
        #region Atributos

        private Guid _id;
        private string _nome;
        private string _matricula;
        private DateTime _dataNascimento;
        private List<Turma> _turmas;

        #endregion

        #region Propriedades

        public Guid Id
        {
            set => _id = value;
            get => _id;
        }

        public string Nome
        {
            set
            {
                var regex = new Regex("^[A-Za-zÀ-Üà-ü\\s]{8,100}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor, informe o nome do aluno.");

                _nome = value;
            }
            get => _nome;
        }

        public string Matricula
        {
            set
            {
                var regex = new Regex("^[A-Za-z0-9]{4,10}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor, informe uma matrícula válida.");

                _matricula = value;
            }
            get => _matricula;
        }

        public DateTime DataNascimento
        {
            set => _dataNascimento = value;
            get => _dataNascimento;
        }

        public List<Turma> Turmas
        {
            set => _turmas = value;
            get => _turmas;
        }

        #endregion
    }
}

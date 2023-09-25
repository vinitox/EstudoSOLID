using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoAula06.Entities
{
    /// <summary>
    /// Modelo de entidade
    /// </summary>
    public class Turma
    {
        #region Atributos

        private Guid _id;
        private string _nome;
        private DateTime _dataInicio;
        private List<Aluno> _alunos;

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
                var regex = new Regex("^[A-Za-zÀ-Üà-ü0-9\\s]{8,50}$");
                if (!regex.IsMatch(value))
                    throw new ArgumentException("Por favor, informe um nome de turma válido.");

                _nome = value;
            }
            get => _nome;
        }

        public DateTime DataInicio
        {
            set => _dataInicio = value;
            get => _dataInicio;
        }

        public List<Aluno> Alunos
        {
            set => _alunos = value;
            get => _alunos;
        }

        #endregion
    }
}


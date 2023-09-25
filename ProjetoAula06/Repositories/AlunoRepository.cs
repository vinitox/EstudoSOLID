using Newtonsoft.Json;
using ProjetoAula06.Entities;
using ProjetoAula06.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula06.Repositories
{
    /// <summary>
    /// Repositório de dados para aluno
    /// </summary>
    public class AlunoRepository : IAlunoRepository
    {
        private const string _path = "c:\\temp\\aluno.json";
        public void Exportar(Aluno obj)
        {
            using (var streamWriter = new StreamWriter(_path))
            {
                streamWriter.Write(JsonConvert.SerializeObject(obj, Formatting.Indented));
            }
        }

        public Aluno Importar()
        {
            using (var streamReader = new StreamReader(_path))
            {
                var json = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<Aluno>(json);
            } 
            
        }
    }
}




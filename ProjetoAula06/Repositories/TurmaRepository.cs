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
    /// Repositório de dados para turma
    /// </summary>
    public class TurmaRepository : ITurmaRepository
    {
        private const string _path = "c:\\temp\\turma.json";
        public void Exportar(Turma obj)
        {
            using (var streamWriter = new StreamWriter(_path))
            {
                streamWriter.WriteLine(JsonConvert.SerializeObject(obj, Formatting.Indented));

            }
        }

        public Turma Importar()
        {
            using (var streamReader = new StreamReader(_path))
            {
                var json = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<Turma>(json);
            }

        }
    }
}

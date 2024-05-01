using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudos_dotnet_one.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeAlunos(){
            int quantidade = Alunos.Count;
            return quantidade;
        }
    }
}
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
        public bool RemoverAluno(Pessoa aluno){
            return Alunos.Remove(aluno);//retorna true or false e remove o aluno
        }
        public void ListarAlunos(){
            Console.WriteLine($"Alunos do curso:");
            foreach(Pessoa aluno in Alunos){
                Console.WriteLine($"-{aluno.NomeCompleto}");
            }
        }
    }
}
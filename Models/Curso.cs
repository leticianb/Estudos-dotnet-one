using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            Console.WriteLine($"Alunos do {Nome}:");
            for(int count=0; count <Alunos.Count; count++){
                //string texto = "Número " + count +" - "+ Alunos[count].NomeCompleto;
                string texto = $"Número {count+1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);

            }

            // foreach(Pessoa aluno in Alunos){
            //     Console.WriteLine($"-{aluno.NomeCompleto}");
            // }
        }
    }
}

// decimal ValorMonetario = 42.23M;
// Console.WriteLine($"{ValorMonetario:C}");
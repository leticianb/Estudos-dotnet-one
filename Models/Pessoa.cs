using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudos_dotnet_one.Models
{
    public class Pessoa
    {
        private string _nome;        
        public string Nome { 
            get =>_nome.();
            set
            {
                if(value ==""){
                    throw new ArgumentException("não pode vazio");

                }
                _nome = value;
            }
        }
        public int Idade { get; set; }

        public void Apresentar(){
            Console.WriteLine($"nome: {Nome}, idade: {Idade}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudos_dotnet_one.Models
{
    public class Pessoa
    {
        private string _nome;//o unico que consegue modificar é a classe
        public string Nome 
        { 
            get => return _nome.ToUpper();
            
            set{
                if(value ==""){
                    throw new ArgumentException("O nome não pode ser vazio");

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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudos_dotnet_one.Models
{
    public class Pessoa
    {
        private string _nome;  
        private int _idade;      
        public string Nome { 
            get =>_nome.ToUpper();
            set
            {
                if(value ==""){
                    throw new ArgumentException("não pode vazio");

                }
                _nome = value;
            }
        }
        public int Idade { 
            get => _idade; 
            set{
                if(value<0){
                    throw new ArgumentException("Idade não pode ser negativa");

                }
                _idade = value;
            }
            }

        public void Apresentar(){
            Console.WriteLine($"nome: {Nome}, idade: {Idade}");
        }
    }
}
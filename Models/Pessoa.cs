using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudos_dotnet_one.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome){//construtor pessoa
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;  
        private int _idade;      
        public string Nome { 
            get =>char.ToUpper(_nome[0]) + _nome.Substring(1);
            set
            {
                if(value ==""){
                    throw new ArgumentException("não pode ser vazio");

                }
                _nome = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {char.ToUpper(Sobrenome[0]) + Sobrenome.Substring(1)}";
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
            Console.WriteLine($"nome: {NomeCompleto}, idade: {Idade}");
        }
    }
}
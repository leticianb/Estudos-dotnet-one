using estudos_dotnet_one.Models;
using Newtonsoft.Json;
Pessoa p1 = new Pessoa(nome:"leticia", sobrenome: "nakahara");
// p1.Nome = "leticia";
// p1.Sobrenome = "nakahara";
// p1.Idade = 19;
// p1.Apresentar();

Pessoa p2 = new Pessoa();
p2.Nome = "Luize";
p2.Sobrenome = "Yuki";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Curso de Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

try {
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
    foreach(string linha in linhas){
        Console.WriteLine(linha);
    }
} catch(Exception ex){
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");

}
finally{
    Console.WriteLine("Chegou até aqui");//após o catch
}

Queue<int> fila = new Queue<int>();
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);
fila.Enqueue(5);
fila.Enqueue(6);

foreach(int elemento in fila){
    Console.WriteLine(elemento);
}

Console.WriteLine($"Removendo o elemento {fila.Dequeue()}");
fila.Enqueue(7);
foreach(int elemento in fila){
    Console.WriteLine(elemento);
}

Stack<int> pilha = new Stack<int>();
pilha.Push(4);
pilha.Push(3);
pilha.Push(2);
pilha.Push(1);
foreach(int item in pilha){
    Console.WriteLine(item);
}
Console.WriteLine($"Removendo o elemento do topo {pilha.Pop()}");
pilha.Push(10);
foreach(int item in pilha){
    Console.WriteLine(item);
}

Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "São paulo");//chave e valor que representa a chave
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");
foreach(var item in estados){
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}
estados.Remove("BA");
Console.WriteLine($" \nNova distribuição\n");
foreach(var item in estados){
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}
string chave = "BA";
Console.WriteLine($"Verificando chave {chave}");
if(estados.ContainsKey(chave)){
    Console.WriteLine("Valor existente");
}
else{
    Console.WriteLine("Valor não existente");
}
Console.WriteLine(estados["MG"]);//acesso do valor

(int Id, string Nome, string Sobrenome, decimal Salario) tupla = (1, "leticia", "nakahara", 50000M);
Console.WriteLine($"Id: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Salário: {tupla.Salario}");

//tupla de outra forma
ValueTuple<int, string, string, decimal> outratupla = (1, "leticia", "nakahara", 50000M);
var outroexemplo = Tuple.Create(1, "leticia", "nakahara", 50000M); 

LeituraArquivo arquivo = new LeituraArquivo();
var (sucesso, linhasarquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");//var serve para n precisar passar o tipoo e _ na informação q n precisa
if(sucesso){
    // Console.WriteLine("Quantidade linhas arquivo " + quantidadelinhas);
    foreach(string linha in linhasarquivo){
        Console.WriteLine(linha);
    }
    
}
else{
    Console.WriteLine("Não foi possivel");
}

// Pessoa p3 = new Pessoa("Let", "Nakahara");
// (string nome, string sobrenome) = p3;
// Console.WriteLine($"{nome} {sobrenome}");

//deserializar o Json - cria a classe para represenar o conteudo
// string conteudo = File.ReadAllText("Arquivos/vendas.json");
// List<Venda> listvenda = JsonConvert.DeserializeObject<List<Venda>>(conteudo);
// foreach(Venda venda in listavenda){
//     Console.WriteLine(venda.Id, venda.Produto, venda.Preco, venda.DataVenda.ToString("dd/MM/aaaa HH:mm"));
// }
DateTime dataAtual = DateTime.Now;


List<Vendas> listavendas = new List<Vendas>();
int n=20;
bool ehPar = false;
ehPar = n%2==0;
Console.WriteLine($"O número {n} é " + (ehPar ? "par" : "ímpar"));//if ternário
Vendas v1 = new Vendas(1, "Material", 25.00M, dataAtual);
Vendas v2 = new Vendas(2, "Software", 110.00M, dataAtual);

listavendas.Add(v1);
listavendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listavendas, Formatting.Indented);
File.WriteAllText("Arquivos/vendas.json", serializado);
Console.WriteLine(serializado);
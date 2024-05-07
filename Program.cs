using estudos_dotnet_one.Models;
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

string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
foreach(string linha in linhas){
    Console.WriteLine(linha);
}
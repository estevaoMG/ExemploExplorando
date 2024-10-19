using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Estevão";
p1.Sobrenome = "Gouveia";

Pessoa p2 = new Pessoa();
p2.Nome = "Eduardo";
p2.Sobrenome = "Neves Queriroz";


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();









































// Pessoa p1 = new Pessoa();
// p1.Nome = "Estevão";
// p1.Sobrenome = "Gouveia";
// p1.Idade = 31;
// p1.Apresentar();
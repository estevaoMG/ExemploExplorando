using ExemploExplorando.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.40M;

Console.WriteLine(valorMonetario.ToString("N2"));

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P2"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));








































// string numero1 = "10";
// string numero2 = 20;

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);














































// Pessoa p1 = new Pessoa(nome: "Estevão", sobrenome:"Gouveia");

// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();









































// Pessoa p1 = new Pessoa();
// p1.Nome = "Estevão";
// p1.Sobrenome = "Gouveia";
// p1.Idade = 31;
// p1.Apresentar();
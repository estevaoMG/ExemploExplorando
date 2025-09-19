using ExemploExplorando.Models;
using System.Globalization;

int numero = 10;
bool ehPar = false;


// IF Ternário
ehPar = numero % 2 == 0;

Console.WriteLine($"O número {numero} é " + (ehPar ? "par!" : "ímpar!"));


// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par!");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é ímpar!");
// }
































































// Pessoa p1 = new Pessoa("Estevão", "Gouveia");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");
































































// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     // Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo!");
// }


































































// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Estevão", "Gouveia", 1.76M);

// // ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Estevão", "Gouveia", 1.76M);
// // var outroExemploTuplaCreate = Tuple.Create(1, "Estevão", "Gouveia", 1.76M);

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");






































// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// Console.WriteLine(estados["MG"]);

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("------------------------");

// estados.Remove("BA");
// estados["SP"] = "São Paulo - valor alterado";

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA2";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");

// }





































// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }












































// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }









































// new ExemploExcecao().Metodo1();
























































// try
// {
// string[] linhas = File.ReadAllLines("Arquivos/d/arquivoLeitura.txt");

// foreach(string linha in linhas)
// {
//     Console.WriteLine(linha);
// }
// } catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// } catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// } catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui!");
// }
















































// string dataString = "2024-10-290 17:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida!");
// }











































// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("N2"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P2"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));








































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
using bootcamp.Models;

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Rafael Queiroz";
// pessoa1.Idade = 39;
// pessoa1.Apresentar();

string apresentacao = "Olá, meu nome é Rafael Queiroz e tenho 39 anos.";

int quantidade = 10;
quantidade = 20;

double altura = 1.82;

decimal peso = 95.5M;

bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine($"Quantidade: {quantidade}");
Console.WriteLine("Altura: " + altura.ToString("0.0"));
Console.WriteLine("Peso: " + peso + "kg");
Console.WriteLine($"Condicao: {condicao}");
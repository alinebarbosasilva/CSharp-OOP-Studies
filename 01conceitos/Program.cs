//Exemplo 01
Pessoa obj1 = new Pessoa();

obj1.Nome = "Aline";
// obj1.Apresentacao();


//Exemplo 02
Pessoa obj2 = new();
obj2.Nome = "Sofia";
// obj2.Apresentacao();


//Exemplo 03
Pessoa obj3 = new()
{
    Nome = "Alex",
    Idade = 32
};

string retorno = obj3.VerificarIdade();
Console.WriteLine(retorno);

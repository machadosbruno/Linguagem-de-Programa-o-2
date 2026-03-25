using System.Text.Json;

Pessoa p = new Pessoa { Id = 1, Nome = "Tiago" };


string pessoa = JsonSerializer.Serialize(p);
Console.WriteLine(pessoa);

Pessoa p2 = JsonSerializer.Deserialize<Pessoa>(pessoa);
Console.WriteLine(p2.Nome);

public class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }
}
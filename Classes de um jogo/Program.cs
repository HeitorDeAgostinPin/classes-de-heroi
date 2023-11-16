using System;

class Heroi
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Tipo { get; set; }

    public Heroi(string nome, int idade, string tipo)
    {
        Nome = nome;
        Idade = idade;
        Tipo = tipo;
    }

    public void Atacar()
    {
        string ataque;

        switch (Tipo.ToLower())
        {
            case "mago":
                ataque = "usou magia";
                break;
            case "guerreiro":
                ataque = "usou espada";
                break;
            case "monge":
                ataque = "usou artes marciais";
                break;
            case "ninja":
                ataque = "usou shuriken";
                break;
            default:
                ataque = "usou um ataque indefinido";
                break;
        }

        string mensagem = $"O {Tipo} {Nome} atacou usando {ataque}";
        Console.WriteLine(mensagem);
    }
}

class Program
{
    static void Main()
    {
        
        Heroi heroiMago = new Heroi("Merlin", 100, "mago");
        heroiMago.Atacar();

        Heroi heroiGuerreiro = new Heroi("Conan", 35, "guerreiro");
        heroiGuerreiro.Atacar();
    }
}

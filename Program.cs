using System;

class Program
{
    static void Main(string[] args)
    {
        string nome = "";
        string nivel = "";
        float xp = 0;

        Console.WriteLine("Bem-vindo ao Classificador de Herói! Vamos descobrir qual o seu nível, baseado no seu nível de XP! Primeiro, digite seu nome:");
        Console.Write("\n");
        nome = Console.ReadLine() ?? "Cavaleiro Sem Nome da Silva";

        Console.WriteLine("Agora, digite seu nível de XP:\n");
        xp = float.Parse(Console.ReadLine() ?? "0");
        
        Console.Write("\n");

        if (xp <= 1000)
        {
            nivel = "FERRO";
        }
        else if (xp <= 2000)
        {
            nivel = "BRONZE";
        }
        else if (xp <= 5000)
        {
            nivel = "PRATA";
        }
        else if (xp <= 6000)
        {
            nivel = "OURO";
        }
        else if (xp <= 7000)
        {
            nivel = "PLATINA";
        }
        else if (xp <= 8000)
        {
            nivel = "DIAMANTE";
        }
        else if (xp <= 9000)
        {
            nivel = "ASCENDENTE";
        }
        else if (xp <= 1000)
        {
            nivel = "IMORTAL";
        }
        else if (xp > 10000)
        {
            nivel = "RADIANTE";
        }
        else{
            nivel = "INVÁLIDO";
        }

        Console.WriteLine($@"
        O Herói de nome {nome} está no nível {nivel} com {xp} XP.
        ");
    }
}

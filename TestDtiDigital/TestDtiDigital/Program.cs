using System;

public class Program
{
    public static void Main(string[] args)
    {
        int dia, racaGrande, racaPequena;
        Orcamento aux = new Orcamento();
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("--------------FACA SEU ORCAMENTO---------------");
        Console.WriteLine("-----------------------------------------------");
        DiaSemana diaSemana = new DiaSemana();
        dia = diaSemana.ObterDiaSemana();
        Console.Write("Digite a quantidade de cães de raça pequena: ");
        racaPequena = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite a quantidade de cães de raça grande: ");
        racaGrande = Convert.ToInt32(Console.ReadLine());
        aux.DiaSemana = dia;
        aux.RacaPequena = racaPequena;
        aux.RacaGrande = racaGrande;
        aux.Compara();
    }
}

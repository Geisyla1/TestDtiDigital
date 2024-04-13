using System;

public class DiaSemana
{
    public int ObterDiaSemana()
    {
        DateTime data;
        Console.WriteLine("Digite uma data no formato dd/mm/yyyy: ");
        if (DateTime.TryParse(Console.ReadLine(), out data))
        {
            return (int)data.DayOfWeek;
        }
        else
        {
            Console.WriteLine("Data inválida.");
            Environment.Exit(1);
            return -1; // Necessário para evitar erro de compilação
        }
    }
}


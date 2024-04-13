using System;

public class Orcamento
{
    private int racaPequena;
    private int racaGrande;
    private int diaSemana;

    public int RacaPequena
    {
        get { return racaPequena; }
        set { racaPequena = value; }
    }

    public int RacaGrande
    {
        get { return racaGrande; }
        set { racaGrande = value; }
    }

    public int DiaSemana
    {
        get { return diaSemana; }
        set { diaSemana = value; }
    }

    public float MeuCaninoFeliz()
    {
        float valor = 0;
        if (diaSemana == 5 || diaSemana == 6)
        {
            valor = (racaPequena * (20 + (20 * 0.2f))) + (racaGrande * (40 + (40 * 0.2f)));
        }
        else
        {
            valor = (racaPequena * 20) + (racaGrande * 40);
        }
        return valor;
    }

    public float VaiRex()
    {
        float valor = 0;
        if (diaSemana == 5 || diaSemana == 6)
        {
            valor = (racaPequena * 20) + (racaGrande * 55);
        }
        else
        {
            valor = (racaPequena * 15) + (racaGrande * 50);
        }
        return valor;
    }

    public float ChowChawgas()
    {
        float valor = 0;
        valor = (racaPequena * 30) + (racaGrande * 45);
        return valor;
    }

    public void Compara()
    {
        float valorMCF = MeuCaninoFeliz();
        float valorVR = VaiRex();
        float valorCC = ChowChawgas();

        if (valorMCF < valorVR && valorMCF < valorCC)
        {
            Console.WriteLine("\nO petshop mais barato: Meu Canino Feliz no valor de: R${0:0.00}", valorMCF);
        }
        else if (valorVR <= valorMCF && valorVR < valorCC)
        {
            Console.WriteLine("\nO petshop mais barato: Vai Rex no valor de: R${0:0.00}", valorVR);
        }
        else if (valorCC <= valorMCF && valorCC <= valorVR)
        {
            Console.WriteLine("\nO petshop mais barato: ChowChawgas no valor de: R${0:0.00}", valorCC);
        }
    }
}

/*Ref (15 pontos)
4 – Ler valor de nota de N1 e N2, calcular a média e escrever a nota correspondente,
tal que 0 é a menor nota e 10 a maior, e imprimir o conceito equivalente
(A, B, C, D ou E), conforme a seguinte tabela:
 A - nota >= 8,5 e nota <= 10
 B - nota >= 7 e nota < 8,5
 C - nota >= 5 e nota < 7
 D - nota >= 3 e nota < 5
 E - nota < 3
Nome: Lavínia Braulio
*/

public static class Atividade4
{
    public static void Executar()
    {
        

    double valorNota1 = 0;
    double valorNota2 = 0;
    double media = 0;

    Console.WriteLine("Digite o valor da nota 1 ");
        valorNota1 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o valor da nota 2 ");
        valorNota2 = double.Parse(Console.ReadLine()!);

        media = (valorNota1 + valorNota2)/2;
        if (media <= 10 & media >=8.5)
        {
            Console.WriteLine($"O aluno tem media A");
        }
        else if (media >=7 && media < 7)
        {
            Console.WriteLine($"O aluno tem media B ");
        }

        else if (media >= 5 & media < 7)
        {
            Console.WriteLine($"O aluno tem media C");
        }
        else if (media >= 3 & media < 5)
        {
            Console.WriteLine($"O aluno tem media D");
        }
        else if (media < 3)
        {
            Console.WriteLine($"O aluno tiver media E");
        }

        Console.WriteLine ("Resultado da media");
        Console.WriteLine (media);



    }
} 
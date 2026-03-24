/* Ref (5 pontos)
2 – Faça um programa que verifique se uma letra digitada é vogal ou consoante
Nome: Lavínia Braulio
*/
public static class Atividade2
{
    public static void Executar()

    {
        string letra;

        Console.WriteLine("Digite a letra para análise: ");
        letra = Console.ReadLine()!.ToLower();

        if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
        {
            Console.WriteLine($"A letra é uma vogal");
        
        }
            
        else
        {
            Console.WriteLine($"A letra é uma consoante");
        }
        
    }
}

    
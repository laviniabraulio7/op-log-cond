/*Ref (15 pontos)
5 - As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia,
e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número
de maçãs compradas, calcule e escreva o valor total da compra.
Nome: Lavínia Braulio
*/
public static class Atividade5
{
    public static void Executar()
    {
        double maca = 0;
        double valor = 0;

        Console.WriteLine("Quantas macas foram compradas?");
        maca = double.Parse(Console.ReadLine()!);

        if (maca <=11)
        {
            Console.WriteLine($"Preço a pagar: {valor}");
        }
        
        else if (maca >= 12)
        {
            valor = 0.25 * maca;
            Console.WriteLine($"Preço a pagar: {valor}");
        }
    

    }
            
}
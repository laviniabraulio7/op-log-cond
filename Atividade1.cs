/*Ref (5 pontos)
1 - Faça um programa que calcule e apresente o valor do volume de uma lata,
sabendo que PI é um valor constante de 3.14159, o programa deve pedir os valores
de RAIO e ALTURA, utilize a fórmula VOLUME = PI * RAIO² * ALTURA.
Nome: Lavínia Braulio
*/
public static class Atividade1
{
    public static void Executar()
    {
        const double pi = 3.14159;
        double raio;
        double altura;
        double volume;

        Console.WriteLine("Digite a altura: ");
        altura = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o raio: ");
        raio = double.Parse(Console.ReadLine()!);

        volume = pi * (raio*raio) * altura;

        Console.WriteLine ("Resultado do volume");
        Console.WriteLine (volume);




    }
}
/*Ref. (10 pontos)
6 - Um programa deve ler três ângulos e verificar qual é o tipo de triângulo formado.
Primeiro, é necessário conferir se a soma dos três ângulos é igual a 180°,
pois só assim eles formam um triângulo. Depois, se um dos ângulos for igual a 90°,
o triângulo é retângulo. Se um dos ângulos for maior que 90°, ele é obtusângulo.
Caso contrário, se os três forem menores que 90°, o triângulo é acutângulo.
Nome: Lavínia Braulio
*/
public static class Atividade6
{
    public static void Executar()
    {
        double a1 = 0;
        double a2 = 0;
        double a3 = 0;
        double angulo = 0;

        Console.WriteLine("Digite o primeiro angulo");
        a1 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o segundo angulo");
        a2 = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o terceiro angulo");
        a3 = double.Parse(Console.ReadLine()!);

        angulo = a1 + a2 + a3;

        if (a1 == 90 || a2 == 90|| a3 == 90)
        {
            Console.WriteLine("É um triângulo retângulo");
        }

        else if (a1 > 90 || a2 > 90 || a3 > 90)
        {
            Console.WriteLine("É um triângulo obtusângulo");
        }

        else if (a1 < 90 && a2 < 90 && a3 > 90)
        {
            Console.WriteLine("É um triângulo acutângulo ");
        }

    }
}
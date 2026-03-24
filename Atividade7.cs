/*Ref. (15 pontos)
7 - Para doar sangue é necessário ter entre 18 e 67 anos e possuir mais de 60 kg.
Faça um aplicativo que pergunte a idade de uma pessoa e seu peso e diga se ela pode
doar sangue ou não; caso não possa, diga o(s) motivo(s).
Nome: Lavínia Braulio
*/
public static class Atividade7
{
    public static void Executar ()
    {
        int idade = 0;
        int peso = 0;

        Console.WriteLine("Digite sua idade");
        idade = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite seu peso");
        peso = int.Parse(Console.ReadLine()!);

        if (idade >= 18 && idade <= 67 && peso >=60)
        {
            Console.WriteLine("Doaçao de sangue liberada");
        }
        else
        {
            Console.WriteLine("Doaçao de sangue não liberada");
        }
    }
}
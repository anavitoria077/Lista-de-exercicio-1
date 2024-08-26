/*-------------------------------------------------------------------
Questão 5: Cálculo de Distância Percorrida
• Contextualização:Um veículo no jogo percorre uma certa distância em um tempo determinado.
• Comando: Crie um programa que receba a velocidade do veículo, o tempo de viagem e dois
multiplicadores (um para condições climáticas e outro para estado do veículo), e calcule a
distância total percorrida.
@Lista: 01 - Lógica de Programação
@Autor: Ana Vitoria
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
class Program
{
    static void Main(string[] args)
    {
        int velocidade, tempo;
        Double mult1, mult2, soma;

        Console.WriteLine("Qual a velocidade? ");
        int.TryParse(Console.ReadLine(), out velocidade);

        Console.WriteLine("Qual foi o tempo? ");
        int.TryParse(Console.ReadLine(), out tempo);

        Console.WriteLine("Qual o Multiplicador Climatico? ");
        Double.TryParse(Console.ReadLine(), out mult1);

        Console.WriteLine("Qual o Multiplicador Estado do Veiculo? ");
        Double.TryParse(Console.ReadLine(), out mult2);

        soma = (velocidade * tempo * mult1 * mult2 );
        Console.WriteLine($"A distancia total percorrida é :{soma}");


    }
}
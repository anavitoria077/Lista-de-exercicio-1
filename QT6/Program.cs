/*-------------------------------------------------------------------
Questão 6: Conversão de Moeda do Jogo
• Contextualização: O jogo possui uma loja onde os jogadores podem trocar moedas de ouro por
cristais.
• Comando: Desenvolva um programa que receba o valor de moedas de ouro, o valor da taxa de
conversão (1 cristal = X moedas de ouro), e dois bônus de conversão (um baseado em eventos
e outro em habilidades), e calcule o número de cristais que o jogador pode obter.

@Lista: 01 - Lógica de Programação
@Autor: Ana Vitoria
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System; 
class Program
{
    static void Main(string[] args)
    {
        int moedas, taxa;
        Double bonusEventos, bonusHabilidade, soma;

        Console.WriteLine("Quantas moedas de ouro? ");
        int.TryParse(Console.ReadLine(), out moedas);

        Console.WriteLine("Qual o valor da taxa de conversão? ");
        int.TryParse(Console.ReadLine(), out taxa);

        Console.WriteLine("Qual o valor do bonus do Eventos? ");
        Double.TryParse(Console.ReadLine(), out bonusEventos);

        Console.WriteLine("Qual o valor dp bonus de Habilidade? ");
        Double.TryParse(Console.ReadLine(), out bonusHabilidade);

        soma = ((moedas / taxa ) + bonusEventos) * bonusHabilidade;
        Console.WriteLine("O numero de cristais obtidos é: " + Math.Floor(soma));
        Console.ReadLine();


    }
}
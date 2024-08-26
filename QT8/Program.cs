/*-------------------------------------------------------------------
Questão 8: Cálculo de Pontos de Habilidade
• Contextualização: Ao subir de nível, um jogador recebe pontos de habilidade que podem ser
distribuídos entre força, agilidade, inteligência e dois atributos adicionais.
• Comando: Desenvolva um programa que receba a quantidade de pontos de habilidade
atribuídos a cada uma das cinco características e calcule o total de pontos distribuídos.
@Lista: 01 - Lógica de Programação
@Autor: Ana Vitoria
@Data: 20/08/2024
---------------------------------------------------------------------*/
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
class Program 
{
    static void Main(string[] args)
    {

    
   
        int forca, agilidade, inteligencia, destreza, vitalidade, soma;

         Console.WriteLine("Pontos de força: ");
         int.TryParse(Console.ReadLine(), out forca);

          Console.WriteLine("Pontos de agilidade: ");
        int.TryParse(Console.ReadLine(), out agilidade);

         Console.WriteLine("Pontos de inteligencia? ");
        int.TryParse(Console.ReadLine(), out inteligencia);

         Console.WriteLine("Pontos de destreza? ");
        int.TryParse(Console.ReadLine(), out destreza);

         Console.WriteLine("Pontos de vitalidade ");
        int.TryParse(Console.ReadLine(), out vitalidade);

      soma = ( forca + agilidade + inteligencia + destreza + vitalidade);

      Console.WriteLine($"O total de ponto é:{soma}");



    }
    
}
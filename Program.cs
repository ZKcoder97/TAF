using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nota_Para_O_Taf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome; int idade; string sexo; double corrida; int fleca; int abd; int barra; 


            do
            {
                Console.WriteLine("Nota para o TAF\n");
                Console.Write("Nome De Guerra: ");
                nome = Console.ReadLine();
            idadeVoltar:
                try
                {
                    Console.Write("Idade: ");
                    idade = int.Parse(Console.ReadLine());

                    if (idade >= 18 && idade <= 100) { }
                    else { Console.Clear(); Console.WriteLine("Idade Inválida\n"); goto idadeVoltar; }
                }
                catch(Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine($"Erro: {ex}\n");
                    goto idadeVoltar;
                }
                sexoVoltar:
                Console.Write("Sexo [M - Masculino || F - Feminino]: ");
                sexo = Console.ReadLine();
                sexo = sexo.ToLower();

                switch (sexo)
                {
                    case "m":
                        break;
                    case "f":
                        break;
                    default:
                        Console.Clear();
                        goto sexoVoltar;
                }
                corridaVoltar:
                try
                {
                    Console.Write("Corrida: ");
                    corrida = double.Parse(Console.ReadLine());

                    if(corrida >= 1600 && corrida <= 3250) { }
                    else { Console.Clear(); Console.WriteLine("Corrida Inválida\n"); goto corridaVoltar; }
                }
                catch (Exception ex) { Console.Clear(); Console.WriteLine($"Erro: {ex}\n"); goto corridaVoltar; }

            flecaVoltar:
                try
                {
                    Console.Write("Flexão: ");
                    fleca = int.Parse(Console.ReadLine());

                    if (fleca >= 0 && fleca <= 120) { }
                    else { Console.Clear(); Console.WriteLine("Flexão Inválida\n"); goto flecaVoltar; }
                }
                catch (Exception ex) { Console.Clear(); Console.WriteLine($"Erro: {ex}\n"); goto flecaVoltar; }

            abdVoltar:
                try
                {
                    Console.Write("Abdominal: ");
                    abd = int.Parse(Console.ReadLine());

                    if (abd >= 0 && abd <= 120) { }
                    else { Console.Clear(); Console.WriteLine("Abdominal Inválida\n"); goto abdVoltar; }
                }
                catch (Exception ex) { Console.Clear(); Console.WriteLine($"Erro: {ex}\n"); goto abdVoltar; }

            barrraVoltar:
                try
                {
                    Console.Write("Barra: ");
                    barra = int.Parse(Console.ReadLine());

                    if (barra >= 0 && barra <= 120) { }
                    else { Console.Clear(); Console.WriteLine("Abdominal Inválida\n"); goto barrraVoltar; }
                }
                catch (Exception ex) { Console.Clear(); Console.WriteLine($"Erro: {ex}\n"); goto barrraVoltar; }




            } while (true);
        }
    }
}

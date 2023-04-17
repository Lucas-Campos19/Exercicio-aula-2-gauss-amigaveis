using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_aula_2_gauss_amigaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            inicio:
            do
            {
                Console.Clear();
                Console.WriteLine("Escolha um dos exercícios");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("1 = programa que exiba uma sequencia de números inteiros");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("2 = programa que exiba uma sequencia de frases");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("3 = programa que exiba uma sequencia de valores booleanos");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("4 = programa que exiba uma sequencia de valores doubles");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("5 = programa que exiba uma sequencia de valores decimais");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.Write("Escolha um número de 1 a 5: ");
                escolha = int.Parse(Console.ReadLine());
            } while (escolha != 1 && escolha != 2 && escolha != 3 && escolha != 4 && escolha != 5);
            if(escolha == 1)
            {
                int i = 0;
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Exercício escolhido: programa que exiba uma sequencia de números inteiros");
                numerosInteiros(i);
            }
            else if (escolha == 2)
            {
                int i = 0;
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Exercício escolhido: programa que exiba uma sequencia de frases");
                Frases(i);
            }
            else if(escolha == 3)
            {
                bool valor = true;
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Exercício escolhido: programa que exiba uma sequencia de valores booleanos");
                Booleanos(valor);
            }
            else if(escolha == 4)
            {
                int i = 0;
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Exercício escolhido: programa que exiba uma sequencia de valores doubles");
                valoresQuebrados(i);
            }
            else
            {
                int i = 0;
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Exercício escolhido: programa que exiba uma sequencia de valores decimais");
                valoresDecimais(i);
            }
            Console.Write("Escolher outro exercício? [s/n] ");
            char retorno = char.Parse(Console.ReadLine());
            if(retorno == 's' || retorno == 'S')
            {
                goto inicio;
            }
            else
            {
                Console.Clear();
                Console.Write("Fim do programa");
            }
            Console.ReadKey();
        }
        static int numerosInteiros(int i)
        {
            for (; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            return i;
        }
        static int Frases(int i)
        {
            string[] frases = new string[5];
            frases[0] = "Meu nome é Lucas Campos Gonçalves.";
            frases[1] = "Nasci em São Paulo na cidade de Atibaia no pais Brasil.";
            frases[2] = "Tenho 19 aninhos!!!!";
            frases[3] = "Torço para o melhor time do Brasil São Paulo futebol clube.";
            frases[4] = "E amo programar.";
            for(; i <frases.Length; i++)
            {
                Console.WriteLine(frases[i]);
            }
            return i;
        }
        static bool Booleanos(bool valor)
        {
            bool[] values = { true, false, true, false, true };
            foreach(bool value in values)
            {
                valor = value;
                Console.WriteLine(valor);
            }
            return valor;
        }
        static int valoresQuebrados(int i)
        {
            double[] valores = { 2.4, 3.5, 5.6, 1.8, 9.3 };
            for(; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);  
            }
            return i;
        }
        static int valoresDecimais(int i)
        {
            decimal[] decimais = { 2.54352589258982358975895732574M, 3.584378935748957438974389589473897589458975892739573987538953M, 5.685757328957392857893758975893748953789389893275935789M, 1.878973985798579837598759837598798579835479858975897349758975897897348974897438975389M, 9.334343444378937874389374893789374893479837489374893478937893789437789347M, 3.14153434343434343434344343434343434349M, 34.3334434443442332323232323344444343443443343434343343434343434334M };
            for (; i < decimais.Length; i++)
            {
                Console.WriteLine(decimais[i]);
            }
            return i;
        }
    }
}

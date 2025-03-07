using System;
using System.Collections.Generic;

namespace SELECT
{
    class Program
    {
        public static Dictionary<int, char> mapaMin = new Dictionary<int, char>
        {
            { 1, 's' },
            { 2, 'e' },
            { 3, 'l' },
            { 4, 'e' },
            { 5, 'c' },
            { 6, 't' }

        };

        public static Dictionary<int, char> mapaMax = new Dictionary<int, char>
        {
            { 1, 'S' },
            { 2, 'E' },
            { 3, 'L' },
            { 4, 'E' },
            { 5, 'C' },
            { 6, 'T' }

        };

        static void Main(string[] args)
        {
            string palavra;
            Console.Write("Digite uma palavra: ");
            palavra = Console.ReadLine();
            analisaSelect(palavra);

        }

        public static bool analisaSelect(string palavra)
        {
         
            bool valido;
            for (int i = 1; i < palavra.Length + 1; i++)
            {
                char c = palavra[i-1];
                if (!verificarChaveValor(mapaMin, i,c) && !verificarChaveValor(mapaMax, i, c))
                {
                    valido = false;
                    Console.Write("Erro léxico");
                    return false;
                }
                continue;
            }
            valido = true;
            Console.Write(valido);
            return true;
        }

        public static bool verificarChaveValor(Dictionary<int,char>mapa, int chave , char valor)
        {
            if(mapa.TryGetValue(chave, out char valorEncontrado))
            {
                return valorEncontrado == valor;
            }
            return false;
        }
    }
}

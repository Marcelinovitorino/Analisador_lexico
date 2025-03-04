using System;
using System.Collections.Generic;

namespace SELECT
{
    class Program
    {
        public static Dictionary<int, char> mapa = new Dictionary<int, char>
        {
            { 1, 's' },
            { 2, 'e' },
            { 3, 'l' },
            { 4, 'e' },
            { 5, 'c' },
            { 6, 't' }

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
            string novaPalavra = palavra.ToLower();
            bool valido;
            for (int i = 1; i < novaPalavra.Length + 1; i++)
            {
                char c = novaPalavra[i-1];
                if (!verificarChaveValor(mapa, i,c))
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    
    class MyFunz
    {
        public struct Record
        {
            public string giocatore;
            public int punteggio;
            public string tempo;
            public int mosse;
            public string livello;
            public DateTime timestamp;

        }
        public static void CaricaCarte(string[] ca)
        {
            for (int i=1;i<13;i++)
            {
                ca[i] = $"{i}a.png";
            }
            for (int i = 13; i < 25; i++)
            {
                ca[i] = $"{i}b.png";
            }

        }
        public static void CaricaFacile(string[] ca)
        {
            int x = 1;
            for (int i = 1; i < 7; i++)
            {
                ca[i] = $"{i}a.png";
            }
            for (int i = 7; i <13 ; i++)
            {
                ca[i] = $"{x}b.png";
                x = x + 1;
            }

        }
        public static void CaricaMedio(string[] ca)
        {
            int x = 1;
            for (int i = 1; i < 10; i++)
            {
                ca[i] = $"{i}a.png";
            }
            for (int i = 10; i < 19; i++)
            {
                ca[i] = $"{x}b.png";
                x = x + 1;
            }

        }
        public static void CaricaDifficile(string[] ca)
        {
            int x = 1;
            for (int i = 1; i < 13; i++)
            {
                ca[i] = $"{i}a.png";
            }
            for (int i = 13; i < 25; i++)
            {
                ca[i] = $"{x}b.png";
                x = x + 1;
            }

        }
        public static void MischiaCarte(string[] ca)
        {
            Random random = new Random();
            //ca.OrderBy(x => random.Next()).ToArray();

            for (int i = 1 ; i < ca.Length - 1; i++)
            {
                int randomIndex = random.Next(1, ca.Length-i);

                string temp = ca[i];
                ca[i] = ca[randomIndex];
                ca[randomIndex] = temp;
            }

        }
    }
}

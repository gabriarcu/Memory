using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            for (int i = 1; i < 13; i++)
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
            for (int i = 7; i < 13; i++)
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

            for (int i = 1; i < ca.Length - 1; i++)
            {
                int randomIndex = random.Next(1, ca.Length - i);

                string temp = ca[i];
                ca[i] = ca[randomIndex];
                ca[randomIndex] = temp;
            }

        }
        public static void CaricaGiocatori(string[] gi, int p2)
        {
            string line2;
            p2 = 0;
            try
            {

                StreamReader sr2 = new StreamReader(@"..\..\Resources\giocatori.csv");

                line2 = sr2.ReadLine();


                while (line2 != null)
                {
                    gi[p2] = line2;

                    p2 = p2 + 1;
                    line2 = sr2.ReadLine();
                }
                //close the file

                sr2.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }


        }
        public static void SalvaGiocatori(string[] gi, int p2)
        {
            int x = 0;
            StreamWriter swww = File.CreateText(@"..\..\Resources\giocatori.csv");
            //Write a line of text
            while (x < p2)
            {
                string linea = gi[x];
                swww.WriteLine(linea);
                x = x + 1;

            }
            

            

            //Close the file
            swww.Close();


        }

        public static int Cerca(string[] gi, int p2, string codiC)
        {
            int x = 0;
            while (x < p2)
            {
                if (string.Compare(gi[x], codiC) == 0)
                {
                    return x;
                }
                x = x + 1;
            }
            return -1;
        }
        public static int Elimina(string[] gi, ref int p2, string P)
        {
            int nDC = default;
            int x = default;
            while (x < p2)
            {
                if (string.Compare(gi[x], P) == 0)
                {
                    gi[x] = gi[p2 - 1];
                    p2 = p2 - 1;
                    x = x - 1;
                    nDC = nDC + 1;
                }
                x = x + 1;
            }
            return nDC;
        }


    }
}

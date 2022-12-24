using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib13
{
    public class Resh
    {
        public static string Vichisl()
        {
            int x;
            Random rnd = new Random();
            string znach = "";
            x = 0;
            double Summ = 0;
            int n;
            do
            {
                n = x;
                x = rnd.Next(-5, 5);
                if (x > 0) Summ = Math.Sqrt(x);
                if (x < 0) Summ = Math.Pow(x, 2);
                znach += "Значение x :" + Convert.ToString(x) + "\n" + "Значение итоговое:" + Convert.ToString(Summ) + "\n";
            } while (x != n);
            return znach;
        }
        public static int Rezu(int[] mas)
        {
            int rez = 1;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > 2) rez *= mas[i];
            }
            return rez;
        }
        public static string SredArif(int[,] mas)
        {
            int sum;
            int sred;
            int kol;
            int mensh;
            string tekst = "";
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                sum = 0;
                sred = 0;
                kol = 0;
                mensh = 0;
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    sum += mas[i, j];
                    kol++;
                }
                sred = sum / kol;
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] < sred) mensh++;
                }
                tekst += $"Кол-во элм. меньш. сред. ариф. в строке {i + 1} = {mensh}\n";
            }
            return tekst;
        }
    }
}
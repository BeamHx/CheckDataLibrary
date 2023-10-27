using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string vin = "JHMCM56557C404453";

            //string[,] codeTable =
            //{
            //    {"A","B","C","D","E","F","G","H","J","K","L","M","N","P","R","S","T","U","V","W","X","Y","Z" },
            //    {"1","2","3","4","5","6","7","8","1","2","3","4","5","7","9","2","3","4","5","6","7","8","9"}
            //};
            //string[] weight = { "8", "7", "6", "5", "4", "3", "2", "10", "0", "9", "8", "7", "6", "5", "4", "3", "2" };

            //int mult = 0;

            //for (int i = 0; i < weight.Length; i++)
            //{
            //    if(i == 8)
            //    {
            //        continue;
            //    }
            //    for (int k = 0; k < codeTable.GetLength(1); k++)
            //    {

            //        if (char.IsDigit(vin[i]))
            //        {
            //            mult += Convert.ToInt32(char.GetNumericValue(vin[i])) * Convert.ToInt32(weight[i]);
            //            break;
            //        }
            //        if (vin[i].ToString() == codeTable[0, k])
            //        {
            //            int numberEq = Convert.ToInt32(codeTable[1, k]);
            //            mult += numberEq * Convert.ToInt32(weight[i]);
            //            break;
            //        }
            //    }
            //}

            //int mineleven = mult / 11;

            //int chk = mult - mineleven;

            //if (vin[8] == chk)
            //{
            //    Console.WriteLine("vse godd");
            //}
            //if (chk == 10)
            //{
            //    if (vin[8] != 'X')
            //    {
            //        Console.WriteLine("vse ne god");
            //    }
            //    //char[] ch = vin.ToCharArray();
            //    //ch[8] = 'X';
            //    //vin = ch.ToString();
            //}


            //Console.WriteLine(vin);
            char[] ch = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };


            char[] chWrong = { 'I', 'O', 'Q' };

            for (int i = 0; i < vin.Length; i++)
            {
                for (int k = 0; k < chWrong.Length; k++)
                {
                    if (vin[i] == chWrong[k])
                    {
                        Console.WriteLine("pz");
                    }
                }
            }
        }
    }
}

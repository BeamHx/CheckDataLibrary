using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckDataLibrary
{
    public class VinCheck
    {
        public bool CheckVin(string vin, int year) 
        {
            if (vin.Length != 17|| String.IsNullOrEmpty(vin))
            {
                throw new ArgumentException("Недопустимая длина VIN");
            }
            char[] ch = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            char[] chWrong = { 'I', 'O', 'Q' };

            for (int i = 0; i < vin.Length; i++)
            {
                for (int k = 0; k < chWrong.Length; k++)
                {
                    if (vin[i] == chWrong[k])
                    {
                        return false;
                    }
                }
            }

            for (int i = 13; i < vin.Length; i++)
            {
                if (char.IsDigit(vin[i]) == false)
                {
                    return false;
                }
            }
           
            return true;

        }

        public string GetVINCountry(string vin) 
        {
            for (int i = 0; i < vin.Length - 15; i++)
            {
                if (vin.Length - 17 == )
                {

                }
            }
            return "1";
        }

        public bool CorrectYear(string vin, int year)
        {
            int[] equivalent = {1,2,3,4,5,6,7,8,1,2,3,4,5,7,9,2,3,4,5,6,7,8,9};
            for (int i = 0; i < vin.Length; i++)
            {
                return true;
            }
            return true;
        }
        /// <summary>
        /// Контрольная сумма
        /// </summary>
        /// <param name="vin"> строка с вином</param>
        /// <returns>true если контрольная сумма сходится, false если нет </returns>
        public bool GetControlSum(string vin)
        {


            string[,] codeTable =
            {
                {"A","B","C","D","E","F","G","H","J","K","L","M","N","P","R","S","T","U","V","W","X","Y","Z" },
                {"1","2","3","4","5","6","7","8","1","2","3","4","5","7","9","2","3","4","5","6","7","8","9"}
            };
            string[] weight = { "8", "7", "6", "5", "4", "3", "2", "10", "0", "9", "8", "7", "6", "5", "4", "3", "2" };

            int mult = 0;

            for (int i = 0; i < weight.Length; i++)
            {
                if (i == 8)
                {
                    continue;
                }
                for (int k = 0; k < codeTable.GetLength(1); k++)
                {

                    if (char.IsDigit(vin[i]))
                    {
                        mult += Convert.ToInt32(char.GetNumericValue(vin[i])) * Convert.ToInt32(weight[i]);
                        break;
                    }
                    if (vin[i].ToString() == codeTable[0, k])
                    {
                        int numberEq = Convert.ToInt32(codeTable[1, k]);
                        mult += numberEq * Convert.ToInt32(weight[i]);
                        break;
                    }
                }
            }

            int mineleven = mult / 11;

            int chk = mult - mineleven;

            if (chk == 10)
            {
                if (vin[8] != 'X')
                {
                    return false;
                }
                //char[] ch = vin.ToCharArray();
                //ch[8] = 'X';
                //vin = ch.ToString();
            }

            if (vin[8] == chk)
            {
                return true;
            }
            return false;

           
        }
    }
}

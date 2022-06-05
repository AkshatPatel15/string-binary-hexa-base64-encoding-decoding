using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class HexadecimalConverter
    {
        public string hexaConverter(string str)
        {
            string hexastring = "";
            foreach (char c in str)
            {
                int x = (int)c;
                string result = "";

                while (x != 0)
                {
                    if ((x % 16) < 10)
                        result = x % 16 + result;
                    else
                    {
                        string temp = "";
                        switch (x % 16)
                        {
                            case 10: temp = "A"; break;
                            case 11: temp = "B"; break;
                            case 12: temp = "C"; break;
                            case 13: temp = "D"; break;
                            case 14: temp = "E"; break;
                            case 15: temp = "F"; break;
                        }
                        result = temp + result;
                    }
                    x /= 16;
                }
                hexastring += result;
            }
            Console.WriteLine($"Hexadecimal code of string '{str}' is = {hexastring}");
            return hexastring;

        }
        //decoding : from hexa to string
        public string ConvertHexToString(string hexa)
        {
            string result = "";
            for (int i = 0; i < hexa.Length; i += 2)
            {
                var first2_bits = hexa.Substring(i, 2);
                var number = Convert.ToInt32(first2_bits, 16);
                result += (char)number;
            }
            Console.WriteLine("hexa to string = " + result);
            return result;
        }
    }
}

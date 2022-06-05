using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class BinaryConverter
    {
        public string StringToBinary(string usr_input)
        {
            string binary_str = "";
            foreach (char ch in usr_input)
            {
                int ascii_value = (int)ch;
                string binary_value = "";
                int remainder = 0;
                while (ascii_value > 0)
                {
                    remainder = ascii_value % 2;
                    ascii_value /= 2;
                    binary_value = remainder + binary_value;
                }
                //binary_value = (ascii_value + binary_value);
                binary_value = binary_value.PadLeft(8, '0');
                //Console.WriteLine($"Binary value of each letter({ch}) of your Name is : {binary_value}");
                binary_str = binary_str + binary_value;
            }
            Console.WriteLine($"Binary code of your name is : {binary_str}");
            Console.WriteLine($"Length of binary code is {binary_str.Length}");
            return binary_str;
        }

        //DEcoding : Convert Binary to String
        //Decoding
        public string binaryToString(string binarydata)
        {
            List<byte> bytes = new List<byte>();
            for (int i = 0; i < binarydata.Length; i += 8)
            {
                bytes.Add(Convert.ToByte(binarydata.Substring(i, 8), 2));
            }
            Console.WriteLine($"String converted from given binary = {Encoding.ASCII.GetString(bytes.ToArray())}");
            return Encoding.ASCII.GetString(bytes.ToArray());

        }
    }
}

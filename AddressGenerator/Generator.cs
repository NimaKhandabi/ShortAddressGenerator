using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressGenerator
{
    public class Generator
    {
        private static Random random = new Random();

        string shortAddress;
        //string _longAddress;
        //string afterSplit;
        string mainAddress;
        int index;
        bool isLong;

        //string[] split;

        public string ShortAddressGenerator(int lenght, string longAddress)
        {
            string tempAddress = Spliter(longAddress);
            if (isLong)
                shortAddress = tempAddress + "/" + RandomString(lenght);
            else
                shortAddress = tempAddress;

            return shortAddress;
        }

        public string Spliter(string address)
        {
            int count = 0;

            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] == '/')
                {
                    count++;
                    if (count == 3)
                    {
                        index = i;
                        isLong = true;
                    }
                    else if (count < 3)
                    {
                        index = address.Length;
                        isLong = false;
                    }
                }
            }

            for (int i = 0; i < index; i++)
            {
                mainAddress += $"{/*afterSplit*/address[i]}";
            }

            return mainAddress;
        }

        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}


//split = new string[] { address };
//if (address.Contains("https://"))
//{
//    split = address.Split("https://");
//}
//else if (address.Contains("http://"))
//{
//    split = address.Split("http://");
//}

//foreach (var word in split)
//{
//    afterSplit = $"{word}";
//}

//int index = afterSplit.IndexOf("/");


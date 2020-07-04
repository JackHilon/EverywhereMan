using System;
using System.Collections.Generic;

namespace EverywhereMan
{
    class Program
    {
        static void Main(string[] args)
        {
            // I've Been Everywhere, Man 
            // https://open.kattis.com/problems/everywhere 
            // simple Array/List - string program
            // === I get Time Limit Exceeded === !!!!!!!!!

            int counterCases = EnterNumber(50);
            int[] ans = new int[counterCases];


            int tripCount;
            string city;
            for (int k = 0; k < counterCases; k++)
            {
                tripCount = EnterNumber(100);


                int magic = 0;
                string[] cities = new string[tripCount];
                for (int i = 0; i < cities.Length; i++)
                {
                    city = EnterCityName();
                    if (ItemExistsList(cities, city) == false)
                        magic++;

                    cities[i] = city;
                }
                ans[k] = cities.Length;


            }
            PrintList(ans);
        }
        
        private static bool ItemExistsList(string[] strArray, string str)
        {
            if (strArray.Length != 0)
            {
                for (int i = 0; i < strArray.Length; i++)
                {
                    if (strArray[i] == str)
                        return true;
                }
                return false;
            }
            else
                return false;
        }
        private static string EnterCityName()
        {
            string str = "";
            try
            {
                str = Console.ReadLine();
                if (CityNameCond(str) == false)
                    throw new ArgumentException();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return EnterCityName();
            }
            return str;
        }
        private static bool CityNameCond(string str)
        {
            if (str.Length < 1 || str.Length > 20)
                return false;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (char.IsLower(str[i]) == false)
                    return false;
            }
            if (str[str.Length - 1] != ' ')
                return false;
            return true;
        }
        private static int EnterNumber(int max)
        {
            int a = 0;
            try
            {
                a = int.Parse(Console.ReadLine());
                if (a < 1 || a > max)
                    throw new ArgumentException();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return EnterNumber(max);
            }
            return a;
        }
        private static void PrintList(int[] list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise1");
            //Exercise1();
            Console.WriteLine("Exercise2");
            Exercise2();
            Console.ReadLine();
        }

        public static void Exercise1()
        {
            int numberOfNiceStrings = 0;
            string temp;
            StreamReader sr = new StreamReader(@"..\..\input.txt");
            while ((temp = sr.ReadLine()) != null)
            {
                char[] uniqueCharacters = String.Join("", temp.Distinct()).ToCharArray();
                char[] vowels = "aeiou".ToCharArray();
                string[] forbiddenCombinations = new string[] {"ab","cd","pq","xy" };
                if(temp.Count(x => x == 'a' || x == 'e'|| x == 'i' || x == 'o' || x == 'u')>=3)
                {
                    bool uniqueFound = false;
                    foreach (var unique in uniqueCharacters)
                    {
                        if(temp.IndexOf(unique.ToString()+unique.ToString())!=-1)
                        {
                            uniqueFound = true;
                            break;
                        }
                    }
                    if(uniqueFound)
                    {
                        bool forbiddenFound = false;
                        foreach (var forbidden in forbiddenCombinations)
                        {
                            if(temp.IndexOf(forbidden)!=-1)
                            {
                                forbiddenFound = true;
                                break;
                            }
                        }
                        if(!forbiddenFound)
                        {
                            numberOfNiceStrings++;
                            Console.WriteLine(temp);
                        }
                    }
                }
            }
            Console.WriteLine("result 1: " + numberOfNiceStrings.ToString() + " number of nice strings");
        }

        public static void Exercise2()
        {
            int numberOfNiceStrings = 0;
            string temp;
            StreamReader sr = new StreamReader(@"..\..\input.txt");
            while ((temp = sr.ReadLine()) != null)
            {
                char[] uniqueCharacters = String.Join("", temp.Distinct()).ToCharArray();
                bool hopFound = false;
                foreach (var unique in uniqueCharacters)
                {
                    int count = temp.Count(x => x == unique);
                    if (count >1)
                    {
                        int first = temp.IndexOf(unique);
                        for (int i = 0,l=count-1; i < l; i++)
                        {
                            if(first>temp.Length-2)
                            {
                                break;
                            }
                            int second = temp.IndexOf(unique, first + 2);
                            if(second - first == 2)
                            {
                                hopFound = true;
                                break;
                            }
                            else
                            {
                                first = second;
                            }

                        }
                    }
                }        
                if(hopFound)
                {
                    bool pairFound = false;
                    for (int i = 0,l=temp.Length; i < l-3; i++)
                    {
                        if (temp.IndexOf(temp.Substring(i, 2), i + 2) != -1)
                        {
                            pairFound = true;
                            break;
                        }
                    }
                    if (pairFound)
                    {
                        numberOfNiceStrings++;
                        Console.WriteLine(temp);
                    }
                }                        
                
            }
            Console.WriteLine("result 2: " + numberOfNiceStrings.ToString() + " number of nice strings");
            //54 to low
            //76 to high

            var good = 0;
            var bad = 0;
            string str;
            StreamReader sr2 = new StreamReader(@"..\..\input.txt");
            while ((str = sr2.ReadLine()) != null)
            
                {
                bool pair = false;
                bool repeat = false;

                for (int i = 0; i < str.Length - 2; i++)
                {
                    if (!pair && i < str.Length - 3 && str.IndexOf(str.Substring(i, 2), i + 2) > 0)
                    {
                        pair = true;
                        if (repeat)
                            break;
                    }
                    if (!repeat && (str[i + 2] == str[i]))
                    {
                        repeat = true;
                        if (pair)
                            break;
                    }
                }
                if (pair && repeat)
                {
                    good++;
                }
                else
                {
                    bad++;
                }
            }

            Console.WriteLine("Total: {0}", good);
        }

    }
}

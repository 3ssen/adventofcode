using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Coordinate> coordinates = new List<Coordinate>();
            int currentx = 0;
            int currenty = 0;
            Coordinate coord = new Coordinate(currentx,currenty);
            coordinates.Add(coord);
            string temp;
            char[] directions;
            StreamReader sr = new StreamReader(@"..\..\input.txt");
            while ((temp = sr.ReadLine()) != null)
            {
                directions = temp.ToCharArray();
                foreach (var direction in directions)
                {
                    switch (direction)
                    {
                        case '>':
                            currentx++;
                            break;
                        case '<':
                            currentx--;
                            break;
                        case '^':
                            currenty++;
                            break;
                        case 'v':
                            currenty--;
                            break;
                    }
                    //check if new coord exists in List
                    int searchresult = coordinates.FindIndex(
                        delegate (Coordinate c)
                        {
                            return c.x == currentx && c.y == currenty;
                        }
                        );

                    if (searchresult == -1)
                    {
                        Coordinate newCoord = new Coordinate(currentx, currenty);
                        coordinates.Add(newCoord);
                    }
                    else
                    {
                        //update coordinate at locationindex;
                        coordinates[searchresult].timesVisited++; 
                    }


                }

            }
            Console.WriteLine(coordinates.Count.ToString()+" different houses visited.");
            Console.ReadKey();


        }
    }

    class Coordinate
    {
        public Coordinate(int _x, int _y)
        {
            x = _x;
            y = _y;
            timesVisited = 1;
        }

        public int x { get; set; }
        public int y { get; set; }
        public int timesVisited { get; set; }
    }
}

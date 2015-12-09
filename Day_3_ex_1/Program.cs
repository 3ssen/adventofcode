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
            Exercise1();
            Exercise2();
        }

        static void Exercise1()
        {
            Console.WriteLine("Exercise 1:");
            List<Coordinate> coordinates = new List<Coordinate>();
            int currentx = 0;
            int currenty = 0;
            Coordinate coord = new Coordinate(currentx, currenty);
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
            Console.WriteLine(coordinates.Count.ToString() + " different houses visited.");
            Console.ReadKey();
        }

        static void Exercise2()
        {
            Console.WriteLine("Exercise 2:");
            List<Coordinate> coordinates = new List<Coordinate>();
            int currentx = 0;
            int currenty = 0;
            int currentx_robot = 0;
            int currenty_robot = 0;
            int step = 0;
            Coordinate coord = new Coordinate(currentx, currenty);
            coordinates.Add(coord);
            string temp;
            char[] directions;
            StreamReader sr = new StreamReader(@"..\..\input.txt");
            while ((temp = sr.ReadLine()) != null)
            {
                directions = temp.ToCharArray();
                foreach (var direction in directions)
                {
                    step++;
                    switch (direction)
                    {
                        case '>':
                            if(step % 2 == 0)
                                currentx++;
                            else
                                currentx_robot++;
                            break;
                        case '<':
                            if (step % 2 == 0)
                                currentx--;
                            else
                                currentx_robot--;
                            break;
                        case '^':
                            if (step % 2 == 0)
                                currenty++;
                            else
                                currenty_robot++;
                            break;
                        case 'v':
                            if (step % 2 == 0)
                                currenty--;
                            else
                                currenty_robot--;
                            break;
                    }
                    //check if new coord exists in List
                    int searchsanta = coordinates.FindIndex(
                        delegate (Coordinate c)
                        {
                            return c.x == currentx && c.y == currenty;
                        }
                        );
                    int searchrobot = coordinates.FindIndex(
                        delegate (Coordinate c)
                        {
                            return c.x == currentx_robot && c.y == currenty_robot;
                        }
                        );
                    int searchresult = (step%2==0) ? searchsanta : searchrobot;
                    if (step % 2 == 0)
                    {
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
                    else
                    {
                        if (searchresult == -1)
                        {
                            Coordinate newCoord = new Coordinate(currentx_robot, currenty_robot);
                            coordinates.Add(newCoord);
                        }
                        else
                        {
                            //update coordinate at locationindex;
                            coordinates[searchresult].timesVisited++;
                        }
                    }


                }

            }
            Console.WriteLine(coordinates.Count.ToString() + " different houses visited.");
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

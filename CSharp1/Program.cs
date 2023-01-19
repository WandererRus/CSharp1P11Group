using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace CSharp1
{
    class Human
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }

        public Human(int age, string name, string path)
        {
            Age = age;
            Name = name;
            Path = path;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*try { 
                try { 
                    string reader = Console.ReadLine();
                    Console.WriteLine(reader);
                    int i = Int32.Parse(reader);
                    Console.WriteLine(i.ToString());
                }
                catch (DivideByZeroException ex) 
                {
                    Console.WriteLine(ex.Message);
                }
                finally 
                { 
                    Console.WriteLine("Все успешно"); 
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }*/

            /*Random random = new Random();
            Console.ForegroundColor = ConsoleColor.Green;
            int widthConsole = Console.WindowWidth;
            int heightConsole = Console.WindowHeight;
            char[,] ints = new char [widthConsole,2000];
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            for (int i = 0; i < Console.WindowWidth; i++) 
            {
                for (int j = 0; j < 2000; j++)
                { 
                    if (random.Next(0, 10) > 5)
                    {
                        ints[i,j] = alphabet[random.Next(0, alphabet.Length - 1)];
                    }
                    else
                    {
                        ints[i,j] = ' ';
                    }
                }
            }
            string[] resultMassive = new string[2000];            
            for (int i = 0; i < 2000; i++)
            {
                for (int j = 0; j < Console.WindowWidth; j++)
                {
                    resultMassive[i] += ints[j, i];                                      
                }               
                
            }
            while (Console.CursorTop < 2000)
            { 
                for (int i =0; i < Console.WindowHeight; i++)
                { 
                    for (int j =i; j >= 0; j--)
                    { 
                        Console.Write(resultMassive[j]);
                    }
                    Thread.Sleep(100);
                
                }
            }*/

            /*List<string> list = new List<string>();
            for (int i = 0; i < 1000; i++) 
            {
                list.Add(i.ToString());
            }
            list.Remove("995");
            list.RemoveAll(StartWithNine);

            string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };

            // создаем новый список для результатов
            var selectedPeople = from p in people // передаем каждый элемент из people в переменную p
                                 where p.ToUpper().StartsWith("T") //фильтрация по критерию
                                 orderby p  // упорядочиваем по возрастанию
                                 select p; // выбираем объект в создаваемую коллекцию

            foreach (string person in selectedPeople)
                Console.WriteLine(person);
            */

            /*StreamWriter sw = new StreamWriter(@"D:\\test.txt");
            sw.WriteLine("123123");            
            sw.Close();

            StreamReader sr = new StreamReader(@"D:\\test.txt");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();*/

            /*List<Human> listHumans = new List<Human>();
            XDocument xml = XDocument.Load(@"D:\\textxml.xml");
            // получаем корневой узел
            XElement humans = xml.Element("humans");
            if (humans != null)
            {
                foreach (XElement human in humans.Elements("human"))
                {                    
                    XElement path = human.Element("path");
                    XElement name = human.Element("name");
                    XElement age = human.Element("age");
                    XAttribute agevalue = age.Attribute("count");

                    listHumans.Add(new Human(Int32.Parse(agevalue.Value), name.Value, path.Value));
                    Console.WriteLine($"Name: {name.Value}");
                    Console.WriteLine($"Path: {path.Value}");
                    Console.WriteLine($"Age: {agevalue.Value}");

                    Console.WriteLine(); //  для разделения при выводе на консоль
                }
            }
            Console.WriteLine("Про кого вывести данные? Напишите имя человека");

            string PersonFile = Console.ReadLine();
            string pathFile = "";
            foreach (Human h in listHumans)
            {
                if (h.Name == PersonFile)
                {
                    pathFile = h.Path;
                }
            }

            StreamReader sr = new StreamReader(pathFile);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close(); */

            Console.ReadLine();
            
            


        }
        private static bool StartWithNine(String s)
        {
            return s.ToLower().StartsWith("9");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * List<>
             * Dictionary<>
             * Queue<>
             * Stack<>
             * SortedList<>
             */
             
            List<string> names = new List<string>{"Thor","Loki","Spiderman","Iron Man","Captain America"};
            
            var query = from name in names
                        where name.ToLower().Contains("i")
                        select new
                               {
                                   Name = name,
                                   FirstLetter = name.Substring(0,1),
                                   UpperCase = name.ToUpper()
                               };
            

            foreach (var hero in query)
            {
                Console.WriteLine(hero.UpperCase);
            }
        }

        private static void Dictionaries()
        {
            Dictionary<string, string> words = new Dictionary<string, string>();
            words.Add("cat", "An aloof feline that thinks it rules the world.");

            Dictionary<string, string> courses = new Dictionary<string, string>();
            courses.Add("CS101", "Introduction to programming.");
            courses.Add("CS201", "Intro to Web Development.");

            string course = "not found";
            if (courses.ContainsKey("CS202"))
            {
                course = courses["CS202"];
            }

            Console.WriteLine(course);

            Console.WriteLine();

            //loop through all the keys
            var keys = courses.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine("{0}: {1}", key, courses[key]);

                string message = $"{key}: {courses[key]}";
                Console.WriteLine(message);
            }

            //loop through each row (KeyValuePair)
            foreach (KeyValuePair<string, string> row in courses)
            {
                Console.WriteLine($"{row.Key}: {row.Value}");
            }
        }

        private static void Lists()
        {
            string[] name = new string[2] {"joe", "jane"};

            List<int> numbers = new List<int> {5, 67, 31, 10};

            List<string> names = new List<string>();
            names.Add("Joe");
            names.Add("Jane");
            names.Add("Joe");
            names.Add("Gregor");
            names.Add("Terry");

            while (names.Contains("Joe"))
            {
                names.Remove("Joe");
            }

            names.RemoveAt(1);
            names.TrimExcess();


            Console.WriteLine(names.Count);
            Console.WriteLine(names.Capacity);

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}

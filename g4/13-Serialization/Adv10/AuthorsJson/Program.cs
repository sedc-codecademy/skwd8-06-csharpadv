using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AuthorsJson
{
    class Program
    {
        static void Main(string[] args)
        {
            //var authors = new AuthorRepo().GetAuthors();

            //var top100 = authors.Take(100);

            //foreach (var author in top100)
            //{
            //    Console.WriteLine(author);
            //}

            //var top100json = JsonConvert.SerializeObject(top100, Formatting.Indented);
            //Console.WriteLine(top100json);

            //File.WriteAllText("top100.json", top100json);


            var authorsString = File.ReadAllText("top100.json");
            var authors = JsonConvert.DeserializeObject<List<Author>>(authorsString);

            var aauthors = authors.Where(a => a.Name.StartsWith('A'));
            foreach (var aauthor in aauthors)
            {
                Console.WriteLine(aauthor);
            }
        }
    }
}

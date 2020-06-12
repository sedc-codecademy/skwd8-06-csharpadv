using System;
using System.IO;
using System.Linq;
using System.Xml.XPath;

namespace TreeOfTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var weko = new Person { FirstName = "Wekoslav", LastName = "Stefanovski" };
            Console.WriteLine(weko.GetType().FullName);
            Console.WriteLine(weko);
            Console.WriteLine("------------");


            Tree myTree = new AppleTree();
            var result = myTree.GetSeedsMultiple(3);
            Console.WriteLine(string.Join("\n", result));

        }
    }
}

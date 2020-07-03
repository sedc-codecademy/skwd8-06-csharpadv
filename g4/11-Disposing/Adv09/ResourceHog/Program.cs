using System;

namespace ResourceHog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var res = new WithResource())
            {
                res.Open();
                Console.WriteLine(res.Resource);
            }
            // res.Close();
        }
    }
}

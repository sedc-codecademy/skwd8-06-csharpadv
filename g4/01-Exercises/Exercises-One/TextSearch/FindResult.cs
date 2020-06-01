using System.Collections.Generic;

namespace TextSearch
{
    public class FindResult
    {
        public int Count { get; set; }
        public IEnumerable<string> Values { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class Rootobject
    {
        public Test[]? tests { get; set; }
    }

    public class Test
    {
        public int id { get; set; }
        public string? title { get; set; }
        public string? value { get; set; }
        public Value[]? values { get; set; }
    }

    public class Value
    {
        public int id { get; set; }
        public string? title { get; set; }
        public string? value { get; set; }
        public Value[]? values { get; set; }
    }

}

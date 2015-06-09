using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoogleChartApi
{
    public class TextStyle
    {
        public string color;
        public bool bold;
        public bool italic;

        public TextStyle(string color = "black", bool bold = false, bool italic = false)
        {
            this.color = color;
            this.bold = bold;
            this.italic = italic;
        }
    }
}
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

        public TextStyle()
        {
            this.color = "black";
            this.bold = false;
            this.italic = false;
        }

        public TextStyle(string color)
        {
            this.color = color;
            this.bold = false;
            this.italic = false;
        }

        public TextStyle(string color, bool bold)
        {
            this.color = color;
            this.bold = bold;
            this.italic = false;
        }

        public TextStyle(string color,bool bold,bool italic)
        {
            this.color = color;
            this.bold = bold;
            this.italic = italic;
        }
    }
}
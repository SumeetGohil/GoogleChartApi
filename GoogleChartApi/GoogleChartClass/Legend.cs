using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoogleChartApi
{
    public class Legend
    {
        public string position;
        public TextStyle textStyle;

        public Legend(string position = "right", TextStyle textStyle = null)
        {
            this.position = position;
            this.textStyle = textStyle;
        }
    }
}
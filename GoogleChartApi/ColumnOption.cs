using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoogleChartApi
{
    public class ColumnOption
    {
        public string backgroundColor;
        public string curveType;
        public string title;
        public Legend legend;

        public ColumnOption(string backgroundColor = "white", string curveType = "none", string title = null, Legend legend = null)
        {
            this.backgroundColor = backgroundColor;
            this.curveType = curveType;
            this.title = title;
            this.legend = legend;
        }
    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace GoogleChartApi
{
    public class LineParam
    {
        public LineOption option;
        public List<object[]> chartData;
   
        public LineParam(List<object[]> chartData = null, LineOption option = null)
        {
            this.chartData = chartData;
            this.option = option;
        }

        public string toJSON()
        {

            return JsonConvert.SerializeObject(this);
        }

    }
}
﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace GoogleChartApi
{
    public class PieParam
    {
        public PieOption option;
        public List<object[]> chartData;

        public PieParam(List<object[]> chartData = null, PieOption option = null)
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
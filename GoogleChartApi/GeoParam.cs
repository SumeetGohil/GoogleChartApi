﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace GoogleChartApi
{
    public class GeoParam
    {
        public GeoOption option;
        public List<object[]> chartData;

        public GeoParam(List<object[]> chartData = null, GeoOption option = null)
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
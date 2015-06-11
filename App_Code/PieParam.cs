using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PieParam
/// </summary>
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
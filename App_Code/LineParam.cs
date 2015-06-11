using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LineParam
/// </summary>
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
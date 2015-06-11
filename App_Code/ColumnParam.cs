using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ColumnParam
/// </summary>
public class ColumnParam
{
    public ColumnOption option;
    public List<object[]> chartData;

    public ColumnParam(List<object[]> chartData = null, ColumnOption option = null)
    {
        this.chartData = chartData;
        this.option = option;
    }

    public string toJSON()
    {
        return JsonConvert.SerializeObject(this);
    }

}
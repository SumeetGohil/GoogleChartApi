using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LineOption
/// </summary>
public class LineOption
{
    public string backgroundColor;
    public string curveType;
    public string title;
    public Legend legend;

    public LineOption(string backgroundColor = "white", string curveType = "none", string title = null, Legend legend = null)
    {
        this.backgroundColor = backgroundColor;
        this.curveType = curveType;
        this.title = title;
        this.legend = legend;
    }
}
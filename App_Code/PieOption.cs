using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PieOption
/// </summary>
public class PieOption
{
    public string backgroundColor;
    public string curveType;
    public string title;
    public Legend legend;
    public bool is3D;

    public PieOption(string backgroundColor = "white", string curveType = "none", string title = null, Legend legend = null, bool is3D = false)
    {
        this.backgroundColor = backgroundColor;
        this.curveType = curveType;
        this.title = title;
        this.legend = legend;
        this.is3D = is3D;
    }
}
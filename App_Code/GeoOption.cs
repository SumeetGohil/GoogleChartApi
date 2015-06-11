using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GeoOption
/// </summary>
public class GeoOption
{
    public string backgroundColor;
    public string defaultColor;
    public string displayMode;
    public string domain;
    public string resolution;

    public GeoOption(string backgroundColor = "white", string defaultColor = "#267114", string displayMode = "auto", string domain = null, string resolution = "countries")
    {
        this.backgroundColor = backgroundColor;
        this.defaultColor = defaultColor;
        this.displayMode = displayMode;
        this.domain = domain;
        this.resolution = resolution;
    }
}
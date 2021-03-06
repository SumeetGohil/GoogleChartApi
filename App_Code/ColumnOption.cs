﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ColumnOption
/// </summary>
public class ColumnOption
{
    public string backgroundColor;
    public string title;
    public Legend legend;

    public ColumnOption(string backgroundColor = "white", string title = null, Legend legend = null)
    {
        this.backgroundColor = backgroundColor;
        this.title = title;
        this.legend = legend;
    }
}
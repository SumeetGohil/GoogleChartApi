using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GoogleChartApi
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClientScript.RegisterClientScriptInclude("googleJSAPI", ClientScript.GetWebResourceUrl(typeof(Default), "GoogleChartApi.Resources.jsapi.js"));
            ClientScript.RegisterClientScriptInclude("googleChart", ClientScript.GetWebResourceUrl(typeof(Default), "GoogleChartApi.Resources.google-chart-api.js"));

            List<object[]> _list = new List<object[]>();

            _list.Add(new object[] { "Country", "Popularity" });
            _list.Add(new object[] { "India", 200 });
            _list.Add(new object[] { "United States", 0 });
            _list.Add(new object[] { "Brazil", 400 });
            _list.Add(new object[] { "Canada", 500 });
            _list.Add(new object[] { "France", 600 });
            _list.Add(new object[] { "RU", 700 });

            // GEO Chart
            GoogleChartGeo.GeoData = new GeoParam(_list);

            // Line Chart
            LineOption lineOption = new LineOption();
            lineOption.curveType = "function";
            lineOption.legend = new Legend();
            lineOption.legend.position = "top";
            GoogleChartLine.LineData = new LineParam(_list,lineOption);

            // Pie Chart
            GoogleChartPie.PieData = new PieParam(_list);

            // Column Chart
            ColumnOption columnOption = new ColumnOption();
            columnOption.legend = new Legend("top");
            GoogleChartColumn.ColumnData = new ColumnParam(_list, columnOption);

        }
    }
}
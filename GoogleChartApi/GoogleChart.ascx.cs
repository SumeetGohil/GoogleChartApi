using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

[assembly: TagPrefix("GoogleChartApi", "gca")]
[assembly: WebResource("GoogleChartApi.Resources.jsapi.js", "text/javascript", PerformSubstitution = true)]
[assembly: WebResource("GoogleChartApi.Resources.google-chart-api.js", "text/javascript", PerformSubstitution = true)]
namespace GoogleChartApi
{    
    [ToolboxData("<{0}:GoogleChartApi runat=\"server\"></{0}:GoogleChartApi>")]
    public partial class GoogleChart : System.Web.UI.UserControl
    {
        public enum GoogleChartType { GEO, LINE, COLUMN, PIE };       
        public GoogleChartType ChartType { get; set; }

        public GeoParam GeoData { get; set; }
        public LineParam LineData { get; set; }
        public PieParam PieData { get; set; }
        public ColumnParam ColumnData { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            string functionCode = "";

            switch (this.ChartType)
            {
                case GoogleChartType.GEO:
                    functionCode = " addFunction(function(){createGeo(" + this.GeoData.toJSON() + ",'" + this.ChartContainer.ClientID + "');});";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "create_geo_graph" + this.ChartContainer.ClientID, functionCode, true);
                    break;
                case GoogleChartType.LINE:
                    functionCode = " addFunction(function(){createLine(" + this.LineData.toJSON() + ",'" + this.ChartContainer.ClientID + "');});";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "create_line_graph" + this.ChartContainer.ClientID, functionCode, true);
                    break;
                case GoogleChartType.COLUMN:
                    functionCode = " addFunction(function(){createColumn(" + this.ColumnData.toJSON() + ",'" + this.ChartContainer.ClientID + "');});";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "create_column_graph" + this.ChartContainer.ClientID, functionCode, true);
                    break;
                case GoogleChartType.PIE:
                    functionCode = " addFunction(function(){createPie(" + this.PieData.toJSON() + ",'" + this.ChartContainer.ClientID + "');});";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "create_pie_graph" + this.ChartContainer.ClientID, functionCode, true);
                    break;
                default:
                    break;
            }            
        }
    }
}
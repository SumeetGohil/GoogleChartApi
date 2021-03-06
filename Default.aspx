﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register Src="~/GoogleChart.ascx" TagPrefix="asp" TagName="GoogleChart" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Google Chart API</title>
    <script type="text/javascript" src="https://www.google.com/jsapi"></script>
    <script src="google_chart_api.js"></script>
</head>
<body>
    <form id="form1" runat="server">
         <div style="width:35%;margin:auto;">
            <div>
                <h1>Google Geo Chart Demo</h1>
                <asp:GoogleChart runat="server" ID="GoogleChartGeo" ChartType="GEO" />
            </div>
            <div>
                <h1>Google Line Chart Demo</h1>
                <asp:GoogleChart runat="server" ID="GoogleChartLine" ChartType="LINE" />
            </div>
            <div>
                <h1>Google Column Chart Demo</h1>
                <asp:GoogleChart runat="server" ID="GoogleChartColumn" ChartType="COLUMN" />
            </div>
            <div>
                <h1>Google Pie Chart Demo</h1>
                <asp:GoogleChart runat="server" ID="GoogleChartPie" ChartType="PIE" />
            </div>
        </div>
    </form>
</body>
</html>

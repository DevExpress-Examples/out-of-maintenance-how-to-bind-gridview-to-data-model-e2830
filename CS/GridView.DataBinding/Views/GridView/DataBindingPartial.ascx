<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

<%
    Html.DevExpress().GridView( settings => {
        settings.Name = "dxGridView";
        settings.CallbackRouteValues = new { controller = "GridView", Action = "DataBindingPartial" };
    })
    .Bind(Model)
    .Render();
%>


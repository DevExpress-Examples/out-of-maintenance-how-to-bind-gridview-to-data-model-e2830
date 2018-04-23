<%@ Control Language="vb" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

<%
	Html.DevExpress().GridView(Function(settings) AnonymousMethod1(settings)).Bind(Model).Render()
%>



private bool AnonymousMethod1(object settings)
{
	settings.Name = "dxGridView";
	settings.CallbackRouteValues = New { controller = "GridView", Action = "DataBindingPartial" };
	Return True;
}
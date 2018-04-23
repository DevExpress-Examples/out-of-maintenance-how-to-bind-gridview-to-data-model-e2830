Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports GridView.DataBinding.Models

Namespace GridView.DataBinding.Controllers
	<HandleError> _
	Public Class GridViewController
		Inherits Controller
		Public Function Index() As ActionResult
			Return DataBinding()
		End Function
		Public Function DataBinding() As ActionResult
			Return View("DataBinding", NorthwindDataProvider.GetProducts())
		End Function
		Public Function DataBindingPartial() As ActionResult
			Return PartialView("DataBindingPartial", NorthwindDataProvider.GetProducts())
		End Function
	End Class
End Namespace

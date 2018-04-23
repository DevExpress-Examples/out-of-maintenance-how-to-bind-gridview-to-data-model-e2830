Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Collections

Namespace GridView.DataBinding.Models
	Public NotInheritable Class NorthwindDataProvider
		Private Shared db_Renamed As NorthwindDataContext
		Private Sub New()
		End Sub
		Public Shared ReadOnly Property DB() As NorthwindDataContext
			Get
				If db_Renamed Is Nothing Then
					db_Renamed = New NorthwindDataContext()
				End If
				Return db_Renamed
			End Get
		End Property
		Public Shared Function GetProducts() As IEnumerable
			Return _
				From product In DB.Products _
				Select product
		End Function
	End Class
End Namespace
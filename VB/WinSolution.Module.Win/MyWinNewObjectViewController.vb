Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Win.SystemModule

Namespace WinSolution.Module.Win
	Public Class MyWinNewObjectViewController
		Inherits WinNewObjectViewController
		Protected Overrides Sub OnAfterConstruction()
			MyBase.OnAfterConstruction()
		End Sub
		Protected Overrides Sub OnActivated()
			MyBase.OnActivated()
			If View.ObjectTypeInfo.Type Is GetType(DomainObject1) Then
				Me.NewObjectAction.Caption = "Add"
			End If
		End Sub
		Protected Overrides Sub OnDeactivating()
			MyBase.OnDeactivating()
			If View.ObjectTypeInfo.Type Is GetType(DomainObject1) Then
				Me.NewObjectAction.Caption = "New"
			End If
		End Sub
	End Class
End Namespace

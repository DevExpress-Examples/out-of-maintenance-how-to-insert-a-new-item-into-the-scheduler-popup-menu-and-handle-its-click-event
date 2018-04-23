Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub schedulerControl1_PreparePopupMenu(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PreparePopupMenuEventArgs) Handles schedulerControl1.PreparePopupMenu
			If e.Menu.Id = DevExpress.XtraScheduler.SchedulerMenuItemId.DefaultMenu Then
				e.Menu.Items.Add(New SchedulerMenuItem("test", AddressOf MyClickHandler))
			End If
		End Sub
		Public Sub MyClickHandler(ByVal sender As Object, ByVal e As EventArgs)
			MessageBox.Show("Test")
		End Sub
	End Class
End Namespace
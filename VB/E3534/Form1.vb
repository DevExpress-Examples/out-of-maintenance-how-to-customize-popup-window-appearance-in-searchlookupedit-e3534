Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraLayout
Imports DevExpress.Utils.Win

Namespace E3534
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub searchLookUpEdit1_Popup(ByVal sender As Object, ByVal e As EventArgs) Handles searchLookUpEdit1.Popup
			Dim window As Control = (TryCast(sender, IPopupControl)).PopupWindow
			'Direct reference to the LayoutControl. It could be changed in future versions.
			'LayoutControl lc = (sender as IPopupControl).PopupWindow.Controls[2].Controls[0] as LayoutControl;
			Dim lc As LayoutControl = SearchForLayout(window)
			Dim lcgroup As LayoutControlGroup = TryCast(lc.Items(0), LayoutControlGroup)
			lcgroup.AppearanceGroup.BackColor = Color.CadetBlue
		End Sub

		Private Function SearchForLayout(ByVal container As Control) As LayoutControl
			For Each control As Control In container.Controls
				If TypeOf control Is LayoutControl Then
					Return TryCast(control, LayoutControl)
				End If
				Dim lc As LayoutControl = SearchForLayout(control)
				If lc IsNot Nothing Then
					Return lc
				End If
			Next control
			Return Nothing
		End Function
	End Class
End Namespace
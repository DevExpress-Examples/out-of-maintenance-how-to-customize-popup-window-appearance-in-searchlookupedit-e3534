Imports Microsoft.VisualBasic
Imports System
Namespace E3534
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.searchLookUpEdit1 = New DevExpress.XtraEditors.SearchLookUpEdit()
			Me.searchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
			CType(Me.searchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.searchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' searchLookUpEdit1
			' 
			Me.searchLookUpEdit1.Location = New System.Drawing.Point(13, 13)
			Me.searchLookUpEdit1.Name = "searchLookUpEdit1"
			Me.searchLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.searchLookUpEdit1.Properties.View = Me.searchLookUpEdit1View
			Me.searchLookUpEdit1.Size = New System.Drawing.Size(173, 20)
			Me.searchLookUpEdit1.TabIndex = 0
'			Me.searchLookUpEdit1.Popup += New System.EventHandler(Me.searchLookUpEdit1_Popup);
			' 
			' searchLookUpEdit1View
			' 
			Me.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
			Me.searchLookUpEdit1View.Name = "searchLookUpEdit1View"
			Me.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
			Me.searchLookUpEdit1View.OptionsView.ShowGroupPanel = False
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 262)
			Me.Controls.Add(Me.searchLookUpEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.searchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.searchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents searchLookUpEdit1 As DevExpress.XtraEditors.SearchLookUpEdit
		Private searchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
	End Class
End Namespace


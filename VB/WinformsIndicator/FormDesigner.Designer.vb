Imports DevExpress.DashboardCommon.Native
Imports DevExpress.DashboardWin

Namespace WinForm
	Partial Public Class FormDesigner
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
			Me.components = New System.ComponentModel.Container()
			Me.dashboardDesigner = New DevExpress.DashboardWin.DashboardDesigner()
			CType(Me.dashboardDesigner, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dashboardViewer
			' 
			Me.dashboardDesigner.Dashboard = New Dashboard1()
			Me.dashboardDesigner.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dashboardDesigner.Location = New System.Drawing.Point(0, 0)
			Me.dashboardDesigner.Name = "dashboardViewer"
			Me.dashboardDesigner.Size = New System.Drawing.Size(800, 450)
			Me.dashboardDesigner.TabIndex = 0
			'this.dashboardViewer.CustomDashboardItemControlCreating += DashboardViewer_CustomDashboardItemControlCreating;
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(9F, 20F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(800, 450)
			Me.Controls.Add(Me.dashboardDesigner)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.dashboardDesigner, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		Private dashboardDesigner As DashboardDesigner

		#End Region
	End Class
End Namespace


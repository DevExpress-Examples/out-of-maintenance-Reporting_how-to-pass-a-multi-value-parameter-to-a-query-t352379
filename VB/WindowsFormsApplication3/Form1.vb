Imports DevExpress.XtraReports.UI
Imports System
Imports System.Windows.Forms

Namespace WindowsFormsApplication3
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            Dim pt As New ReportPrintTool(New XtraReport1())
            pt.ShowPreviewDialog()
        End Sub
    End Class
End Namespace

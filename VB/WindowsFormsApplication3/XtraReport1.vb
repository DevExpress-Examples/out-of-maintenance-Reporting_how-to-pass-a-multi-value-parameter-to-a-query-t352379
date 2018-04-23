Imports DevExpress.DataAccess.Sql
Imports System
Imports System.Collections
Imports System.Text
' ...

Namespace WindowsFormsApplication3
    Partial Public Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()

            ' Assign a set of values to the report parameter.
            Me.parameter1.Value = New Integer() { 1, 2, 3 }

            ' Handle the DataSourceDemanded event of a report.
            AddHandler Me.DataSourceDemanded, AddressOf XtraReport1_DataSourceDemanded
        End Sub

        Private Sub XtraReport1_DataSourceDemanded(ByVal sender As Object, ByVal e As EventArgs)
            Dim query As CustomSqlQuery = TryCast(Me.sqlDataSource1.Queries(0), CustomSqlQuery)
            Dim count As Integer = (TryCast(Me.parameter1.Value, IList)).Count
            If count = 0 Then
                Return
            End If
            Dim builder As New StringBuilder()
            builder.Append("("c)
            For i As Integer = 0 To count - 1
                'builder.Append('\''); // Uncomment this line when parsing a string parameter value.
                builder.Append((TryCast(Me.parameter1.Value, IList))(i))
                'builder.Append('\''); // Uncomment this line when parsing a string parameter value.
                If i <> count - 1 Then
                    builder.Append(","c)
                End If
            Next i

            builder.Append(")"c)
            query.Sql &= " WHERE [Categories].[CategoryID] IN " & builder.ToString()
            sqlDataSource1.RebuildResultSchema()
        End Sub
    End Class
End Namespace



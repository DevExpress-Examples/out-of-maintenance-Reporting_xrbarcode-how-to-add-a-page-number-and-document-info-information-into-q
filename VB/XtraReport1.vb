Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace BarcodeWithPageInfo
    Partial Public Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub xrBarCode1_PrintOnPage(ByVal sender As Object, ByVal e As PrintOnPageEventArgs) Handles xrBarCode1.PrintOnPage
            Dim s As String = "Product Report, Page: " & (e.PageIndex + 1).ToString() & " - Category :" & DirectCast(sender, XRControl).Tag.ToString()
            DirectCast(sender, XRBarCode).BinaryData = GetBytes(s)
        End Sub
        Private Shared Function GetBytes(ByVal str As String) As Byte()
            Dim bytes((str.Length * Len(New Char)) - 1) As Byte
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length)
            Return bytes
        End Function

    End Class
End Namespace

Namespace BarcodeWithPageInfo
    Partial Public Class XtraReport1
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

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim msSqlConnectionParameters1 As New DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters()
            Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim relationInfo1 As New DevExpress.DataAccess.Sql.RelationInfo()
            Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim tableInfo2 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo4 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo5 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo6 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo7 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo8 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
            Dim qrCodeGenerator1 As New DevExpress.XtraPrinting.BarCode.QRCodeGenerator()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
            Me.pageHeaderBand1 = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine()
            Me.groupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
            Me.pageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.reportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine()
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.xrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel7, Me.xrLabel8, Me.xrLabel9, Me.xrLabel10})
            Me.Detail.HeightF = 23F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.StyleName = "DataField"
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "local.Northwind.dbo"
            msSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows
            msSqlConnectionParameters1.DatabaseName = "Northwind"
            msSqlConnectionParameters1.Password = Nothing
            msSqlConnectionParameters1.ServerName = "(local)"
            msSqlConnectionParameters1.UserName = Nothing
            Me.sqlDataSource1.ConnectionParameters = msSqlConnectionParameters1
            tableQuery1.Name = "Categories"
            relationColumnInfo1.NestedKeyColumn = "CategoryID"
            relationColumnInfo1.ParentKeyColumn = "CategoryID"
            relationInfo1.KeyColumns.AddRange(New DevExpress.DataAccess.Sql.RelationColumnInfo() { relationColumnInfo1})
            relationInfo1.NestedTable = "Products"
            relationInfo1.ParentTable = "Categories"
            tableQuery1.Relations.AddRange(New DevExpress.DataAccess.Sql.RelationInfo() { relationInfo1})
            tableInfo1.Name = "Categories"
            columnInfo1.Alias = "Categories_CategoryID"
            columnInfo1.Name = "CategoryID"
            columnInfo2.Name = "CategoryName"
            columnInfo3.Name = "Description"
            tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3})
            tableInfo2.Name = "Products"
            columnInfo4.Name = "ProductName"
            columnInfo5.Name = "CategoryID"
            columnInfo6.Name = "QuantityPerUnit"
            columnInfo7.Name = "UnitPrice"
            columnInfo8.Name = "UnitsInStock"
            tableInfo2.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo4, columnInfo5, columnInfo6, columnInfo7, columnInfo8})
            tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1, tableInfo2})
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' pageHeaderBand1
            ' 
            Me.pageHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrLabel3, Me.xrLabel4, Me.xrLabel5, Me.xrLine1, Me.xrLine2})
            Me.pageHeaderBand1.HeightF = 44F
            Me.pageHeaderBand1.Name = "pageHeaderBand1"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(32.89875F, 5.999998F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(240.4039F, 36F)
            Me.xrLabel2.StyleName = "FieldCaption"
            Me.xrLabel2.Text = "Product Name"
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(273.3027F, 6F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(154.4376F, 36F)
            Me.xrLabel3.StyleName = "FieldCaption"
            Me.xrLabel3.Text = "Quantity Per Unit"
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(427.7403F, 6F)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(90.30675F, 36F)
            Me.xrLabel4.StyleName = "FieldCaption"
            Me.xrLabel4.Text = "Unit Price"
            ' 
            ' xrLabel5
            ' 
            Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(518.0471F, 6F)
            Me.xrLabel5.Name = "xrLabel5"
            Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel5.SizeF = New System.Drawing.SizeF(126.9529F, 36F)
            Me.xrLabel5.StyleName = "FieldCaption"
            Me.xrLabel5.Text = "Units In Stock"
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(32.89876F, 4.000002F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.SizeF = New System.Drawing.SizeF(612.1013F, 2F)
            ' 
            ' xrLine2
            ' 
            Me.xrLine2.LocationFloat = New DevExpress.Utils.PointFloat(32.89875F, 42F)
            Me.xrLine2.Name = "xrLine2"
            Me.xrLine2.SizeF = New System.Drawing.SizeF(612.1013F, 2F)
            ' 
            ' groupHeaderBand1
            ' 
            Me.groupHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel6, Me.xrBarCode1})
            Me.groupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.groupHeaderBand1.HeightF = 142.5F
            Me.groupHeaderBand1.Name = "groupHeaderBand1"
            Me.groupHeaderBand1.StyleName = "DataField"
            ' 
            ' xrLabel6
            ' 
            Me.xrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
            Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel6.Name = "xrLabel6"
            Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel6.SizeF = New System.Drawing.SizeF(262.5F, 23F)
            Me.xrLabel6.Text = "xrLabel6"
            ' 
            ' xrLabel7
            ' 
            Me.xrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.ProductName")})
            Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(32.89876F, 0F)
            Me.xrLabel7.Name = "xrLabel7"
            Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 120F)
            Me.xrLabel7.SizeF = New System.Drawing.SizeF(240.4039F, 18F)
            Me.xrLabel7.Text = "xrLabel7"
            ' 
            ' xrLabel8
            ' 
            Me.xrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.QuantityPerUnit")})
            Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(273.3027F, 0F)
            Me.xrLabel8.Name = "xrLabel8"
            Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 120F)
            Me.xrLabel8.SizeF = New System.Drawing.SizeF(154.4376F, 18F)
            Me.xrLabel8.Text = "xrLabel8"
            ' 
            ' xrLabel9
            ' 
            Me.xrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.UnitPrice", "{0:C2}")})
            Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(427.7403F, 0F)
            Me.xrLabel9.Name = "xrLabel9"
            Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 120F)
            Me.xrLabel9.SizeF = New System.Drawing.SizeF(90.30675F, 18F)
            Me.xrLabel9.Text = "xrLabel9"
            ' 
            ' xrLabel10
            ' 
            Me.xrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.UnitsInStock")})
            Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(518.0471F, 0F)
            Me.xrLabel10.Name = "xrLabel10"
            Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 120F)
            Me.xrLabel10.SizeF = New System.Drawing.SizeF(126.9529F, 18F)
            Me.xrLabel10.Text = "xrLabel10"
            ' 
            ' pageFooterBand1
            ' 
            Me.pageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1, Me.xrPageInfo2})
            Me.pageFooterBand1.HeightF = 28F
            Me.pageFooterBand1.Name = "pageFooterBand1"
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(5F, 5F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(315F, 23F)
            Me.xrPageInfo1.StyleName = "PageInfo"
            ' 
            ' xrPageInfo2
            ' 
            Me.xrPageInfo2.Format = "Page {0} of {1}"
            Me.xrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(330F, 5F)
            Me.xrPageInfo2.Name = "xrPageInfo2"
            Me.xrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo2.SizeF = New System.Drawing.SizeF(315F, 23F)
            Me.xrPageInfo2.StyleName = "PageInfo"
            Me.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' reportHeaderBand1
            ' 
            Me.reportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel11, Me.xrLine3})
            Me.reportHeaderBand1.HeightF = 48F
            Me.reportHeaderBand1.Name = "reportHeaderBand1"
            ' 
            ' xrLabel11
            ' 
            Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(5F, 2F)
            Me.xrLabel11.Name = "xrLabel11"
            Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel11.SizeF = New System.Drawing.SizeF(640F, 33F)
            Me.xrLabel11.StyleName = "Title"
            Me.xrLabel11.Text = "Products"
            ' 
            ' xrLine3
            ' 
            Me.xrLine3.LocationFloat = New DevExpress.Utils.PointFloat(5F, 0F)
            Me.xrLine3.Name = "xrLine3"
            Me.xrLine3.SizeF = New System.Drawing.SizeF(640F, 2F)
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold)
            Me.Title.ForeColor = System.Drawing.Color.Maroon
            Me.Title.Name = "Title"
            ' 
            ' FieldCaption
            ' 
            Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
            Me.FieldCaption.BorderColor = System.Drawing.Color.Black
            Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.FieldCaption.BorderWidth = 1F
            Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold)
            Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
            Me.FieldCaption.Name = "FieldCaption"
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.BackColor = System.Drawing.Color.Transparent
            Me.PageInfo.BorderColor = System.Drawing.Color.Black
            Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.PageInfo.BorderWidth = 1F
            Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.Black
            Me.PageInfo.Name = "PageInfo"
            ' 
            ' DataField
            ' 
            Me.DataField.BackColor = System.Drawing.Color.Transparent
            Me.DataField.BorderColor = System.Drawing.Color.Black
            Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DataField.BorderWidth = 1F
            Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10F)
            Me.DataField.ForeColor = System.Drawing.Color.Black
            Me.DataField.Name = "DataField"
            Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' GroupFooter1
            ' 
            Me.GroupFooter1.HeightF = 0F
            Me.GroupFooter1.Name = "GroupFooter1"
            Me.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            ' 
            ' xrBarCode1
            ' 
            Me.xrBarCode1.AutoModule = True
            Me.xrBarCode1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Tag", Nothing, "Categories.Description")})
            Me.xrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(262.5F, 0F)
            Me.xrBarCode1.Name = "xrBarCode1"
            Me.xrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F)
            Me.xrBarCode1.SizeF = New System.Drawing.SizeF(230F, 142.5F)
            qrCodeGenerator1.CompactionMode = DevExpress.XtraPrinting.BarCode.QRCodeCompactionMode.Byte
            qrCodeGenerator1.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1
            Me.xrBarCode1.Symbology = qrCodeGenerator1
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.pageHeaderBand1, Me.groupHeaderBand1, Me.pageFooterBand1, Me.reportHeaderBand1, Me.GroupFooter1})
            Me.DataMember = "Categories"
            Me.DataSource = Me.sqlDataSource1
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
            Me.Version = "14.1"
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel10 As DevExpress.XtraReports.UI.XRLabel
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private pageHeaderBand1 As DevExpress.XtraReports.UI.PageHeaderBand
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
        Private xrLine1 As DevExpress.XtraReports.UI.XRLine
        Private xrLine2 As DevExpress.XtraReports.UI.XRLine
        Private groupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
        Private pageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
        Private xrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
        Private reportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
        Private xrLabel11 As DevExpress.XtraReports.UI.XRLabel
        Private xrLine3 As DevExpress.XtraReports.UI.XRLine
        Private Title As DevExpress.XtraReports.UI.XRControlStyle
        Private FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
        Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
        Private DataField As DevExpress.XtraReports.UI.XRControlStyle
        Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
        Private WithEvents xrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    End Class
End Namespace

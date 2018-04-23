using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BarcodeWithPageInfo
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }

        private void xrBarCode1_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            string s = "Product Report, Page: " + (e.PageIndex + 1).ToString() + " - Category :" + ((XRControl)sender).Tag.ToString();
            ((XRBarCode)sender).BinaryData = GetBytes(s);
        }
        static byte[] GetBytes(string str) {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

    }
}

using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace WindowsFormsApplication3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            ReportPrintTool pt = new ReportPrintTool(new XtraReport1());
            pt.ShowPreviewDialog();
        }
    }
}

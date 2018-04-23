using DevExpress.DataAccess.Sql;
using System;
using System.Collections;
using System.Text;
// ...

namespace WindowsFormsApplication3 {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();

            // Assign a set of values to the report parameter.
            this.parameter1.Value = new int[] { 1, 2, 3 };

            // Handle the DataSourceDemanded event of a report.
            this.DataSourceDemanded += XtraReport1_DataSourceDemanded;
        }

        void XtraReport1_DataSourceDemanded(object sender, EventArgs e) {
            CustomSqlQuery query = this.sqlDataSource1.Queries[0] as CustomSqlQuery;
            int count = (this.parameter1.Value as IList).Count;
            if (count == 0)
                return;
            StringBuilder builder = new StringBuilder();
            builder.Append('(');
            for (int i = 0; i < count; i++) {
                //builder.Append('\''); // Uncomment this line when parsing a string parameter value.
                builder.Append((this.parameter1.Value as IList)[i]);
                //builder.Append('\''); // Uncomment this line when parsing a string parameter value.
                if (i != count - 1)
                    builder.Append(',');
            }

            builder.Append(')');
            query.Sql += " WHERE [Categories].[CategoryID] IN " + builder.ToString();
            sqlDataSource1.RebuildResultSchema();
        }
    }
}



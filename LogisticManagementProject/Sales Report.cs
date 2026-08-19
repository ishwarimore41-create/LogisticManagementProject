using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LogisticManagementProject
{
    public partial class Sales_Report : Form
    {
        public Sales_Report()
        {
            InitializeComponent();
        }
        string query;
        public DataSet populate(string query)
        {
            OleDbConnection Con = getCon();
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = query;
            OleDbDataAdapter da = new OleDbDataAdapter(Cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        protected OleDbConnection getCon()
        {
            OleDbConnection Con = new OleDbConnection();
            Con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C: \Users\Ishwari\source\repos\LogisticManagementProject\LogisticManagementProject\Logistic Management.accdb""";
            return Con;
        }

        private void Sales_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logistic_ManagementDataSet11.SALES' table. You can move, or remove it, as needed.
            this.sALESTableAdapter.Fill(this.logistic_ManagementDataSet11.SALES);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into SALES_Report values('" + ProductID.Text +"','" + Productname.Text + "','"+ Quantity.Text + "')";
                OleDbConnection Con = getCon();
                OleDbCommand Cmd = new OleDbCommand();
                Cmd.Connection = Con;
                Con.Open();
                Cmd.CommandText = query;
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Data Added successfully.");
                Con.Close();
                query = "select * from SALES;";
                var ds = populate(query);

                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

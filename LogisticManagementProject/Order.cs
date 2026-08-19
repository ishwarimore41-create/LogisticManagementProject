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
    public partial class Order : Form
    {
        public Order()
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

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logistic_ManagementDataSet10.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.logistic_ManagementDataSet10.Order);

        }
        
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into Order values('" + OrderID.Text +"','" + Employeename.Text + "','" + Productname.Text + "','"+ Shippingaddress.Text + "', '" + Quantiy.Text +"')";
                OleDbConnection Con = getCon();
                OleDbCommand Cmd = new OleDbCommand();
                Cmd.Connection = Con;
                Con.Open();
                Cmd.CommandText = query;
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Data Added successfully.");
                Con.Close();
                query = "select * from Order;";

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

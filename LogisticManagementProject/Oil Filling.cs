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
    public partial class Oil_Filling : Form
    {
        public Oil_Filling()
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

        private void Oil_Filling_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logistic_ManagementDataSet9.Oilfilling' table. You can move, or remove it, as needed.
            this.oilfillingTableAdapter.Fill(this.logistic_ManagementDataSet9.Oilfilling);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into Oil_Filling values('"+ Vehiclemodel.Text +"','" + Vehicletype.Text + "','" + Vehicleno.Text + "','" + Enginetype.Text + "', '" + Containercapacity.Text + "')";
                OleDbConnection Con = getCon();
                OleDbCommand Cmd = new OleDbCommand();
                Cmd.Connection = Con;
                Con.Open();
                Cmd.CommandText = query;
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Data Added successfully.");
                Con.Close();
                query = "select * from Oil_Filling;";
                var ds = populate(query);

                dataGridView1.DataSource = ds.Tables[0];

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

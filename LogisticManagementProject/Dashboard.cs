using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticManagementProject
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private Employee emp;
        private Warehouse war;
        private Order ord;
        private Inventory2 inv2;
        private Shipment ship;

        private Sales_Report sal;
        private Oil_Filling oil;
        private Supplier sup;
        private Carrior car;
        private Trip trip;
        private Vehicle_Tracking veh;
        private Invoice inv;

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Click(object sender, EventArgs e)
        {
            
            emp = new Employee();
            emp.Show();

            
        }

        private void Warehouse_Click(object sender, EventArgs e)
        {
            
            war = new Warehouse();
            war.Show();
        }

        private void Order_Click(object sender, EventArgs e)
        {
            ord = new Order();
            ord.Show();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            inv2 = new Inventory2();
            inv2.Show();
        }

        private void Shipment_Click(object sender, EventArgs e)
        {
            ship = new Shipment();
            ship.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void SalesReport_Click(object sender, EventArgs e)
        {
            sal = new Sales_Report();
            sal.Show();
        }

        private void Oilfilling_Click(object sender, EventArgs e)
        {
            oil = new Oil_Filling();
            oil.Show();
        }

        private void Supplier_Click(object sender, EventArgs e)
        {
            sup = new Supplier();
            sup.Show();

        }

        private void Carrior_Click(object sender, EventArgs e)
        {
            car = new Carrior();
            car.Show();
        }

        private void Trip_Click(object sender, EventArgs e)
        {
            trip = new Trip();
            trip.Show();


        }

        private void Vehicletracking_Click(object sender, EventArgs e)
        {
            veh = new Vehicle_Tracking();
            veh.Show();
        }

        private void Invoice_Click(object sender, EventArgs e)
        {
            inv = new Invoice();
            inv.Show();
        }
    }
}

namespace LogisticManagementProject
{
    partial class Vehicle_Tracking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OK = new System.Windows.Forms.Button();
            this.Deliverydate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Orderdate = new System.Windows.Forms.TextBox();
            this.Cityname = new System.Windows.Forms.TextBox();
            this.Vehicletype = new System.Windows.Forms.TextBox();
            this.Vehicleuser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehicleUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTrackingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.logistic_ManagementDataSet20 = new LogisticManagementProject.Logistic_ManagementDataSet20();
            this.vehicleTrackingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logistic_ManagementDataSet14 = new LogisticManagementProject.Logistic_ManagementDataSet14();
            this.vehicleTrackingTableAdapter = new LogisticManagementProject.Logistic_ManagementDataSet14TableAdapters.VehicleTrackingTableAdapter();
            this.vehicleTrackingTableAdapter1 = new LogisticManagementProject.Logistic_ManagementDataSet20TableAdapters.VehicleTrackingTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTrackingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logistic_ManagementDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTrackingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logistic_ManagementDataSet14)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Red;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.ForeColor = System.Drawing.Color.Black;
            this.OK.Location = new System.Drawing.Point(432, 542);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(109, 44);
            this.OK.TabIndex = 45;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Deliverydate
            // 
            this.Deliverydate.Location = new System.Drawing.Point(349, 335);
            this.Deliverydate.Name = "Deliverydate";
            this.Deliverydate.Size = new System.Drawing.Size(265, 22);
            this.Deliverydate.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(143, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Delivery Date";
            // 
            // Orderdate
            // 
            this.Orderdate.Location = new System.Drawing.Point(349, 288);
            this.Orderdate.Name = "Orderdate";
            this.Orderdate.Size = new System.Drawing.Size(265, 22);
            this.Orderdate.TabIndex = 42;
            // 
            // Cityname
            // 
            this.Cityname.Location = new System.Drawing.Point(349, 232);
            this.Cityname.Name = "Cityname";
            this.Cityname.Size = new System.Drawing.Size(265, 22);
            this.Cityname.TabIndex = 41;
            // 
            // Vehicletype
            // 
            this.Vehicletype.Location = new System.Drawing.Point(349, 183);
            this.Vehicletype.Name = "Vehicletype";
            this.Vehicletype.Size = new System.Drawing.Size(265, 22);
            this.Vehicletype.TabIndex = 40;
            // 
            // Vehicleuser
            // 
            this.Vehicleuser.Location = new System.Drawing.Point(349, 124);
            this.Vehicleuser.Name = "Vehicleuser";
            this.Vehicleuser.Size = new System.Drawing.Size(265, 22);
            this.Vehicleuser.TabIndex = 39;
            this.Vehicleuser.TextChanged += new System.EventHandler(this.Vehicleuser_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Oder Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "City name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "Vehicle type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Vehicle User";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 83);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Tracking";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleUserDataGridViewTextBoxColumn,
            this.vehicleTypeDataGridViewTextBoxColumn,
            this.cityNameDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vehicleTrackingBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 386);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vehicleUserDataGridViewTextBoxColumn
            // 
            this.vehicleUserDataGridViewTextBoxColumn.DataPropertyName = "VehicleUser";
            this.vehicleUserDataGridViewTextBoxColumn.HeaderText = "VehicleUser";
            this.vehicleUserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleUserDataGridViewTextBoxColumn.Name = "vehicleUserDataGridViewTextBoxColumn";
            this.vehicleUserDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            this.vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.HeaderText = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            this.vehicleTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityNameDataGridViewTextBoxColumn
            // 
            this.cityNameDataGridViewTextBoxColumn.DataPropertyName = "City Name";
            this.cityNameDataGridViewTextBoxColumn.HeaderText = "City Name";
            this.cityNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityNameDataGridViewTextBoxColumn.Name = "cityNameDataGridViewTextBoxColumn";
            this.cityNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicleTrackingBindingSource1
            // 
            this.vehicleTrackingBindingSource1.DataMember = "VehicleTracking";
            this.vehicleTrackingBindingSource1.DataSource = this.logistic_ManagementDataSet20;
            // 
            // logistic_ManagementDataSet20
            // 
            this.logistic_ManagementDataSet20.DataSetName = "Logistic_ManagementDataSet20";
            this.logistic_ManagementDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleTrackingBindingSource
            // 
            this.vehicleTrackingBindingSource.DataMember = "VehicleTracking";
            this.vehicleTrackingBindingSource.DataSource = this.logistic_ManagementDataSet14;
            // 
            // logistic_ManagementDataSet14
            // 
            this.logistic_ManagementDataSet14.DataSetName = "Logistic_ManagementDataSet14";
            this.logistic_ManagementDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleTrackingTableAdapter
            // 
            this.vehicleTrackingTableAdapter.ClearBeforeFill = true;
            // 
            // vehicleTrackingTableAdapter1
            // 
            this.vehicleTrackingTableAdapter1.ClearBeforeFill = true;
            // 
            // Vehicle_Tracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Deliverydate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Orderdate);
            this.Controls.Add(this.Cityname);
            this.Controls.Add(this.Vehicletype);
            this.Controls.Add(this.Vehicleuser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vehicle_Tracking";
            this.Text = "Vehicle_Tracking";
            this.Load += new System.EventHandler(this.Vehicle_Tracking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTrackingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logistic_ManagementDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTrackingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logistic_ManagementDataSet14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox Deliverydate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Orderdate;
        private System.Windows.Forms.TextBox Cityname;
        private System.Windows.Forms.TextBox Vehicletype;
        private System.Windows.Forms.TextBox Vehicleuser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Logistic_ManagementDataSet14 logistic_ManagementDataSet14;
        private System.Windows.Forms.BindingSource vehicleTrackingBindingSource;
        private Logistic_ManagementDataSet14TableAdapters.VehicleTrackingTableAdapter vehicleTrackingTableAdapter;
        private Logistic_ManagementDataSet20 logistic_ManagementDataSet20;
        private System.Windows.Forms.BindingSource vehicleTrackingBindingSource1;
        private Logistic_ManagementDataSet20TableAdapters.VehicleTrackingTableAdapter vehicleTrackingTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
    }
}
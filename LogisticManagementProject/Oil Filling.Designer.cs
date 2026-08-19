namespace LogisticManagementProject
{
    partial class Oil_Filling
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
            this.button1 = new System.Windows.Forms.Button();
            this.Containercapacity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Enginetype = new System.Windows.Forms.TextBox();
            this.Vehicleno = new System.Windows.Forms.TextBox();
            this.Vehicletype = new System.Windows.Forms.TextBox();
            this.Vehiclemodel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehicleModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containerCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oilfillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logistic_ManagementDataSet9 = new LogisticManagementProject.Logistic_ManagementDataSet9();
            this.oilfillingTableAdapter = new LogisticManagementProject.Logistic_ManagementDataSet9TableAdapters.OilfillingTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilfillingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logistic_ManagementDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(707, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 44);
            this.button1.TabIndex = 33;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Containercapacity
            // 
            this.Containercapacity.Location = new System.Drawing.Point(379, 325);
            this.Containercapacity.Name = "Containercapacity";
            this.Containercapacity.Size = new System.Drawing.Size(265, 22);
            this.Containercapacity.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(173, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Container capacity";
            // 
            // Enginetype
            // 
            this.Enginetype.Location = new System.Drawing.Point(379, 278);
            this.Enginetype.Name = "Enginetype";
            this.Enginetype.Size = new System.Drawing.Size(265, 22);
            this.Enginetype.TabIndex = 30;
            // 
            // Vehicleno
            // 
            this.Vehicleno.Location = new System.Drawing.Point(379, 222);
            this.Vehicleno.Name = "Vehicleno";
            this.Vehicleno.Size = new System.Drawing.Size(265, 22);
            this.Vehicleno.TabIndex = 29;
            // 
            // Vehicletype
            // 
            this.Vehicletype.Location = new System.Drawing.Point(379, 173);
            this.Vehicletype.Name = "Vehicletype";
            this.Vehicletype.Size = new System.Drawing.Size(265, 22);
            this.Vehicletype.TabIndex = 28;
            // 
            // Vehiclemodel
            // 
            this.Vehiclemodel.Location = new System.Drawing.Point(379, 114);
            this.Vehiclemodel.Name = "Vehiclemodel";
            this.Vehiclemodel.Size = new System.Drawing.Size(265, 22);
            this.Vehiclemodel.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Engine type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Vehicle No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Vehicle type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Vehicle model";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 83);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(319, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oil Filling";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleModeDataGridViewTextBoxColumn,
            this.vehicleTypeDataGridViewTextBoxColumn,
            this.vehicleNODataGridViewTextBoxColumn,
            this.engineTypeDataGridViewTextBoxColumn,
            this.containerCapacityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oilfillingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(675, 150);
            this.dataGridView1.TabIndex = 39;
            // 
            // vehicleModeDataGridViewTextBoxColumn
            // 
            this.vehicleModeDataGridViewTextBoxColumn.DataPropertyName = "VehicleMode";
            this.vehicleModeDataGridViewTextBoxColumn.HeaderText = "VehicleMode";
            this.vehicleModeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleModeDataGridViewTextBoxColumn.Name = "vehicleModeDataGridViewTextBoxColumn";
            this.vehicleModeDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            this.vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.HeaderText = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            this.vehicleTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // vehicleNODataGridViewTextBoxColumn
            // 
            this.vehicleNODataGridViewTextBoxColumn.DataPropertyName = "VehicleNO";
            this.vehicleNODataGridViewTextBoxColumn.HeaderText = "VehicleNO";
            this.vehicleNODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleNODataGridViewTextBoxColumn.Name = "vehicleNODataGridViewTextBoxColumn";
            this.vehicleNODataGridViewTextBoxColumn.Width = 125;
            // 
            // engineTypeDataGridViewTextBoxColumn
            // 
            this.engineTypeDataGridViewTextBoxColumn.DataPropertyName = "EngineType";
            this.engineTypeDataGridViewTextBoxColumn.HeaderText = "EngineType";
            this.engineTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.engineTypeDataGridViewTextBoxColumn.Name = "engineTypeDataGridViewTextBoxColumn";
            this.engineTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // containerCapacityDataGridViewTextBoxColumn
            // 
            this.containerCapacityDataGridViewTextBoxColumn.DataPropertyName = "ContainerCapacity";
            this.containerCapacityDataGridViewTextBoxColumn.HeaderText = "ContainerCapacity";
            this.containerCapacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.containerCapacityDataGridViewTextBoxColumn.Name = "containerCapacityDataGridViewTextBoxColumn";
            this.containerCapacityDataGridViewTextBoxColumn.Width = 125;
            // 
            // oilfillingBindingSource
            // 
            this.oilfillingBindingSource.DataMember = "Oilfilling";
            this.oilfillingBindingSource.DataSource = this.logistic_ManagementDataSet9;
            // 
            // logistic_ManagementDataSet9
            // 
            this.logistic_ManagementDataSet9.DataSetName = "Logistic_ManagementDataSet9";
            this.logistic_ManagementDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oilfillingTableAdapter
            // 
            this.oilfillingTableAdapter.ClearBeforeFill = true;
            // 
            // Oil_Filling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 568);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Containercapacity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Enginetype);
            this.Controls.Add(this.Vehicleno);
            this.Controls.Add(this.Vehicletype);
            this.Controls.Add(this.Vehiclemodel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Oil_Filling";
            this.Text = "Oil_Filling";
            this.Load += new System.EventHandler(this.Oil_Filling_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilfillingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logistic_ManagementDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Containercapacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Enginetype;
        private System.Windows.Forms.TextBox Vehicleno;
        private System.Windows.Forms.TextBox Vehicletype;
        private System.Windows.Forms.TextBox Vehiclemodel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Logistic_ManagementDataSet9 logistic_ManagementDataSet9;
        private System.Windows.Forms.BindingSource oilfillingBindingSource;
        private Logistic_ManagementDataSet9TableAdapters.OilfillingTableAdapter oilfillingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn containerCapacityDataGridViewTextBoxColumn;
    }
}
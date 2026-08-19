namespace LogisticManagementProject
{
    partial class Shipment
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
            this.Save = new System.Windows.Forms.Button();
            this.Receiveraddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Senderaddress = new System.Windows.Forms.TextBox();
            this.ShipmentID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shipIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrierDataSet1 = new LogisticManagementProject.carrierDataSet1();
            this.shipmentTableAdapter = new LogisticManagementProject.carrierDataSet1TableAdapters.ShipmentTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrierDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Red;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Location = new System.Drawing.Point(350, 510);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(109, 44);
            this.Save.TabIndex = 36;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // Receiveraddress
            // 
            this.Receiveraddress.Location = new System.Drawing.Point(350, 247);
            this.Receiveraddress.Name = "Receiveraddress";
            this.Receiveraddress.Size = new System.Drawing.Size(265, 22);
            this.Receiveraddress.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(144, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Receiver Address";
            // 
            // Senderaddress
            // 
            this.Senderaddress.Location = new System.Drawing.Point(350, 200);
            this.Senderaddress.Name = "Senderaddress";
            this.Senderaddress.Size = new System.Drawing.Size(265, 22);
            this.Senderaddress.TabIndex = 33;
            // 
            // ShipmentID
            // 
            this.ShipmentID.Location = new System.Drawing.Point(350, 144);
            this.ShipmentID.Name = "ShipmentID";
            this.ShipmentID.Size = new System.Drawing.Size(265, 22);
            this.ShipmentID.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Sender Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Shipment ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 83);
            this.panel1.TabIndex = 29;
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
            this.label1.Text = "Shipment";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shipIdDataGridViewTextBoxColumn,
            this.senderAddDataGridViewTextBoxColumn,
            this.receiverAddDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shipmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(204, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 150);
            this.dataGridView1.TabIndex = 46;
            // 
            // shipIdDataGridViewTextBoxColumn
            // 
            this.shipIdDataGridViewTextBoxColumn.DataPropertyName = "ShipId";
            this.shipIdDataGridViewTextBoxColumn.HeaderText = "ShipId";
            this.shipIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shipIdDataGridViewTextBoxColumn.Name = "shipIdDataGridViewTextBoxColumn";
            this.shipIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // senderAddDataGridViewTextBoxColumn
            // 
            this.senderAddDataGridViewTextBoxColumn.DataPropertyName = "SenderAdd";
            this.senderAddDataGridViewTextBoxColumn.HeaderText = "SenderAdd";
            this.senderAddDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.senderAddDataGridViewTextBoxColumn.Name = "senderAddDataGridViewTextBoxColumn";
            this.senderAddDataGridViewTextBoxColumn.Width = 125;
            // 
            // receiverAddDataGridViewTextBoxColumn
            // 
            this.receiverAddDataGridViewTextBoxColumn.DataPropertyName = "ReceiverAdd";
            this.receiverAddDataGridViewTextBoxColumn.HeaderText = "ReceiverAdd";
            this.receiverAddDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receiverAddDataGridViewTextBoxColumn.Name = "receiverAddDataGridViewTextBoxColumn";
            this.receiverAddDataGridViewTextBoxColumn.Width = 125;
            // 
            // shipmentBindingSource
            // 
            this.shipmentBindingSource.DataMember = "Shipment";
            this.shipmentBindingSource.DataSource = this.carrierDataSet1;
            // 
            // carrierDataSet1
            // 
            this.carrierDataSet1.DataSetName = "carrierDataSet1";
            this.carrierDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shipmentTableAdapter
            // 
            this.shipmentTableAdapter.ClearBeforeFill = true;
            // 
            // Shipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Receiveraddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Senderaddress);
            this.Controls.Add(this.ShipmentID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Shipment";
            this.Text = "Shipment";
            this.Load += new System.EventHandler(this.Shipment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrierDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox Receiveraddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Senderaddress;
        private System.Windows.Forms.TextBox ShipmentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private carrierDataSet1 carrierDataSet1;
        private System.Windows.Forms.BindingSource shipmentBindingSource;
        private carrierDataSet1TableAdapters.ShipmentTableAdapter shipmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderAddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverAddDataGridViewTextBoxColumn;
    }
}
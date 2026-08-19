namespace LogisticManagementProject
{
    partial class Trip
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
            this.Departuretime = new System.Windows.Forms.TextBox();
            this.Destination = new System.Windows.Forms.TextBox();
            this.Startlocation = new System.Windows.Forms.TextBox();
            this.TripID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tripIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tripBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logistic_ManagementDataSet13 = new LogisticManagementProject.Logistic_ManagementDataSet13();
            this.tripTableAdapter = new LogisticManagementProject.Logistic_ManagementDataSet13TableAdapters.TripTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logistic_ManagementDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Red;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.ForeColor = System.Drawing.Color.Black;
            this.OK.Location = new System.Drawing.Point(377, 505);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(109, 44);
            this.OK.TabIndex = 21;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // Departuretime
            // 
            this.Departuretime.Location = new System.Drawing.Point(338, 275);
            this.Departuretime.Name = "Departuretime";
            this.Departuretime.Size = new System.Drawing.Size(265, 22);
            this.Departuretime.TabIndex = 20;
            // 
            // Destination
            // 
            this.Destination.Location = new System.Drawing.Point(338, 219);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(265, 22);
            this.Destination.TabIndex = 19;
            // 
            // Startlocation
            // 
            this.Startlocation.Location = new System.Drawing.Point(338, 170);
            this.Startlocation.Name = "Startlocation";
            this.Startlocation.Size = new System.Drawing.Size(265, 22);
            this.Startlocation.TabIndex = 18;
            // 
            // TripID
            // 
            this.TripID.Location = new System.Drawing.Point(338, 111);
            this.TripID.Name = "TripID";
            this.TripID.Size = new System.Drawing.Size(265, 22);
            this.TripID.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Departure time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Start location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Trip ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 83);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(357, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trip";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tripIdDataGridViewTextBoxColumn,
            this.startLocationDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.departureTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tripBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(120, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(542, 150);
            this.dataGridView1.TabIndex = 48;
            // 
            // tripIdDataGridViewTextBoxColumn
            // 
            this.tripIdDataGridViewTextBoxColumn.DataPropertyName = "TripId";
            this.tripIdDataGridViewTextBoxColumn.HeaderText = "TripId";
            this.tripIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tripIdDataGridViewTextBoxColumn.Name = "tripIdDataGridViewTextBoxColumn";
            this.tripIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // startLocationDataGridViewTextBoxColumn
            // 
            this.startLocationDataGridViewTextBoxColumn.DataPropertyName = "StartLocation";
            this.startLocationDataGridViewTextBoxColumn.HeaderText = "StartLocation";
            this.startLocationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startLocationDataGridViewTextBoxColumn.Name = "startLocationDataGridViewTextBoxColumn";
            this.startLocationDataGridViewTextBoxColumn.Width = 125;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.Width = 125;
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.HeaderText = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            this.departureTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // tripBindingSource
            // 
            this.tripBindingSource.DataMember = "Trip";
            this.tripBindingSource.DataSource = this.logistic_ManagementDataSet13;
            // 
            // logistic_ManagementDataSet13
            // 
            this.logistic_ManagementDataSet13.DataSetName = "Logistic_ManagementDataSet13";
            this.logistic_ManagementDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tripTableAdapter
            // 
            this.tripTableAdapter.ClearBeforeFill = true;
            // 
            // Trip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Departuretime);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.Startlocation);
            this.Controls.Add(this.TripID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Trip";
            this.Text = "Trip";
            this.Load += new System.EventHandler(this.Trip_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logistic_ManagementDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox Departuretime;
        private System.Windows.Forms.TextBox Destination;
        private System.Windows.Forms.TextBox Startlocation;
        private System.Windows.Forms.TextBox TripID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Logistic_ManagementDataSet13 logistic_ManagementDataSet13;
        private System.Windows.Forms.BindingSource tripBindingSource;
        private Logistic_ManagementDataSet13TableAdapters.TripTableAdapter tripTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
    }
}
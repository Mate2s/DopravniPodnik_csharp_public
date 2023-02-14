namespace WinFormsDopravniPodnik
{
    partial class RouteDetail
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
            this.labelStation = new System.Windows.Forms.Label();
            this.buttonNextStation = new System.Windows.Forms.Button();
            this.buttonStationBefore = new System.Windows.Forms.Button();
            this.labelNumberRoute = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelVehicleID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPassangerNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewPassanger = new System.Windows.Forms.DataGridView();
            this.buttonNewPassanger = new System.Windows.Forms.Button();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.buttonRouteEnd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jmeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassanger)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStation
            // 
            this.labelStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStation.Location = new System.Drawing.Point(0, 0);
            this.labelStation.Name = "labelStation";
            this.labelStation.Size = new System.Drawing.Size(200, 23);
            this.labelStation.TabIndex = 0;
            this.labelStation.Text = "Zastavka";
            this.labelStation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStation.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonNextStation
            // 
            this.buttonNextStation.Location = new System.Drawing.Point(563, 24);
            this.buttonNextStation.Name = "buttonNextStation";
            this.buttonNextStation.Size = new System.Drawing.Size(75, 23);
            this.buttonNextStation.TabIndex = 1;
            this.buttonNextStation.Text = "Dalsi";
            this.buttonNextStation.UseVisualStyleBackColor = true;
            this.buttonNextStation.Click += new System.EventHandler(this.buttonNextStation_Click);
            // 
            // buttonStationBefore
            // 
            this.buttonStationBefore.Location = new System.Drawing.Point(276, 24);
            this.buttonStationBefore.Name = "buttonStationBefore";
            this.buttonStationBefore.Size = new System.Drawing.Size(75, 23);
            this.buttonStationBefore.TabIndex = 2;
            this.buttonStationBefore.Text = "Minula zastavka";
            this.buttonStationBefore.UseVisualStyleBackColor = true;
            this.buttonStationBefore.Click += new System.EventHandler(this.buttonStationBefore_Click);
            // 
            // labelNumberRoute
            // 
            this.labelNumberRoute.AutoSize = true;
            this.labelNumberRoute.Location = new System.Drawing.Point(456, 81);
            this.labelNumberRoute.Name = "labelNumberRoute";
            this.labelNumberRoute.Size = new System.Drawing.Size(19, 13);
            this.labelNumberRoute.TabIndex = 3;
            this.labelNumberRoute.Text = "17";
            this.labelNumberRoute.Click += new System.EventHandler(this.labelNumberRoute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Číslo linky:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(777, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vozidlo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelVehicleID
            // 
            this.labelVehicleID.AutoSize = true;
            this.labelVehicleID.Location = new System.Drawing.Point(828, 81);
            this.labelVehicleID.Name = "labelVehicleID";
            this.labelVehicleID.Size = new System.Drawing.Size(19, 13);
            this.labelVehicleID.TabIndex = 6;
            this.labelVehicleID.Text = "35";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cestujících:";
            // 
            // labelPassangerNumber
            // 
            this.labelPassangerNumber.AutoSize = true;
            this.labelPassangerNumber.Location = new System.Drawing.Point(110, 81);
            this.labelPassangerNumber.Name = "labelPassangerNumber";
            this.labelPassangerNumber.Size = new System.Drawing.Size(30, 13);
            this.labelPassangerNumber.TabIndex = 8;
            this.labelPassangerNumber.Text = "0/20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seznam cestujících:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewPassanger);
            this.panel1.Location = new System.Drawing.Point(39, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 315);
            this.panel1.TabIndex = 11;
            // 
            // dataGridViewPassanger
            // 
            this.dataGridViewPassanger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPassanger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPassanger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Login,
            this.Jmeno,
            this.StartStation,
            this.EndStation,
            this.StartTime});
            this.dataGridViewPassanger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPassanger.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPassanger.Name = "dataGridViewPassanger";
            this.dataGridViewPassanger.Size = new System.Drawing.Size(812, 315);
            this.dataGridViewPassanger.TabIndex = 0;
            this.dataGridViewPassanger.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonNewPassanger
            // 
            this.buttonNewPassanger.Location = new System.Drawing.Point(41, 457);
            this.buttonNewPassanger.Name = "buttonNewPassanger";
            this.buttonNewPassanger.Size = new System.Drawing.Size(119, 32);
            this.buttonNewPassanger.TabIndex = 12;
            this.buttonNewPassanger.Text = "Přidat cestujícího";
            this.buttonNewPassanger.UseVisualStyleBackColor = true;
            this.buttonNewPassanger.Click += new System.EventHandler(this.buttonNewPassanger_Click);
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(395, 457);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(108, 32);
            this.buttonRegistration.TabIndex = 13;
            this.buttonRegistration.Text = "Registrace";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // buttonRouteEnd
            // 
            this.buttonRouteEnd.Location = new System.Drawing.Point(739, 457);
            this.buttonRouteEnd.Name = "buttonRouteEnd";
            this.buttonRouteEnd.Size = new System.Drawing.Size(112, 32);
            this.buttonRouteEnd.TabIndex = 14;
            this.buttonRouteEnd.Text = "Konec cesty";
            this.buttonRouteEnd.UseVisualStyleBackColor = true;
            this.buttonRouteEnd.Click += new System.EventHandler(this.buttonRouteEnd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelStation);
            this.panel2.Location = new System.Drawing.Point(357, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 23);
            this.panel2.TabIndex = 15;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Login
            // 
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            // 
            // Jmeno
            // 
            this.Jmeno.HeaderText = "Jméno";
            this.Jmeno.Name = "Jmeno";
            // 
            // StartStation
            // 
            this.StartStation.HeaderText = "Zastávka nástupu";
            this.StartStation.Name = "StartStation";
            // 
            // EndStation
            // 
            this.EndStation.HeaderText = "Zastávka výstupu";
            this.EndStation.Name = "EndStation";
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Čas nástupu";
            this.StartTime.Name = "StartTime";
            // 
            // RouteDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonRouteEnd);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.buttonNewPassanger);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPassangerNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelVehicleID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNumberRoute);
            this.Controls.Add(this.buttonStationBefore);
            this.Controls.Add(this.buttonNextStation);
            this.Name = "RouteDetail";
            this.Text = "RouteDetail";
            this.Load += new System.EventHandler(this.RouteDetail_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassanger)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStation;
        private System.Windows.Forms.Button buttonNextStation;
        private System.Windows.Forms.Button buttonStationBefore;
        private System.Windows.Forms.Label labelNumberRoute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelVehicleID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPassangerNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewPassanger;
        private System.Windows.Forms.Button buttonNewPassanger;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Button buttonRouteEnd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jmeno;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
    }
}
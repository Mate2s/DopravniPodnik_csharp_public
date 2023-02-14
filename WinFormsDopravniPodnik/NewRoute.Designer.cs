namespace WinFormsDopravniPodnik
{
    partial class NewRoute
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
            this.cBoxRouteNumber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.buttonCreateRoute = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxVehicle = new System.Windows.Forms.ComboBox();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxRouteNumber
            // 
            this.cBoxRouteNumber.FormattingEnabled = true;
            this.cBoxRouteNumber.Location = new System.Drawing.Point(104, 78);
            this.cBoxRouteNumber.Name = "cBoxRouteNumber";
            this.cBoxRouteNumber.Size = new System.Drawing.Size(208, 21);
            this.cBoxRouteNumber.TabIndex = 0;
            this.cBoxRouteNumber.SelectedIndexChanged += new System.EventHandler(this.cBoxRouteNumber_SelectedIndexChanged);
            this.cBoxRouteNumber.Click += new System.EventHandler(this.cBoxRouteNumber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Číslo linky:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Směr:";
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Location = new System.Drawing.Point(104, 112);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(208, 21);
            this.comboBoxDirection.TabIndex = 3;
            this.comboBoxDirection.SelectedIndexChanged += new System.EventHandler(this.comboBoxDirection_SelectedIndexChanged);
            // 
            // buttonCreateRoute
            // 
            this.buttonCreateRoute.Location = new System.Drawing.Point(45, 163);
            this.buttonCreateRoute.Name = "buttonCreateRoute";
            this.buttonCreateRoute.Size = new System.Drawing.Size(267, 40);
            this.buttonCreateRoute.TabIndex = 4;
            this.buttonCreateRoute.Text = "Vytvořit";
            this.buttonCreateRoute.UseVisualStyleBackColor = true;
            this.buttonCreateRoute.Click += new System.EventHandler(this.buttonCreateRoute_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vozidlo:";
            // 
            // cBoxVehicle
            // 
            this.cBoxVehicle.FormattingEnabled = true;
            this.cBoxVehicle.Location = new System.Drawing.Point(104, 45);
            this.cBoxVehicle.Name = "cBoxVehicle";
            this.cBoxVehicle.Size = new System.Drawing.Size(208, 21);
            this.cBoxVehicle.TabIndex = 6;
            this.cBoxVehicle.SelectedIndexChanged += new System.EventHandler(this.cBoxVehicle_SelectedIndexChanged);
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(WinFormsDopravniPodnik.VehicleService1.Vehicle);
            // 
            // vehicleBindingSource1
            // 
            this.vehicleBindingSource1.DataSource = typeof(WinFormsDopravniPodnik.VehicleService1.Vehicle);
            // 
            // NewRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 232);
            this.Controls.Add(this.cBoxVehicle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCreateRoute);
            this.Controls.Add(this.comboBoxDirection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxRouteNumber);
            this.Name = "NewRoute";
            this.Text = "Nová cesta";
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxRouteNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.Button buttonCreateRoute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxVehicle;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private System.Windows.Forms.BindingSource vehicleBindingSource1;
    }
}
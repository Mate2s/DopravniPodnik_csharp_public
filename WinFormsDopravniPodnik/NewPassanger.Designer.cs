namespace WinFormsDopravniPodnik
{
    partial class NewPassanger
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.buttonStorno = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxStation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(28, 114);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(98, 37);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cestující";
            // 
            // cBoxCustomer
            // 
            this.cBoxCustomer.FormattingEnabled = true;
            this.cBoxCustomer.Location = new System.Drawing.Point(126, 30);
            this.cBoxCustomer.Name = "cBoxCustomer";
            this.cBoxCustomer.Size = new System.Drawing.Size(161, 21);
            this.cBoxCustomer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Částka k zaplacení:";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(261, 89);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(26, 13);
            this.labelValue.TabIndex = 4;
            this.labelValue.Text = "0Kč";
            // 
            // buttonStorno
            // 
            this.buttonStorno.Location = new System.Drawing.Point(195, 114);
            this.buttonStorno.Name = "buttonStorno";
            this.buttonStorno.Size = new System.Drawing.Size(92, 37);
            this.buttonStorno.TabIndex = 5;
            this.buttonStorno.Text = "Storno";
            this.buttonStorno.UseVisualStyleBackColor = true;
            this.buttonStorno.Click += new System.EventHandler(this.buttonStorno_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Výstupní zastávka:";
            // 
            // cBoxStation
            // 
            this.cBoxStation.FormattingEnabled = true;
            this.cBoxStation.Location = new System.Drawing.Point(126, 54);
            this.cBoxStation.Name = "cBoxStation";
            this.cBoxStation.Size = new System.Drawing.Size(161, 21);
            this.cBoxStation.TabIndex = 7;
            this.cBoxStation.SelectedIndexChanged += new System.EventHandler(this.cBoxStation_SelectedIndexChanged);
            this.cBoxStation.Click += new System.EventHandler(this.cBoxStation_Click);
            // 
            // NewPassanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 163);
            this.Controls.Add(this.cBoxStation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonStorno);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOK);
            this.Name = "NewPassanger";
            this.Text = "Přidat cestujícího";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Button buttonStorno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxStation;
    }
}
namespace WinFormsDopravniPodnik
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreateRoute = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateRoute
            // 
            this.buttonCreateRoute.Location = new System.Drawing.Point(113, 42);
            this.buttonCreateRoute.Name = "buttonCreateRoute";
            this.buttonCreateRoute.Size = new System.Drawing.Size(147, 46);
            this.buttonCreateRoute.TabIndex = 0;
            this.buttonCreateRoute.Text = "Vytvořit cestu";
            this.buttonCreateRoute.UseVisualStyleBackColor = true;
            this.buttonCreateRoute.Click += new System.EventHandler(this.buttonCreateRoute_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(113, 109);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(146, 45);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Odhlásit se";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 209);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonCreateRoute);
            this.Name = "Form1";
            this.Text = "DP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateRoute;
        private System.Windows.Forms.Button buttonLogout;
    }
}


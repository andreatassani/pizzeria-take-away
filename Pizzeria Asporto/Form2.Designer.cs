namespace Pizzeria_Asporto_Visual_Studio
{
    partial class Benvenuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Benvenuto));
            this.accesso = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accesso
            // 
            this.accesso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.accesso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.accesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accesso.ForeColor = System.Drawing.Color.Black;
            this.accesso.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.accesso.Location = new System.Drawing.Point(446, 297);
            this.accesso.Margin = new System.Windows.Forms.Padding(6);
            this.accesso.Name = "accesso";
            this.accesso.Size = new System.Drawing.Size(572, 82);
            this.accesso.TabIndex = 0;
            this.accesso.Text = "ACCEDI AL PANNELLO DI CONTROLLO";
            this.accesso.UseVisualStyleBackColor = false;
            this.accesso.Click += new System.EventHandler(this.Accesso_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(446, 391);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(572, 82);
            this.button1.TabIndex = 1;
            this.button1.Text = "ACCEDI ALL\' AREA RISERVATA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Benvenuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Pizzeria_Asporto_Visual_Studio.Properties.Resources.pizza_uhd_4k_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1444, 880);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.accesso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Benvenuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizzeria d\'asporto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Benvenuto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button accesso;
        private System.Windows.Forms.Button button1;
    }
}
namespace Pizzeria_Asporto_Visual_Studio
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.accedi = new System.Windows.Forms.Button();
            this.utente = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.utentebox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.riprova = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accedi
            // 
            this.accedi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.accedi.Location = new System.Drawing.Point(222, 253);
            this.accedi.Name = "accedi";
            this.accedi.Size = new System.Drawing.Size(136, 64);
            this.accedi.TabIndex = 0;
            this.accedi.Text = "ACCEDI";
            this.accedi.UseVisualStyleBackColor = false;
            this.accedi.Click += new System.EventHandler(this.ACCEDI_Click);
            // 
            // utente
            // 
            this.utente.AutoSize = true;
            this.utente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utente.Location = new System.Drawing.Point(123, 61);
            this.utente.Name = "utente";
            this.utente.Size = new System.Drawing.Size(119, 37);
            this.utente.TabIndex = 1;
            this.utente.Text = "Utente:";
            this.utente.Click += new System.EventHandler(this.Label1_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(75, 138);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(167, 37);
            this.password.TabIndex = 2;
            this.password.Text = "Password:";
            this.password.Click += new System.EventHandler(this.Label2_Click);
            // 
            // utentebox
            // 
            this.utentebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utentebox.Location = new System.Drawing.Point(248, 54);
            this.utentebox.Name = "utentebox";
            this.utentebox.Size = new System.Drawing.Size(179, 44);
            this.utentebox.TabIndex = 3;
            // 
            // passbox
            // 
            this.passbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passbox.Location = new System.Drawing.Point(248, 131);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(179, 44);
            this.passbox.TabIndex = 4;
            // 
            // riprova
            // 
            this.riprova.BackColor = System.Drawing.Color.Transparent;
            this.riprova.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riprova.ForeColor = System.Drawing.Color.Red;
            this.riprova.Location = new System.Drawing.Point(137, 191);
            this.riprova.Name = "riprova";
            this.riprova.Size = new System.Drawing.Size(290, 135);
            this.riprova.TabIndex = 5;
            this.riprova.Text = "Parametri errati. Cliccare qui e riprovare";
            this.riprova.UseVisualStyleBackColor = false;
            this.riprova.Visible = false;
            this.riprova.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(574, 329);
            this.Controls.Add(this.riprova);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.utentebox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.utente);
            this.Controls.Add(this.accedi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accedi;
        private System.Windows.Forms.Label utente;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox utentebox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Button riprova;
    }
}
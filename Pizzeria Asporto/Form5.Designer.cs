namespace Pizzeria_Asporto_Visual_Studio
{
    partial class area
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(area));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.voce = new System.Windows.Forms.ComboBox();
            this.destra = new System.Windows.Forms.Button();
            this.basso = new System.Windows.Forms.Button();
            this.centro = new System.Windows.Forms.Button();
            this.quadrato = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeight = 46;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(455, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(952, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(841, 370);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1041, 268);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(841, 687);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 82;
            this.dataGridView3.RowTemplate.Height = 33;
            this.dataGridView3.Size = new System.Drawing.Size(1041, 268);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(18, 370);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 82;
            this.dataGridView4.RowTemplate.Height = 33;
            this.dataGridView4.Size = new System.Drawing.Size(781, 585);
            this.dataGridView4.TabIndex = 3;
            // 
            // voce
            // 
            this.voce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.voce.FormattingEnabled = true;
            this.voce.Items.AddRange(new object[] {
            "ORDINI FORNITORI",
            "FATTURE RICEVUTE",
            "DETTAGLIO ORDINI",
            "TURNI",
            "DIPENDENTI",
            "TUTTI I PRODOTTI",
            "RETRIBUZIONE"});
            this.voce.Location = new System.Drawing.Point(12, 12);
            this.voce.Name = "voce";
            this.voce.Size = new System.Drawing.Size(376, 33);
            this.voce.TabIndex = 4;
            this.voce.Text = "Selezina una voce da visualizzare";
            this.voce.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // destra
            // 
            this.destra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.destra.Location = new System.Drawing.Point(12, 72);
            this.destra.Name = "destra";
            this.destra.Size = new System.Drawing.Size(314, 44);
            this.destra.TabIndex = 5;
            this.destra.Text = "visualizza a destra";
            this.destra.UseVisualStyleBackColor = false;
            this.destra.Click += new System.EventHandler(this.Destra_Click);
            // 
            // basso
            // 
            this.basso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.basso.Location = new System.Drawing.Point(12, 260);
            this.basso.Name = "basso";
            this.basso.Size = new System.Drawing.Size(314, 44);
            this.basso.TabIndex = 6;
            this.basso.Text = "visualizza in basso";
            this.basso.UseVisualStyleBackColor = false;
            this.basso.Click += new System.EventHandler(this.Basso_Click);
            // 
            // centro
            // 
            this.centro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.centro.Location = new System.Drawing.Point(12, 199);
            this.centro.Name = "centro";
            this.centro.Size = new System.Drawing.Size(314, 44);
            this.centro.TabIndex = 7;
            this.centro.Text = "visualizza al centro";
            this.centro.UseVisualStyleBackColor = false;
            this.centro.Click += new System.EventHandler(this.Centro_Click);
            // 
            // quadrato
            // 
            this.quadrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.quadrato.Location = new System.Drawing.Point(12, 138);
            this.quadrato.Name = "quadrato";
            this.quadrato.Size = new System.Drawing.Size(314, 44);
            this.quadrato.TabIndex = 8;
            this.quadrato.Text = "visualizza nel quadrato";
            this.quadrato.UseVisualStyleBackColor = false;
            this.quadrato.Click += new System.EventHandler(this.Quadrato_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1578, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 89);
            this.button1.TabIndex = 9;
            this.button1.Text = "VAI ALLA HOME";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quadrato);
            this.Controls.Add(this.centro);
            this.Controls.Add(this.basso);
            this.Controls.Add(this.destra);
            this.Controls.Add(this.voce);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "area";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area Riservata";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.ComboBox voce;
        private System.Windows.Forms.Button destra;
        private System.Windows.Forms.Button basso;
        private System.Windows.Forms.Button centro;
        private System.Windows.Forms.Button quadrato;
        private System.Windows.Forms.Button button1;
    }
}
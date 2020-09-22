namespace Pizzeria_Asporto_Visual_Studio
{
    partial class ordine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ordine));
            this.formato = new System.Windows.Forms.DataGridView();
            this.impasto = new System.Windows.Forms.DataGridView();
            this.ordinebevande = new System.Windows.Forms.DataGridView();
            this.bevande = new System.Windows.Forms.DataGridView();
            this.modifiche = new System.Windows.Forms.DataGridView();
            this.ingredienti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.formato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impasto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordinebevande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bevande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifiche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredienti)).BeginInit();
            this.SuspendLayout();
            // 
            // formato
            // 
            this.formato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.formato.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.formato.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.formato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formato.Location = new System.Drawing.Point(792, 427);
            this.formato.Margin = new System.Windows.Forms.Padding(6);
            this.formato.Name = "formato";
            this.formato.RowHeadersWidth = 82;
            this.formato.Size = new System.Drawing.Size(840, 158);
            this.formato.TabIndex = 0;
            // 
            // impasto
            // 
            this.impasto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.impasto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.impasto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.impasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.impasto.Location = new System.Drawing.Point(846, 54);
            this.impasto.Margin = new System.Windows.Forms.Padding(6);
            this.impasto.Name = "impasto";
            this.impasto.RowHeadersWidth = 82;
            this.impasto.Size = new System.Drawing.Size(732, 292);
            this.impasto.TabIndex = 1;
            // 
            // ordinebevande
            // 
            this.ordinebevande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ordinebevande.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ordinebevande.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ordinebevande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordinebevande.Location = new System.Drawing.Point(792, 886);
            this.ordinebevande.Margin = new System.Windows.Forms.Padding(6);
            this.ordinebevande.Name = "ordinebevande";
            this.ordinebevande.RowHeadersWidth = 82;
            this.ordinebevande.Size = new System.Drawing.Size(840, 158);
            this.ordinebevande.TabIndex = 5;
            this.ordinebevande.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Ordinebevande_CellContentClick);
            // 
            // bevande
            // 
            this.bevande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bevande.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bevande.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bevande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bevande.Location = new System.Drawing.Point(1729, 54);
            this.bevande.Margin = new System.Windows.Forms.Padding(6);
            this.bevande.Name = "bevande";
            this.bevande.RowHeadersWidth = 82;
            this.bevande.Size = new System.Drawing.Size(652, 575);
            this.bevande.TabIndex = 6;
            // 
            // modifiche
            // 
            this.modifiche.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.modifiche.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.modifiche.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.modifiche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifiche.Location = new System.Drawing.Point(682, 655);
            this.modifiche.Margin = new System.Windows.Forms.Padding(6);
            this.modifiche.Name = "modifiche";
            this.modifiche.RowHeadersWidth = 82;
            this.modifiche.Size = new System.Drawing.Size(1038, 158);
            this.modifiche.TabIndex = 7;
            // 
            // ingredienti
            // 
            this.ingredienti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ingredienti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ingredienti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ingredienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredienti.Location = new System.Drawing.Point(15, 54);
            this.ingredienti.Margin = new System.Windows.Forms.Padding(6);
            this.ingredienti.Name = "ingredienti";
            this.ingredienti.RowHeadersWidth = 82;
            this.ingredienti.Size = new System.Drawing.Size(652, 575);
            this.ingredienti.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "INGREDIENTI DISPONIBILI";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(1775, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "BEVANDE DISPONIBILI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(682, 625);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "MODIFICHE INGREDIENTI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(786, 855);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "BEVANDE AGGIUNTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(786, 396);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "FORMATI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(840, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "IMPASTI";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(2, 987);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(652, 87);
            this.button1.TabIndex = 15;
            this.button1.Text = "INDIETRO AL PANNELLO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1716, 986);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(652, 87);
            this.button2.TabIndex = 16;
            this.button2.Text = "INSERISCI NUOVO ORDINE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ordine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(2368, 1079);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingredienti);
            this.Controls.Add(this.modifiche);
            this.Controls.Add(this.bevande);
            this.Controls.Add(this.ordinebevande);
            this.Controls.Add(this.impasto);
            this.Controls.Add(this.formato);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ordine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proposte e Scelte";
            this.Load += new System.EventHandler(this.Ordine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impasto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordinebevande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bevande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifiche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredienti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView formato;
        private System.Windows.Forms.DataGridView impasto;
        private System.Windows.Forms.DataGridView ordinebevande;
        private System.Windows.Forms.DataGridView bevande;
        private System.Windows.Forms.DataGridView modifiche;
        private System.Windows.Forms.DataGridView ingredienti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
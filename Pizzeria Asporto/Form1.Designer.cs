namespace Pizzeria_Asporto_Visual_Studio
{
    partial class Pizzeria
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pizzeria));
            this.tabellasotto = new System.Windows.Forms.DataGridView();
            this.bottonepersotto = new System.Windows.Forms.Button();
            this.tendina = new System.Windows.Forms.ComboBox();
            this.tabellasopra = new System.Windows.Forms.DataGridView();
            this.bottonepersopra = new System.Windows.Forms.Button();
            this.visualizza = new System.Windows.Forms.Button();
            this.tabellalaterale = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabellasotto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabellasopra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabellalaterale)).BeginInit();
            this.SuspendLayout();
            // 
            // tabellasotto
            // 
            this.tabellasotto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.tabellasotto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.tabellasotto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabellasotto.ColumnHeadersHeight = 46;
            this.tabellasotto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tabellasotto.Location = new System.Drawing.Point(68, 1000);
            this.tabellasotto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabellasotto.Name = "tabellasotto";
            this.tabellasotto.RowHeadersWidth = 82;
            this.tabellasotto.Size = new System.Drawing.Size(2700, 500);
            this.tabellasotto.TabIndex = 0;
            // 
            // bottonepersotto
            // 
            this.bottonepersotto.AutoSize = true;
            this.bottonepersotto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bottonepersotto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bottonepersotto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bottonepersotto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottonepersotto.Location = new System.Drawing.Point(420, 72);
            this.bottonepersotto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bottonepersotto.Name = "bottonepersotto";
            this.bottonepersotto.Size = new System.Drawing.Size(430, 90);
            this.bottonepersotto.TabIndex = 1;
            this.bottonepersotto.Text = "Visualizza in basso";
            this.bottonepersotto.UseVisualStyleBackColor = false;
            this.bottonepersotto.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tendina
            // 
            this.tendina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tendina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tendina.FormattingEnabled = true;
            this.tendina.Items.AddRange(new object[] {
            "ORDINI CLIENTI",
            "CONSEGNE DI OGGI",
            "TUTTI I CLIENTI"});
            this.tendina.Location = new System.Drawing.Point(68, 72);
            this.tendina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tendina.Name = "tendina";
            this.tendina.Size = new System.Drawing.Size(320, 33);
            this.tendina.TabIndex = 2;
            this.tendina.Text = "Seleziona cosa visualizzare";
            this.tendina.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // tabellasopra
            // 
            this.tabellasopra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabellasopra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabellasopra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabellasopra.ColumnHeadersHeight = 46;
            this.tabellasopra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tabellasopra.Location = new System.Drawing.Point(68, 444);
            this.tabellasopra.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabellasopra.Name = "tabellasopra";
            this.tabellasopra.RowHeadersWidth = 82;
            this.tabellasopra.Size = new System.Drawing.Size(2700, 500);
            this.tabellasopra.TabIndex = 3;
            this.tabellasopra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabellasopra_CellContentClick);
            // 
            // bottonepersopra
            // 
            this.bottonepersopra.AutoSize = true;
            this.bottonepersopra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bottonepersopra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bottonepersopra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottonepersopra.Location = new System.Drawing.Point(420, 184);
            this.bottonepersopra.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bottonepersopra.Name = "bottonepersopra";
            this.bottonepersopra.Size = new System.Drawing.Size(430, 90);
            this.bottonepersopra.TabIndex = 4;
            this.bottonepersopra.Text = "Visualizza in alto";
            this.bottonepersopra.UseVisualStyleBackColor = false;
            this.bottonepersopra.Click += new System.EventHandler(this.Bottonepersopra_Click);
            // 
            // visualizza
            // 
            this.visualizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.visualizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualizza.Location = new System.Drawing.Point(420, 294);
            this.visualizza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.visualizza.Name = "visualizza";
            this.visualizza.Size = new System.Drawing.Size(430, 90);
            this.visualizza.TabIndex = 5;
            this.visualizza.Text = "Visualizza altro";
            this.visualizza.UseVisualStyleBackColor = false;
            this.visualizza.Click += new System.EventHandler(this.Visualizza_Click);
            // 
            // tabellalaterale
            // 
            this.tabellalaterale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabellalaterale.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabellalaterale.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabellalaterale.ColumnHeadersHeight = 46;
            this.tabellalaterale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tabellalaterale.Location = new System.Drawing.Point(872, 16);
            this.tabellalaterale.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabellalaterale.Name = "tabellalaterale";
            this.tabellalaterale.RowHeadersWidth = 82;
            this.tabellalaterale.Size = new System.Drawing.Size(1896, 368);
            this.tabellalaterale.TabIndex = 6;
            this.tabellalaterale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabellalaterale_CellContentClick);
            // 
            // Pizzeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1444, 880);
            this.Controls.Add(this.tabellalaterale);
            this.Controls.Add(this.visualizza);
            this.Controls.Add(this.bottonepersopra);
            this.Controls.Add(this.tabellasopra);
            this.Controls.Add(this.tendina);
            this.Controls.Add(this.bottonepersotto);
            this.Controls.Add(this.tabellasotto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Pizzeria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pannello di Controllo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pizzeria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabellasotto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabellasopra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabellalaterale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bottonepersotto;
        private System.Windows.Forms.DataGridView tabellasotto;
        private System.Windows.Forms.ComboBox tendina;
        private System.Windows.Forms.DataGridView tabellasopra;
        private System.Windows.Forms.Button bottonepersopra;
        private System.Windows.Forms.Button visualizza;
        private System.Windows.Forms.DataGridView tabellalaterale;
    }
}


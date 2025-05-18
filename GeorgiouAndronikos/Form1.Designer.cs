namespace GeorgiouAndronikos
{
    partial class Form1
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
            this.CLose = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.onoma = new System.Windows.Forms.TextBox();
            this.aeksamino = new System.Windows.Forms.RadioButton();
            this.beksamino = new System.Windows.Forms.RadioButton();
            this.geksamino = new System.Windows.Forms.RadioButton();
            this.deksamino = new System.Windows.Forms.RadioButton();
            this.boxeksaminou = new System.Windows.Forms.GroupBox();
            this.boxmathimatos = new System.Windows.Forms.GroupBox();
            this.diktia = new System.Windows.Forms.CheckBox();
            this.SQL = new System.Windows.Forms.CheckBox();
            this.gamedev = new System.Windows.Forms.CheckBox();
            this.programing = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.αρχείοToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.αοθήκευσηToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.κλείσιμοToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.βαθμολογίαToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.μέσοςΌροςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.boxeksaminou.SuspendLayout();
            this.boxmathimatos.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CLose
            // 
            this.CLose.Location = new System.Drawing.Point(585, 353);
            this.CLose.Name = "CLose";
            this.CLose.Size = new System.Drawing.Size(108, 32);
            this.CLose.TabIndex = 0;
            this.CLose.Text = "Close";
            this.CLose.UseVisualStyleBackColor = true;
            this.CLose.Click += new System.EventHandler(this.CLose_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(585, 282);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(108, 32);
            this.Submit.TabIndex = 1;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // onoma
            // 
            this.onoma.Location = new System.Drawing.Point(33, 34);
            this.onoma.Name = "onoma";
            this.onoma.Size = new System.Drawing.Size(155, 20);
            this.onoma.TabIndex = 3;
            this.onoma.Text = "Συμπλήροσε το όνομα σου";
            // 
            // aeksamino
            // 
            this.aeksamino.AutoSize = true;
            this.aeksamino.Location = new System.Drawing.Point(6, 36);
            this.aeksamino.Name = "aeksamino";
            this.aeksamino.Size = new System.Drawing.Size(80, 17);
            this.aeksamino.TabIndex = 4;
            this.aeksamino.TabStop = true;
            this.aeksamino.Text = "A Εξάμηνο ";
            this.aeksamino.UseVisualStyleBackColor = true;
            // 
            // beksamino
            // 
            this.beksamino.AutoSize = true;
            this.beksamino.Location = new System.Drawing.Point(115, 36);
            this.beksamino.Name = "beksamino";
            this.beksamino.Size = new System.Drawing.Size(76, 17);
            this.beksamino.TabIndex = 5;
            this.beksamino.TabStop = true;
            this.beksamino.Text = "Β Εξάμηνο";
            this.beksamino.UseVisualStyleBackColor = true;
            // 
            // geksamino
            // 
            this.geksamino.AutoSize = true;
            this.geksamino.Location = new System.Drawing.Point(218, 36);
            this.geksamino.Name = "geksamino";
            this.geksamino.Size = new System.Drawing.Size(76, 17);
            this.geksamino.TabIndex = 6;
            this.geksamino.TabStop = true;
            this.geksamino.Text = "Γ Εξάμηνο";
            this.geksamino.UseVisualStyleBackColor = true;
            // 
            // deksamino
            // 
            this.deksamino.AutoSize = true;
            this.deksamino.Location = new System.Drawing.Point(334, 36);
            this.deksamino.Name = "deksamino";
            this.deksamino.Size = new System.Drawing.Size(77, 17);
            this.deksamino.TabIndex = 7;
            this.deksamino.TabStop = true;
            this.deksamino.Text = "Δ Εξάμηνο";
            this.deksamino.UseVisualStyleBackColor = true;
            // 
            // boxeksaminou
            // 
            this.boxeksaminou.Controls.Add(this.aeksamino);
            this.boxeksaminou.Controls.Add(this.deksamino);
            this.boxeksaminou.Controls.Add(this.beksamino);
            this.boxeksaminou.Controls.Add(this.geksamino);
            this.boxeksaminou.Location = new System.Drawing.Point(33, 75);
            this.boxeksaminou.Name = "boxeksaminou";
            this.boxeksaminou.Size = new System.Drawing.Size(447, 127);
            this.boxeksaminou.TabIndex = 8;
            this.boxeksaminou.TabStop = false;
            this.boxeksaminou.Text = "Επιλογή Εξαμήνου";
            // 
            // boxmathimatos
            // 
            this.boxmathimatos.Controls.Add(this.diktia);
            this.boxmathimatos.Controls.Add(this.SQL);
            this.boxmathimatos.Controls.Add(this.gamedev);
            this.boxmathimatos.Controls.Add(this.programing);
            this.boxmathimatos.Location = new System.Drawing.Point(33, 230);
            this.boxmathimatos.Name = "boxmathimatos";
            this.boxmathimatos.Size = new System.Drawing.Size(447, 127);
            this.boxmathimatos.TabIndex = 9;
            this.boxmathimatos.TabStop = false;
            this.boxmathimatos.Text = "Επιλογή Μαθήματος";
            // 
            // diktia
            // 
            this.diktia.AutoSize = true;
            this.diktia.Location = new System.Drawing.Point(194, 83);
            this.diktia.Name = "diktia";
            this.diktia.Size = new System.Drawing.Size(60, 17);
            this.diktia.TabIndex = 3;
            this.diktia.Text = "Δίκτυα";
            this.diktia.UseVisualStyleBackColor = true;
            // 
            // SQL
            // 
            this.SQL.AutoSize = true;
            this.SQL.Location = new System.Drawing.Point(0, 83);
            this.SQL.Name = "SQL";
            this.SQL.Size = new System.Drawing.Size(121, 17);
            this.SQL.TabIndex = 2;
            this.SQL.Text = "Βάσεις Δεδομένων";
            this.SQL.UseVisualStyleBackColor = true;
            // 
            // gamedev
            // 
            this.gamedev.AutoSize = true;
            this.gamedev.Location = new System.Drawing.Point(194, 33);
            this.gamedev.Name = "gamedev";
            this.gamedev.Size = new System.Drawing.Size(140, 17);
            this.gamedev.TabIndex = 1;
            this.gamedev.Text = "Κατασκευή Παιχνιδιών";
            this.gamedev.UseVisualStyleBackColor = true;
            // 
            // programing
            // 
            this.programing.AutoSize = true;
            this.programing.Location = new System.Drawing.Point(0, 33);
            this.programing.Name = "programing";
            this.programing.Size = new System.Drawing.Size(111, 17);
            this.programing.TabIndex = 0;
            this.programing.Text = "Πργραμματισμός";
            this.programing.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.αρχείοToolStripMenuItem,
            this.βαθμολογίαToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // αρχείοToolStripMenuItem
            // 
            this.αρχείοToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.αοθήκευσηToolStripMenuItem,
            this.κλείσιμοToolStripMenuItem});
            this.αρχείοToolStripMenuItem.Name = "αρχείοToolStripMenuItem";
            this.αρχείοToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.αρχείοToolStripMenuItem.Text = "Αρχείο";
            // 
            // αοθήκευσηToolStripMenuItem
            // 
            this.αοθήκευσηToolStripMenuItem.Name = "αοθήκευσηToolStripMenuItem";
            this.αοθήκευσηToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.αοθήκευσηToolStripMenuItem.Text = "Αοθήκευση";
            this.αοθήκευσηToolStripMenuItem.Click += new System.EventHandler(this.αοθήκευσηToolStripMenuItem_Click);
            // 
            // κλείσιμοToolStripMenuItem
            // 
            this.κλείσιμοToolStripMenuItem.Name = "κλείσιμοToolStripMenuItem";
            this.κλείσιμοToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.κλείσιμοToolStripMenuItem.Text = "Κλείσιμο";
            this.κλείσιμοToolStripMenuItem.Click += new System.EventHandler(this.κλείσιμοToolStripMenuItem_Click);
            // 
            // βαθμολογίαToolStripMenuItem
            // 
            this.βαθμολογίαToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.μέσοςΌροςToolStripMenuItem});
            this.βαθμολογίαToolStripMenuItem.Name = "βαθμολογίαToolStripMenuItem";
            this.βαθμολογίαToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.βαθμολογίαToolStripMenuItem.Text = "Βαθμολογία";
            // 
            // μέσοςΌροςToolStripMenuItem
            // 
            this.μέσοςΌροςToolStripMenuItem.Name = "μέσοςΌροςToolStripMenuItem";
            this.μέσοςΌροςToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.μέσοςΌροςToolStripMenuItem.Text = "Μέσος όρος";
            this.μέσοςΌροςToolStripMenuItem.Click += new System.EventHandler(this.μέσοςΌροςToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
           // this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxmathimatos);
            this.Controls.Add(this.boxeksaminou);
            this.Controls.Add(this.onoma);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.CLose);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.boxeksaminou.ResumeLayout(false);
            this.boxeksaminou.PerformLayout();
            this.boxmathimatos.ResumeLayout(false);
            this.boxmathimatos.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CLose;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox onoma;
        private System.Windows.Forms.RadioButton aeksamino;
        private System.Windows.Forms.RadioButton beksamino;
        private System.Windows.Forms.RadioButton geksamino;
        private System.Windows.Forms.RadioButton deksamino;
        private System.Windows.Forms.GroupBox boxeksaminou;
        private System.Windows.Forms.GroupBox boxmathimatos;
        private System.Windows.Forms.CheckBox programing;
        private System.Windows.Forms.CheckBox diktia;
        private System.Windows.Forms.CheckBox SQL;
        private System.Windows.Forms.CheckBox gamedev;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem αρχείοToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem αοθήκευσηToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem κλείσιμοToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem βαθμολογίαToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem μέσοςΌροςToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


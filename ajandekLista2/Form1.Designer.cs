namespace ajandekLista2
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
            this.labelUjAjandek = new System.Windows.Forms.Label();
            this.labelAjandekNev = new System.Windows.Forms.Label();
            this.labelAjandekUzlet = new System.Windows.Forms.Label();
            this.textBoxAjandekNev = new System.Windows.Forms.TextBox();
            this.textBoxAjandekUzlet = new System.Windows.Forms.TextBox();
            this.buttonHozzaad = new System.Windows.Forms.Button();
            this.buttonTorol = new System.Windows.Forms.Button();
            this.buttonReszletek = new System.Windows.Forms.Button();
            this.labelAjandekok = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ajandekListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonszerkesztes = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUjAjandek
            // 
            this.labelUjAjandek.AutoSize = true;
            this.labelUjAjandek.Location = new System.Drawing.Point(61, 23);
            this.labelUjAjandek.Name = "labelUjAjandek";
            this.labelUjAjandek.Size = new System.Drawing.Size(139, 17);
            this.labelUjAjandek.TabIndex = 1;
            this.labelUjAjandek.Text = "Új ajándék felvétele! ";
            // 
            // labelAjandekNev
            // 
            this.labelAjandekNev.AutoSize = true;
            this.labelAjandekNev.Location = new System.Drawing.Point(40, 65);
            this.labelAjandekNev.Name = "labelAjandekNev";
            this.labelAjandekNev.Size = new System.Drawing.Size(37, 17);
            this.labelAjandekNev.TabIndex = 2;
            this.labelAjandekNev.Text = "Név:";
            // 
            // labelAjandekUzlet
            // 
            this.labelAjandekUzlet.AutoSize = true;
            this.labelAjandekUzlet.Location = new System.Drawing.Point(33, 116);
            this.labelAjandekUzlet.Name = "labelAjandekUzlet";
            this.labelAjandekUzlet.Size = new System.Drawing.Size(44, 17);
            this.labelAjandekUzlet.TabIndex = 3;
            this.labelAjandekUzlet.Text = "Üzlet:";
            // 
            // textBoxAjandekNev
            // 
            this.textBoxAjandekNev.Location = new System.Drawing.Point(100, 65);
            this.textBoxAjandekNev.Name = "textBoxAjandekNev";
            this.textBoxAjandekNev.Size = new System.Drawing.Size(100, 22);
            this.textBoxAjandekNev.TabIndex = 4;
            this.textBoxAjandekNev.TextChanged += new System.EventHandler(this.textBoxAjandekNev_TextChanged);
            // 
            // textBoxAjandekUzlet
            // 
            this.textBoxAjandekUzlet.Location = new System.Drawing.Point(100, 111);
            this.textBoxAjandekUzlet.Name = "textBoxAjandekUzlet";
            this.textBoxAjandekUzlet.Size = new System.Drawing.Size(100, 22);
            this.textBoxAjandekUzlet.TabIndex = 5;
            // 
            // buttonHozzaad
            // 
            this.buttonHozzaad.Location = new System.Drawing.Point(55, 179);
            this.buttonHozzaad.Name = "buttonHozzaad";
            this.buttonHozzaad.Size = new System.Drawing.Size(145, 56);
            this.buttonHozzaad.TabIndex = 6;
            this.buttonHozzaad.Text = "Hozzáadás!";
            this.buttonHozzaad.UseVisualStyleBackColor = true;
            this.buttonHozzaad.Click += new System.EventHandler(this.buttonHozzaad_Click);
            // 
            // buttonTorol
            // 
            this.buttonTorol.Location = new System.Drawing.Point(33, 257);
            this.buttonTorol.Name = "buttonTorol";
            this.buttonTorol.Size = new System.Drawing.Size(94, 36);
            this.buttonTorol.TabIndex = 7;
            this.buttonTorol.Text = "Törlés";
            this.buttonTorol.UseVisualStyleBackColor = true;
            this.buttonTorol.Click += new System.EventHandler(this.buttonTorol_Click);
            // 
            // buttonReszletek
            // 
            this.buttonReszletek.Location = new System.Drawing.Point(150, 257);
            this.buttonReszletek.Name = "buttonReszletek";
            this.buttonReszletek.Size = new System.Drawing.Size(100, 36);
            this.buttonReszletek.TabIndex = 8;
            this.buttonReszletek.Text = "Részletek";
            this.buttonReszletek.UseVisualStyleBackColor = true;
            this.buttonReszletek.Click += new System.EventHandler(this.buttonReszletek_Click);
            // 
            // labelAjandekok
            // 
            this.labelAjandekok.AutoSize = true;
            this.labelAjandekok.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAjandekok.Location = new System.Drawing.Point(367, 24);
            this.labelAjandekok.Name = "labelAjandekok";
            this.labelAjandekok.Size = new System.Drawing.Size(267, 50);
            this.labelAjandekok.TabIndex = 9;
            this.labelAjandekok.Text = "AJÁNDÉKOK";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHozzaad);
            this.panel1.Controls.Add(this.textBoxAjandekUzlet);
            this.panel1.Controls.Add(this.textBoxAjandekNev);
            this.panel1.Controls.Add(this.labelAjandekUzlet);
            this.panel1.Controls.Add(this.labelAjandekNev);
            this.panel1.Controls.Add(this.labelUjAjandek);
            this.panel1.Location = new System.Drawing.Point(34, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 294);
            this.panel1.TabIndex = 10;
            // 
            // ajandekListBox
            // 
            this.ajandekListBox.FormattingEnabled = true;
            this.ajandekListBox.ItemHeight = 16;
            this.ajandekListBox.Location = new System.Drawing.Point(33, 21);
            this.ajandekListBox.Name = "ajandekListBox";
            this.ajandekListBox.Size = new System.Drawing.Size(336, 212);
            this.ajandekListBox.TabIndex = 0;
            this.ajandekListBox.SelectedIndexChanged += new System.EventHandler(this.ajandekListBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonszerkesztes);
            this.panel2.Controls.Add(this.buttonReszletek);
            this.panel2.Controls.Add(this.buttonTorol);
            this.panel2.Controls.Add(this.ajandekListBox);
            this.panel2.Location = new System.Drawing.Point(293, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 327);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.labelAjandekok);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1013, 654);
            this.panel3.TabIndex = 12;
            // 
            // buttonszerkesztes
            // 
            this.buttonszerkesztes.Enabled = false;
            this.buttonszerkesztes.Location = new System.Drawing.Point(272, 257);
            this.buttonszerkesztes.Name = "buttonszerkesztes";
            this.buttonszerkesztes.Size = new System.Drawing.Size(97, 36);
            this.buttonszerkesztes.TabIndex = 9;
            this.buttonszerkesztes.Text = "Szerkesztés";
            this.buttonszerkesztes.UseVisualStyleBackColor = true;
            this.buttonszerkesztes.Click += new System.EventHandler(this.buttonszerkesztes_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonOk);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(706, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 336);
            this.panel4.TabIndex = 12;
            this.panel4.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajándék szerkesztése";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Üzlet:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(79, 177);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 54);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 678);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Ajcsik UWU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelUjAjandek;
        private System.Windows.Forms.Label labelAjandekNev;
        private System.Windows.Forms.Label labelAjandekUzlet;
        private System.Windows.Forms.TextBox textBoxAjandekNev;
        private System.Windows.Forms.TextBox textBoxAjandekUzlet;
        private System.Windows.Forms.Button buttonHozzaad;
        private System.Windows.Forms.Button buttonTorol;
        private System.Windows.Forms.Button buttonReszletek;
        private System.Windows.Forms.Label labelAjandekok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ajandekListBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonszerkesztes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


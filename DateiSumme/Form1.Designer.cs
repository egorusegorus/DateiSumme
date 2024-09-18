namespace DateiSumme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnBeenden = new Button();
            btnEintrageLoschen = new Button();
            btnBerechneSumme = new Button();
            btnDatenAuswählen = new Button();
            CboDatei = new ComboBox();
            txtSumme = new TextBox();
            label2 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBeenden);
            panel1.Controls.Add(btnEintrageLoschen);
            panel1.Controls.Add(btnBerechneSumme);
            panel1.Controls.Add(btnDatenAuswählen);
            panel1.Controls.Add(CboDatei);
            panel1.Controls.Add(txtSumme);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 106);
            panel1.TabIndex = 0;
            // 
            // btnBeenden
            // 
            btnBeenden.Location = new Point(424, 74);
            btnBeenden.Name = "btnBeenden";
            btnBeenden.Size = new Size(141, 23);
            btnBeenden.TabIndex = 7;
            btnBeenden.Text = "Beenden";
            btnBeenden.UseVisualStyleBackColor = true;
            btnBeenden.Click += btnBeenden_Click;
            // 
            // btnEintrageLoschen
            // 
            btnEintrageLoschen.Location = new Point(424, 45);
            btnEintrageLoschen.Name = "btnEintrageLoschen";
            btnEintrageLoschen.Size = new Size(141, 23);
            btnEintrageLoschen.TabIndex = 6;
            btnEintrageLoschen.Text = "Einträge löschen";
            btnEintrageLoschen.UseVisualStyleBackColor = true;
            // 
            // btnBerechneSumme
            // 
            btnBerechneSumme.Location = new Point(424, 18);
            btnBerechneSumme.Name = "btnBerechneSumme";
            btnBerechneSumme.Size = new Size(141, 23);
            btnBerechneSumme.TabIndex = 5;
            btnBerechneSumme.Text = "berechne Summe";
            btnBerechneSumme.UseVisualStyleBackColor = true;
            btnBerechneSumme.Click += btnBerechneSumme_Click;
            // 
            // btnDatenAuswählen
            // 
            btnDatenAuswählen.Location = new Point(389, 18);
            btnDatenAuswählen.Name = "btnDatenAuswählen";
            btnDatenAuswählen.Size = new Size(29, 23);
            btnDatenAuswählen.TabIndex = 4;
            btnDatenAuswählen.Text = "...";
            btnDatenAuswählen.UseVisualStyleBackColor = true;
            btnDatenAuswählen.Click += btnDatenAuswählen_Click;
            // 
            // CboDatei
            // 
            CboDatei.FormattingEnabled = true;
            CboDatei.Location = new Point(3, 18);
            CboDatei.Name = "CboDatei";
            CboDatei.Size = new Size(380, 23);
            CboDatei.TabIndex = 3;
            CboDatei.Text = "Summe.txt";
            // 
            // txtSumme
            // 
            txtSumme.Location = new Point(3, 71);
            txtSumme.Name = "txtSumme";
            txtSumme.Size = new Size(380, 23);
            txtSumme.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 53);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Summe:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Datei:";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(12, 124);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(569, 214);
            listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 350);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnBeenden;
        private Button btnEintrageLoschen;
        private Button btnBerechneSumme;
        private Button btnDatenAuswählen;
        private ComboBox CboDatei;
        private TextBox txtSumme;
        private ListBox listBox1;
    }
}

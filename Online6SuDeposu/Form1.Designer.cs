namespace Online6SuDeposu
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
            pnlDepo = new Panel();
            pnlSu = new Panel();
            label1 = new Label();
            nudMiktar = new NumericUpDown();
            btnEkle = new Button();
            pnlDepo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).BeginInit();
            SuspendLayout();
            // 
            // pnlDepo
            // 
            pnlDepo.BackColor = Color.Gray;
            pnlDepo.Controls.Add(pnlSu);
            pnlDepo.Location = new Point(546, 44);
            pnlDepo.Name = "pnlDepo";
            pnlDepo.Size = new Size(224, 373);
            pnlDepo.TabIndex = 0;
            // 
            // pnlSu
            // 
            pnlSu.BackColor = Color.SkyBlue;
            pnlSu.Dock = DockStyle.Bottom;
            pnlSu.Location = new Point(0, 285);
            pnlSu.Name = "pnlSu";
            pnlSu.Size = new Size(224, 88);
            pnlSu.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(136, 157);
            label1.Name = "label1";
            label1.Size = new Size(212, 30);
            label1.TabIndex = 1;
            label1.Text = "Eklenecek Su Miktarı";
            // 
            // nudMiktar
            // 
            nudMiktar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            nudMiktar.Location = new Point(136, 190);
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(212, 36);
            nudMiktar.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkle.Location = new Point(136, 232);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(212, 49);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEkle);
            Controls.Add(nudMiktar);
            Controls.Add(label1);
            Controls.Add(pnlDepo);
            Name = "Form1";
            Text = "Online6 Su Deposu";
            pnlDepo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudMiktar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlDepo;
        private Panel pnlSu;
        private Label label1;
        private NumericUpDown nudMiktar;
        private Button btnEkle;
    }
}
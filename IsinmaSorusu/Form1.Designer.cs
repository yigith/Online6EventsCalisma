namespace IsinmaSorusu
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
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(16, 14);
            label1.Name = "label1";
            label1.Size = new Size(267, 50);
            label1.TabIndex = 0;
            label1.Text = "Görev 1: Bu etiketin altındaki panele \"panel1\" bir adet buton ekleyin ve bu butonun üzerine mouse ile gelinince kaybolmasını sağlayın.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(16, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 300);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Location = new Point(339, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 300);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(339, 14);
            label2.Name = "label2";
            label2.Size = new Size(287, 50);
            label2.TabIndex = 2;
            label2.Text = "Görev 2: Aşağıdaki panele \"panel2\" 10x10 ızgara olacak şekilde 100 adet buton ekleyin ve hangi butonun üzerine gelinirse onun rengi yeşil olsun.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 400);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Isınma Sorusu";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
    }
}
namespace Kronometre
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
            components = new System.ComponentModel.Container();
            lblEkran = new Label();
            btnBaslatDurdur = new Button();
            btnSifirla = new Button();
            tmr1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblEkran
            // 
            lblEkran.AutoSize = true;
            lblEkran.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEkran.Location = new Point(26, 44);
            lblEkran.Name = "lblEkran";
            lblEkran.Size = new Size(159, 34);
            lblEkran.TabIndex = 0;
            lblEkran.Text = "00:00:000";
            // 
            // btnBaslatDurdur
            // 
            btnBaslatDurdur.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaslatDurdur.Location = new Point(206, 24);
            btnBaslatDurdur.Name = "btnBaslatDurdur";
            btnBaslatDurdur.Size = new Size(83, 79);
            btnBaslatDurdur.TabIndex = 1;
            btnBaslatDurdur.Text = "Başlat";
            btnBaslatDurdur.UseVisualStyleBackColor = true;
            btnBaslatDurdur.Click += btnBaslatDurdur_Click;
            // 
            // btnSifirla
            // 
            btnSifirla.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSifirla.Location = new Point(295, 24);
            btnSifirla.Name = "btnSifirla";
            btnSifirla.Size = new Size(83, 79);
            btnSifirla.TabIndex = 1;
            btnSifirla.Text = "Sıfırla";
            btnSifirla.UseVisualStyleBackColor = true;
            // 
            // tmr1
            // 
            tmr1.Tick += tmr1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 390);
            Controls.Add(btnSifirla);
            Controls.Add(btnBaslatDurdur);
            Controls.Add(lblEkran);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEkran;
        private Button btnBaslatDurdur;
        private Button btnSifirla;
        private System.Windows.Forms.Timer tmr1;
    }
}
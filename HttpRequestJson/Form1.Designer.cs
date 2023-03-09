namespace HttpRequestJson
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
            lstSymbol = new ListBox();
            lblInfo = new Label();
            tmrVeri = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lstSymbol
            // 
            lstSymbol.FormattingEnabled = true;
            lstSymbol.ItemHeight = 15;
            lstSymbol.Location = new Point(12, 12);
            lstSymbol.Name = "lstSymbol";
            lstSymbol.Size = new Size(217, 424);
            lstSymbol.TabIndex = 0;
            lstSymbol.SelectedIndexChanged += lstSymbol_SelectedIndexChanged;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI Semibold", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfo.Location = new Point(248, 12);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(302, 128);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "label1";
            // 
            // tmrVeri
            // 
            tmrVeri.Tick += tmrVeri_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInfo);
            Controls.Add(lstSymbol);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSymbol;
        private Label lblInfo;
        private System.Windows.Forms.Timer tmrVeri;
    }
}
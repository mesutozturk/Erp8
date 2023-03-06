namespace StatikNesneler
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
            btnSingleton = new Button();
            SuspendLayout();
            // 
            // btnSingleton
            // 
            btnSingleton.Location = new Point(176, 12);
            btnSingleton.Name = "btnSingleton";
            btnSingleton.Size = new Size(123, 102);
            btnSingleton.TabIndex = 0;
            btnSingleton.Text = "Singleton Deneme";
            btnSingleton.UseVisualStyleBackColor = true;
            btnSingleton.Click += btnSingleton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 429);
            Controls.Add(btnSingleton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSingleton;
    }
}
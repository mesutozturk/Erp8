namespace AracTakip
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
            menuStrip1 = new MenuStrip();
            düzenToolStripMenuItem = new ToolStripMenuItem();
            markaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { düzenToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(669, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // düzenToolStripMenuItem
            // 
            düzenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { markaToolStripMenuItem });
            düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            düzenToolStripMenuItem.Size = new Size(52, 20);
            düzenToolStripMenuItem.Text = "&Düzen";
            // 
            // markaToolStripMenuItem
            // 
            markaToolStripMenuItem.Name = "markaToolStripMenuItem";
            markaToolStripMenuItem.Size = new Size(180, 22);
            markaToolStripMenuItem.Text = "&Marka";
            markaToolStripMenuItem.Click += markaToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 453);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem düzenToolStripMenuItem;
        private ToolStripMenuItem markaToolStripMenuItem;
    }
}
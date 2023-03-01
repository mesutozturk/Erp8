namespace RandevuSistemi
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
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnUret = new Button();
            button2 = new Button();
            flp1 = new FlowLayoutPanel();
            button3 = new Button();
            button7 = new Button();
            button5 = new Button();
            button6 = new Button();
            button8 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flp1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(flp1, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(378, 454);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(372, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Top;
            textBox2.Location = new Point(3, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(372, 23);
            textBox2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnUret, 0, 0);
            tableLayoutPanel2.Controls.Add(button2, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(3, 61);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(372, 100);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // btnUret
            // 
            btnUret.Dock = DockStyle.Top;
            btnUret.Location = new Point(3, 3);
            btnUret.Name = "btnUret";
            btnUret.Size = new Size(180, 44);
            btnUret.TabIndex = 0;
            btnUret.Text = "Mesai Saatlerini Üret";
            btnUret.UseVisualStyleBackColor = true;
            btnUret.Click += btnUret_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(189, 3);
            button2.Name = "button2";
            button2.Size = new Size(180, 44);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // flp1
            // 
            flp1.AutoScroll = true;
            flp1.Controls.Add(button3);
            flp1.Controls.Add(button7);
            flp1.Controls.Add(button5);
            flp1.Controls.Add(button6);
            flp1.Controls.Add(button8);
            flp1.Dock = DockStyle.Fill;
            flp1.Location = new Point(3, 167);
            flp1.Name = "flp1";
            flp1.Padding = new Padding(5);
            flp1.Size = new Size(372, 284);
            flp1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(8, 8);
            button3.Name = "button3";
            button3.Size = new Size(66, 60);
            button3.TabIndex = 0;
            button3.Text = "08:45";
            button3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(80, 8);
            button7.Name = "button7";
            button7.Size = new Size(66, 60);
            button7.TabIndex = 3;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(152, 8);
            button5.Name = "button5";
            button5.Size = new Size(66, 60);
            button5.TabIndex = 1;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(224, 8);
            button6.Name = "button6";
            button6.Size = new Size(66, 60);
            button6.TabIndex = 2;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(296, 8);
            button8.Name = "button8";
            button8.Size = new Size(66, 60);
            button8.TabIndex = 4;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 454);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            flp1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnUret;
        private Button button2;
        private FlowLayoutPanel flp1;
        private Button button3;
        private Button button5;
        private Button button7;
        private Button button6;
        private Button button8;
    }
}
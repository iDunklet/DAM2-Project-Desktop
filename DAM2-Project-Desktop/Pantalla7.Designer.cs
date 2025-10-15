namespace DAM2_Project_Desktop
{
    partial class Pantalla7
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
            splitter1 = new Splitter();
            splitter2 = new Splitter();
            splitter3 = new Splitter();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.BorderStyle = BorderStyle.FixedSingle;
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.RightToLeft = RightToLeft.Yes;
            splitter1.Size = new Size(1424, 100);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(0, 100);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(221, 885);
            splitter2.TabIndex = 1;
            splitter2.TabStop = false;
            splitter2.SplitterMoved += splitter2_SplitterMoved;
            // 
            // splitter3
            // 
            splitter3.Location = new Point(221, 100);
            splitter3.Margin = new Padding(3, 3, 3, 0);
            splitter3.Name = "splitter3";
            splitter3.Size = new Size(1209, 885);
            splitter3.TabIndex = 2;
            splitter3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(79, 209, 197);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(35, 78, 82);
            button1.Location = new Point(12, 120);
            button1.Name = "button1";
            button1.Size = new Size(200, 60);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(79, 209, 197);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(35, 78, 82);
            button2.Location = new Point(12, 186);
            button2.Name = "button2";
            button2.Size = new Size(200, 60);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(79, 209, 197);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(35, 78, 82);
            button3.Location = new Point(12, 252);
            button3.Name = "button3";
            button3.Size = new Size(200, 60);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(79, 209, 197);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.FromArgb(35, 78, 82);
            button5.Location = new Point(12, 384);
            button5.Name = "button5";
            button5.Size = new Size(200, 60);
            button5.TabIndex = 7;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(79, 209, 197);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.FromArgb(35, 78, 82);
            button6.Location = new Point(12, 450);
            button6.Name = "button6";
            button6.Size = new Size(200, 60);
            button6.TabIndex = 8;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.Location = new Point(12, 913);
            button7.Name = "button7";
            button7.Size = new Size(200, 60);
            button7.TabIndex = 9;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(79, 209, 197);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.FromArgb(35, 78, 82);
            button4.Location = new Point(12, 318);
            button4.Name = "button4";
            button4.Size = new Size(200, 60);
            button4.TabIndex = 10;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            // 
            // Pantalla7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 250, 252);
            ClientSize = new Size(1424, 985);
            Controls.Add(button4);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(splitter3);
            Controls.Add(splitter2);
            Controls.Add(splitter1);
            Name = "Pantalla7";
            Text = "Pantalla7";
            Load += Pantalla7_Load;
            ResumeLayout(false);
        }

        #endregion

        private Splitter splitter1;
        private Splitter splitter2;
        public Splitter splitter3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button4;
    }
}
using System.Windows.Forms;

namespace DAM2_Project_Desktop
{
    partial class Pantalla9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla9));
            splitContainer1 = new SplitContainer();
            buttonOut = new Button();
            pictureBoxTasky = new PictureBox();
            splitContainer2 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTasky).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer1.Panel1.Controls.Add(buttonOut);
            splitContainer1.Panel1.Controls.Add(pictureBoxTasky);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1424, 985);
            splitContainer1.SplitterDistance = 93;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 0;
            // 
            // buttonOut
            // 
            buttonOut.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonOut.BackgroundImage = (Image)resources.GetObject("buttonOut.BackgroundImage");
            buttonOut.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOut.FlatStyle = FlatStyle.Flat;
            buttonOut.ForeColor = Color.Transparent;
            buttonOut.Location = new Point(1328, 0);
            buttonOut.Name = "buttonOut";
            buttonOut.Size = new Size(94, 91);
            buttonOut.TabIndex = 3;
            buttonOut.UseVisualStyleBackColor = true;
            buttonOut.Click += buttonOut_Click;
            // 
            // pictureBoxTasky
            // 
            pictureBoxTasky.Image = Properties.Resources.Group_50;
            pictureBoxTasky.Location = new Point(-1, -1);
            pictureBoxTasky.Margin = new Padding(4, 3, 4, 3);
            pictureBoxTasky.Name = "pictureBoxTasky";
            pictureBoxTasky.Size = new Size(300, 94);
            pictureBoxTasky.TabIndex = 2;
            pictureBoxTasky.TabStop = false;
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = Color.FromArgb(35, 78, 82);
            splitContainer2.BorderStyle = BorderStyle.FixedSingle;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(3, 4, 3, 4);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.FromArgb(247, 250, 252);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.FromArgb(247, 250, 252);
            splitContainer2.Size = new Size(1424, 889);
            splitContainer2.SplitterDistance = 242;
            splitContainer2.SplitterWidth = 2;
            splitContainer2.TabIndex = 0;
            // 
            // Pantalla9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 985);
            Controls.Add(splitContainer1);
            MaximumSize = new Size(1440, 1024);
            Name = "Pantalla9";
            Text = "Pantalla9";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTasky).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBoxTasky;
        private SplitContainer splitContainer2;
        private Button buttonOut;
    }
}
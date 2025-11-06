namespace DAM2_Project_Desktop
{
    partial class Pantalla1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla1));
            ButtonLogin = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBoxUser = new TextBox();
            textBoxPass = new TextBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // ButtonLogin
            // 
            ButtonLogin.BackColor = Color.FromArgb(79, 209, 197);
            ButtonLogin.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonLogin.Location = new Point(195, 734);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(249, 55);
            ButtonLogin.TabIndex = 7;
            ButtonLogin.Text = "Log in";
            ButtonLogin.UseVisualStyleBackColor = false;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(108, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(443, 301);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(108, 379);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(443, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(183, 537);
            label1.Name = "label1";
            label1.Size = new Size(204, 20);
            label1.TabIndex = 2;
            label1.Text = "Username/Correo electrònico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(183, 607);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 3;
            label2.Text = "Password/Contraseña";
            // 
            // textBoxUser
            // 
            textBoxUser.BorderStyle = BorderStyle.FixedSingle;
            textBoxUser.Location = new Point(183, 565);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(273, 23);
            textBoxUser.TabIndex = 4;
            // 
            // textBoxPass
            // 
            textBoxPass.AccessibleRole = AccessibleRole.Sound;
            textBoxPass.BorderStyle = BorderStyle.FixedSingle;
            textBoxPass.Location = new Point(183, 635);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(273, 23);
            textBoxPass.TabIndex = 5;
            textBoxPass.UseSystemPasswordChar = true;
            textBoxPass.TextChanged += textBoxPass_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(643, -4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(786, 982);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Paint += pictureBox3_Paint;
            // 
            // Pantalla1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1424, 985);
            Controls.Add(pictureBox3);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxUser);
            Controls.Add(ButtonLogin);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1440, 1024);
            Name = "Pantalla1";
            Text = "Tasky";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ButtonLogin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private TextBox textBoxUser;
        private TextBox textBoxPass;
        private PictureBox pictureBox3;
    }
}
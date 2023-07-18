namespace BookingAirlineManagement
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            label1 = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btn_login = new Button();
            cb_remem = new CheckBox();
            lb_forget = new LinkLabel();
            lb_dki = new LinkLabel();
            tb_pass = new TextBox();
            tb_email = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(125, 19);
            label1.Name = "label1";
            label1.Size = new Size(183, 32);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(cb_remem);
            panel1.Controls.Add(lb_forget);
            panel1.Controls.Add(lb_dki);
            panel1.Controls.Add(tb_pass);
            panel1.Controls.Add(tb_email);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(392, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 412);
            panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(314, 19);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(41, 174);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_email_50;
            pictureBox1.Location = new Point(41, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.DodgerBlue;
            btn_login.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.Location = new Point(134, 331);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(174, 37);
            btn_login.TabIndex = 9;
            btn_login.Text = "Đăng nhập";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += button1_Click;
            // 
            // cb_remem
            // 
            cb_remem.AutoSize = true;
            cb_remem.Location = new Point(41, 270);
            cb_remem.Name = "cb_remem";
            cb_remem.Size = new Size(157, 24);
            cb_remem.TabIndex = 8;
            cb_remem.Text = "Ghi nhớ đăng nhập";
            cb_remem.UseVisualStyleBackColor = true;
            // 
            // lb_forget
            // 
            lb_forget.AutoSize = true;
            lb_forget.Location = new Point(299, 274);
            lb_forget.Name = "lb_forget";
            lb_forget.Size = new Size(120, 20);
            lb_forget.TabIndex = 7;
            lb_forget.TabStop = true;
            lb_forget.Text = "Quên mật khẩu ?";
            // 
            // lb_dki
            // 
            lb_dki.AutoSize = true;
            lb_dki.Location = new Point(235, 274);
            lb_dki.Name = "lb_dki";
            lb_dki.Size = new Size(63, 20);
            lb_dki.TabIndex = 6;
            lb_dki.TabStop = true;
            lb_dki.Text = "Đăng ký";
            // 
            // tb_pass
            // 
            tb_pass.BorderStyle = BorderStyle.FixedSingle;
            tb_pass.Location = new Point(41, 220);
            tb_pass.Name = "tb_pass";
            tb_pass.Size = new Size(378, 27);
            tb_pass.TabIndex = 5;
            tb_pass.UseSystemPasswordChar = true;
            // 
            // tb_email
            // 
            tb_email.BorderStyle = BorderStyle.FixedSingle;
            tb_email.ForeColor = SystemColors.WindowText;
            tb_email.Location = new Point(41, 122);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(378, 27);
            tb_email.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(82, 182);
            label3.Name = "label3";
            label3.Size = new Size(82, 22);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(82, 80);
            label2.Name = "label2";
            label2.Size = new Size(124, 22);
            label2.TabIndex = 2;
            label2.Text = "Tên đăng nhập";
            // 
            // fLogin
            // 
            AcceptButton = btn_login;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.anhmaybay;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(849, 440);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btn_login;
        private CheckBox cb_remem;
        private LinkLabel lb_forget;
        private LinkLabel lb_dki;
        private TextBox tb_pass;
        private TextBox tb_email;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}
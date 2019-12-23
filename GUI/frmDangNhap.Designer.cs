namespace GUI
{
    partial class frmDangNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.account = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textDangNhap = new System.Windows.Forms.TextBox();
            this.textMatKhau = new System.Windows.Forms.TextBox();
            this.buttonDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.buttonThoat = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.BackColor = System.Drawing.Color.Transparent;
            this.account.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.Location = new System.Drawing.Point(13, 33);
            this.account.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(144, 22);
            this.account.TabIndex = 0;
            this.account.Text = "Tên Đăng Nhập: ";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(13, 65);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(98, 22);
            this.password.TabIndex = 1;
            this.password.Text = "Mật Khẩu: ";
            // 
            // textDangNhap
            // 
            this.textDangNhap.Location = new System.Drawing.Point(148, 32);
            this.textDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.textDangNhap.MaxLength = 30;
            this.textDangNhap.Name = "textDangNhap";
            this.textDangNhap.Size = new System.Drawing.Size(239, 23);
            this.textDangNhap.TabIndex = 2;
            // 
            // textMatKhau
            // 
            this.textMatKhau.Location = new System.Drawing.Point(148, 66);
            this.textMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.textMatKhau.MaxLength = 30;
            this.textMatKhau.Name = "textMatKhau";
            this.textMatKhau.Size = new System.Drawing.Size(239, 23);
            this.textMatKhau.TabIndex = 3;
            this.textMatKhau.UseSystemPasswordChar = true;
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Location = new System.Drawing.Point(148, 116);
            this.buttonDangNhap.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.buttonDangNhap.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.buttonDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(114, 33);
            this.buttonDangNhap.TabIndex = 4;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(273, 116);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(114, 33);
            this.buttonThoat.TabIndex = 5;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // frmDangNhap
            // 
            this.Appearance.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 166);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonDangNhap);
            this.Controls.Add(this.textMatKhau);
            this.Controls.Add(this.textDangNhap);
            this.Controls.Add(this.password);
            this.Controls.Add(this.account);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.True;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.Enter += new System.EventHandler(this.buttonDangNhap_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label account;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textDangNhap;
        private System.Windows.Forms.TextBox textMatKhau;
        private DevExpress.XtraEditors.SimpleButton buttonDangNhap;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton buttonThoat;
    }
}
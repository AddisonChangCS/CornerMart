namespace CornerMart.user_controls
{
    partial class Login_page
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            Welcome_title = new Label();
            username_txt = new Label();
            password_txt = new Label();
            Login_bnt = new Button();
            register_bnt = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            key_table = new TableLayoutPanel();
            Show_KB_bnt = new Button();
            Up_down_switch_bnt = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Welcome_title
            // 
            Welcome_title.AutoSize = true;
            Welcome_title.Font = new Font("Script MT Bold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Welcome_title.Location = new Point(180, 40);
            Welcome_title.Name = "Welcome_title";
            Welcome_title.Size = new Size(448, 41);
            Welcome_title.TabIndex = 0;
            Welcome_title.Text = "Welcome to NCKU CSIE Shop";
            // 
            // username_txt
            // 
            username_txt.AutoSize = true;
            username_txt.Location = new Point(172, 120);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(144, 19);
            username_txt.TabIndex = 1;
            username_txt.Text = "請輸入使用者名稱：";
            // 
            // password_txt
            // 
            password_txt.AutoSize = true;
            password_txt.Location = new Point(217, 170);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(99, 19);
            password_txt.TabIndex = 2;
            password_txt.Text = "請輸入密碼：";
            // 
            // Login_bnt
            // 
            Login_bnt.Font = new Font("微軟正黑體", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            Login_bnt.Location = new Point(570, 125);
            Login_bnt.Name = "Login_bnt";
            Login_bnt.Size = new Size(100, 60);
            Login_bnt.TabIndex = 3;
            Login_bnt.Text = "登入";
            Login_bnt.UseVisualStyleBackColor = true;
            Login_bnt.Click += Login_bnt_Click;
            // 
            // register_bnt
            // 
            register_bnt.Font = new Font("微軟正黑體", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            register_bnt.Location = new Point(570, 200);
            register_bnt.Name = "register_bnt";
            register_bnt.Size = new Size(100, 60);
            register_bnt.TabIndex = 4;
            register_bnt.Text = "註冊";
            register_bnt.UseVisualStyleBackColor = true;
            register_bnt.Click += register_bnt_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(320, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 5;
            textBox1.Click += textBox1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(320, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 6;
            textBox2.Click += textBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mian_page;
            pictureBox1.Location = new Point(3, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // key_table
            // 
            key_table.ColumnCount = 10;
            key_table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            key_table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            key_table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            key_table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            key_table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            key_table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            key_table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            key_table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            key_table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            key_table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            key_table.Location = new Point(170, 295);
            key_table.Name = "key_table";
            key_table.RowCount = 3;
            key_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            key_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            key_table.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            key_table.Size = new Size(500, 150);
            key_table.TabIndex = 21;
            key_table.Visible = false;
            // 
            // Show_KB_bnt
            // 
            Show_KB_bnt.Font = new Font("微軟正黑體", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            Show_KB_bnt.Location = new Point(30, 300);
            Show_KB_bnt.Name = "Show_KB_bnt";
            Show_KB_bnt.Size = new Size(100, 60);
            Show_KB_bnt.TabIndex = 22;
            Show_KB_bnt.Text = "顯示鍵盤";
            Show_KB_bnt.UseVisualStyleBackColor = true;
            Show_KB_bnt.Click += Show_KB_bnt_Click;
            // 
            // Up_down_switch_bnt
            // 
            Up_down_switch_bnt.Font = new Font("微軟正黑體", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            Up_down_switch_bnt.Location = new Point(30, 380);
            Up_down_switch_bnt.Name = "Up_down_switch_bnt";
            Up_down_switch_bnt.Size = new Size(100, 60);
            Up_down_switch_bnt.TabIndex = 23;
            Up_down_switch_bnt.Text = "切換大小寫";
            Up_down_switch_bnt.UseVisualStyleBackColor = true;
            Up_down_switch_bnt.Visible = false;
            Up_down_switch_bnt.Click += Up_down_switch_bnt_Click;
            // 
            // Login_page
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Up_down_switch_bnt);
            Controls.Add(Show_KB_bnt);
            Controls.Add(key_table);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(register_bnt);
            Controls.Add(Login_bnt);
            Controls.Add(password_txt);
            Controls.Add(username_txt);
            Controls.Add(Welcome_title);
            Name = "Login_page";
            Size = new Size(800, 450);
            Load += Login_page_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Welcome_title;
        private Label username_txt;
        private Label password_txt;
        private Button Login_bnt;
        private Button register_bnt;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private TableLayoutPanel key_table;
        private Button Show_KB_bnt;
        private Button Up_down_switch_bnt;
    }
}

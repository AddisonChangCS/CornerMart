namespace CornerMart.user_controls
{
    partial class Registration_page
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            register_bnt = new Button();
            password_txt = new Label();
            username_txt = new Label();
            Welcome_title = new Label();
            label1 = new Label();
            PW_check1 = new Label();
            PW_check2 = new Label();
            PW_check3 = new Label();
            PW_check4 = new Label();
            key_table = new TableLayoutPanel();
            Up_down_switch_bnt = new Button();
            Show_KB_bnt = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(320, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 14;
            textBox2.Click += textBox2_Click;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(320, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 13;
            textBox1.Click += textBox1_Click;
            // 
            // register_bnt
            // 
            register_bnt.Font = new Font("微軟正黑體", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            register_bnt.Location = new Point(570, 125);
            register_bnt.Name = "register_bnt";
            register_bnt.Size = new Size(100, 60);
            register_bnt.TabIndex = 12;
            register_bnt.Text = "註冊使用者";
            register_bnt.UseVisualStyleBackColor = true;
            register_bnt.Click += register_bnt_Click;
            // 
            // password_txt
            // 
            password_txt.AutoSize = true;
            password_txt.Location = new Point(217, 170);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(99, 19);
            password_txt.TabIndex = 10;
            password_txt.Text = "請輸入密碼：";
            // 
            // username_txt
            // 
            username_txt.AutoSize = true;
            username_txt.Location = new Point(172, 120);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(144, 19);
            username_txt.TabIndex = 9;
            username_txt.Text = "請輸入使用者名稱：";
            // 
            // Welcome_title
            // 
            Welcome_title.AutoSize = true;
            Welcome_title.Font = new Font("Script MT Bold", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Welcome_title.Location = new Point(180, 40);
            Welcome_title.Name = "Welcome_title";
            Welcome_title.Size = new Size(448, 41);
            Welcome_title.TabIndex = 8;
            Welcome_title.Text = "Welcome to NCKU CSIE Shop";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微軟正黑體", 9F);
            label1.Location = new Point(320, 195);
            label1.Name = "label1";
            label1.Size = new Size(159, 19);
            label1.TabIndex = 15;
            label1.Text = "密碼請符合以下條件：";
            // 
            // PW_check1
            // 
            PW_check1.AutoSize = true;
            PW_check1.Font = new Font("微軟正黑體", 9F);
            PW_check1.ForeColor = Color.Red;
            PW_check1.Location = new Point(320, 214);
            PW_check1.Name = "PW_check1";
            PW_check1.Size = new Size(185, 19);
            PW_check1.TabIndex = 16;
            PW_check1.Text = "1. 需有英文大寫字母： No";
            // 
            // PW_check2
            // 
            PW_check2.AutoSize = true;
            PW_check2.Font = new Font("微軟正黑體", 9F);
            PW_check2.ForeColor = Color.Red;
            PW_check2.Location = new Point(320, 233);
            PW_check2.Name = "PW_check2";
            PW_check2.Size = new Size(185, 19);
            PW_check2.TabIndex = 17;
            PW_check2.Text = "2. 需有英文小寫字母： No";
            // 
            // PW_check3
            // 
            PW_check3.AutoSize = true;
            PW_check3.Font = new Font("微軟正黑體", 9F);
            PW_check3.ForeColor = Color.Red;
            PW_check3.Location = new Point(320, 252);
            PW_check3.Name = "PW_check3";
            PW_check3.Size = new Size(273, 19);
            PW_check3.TabIndex = 18;
            PW_check3.Text = "3. 需有至少一個特殊字元(#,@,!,$)： No";
            // 
            // PW_check4
            // 
            PW_check4.AutoSize = true;
            PW_check4.Font = new Font("微軟正黑體", 9F);
            PW_check4.ForeColor = Color.Red;
            PW_check4.Location = new Point(320, 271);
            PW_check4.Name = "PW_check4";
            PW_check4.Size = new Size(149, 19);
            PW_check4.TabIndex = 19;
            PW_check4.Text = "4. 長度至少為8： No";
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
            key_table.TabIndex = 20;
            key_table.Visible = false;
            // 
            // Up_down_switch_bnt
            // 
            Up_down_switch_bnt.Font = new Font("微軟正黑體", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            Up_down_switch_bnt.Location = new Point(30, 380);
            Up_down_switch_bnt.Name = "Up_down_switch_bnt";
            Up_down_switch_bnt.Size = new Size(100, 60);
            Up_down_switch_bnt.TabIndex = 25;
            Up_down_switch_bnt.Text = "切換大小寫";
            Up_down_switch_bnt.UseVisualStyleBackColor = true;
            Up_down_switch_bnt.Visible = false;
            Up_down_switch_bnt.Click += Up_down_switch_bnt_Click;
            // 
            // Show_KB_bnt
            // 
            Show_KB_bnt.Font = new Font("微軟正黑體", 9F, FontStyle.Bold, GraphicsUnit.Point, 136);
            Show_KB_bnt.Location = new Point(30, 300);
            Show_KB_bnt.Name = "Show_KB_bnt";
            Show_KB_bnt.Size = new Size(100, 60);
            Show_KB_bnt.TabIndex = 24;
            Show_KB_bnt.Text = "顯示鍵盤";
            Show_KB_bnt.UseVisualStyleBackColor = true;
            Show_KB_bnt.Click += Show_KB_bnt_Click;
            // 
            // Registration_page
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Up_down_switch_bnt);
            Controls.Add(Show_KB_bnt);
            Controls.Add(key_table);
            Controls.Add(PW_check4);
            Controls.Add(PW_check3);
            Controls.Add(PW_check2);
            Controls.Add(PW_check1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(register_bnt);
            Controls.Add(password_txt);
            Controls.Add(username_txt);
            Controls.Add(Welcome_title);
            Name = "Registration_page";
            Size = new Size(800, 450);
            Load += Registration_page_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Button register_bnt;
        private Label password_txt;
        private Label username_txt;
        private Label Welcome_title;
        private Label label1;
        private Label PW_check1;
        private Label PW_check2;
        private Label PW_check3;
        private Label PW_check4;
        private TableLayoutPanel key_table;
        private Button Up_down_switch_bnt;
        private Button Show_KB_bnt;
    }
}

namespace CornerMart.User_Controls
{
    partial class Main_page
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
            New_bnt = new Button();
            Delete_bnt = new Button();
            search_bnt = new Button();
            modify_bnt = new Button();
            order_num_txt = new Label();
            textBox1 = new TextBox();
            Welcome_txt = new Label();
            GB1 = new GroupBox();
            GB1_size3 = new RadioButton();
            GB1_size2 = new RadioButton();
            GB1_size1 = new RadioButton();
            listBox1 = new ListBox();
            Logout_bnt = new Button();
            GB2 = new GroupBox();
            GB2_size3 = new RadioButton();
            GB2_size2 = new RadioButton();
            GB2_size1 = new RadioButton();
            GB3 = new GroupBox();
            GB3_size3 = new RadioButton();
            GB3_size2 = new RadioButton();
            GB3_size1 = new RadioButton();
            GB4 = new GroupBox();
            GB4_size3 = new RadioButton();
            GB4_size2 = new RadioButton();
            GB4_size1 = new RadioButton();
            GB5 = new GroupBox();
            GB5_size3 = new RadioButton();
            GB5_size2 = new RadioButton();
            GB5_size1 = new RadioButton();
            GB6 = new GroupBox();
            GB6_size3 = new RadioButton();
            GB6_size2 = new RadioButton();
            GB6_size1 = new RadioButton();
            GB1.SuspendLayout();
            GB2.SuspendLayout();
            GB3.SuspendLayout();
            GB4.SuspendLayout();
            GB5.SuspendLayout();
            GB6.SuspendLayout();
            SuspendLayout();
            // 
            // New_bnt
            // 
            New_bnt.Font = new Font("微軟正黑體", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            New_bnt.Location = new Point(40, 70);
            New_bnt.Name = "New_bnt";
            New_bnt.Size = new Size(110, 40);
            New_bnt.TabIndex = 0;
            New_bnt.Text = "新增訂單";
            New_bnt.UseVisualStyleBackColor = true;
            New_bnt.Click += New_bnt_Click;
            // 
            // Delete_bnt
            // 
            Delete_bnt.Font = new Font("微軟正黑體", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Delete_bnt.Location = new Point(40, 140);
            Delete_bnt.Name = "Delete_bnt";
            Delete_bnt.Size = new Size(110, 40);
            Delete_bnt.TabIndex = 1;
            Delete_bnt.Text = "刪除訂單";
            Delete_bnt.UseVisualStyleBackColor = true;
            Delete_bnt.Click += Delete_bnt_Click;
            // 
            // search_bnt
            // 
            search_bnt.Font = new Font("微軟正黑體", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            search_bnt.Location = new Point(40, 210);
            search_bnt.Name = "search_bnt";
            search_bnt.Size = new Size(110, 40);
            search_bnt.TabIndex = 2;
            search_bnt.Text = "查詢訂單";
            search_bnt.UseVisualStyleBackColor = true;
            search_bnt.Click += search_bnt_Click;
            // 
            // modify_bnt
            // 
            modify_bnt.Font = new Font("微軟正黑體", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            modify_bnt.Location = new Point(40, 280);
            modify_bnt.Name = "modify_bnt";
            modify_bnt.Size = new Size(110, 40);
            modify_bnt.TabIndex = 3;
            modify_bnt.Text = "修改訂單";
            modify_bnt.UseVisualStyleBackColor = true;
            modify_bnt.Click += modify_bnt_Click;
            // 
            // order_num_txt
            // 
            order_num_txt.AutoSize = true;
            order_num_txt.Font = new Font("微軟正黑體", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            order_num_txt.Location = new Point(57, 350);
            order_num_txt.Name = "order_num_txt";
            order_num_txt.Size = new Size(78, 22);
            order_num_txt.TabIndex = 4;
            order_num_txt.Text = "訂單編號";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 380);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 27);
            textBox1.TabIndex = 5;
            // 
            // Welcome_txt
            // 
            Welcome_txt.AutoSize = true;
            Welcome_txt.Location = new Point(26, 19);
            Welcome_txt.Name = "Welcome_txt";
            Welcome_txt.Size = new Size(51, 19);
            Welcome_txt.TabIndex = 6;
            Welcome_txt.Text = "label2";
            // 
            // GB1
            // 
            GB1.Controls.Add(GB1_size3);
            GB1.Controls.Add(GB1_size2);
            GB1.Controls.Add(GB1_size1);
            GB1.Location = new Point(185, 35);
            GB1.Name = "GB1";
            GB1.Size = new Size(168, 125);
            GB1.TabIndex = 7;
            GB1.TabStop = false;
            GB1.Text = "炸豬排";
            // 
            // GB1_size3
            // 
            GB1_size3.AutoSize = true;
            GB1_size3.Location = new Point(23, 85);
            GB1_size3.Name = "GB1_size3";
            GB1_size3.Size = new Size(45, 23);
            GB1_size3.TabIndex = 2;
            GB1_size3.TabStop = true;
            GB1_size3.Text = "小";
            GB1_size3.UseVisualStyleBackColor = true;
            // 
            // GB1_size2
            // 
            GB1_size2.AutoSize = true;
            GB1_size2.Location = new Point(23, 56);
            GB1_size2.Name = "GB1_size2";
            GB1_size2.Size = new Size(45, 23);
            GB1_size2.TabIndex = 1;
            GB1_size2.TabStop = true;
            GB1_size2.Text = "中";
            GB1_size2.UseVisualStyleBackColor = true;
            // 
            // GB1_size1
            // 
            GB1_size1.AutoSize = true;
            GB1_size1.Location = new Point(23, 26);
            GB1_size1.Name = "GB1_size1";
            GB1_size1.Size = new Size(45, 23);
            GB1_size1.TabIndex = 0;
            GB1_size1.TabStop = true;
            GB1_size1.Text = "大";
            GB1_size1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(547, 45);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.None;
            listBox1.Size = new Size(201, 308);
            listBox1.TabIndex = 8;
            // 
            // Logout_bnt
            // 
            Logout_bnt.Font = new Font("微軟正黑體", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            Logout_bnt.ForeColor = Color.Red;
            Logout_bnt.Location = new Point(594, 372);
            Logout_bnt.Name = "Logout_bnt";
            Logout_bnt.Size = new Size(110, 40);
            Logout_bnt.TabIndex = 9;
            Logout_bnt.Text = "登出";
            Logout_bnt.UseVisualStyleBackColor = true;
            Logout_bnt.Click += Logout_bnt_Click;
            // 
            // GB2
            // 
            GB2.Controls.Add(GB2_size3);
            GB2.Controls.Add(GB2_size2);
            GB2.Controls.Add(GB2_size1);
            GB2.Location = new Point(185, 166);
            GB2.Name = "GB2";
            GB2.Size = new Size(168, 125);
            GB2.TabIndex = 8;
            GB2.TabStop = false;
            GB2.Text = "河童";
            // 
            // GB2_size3
            // 
            GB2_size3.AutoSize = true;
            GB2_size3.Location = new Point(23, 85);
            GB2_size3.Name = "GB2_size3";
            GB2_size3.Size = new Size(45, 23);
            GB2_size3.TabIndex = 2;
            GB2_size3.TabStop = true;
            GB2_size3.Text = "小";
            GB2_size3.UseVisualStyleBackColor = true;
            // 
            // GB2_size2
            // 
            GB2_size2.AutoSize = true;
            GB2_size2.Location = new Point(23, 56);
            GB2_size2.Name = "GB2_size2";
            GB2_size2.Size = new Size(45, 23);
            GB2_size2.TabIndex = 1;
            GB2_size2.TabStop = true;
            GB2_size2.Text = "中";
            GB2_size2.UseVisualStyleBackColor = true;
            // 
            // GB2_size1
            // 
            GB2_size1.AutoSize = true;
            GB2_size1.Location = new Point(23, 26);
            GB2_size1.Name = "GB2_size1";
            GB2_size1.Size = new Size(45, 23);
            GB2_size1.TabIndex = 0;
            GB2_size1.TabStop = true;
            GB2_size1.Text = "大";
            GB2_size1.UseVisualStyleBackColor = true;
            // 
            // GB3
            // 
            GB3.Controls.Add(GB3_size3);
            GB3.Controls.Add(GB3_size2);
            GB3.Controls.Add(GB3_size1);
            GB3.Location = new Point(185, 297);
            GB3.Name = "GB3";
            GB3.Size = new Size(168, 125);
            GB3.TabIndex = 8;
            GB3.TabStop = false;
            GB3.Text = "企鵝";
            // 
            // GB3_size3
            // 
            GB3_size3.AutoSize = true;
            GB3_size3.Location = new Point(23, 85);
            GB3_size3.Name = "GB3_size3";
            GB3_size3.Size = new Size(45, 23);
            GB3_size3.TabIndex = 2;
            GB3_size3.TabStop = true;
            GB3_size3.Text = "小";
            GB3_size3.UseVisualStyleBackColor = true;
            // 
            // GB3_size2
            // 
            GB3_size2.AutoSize = true;
            GB3_size2.Location = new Point(23, 56);
            GB3_size2.Name = "GB3_size2";
            GB3_size2.Size = new Size(45, 23);
            GB3_size2.TabIndex = 1;
            GB3_size2.TabStop = true;
            GB3_size2.Text = "中";
            GB3_size2.UseVisualStyleBackColor = true;
            // 
            // GB3_size1
            // 
            GB3_size1.AutoSize = true;
            GB3_size1.Location = new Point(23, 26);
            GB3_size1.Name = "GB3_size1";
            GB3_size1.Size = new Size(45, 23);
            GB3_size1.TabIndex = 0;
            GB3_size1.TabStop = true;
            GB3_size1.Text = "大";
            GB3_size1.UseVisualStyleBackColor = true;
            // 
            // GB4
            // 
            GB4.Controls.Add(GB4_size3);
            GB4.Controls.Add(GB4_size2);
            GB4.Controls.Add(GB4_size1);
            GB4.Location = new Point(362, 35);
            GB4.Name = "GB4";
            GB4.Size = new Size(168, 125);
            GB4.TabIndex = 8;
            GB4.TabStop = false;
            GB4.Text = "炸蝦";
            // 
            // GB4_size3
            // 
            GB4_size3.AutoSize = true;
            GB4_size3.Location = new Point(23, 85);
            GB4_size3.Name = "GB4_size3";
            GB4_size3.Size = new Size(45, 23);
            GB4_size3.TabIndex = 2;
            GB4_size3.TabStop = true;
            GB4_size3.Text = "小";
            GB4_size3.UseVisualStyleBackColor = true;
            // 
            // GB4_size2
            // 
            GB4_size2.AutoSize = true;
            GB4_size2.Location = new Point(23, 56);
            GB4_size2.Name = "GB4_size2";
            GB4_size2.Size = new Size(45, 23);
            GB4_size2.TabIndex = 1;
            GB4_size2.TabStop = true;
            GB4_size2.Text = "中";
            GB4_size2.UseVisualStyleBackColor = true;
            // 
            // GB4_size1
            // 
            GB4_size1.AutoSize = true;
            GB4_size1.Location = new Point(23, 26);
            GB4_size1.Name = "GB4_size1";
            GB4_size1.Size = new Size(45, 23);
            GB4_size1.TabIndex = 0;
            GB4_size1.TabStop = true;
            GB4_size1.Text = "大";
            GB4_size1.UseVisualStyleBackColor = true;
            // 
            // GB5
            // 
            GB5.Controls.Add(GB5_size3);
            GB5.Controls.Add(GB5_size2);
            GB5.Controls.Add(GB5_size1);
            GB5.Location = new Point(362, 166);
            GB5.Name = "GB5";
            GB5.Size = new Size(168, 125);
            GB5.TabIndex = 8;
            GB5.TabStop = false;
            GB5.Text = "貓咪";
            // 
            // GB5_size3
            // 
            GB5_size3.AutoSize = true;
            GB5_size3.Location = new Point(23, 85);
            GB5_size3.Name = "GB5_size3";
            GB5_size3.Size = new Size(45, 23);
            GB5_size3.TabIndex = 2;
            GB5_size3.TabStop = true;
            GB5_size3.Text = "小";
            GB5_size3.UseVisualStyleBackColor = true;
            // 
            // GB5_size2
            // 
            GB5_size2.AutoSize = true;
            GB5_size2.Location = new Point(23, 56);
            GB5_size2.Name = "GB5_size2";
            GB5_size2.Size = new Size(45, 23);
            GB5_size2.TabIndex = 1;
            GB5_size2.TabStop = true;
            GB5_size2.Text = "中";
            GB5_size2.UseVisualStyleBackColor = true;
            // 
            // GB5_size1
            // 
            GB5_size1.AutoSize = true;
            GB5_size1.Location = new Point(23, 26);
            GB5_size1.Name = "GB5_size1";
            GB5_size1.Size = new Size(45, 23);
            GB5_size1.TabIndex = 0;
            GB5_size1.TabStop = true;
            GB5_size1.Text = "大";
            GB5_size1.UseVisualStyleBackColor = true;
            // 
            // GB6
            // 
            GB6.Controls.Add(GB6_size3);
            GB6.Controls.Add(GB6_size2);
            GB6.Controls.Add(GB6_size1);
            GB6.Location = new Point(362, 297);
            GB6.Name = "GB6";
            GB6.Size = new Size(168, 125);
            GB6.TabIndex = 8;
            GB6.TabStop = false;
            GB6.Text = "恐龍";
            // 
            // GB6_size3
            // 
            GB6_size3.AutoSize = true;
            GB6_size3.Location = new Point(23, 85);
            GB6_size3.Name = "GB6_size3";
            GB6_size3.Size = new Size(45, 23);
            GB6_size3.TabIndex = 2;
            GB6_size3.TabStop = true;
            GB6_size3.Text = "小";
            GB6_size3.UseVisualStyleBackColor = true;
            // 
            // GB6_size2
            // 
            GB6_size2.AutoSize = true;
            GB6_size2.Location = new Point(23, 56);
            GB6_size2.Name = "GB6_size2";
            GB6_size2.Size = new Size(45, 23);
            GB6_size2.TabIndex = 1;
            GB6_size2.TabStop = true;
            GB6_size2.Text = "中";
            GB6_size2.UseVisualStyleBackColor = true;
            // 
            // GB6_size1
            // 
            GB6_size1.AutoSize = true;
            GB6_size1.Location = new Point(23, 26);
            GB6_size1.Name = "GB6_size1";
            GB6_size1.Size = new Size(45, 23);
            GB6_size1.TabIndex = 0;
            GB6_size1.TabStop = true;
            GB6_size1.Text = "大";
            GB6_size1.UseVisualStyleBackColor = true;
            // 
            // Main_page
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GB6);
            Controls.Add(GB5);
            Controls.Add(GB4);
            Controls.Add(GB3);
            Controls.Add(GB2);
            Controls.Add(Logout_bnt);
            Controls.Add(listBox1);
            Controls.Add(GB1);
            Controls.Add(Welcome_txt);
            Controls.Add(textBox1);
            Controls.Add(order_num_txt);
            Controls.Add(modify_bnt);
            Controls.Add(search_bnt);
            Controls.Add(Delete_bnt);
            Controls.Add(New_bnt);
            Name = "Main_page";
            Size = new Size(800, 450);
            Load += Main_page_Load;
            GB1.ResumeLayout(false);
            GB1.PerformLayout();
            GB2.ResumeLayout(false);
            GB2.PerformLayout();
            GB3.ResumeLayout(false);
            GB3.PerformLayout();
            GB4.ResumeLayout(false);
            GB4.PerformLayout();
            GB5.ResumeLayout(false);
            GB5.PerformLayout();
            GB6.ResumeLayout(false);
            GB6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button New_bnt;
        private Button Delete_bnt;
        private Button search_bnt;
        private Button modify_bnt;
        private Label order_num_txt;
        private TextBox textBox1;
        private Label Welcome_txt;
        private GroupBox GB1;
        private RadioButton GB1_size3;
        private RadioButton GB1_size2;
        private RadioButton GB1_size1;
        private ListBox listBox1;
        private Button Logout_bnt;
        private GroupBox GB2;
        private RadioButton GB2_size3;
        private RadioButton GB2_size2;
        private RadioButton GB2_size1;
        private GroupBox GB3;
        private RadioButton GB3_size3;
        private RadioButton GB3_size2;
        private RadioButton GB3_size1;
        private GroupBox GB4;
        private RadioButton GB4_size3;
        private RadioButton GB4_size2;
        private RadioButton GB4_size1;
        private GroupBox GB5;
        private RadioButton GB5_size3;
        private RadioButton GB5_size2;
        private RadioButton GB5_size1;
        private GroupBox GB6;
        private RadioButton GB6_size3;
        private RadioButton GB6_size2;
        private RadioButton GB6_size1;
    }
}

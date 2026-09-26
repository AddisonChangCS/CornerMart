using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CornerMart.user_controls
{
    public partial class Registration_page : UserControl
    {
        private Form1 main;
        private List<Button> key_buttons;
        private string[] keys;
        private bool IsUpper;
        private TextBox inputting;
        public Registration_page()
        {
            InitializeComponent();
        }
        public Registration_page(Form1 main)
        {
            InitializeComponent();
            this.main = main;
            key_buttons = new List<Button>();
            IsUpper = false;
            inputting = new TextBox();
            keys = new string[]
            {
                "q","w","e","r","t","y","u","i","o","p",
                "a","s","d","f","g","h","j","k","l","!",
                "z","x","c","v","b","n","m","@","#","$"
            };
        }
        private bool have_Upper()
        {
            if (textBox2.Text.Any(char.IsUpper))
            {
                PW_check1.Text = "1. 需有英文大寫字母： Yes";
                PW_check1.ForeColor = Color.Black;
            }
            else
            {
                PW_check1.Text = "1. 需有英文大寫字母： No";
                PW_check1.ForeColor = Color.Red;
            }

            return textBox2.Text.Any(char.IsUpper);
        }
        private bool have_Lower()
        {
            if (textBox2.Text.Any(char.IsLower))
            {
                PW_check2.Text = "2. 需有英文小寫字母： Yes";
                PW_check2.ForeColor = Color.Black;
            }
            else
            {
                PW_check2.Text = "2. 需有英文小寫字母： No";
                PW_check2.ForeColor = Color.Red;
            }
            return textBox2.Text.Any(char.IsLower);
        }
        private bool have_Special()
        {
            char[] Special = { '@', '!', '#', '$' };
            if (textBox2.Text.Any(c => Special.Contains(c)))
            {
                PW_check3.Text = "3.需有至少一個特殊字元(#,@,!,$)： Yes";
                PW_check3.ForeColor = Color.Black;
            }
            else
            {
                PW_check3.Text = "3. 需有至少一個特殊字元(#,@,!,$)： No";
                PW_check3.ForeColor = Color.Red;
            }
            return textBox2.Text.Any(c => Special.Contains(c));
        }
        private bool length_8()
        {
            if (textBox2.Text.Length >= 8)
            {
                PW_check4.Text = "4. 長度至少為8： Yes";
                PW_check4.ForeColor = Color.Black;
            }
            else
            {
                PW_check4.Text = "4. 長度至少為8： No";
                PW_check4.ForeColor = Color.Red;
            }
            return (textBox2.Text.Length >= 8);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            have_Lower();
            have_Special();
            have_Upper();
            length_8();
        }

        private void register_bnt_Click(object sender, EventArgs e)
        {
            foreach (var item in main.users)
            {
                if (textBox1.Text == item.Name)
                {
                    DialogResult result = MessageBox.Show("您的帳號名已被使用！\n請重新輸入。", "註冊失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        textBox1.Text = "";
                    }
                    return;
                }

            }
            if (have_Lower() && have_Special() && have_Upper() && length_8() && textBox1.Text.Length > 0)
            {
                main.users.Add(new Modles.Users(textBox1.Text, textBox2.Text));
                DialogResult result = MessageBox.Show("您的帳號已成功建立!\n請使用您的新帳號登入", "註冊成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    main.page_change(new Login_page(main));
                }
            }
            else if (textBox1.Text.Length <= 0)
            {
                DialogResult result = MessageBox.Show("帳號名不能為空！\n請重新輸入。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    textBox1.Text = "";
                    return;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("密碼格式不符！\n請重新輸入。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    return;
                }
            }
        }

        private void Registration_page_Load(object sender, EventArgs e)
        {
            Button button;
            int row = 0, col = 0;
            foreach (string key in keys)
            {
                button = new Button();
                button.Click += Key_click;
                button.Text = key;
                button.Size = new Size(45, 45);
                button.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
                key_buttons.Add(button);
                key_table.Controls.Add(button, col++, row);
                if (col == 10)
                {
                    row++;
                    col = 0;
                }
            }

        }
        private void Up_down_switch_bnt_Click(object sender, EventArgs e)
        {
            if (IsUpper)
            {
                IsUpper = false;
                foreach (Button keys in key_buttons)
                {
                    keys.Text = keys.Text.ToLower();
                }
            }
            else
            {
                IsUpper = true;
                foreach (Button keys in key_buttons)
                {
                    keys.Text = keys.Text.ToUpper();
                }
            }
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            inputting = textBox1;
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            inputting = textBox2;
        }
        private void Key_click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            inputting.Text += button.Text;
        }
        private void Show_KB_bnt_Click(object sender, EventArgs e)
        {
            if (key_table.Visible && Up_down_switch_bnt.Visible)
            {
                Show_KB_bnt.Text = "顯示鍵盤";
                key_table.Visible = false;
                Up_down_switch_bnt.Visible = false;
            }
            else
            {
                Show_KB_bnt.Text = "取消鍵盤";
                key_table.Visible = true;
                Up_down_switch_bnt.Visible = true;
            }
        }
    }
}

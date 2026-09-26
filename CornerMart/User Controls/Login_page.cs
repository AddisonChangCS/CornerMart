using CornerMart.User_Controls;
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
    public partial class Login_page : UserControl
    {
        private Form1 main;
        private List<Button> key_buttons;
        private string[] keys;
        private bool IsUpper;
        private TextBox inputting;
        public Login_page()
        {
            InitializeComponent();
        }
        public Login_page(Form1 form)
        {
            InitializeComponent();
            main = form;
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

        private void register_bnt_Click(object sender, EventArgs e)
        {
            main.page_change(new Registration_page(main));
        }

        private void Login_bnt_Click(object sender, EventArgs e)
        {
            foreach (var item in main.users)
            {
                if (textBox1.Text == item.Name)
                {
                    if (item.Password_check(textBox2.Text))
                    {
                        DialogResult result = MessageBox.Show($"Welcome aborad, {item.Name}.", "登入成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            main.now_using = item;
                            main.page_change(new Main_page(main));
                        }
                        return;
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("使用者帳號或密碼錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (result == DialogResult.OK)
                        {
                            return;
                        }

                    }
                }
            }
            DialogResult result2 = MessageBox.Show("使用者帳號或密碼錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (result2 == DialogResult.OK)
            {
                return;
            }
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

        private void Login_page_Load(object sender, EventArgs e)
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
                    keys.Text= keys.Text.ToLower();
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
    }
}

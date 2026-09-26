using CornerMart.Modles;
using CornerMart.user_controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CornerMart.User_Controls
{
    public partial class Main_page : UserControl
    {
        private Form1 main;
        private BindingList<Orders> myList;
        public Main_page()
        {
            InitializeComponent();
        }
        public Main_page(Form1 main)
        {
            InitializeComponent();
            this.main = main;
            myList = new BindingList<Orders>();
            listBox1.DataSource = myList;
        }

        private void Main_page_Load(object sender, EventArgs e)
        {
            this.myList.Clear();
            this.myList.Add(new Orders("ID", "Status"));
            foreach (Orders item in main.now_using.orders)
            {
                this.myList.Add(item);
            }
            this.Welcome_txt.Text = $"Welcome, {main.now_using.Name}";
        }

        private void Logout_bnt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您確定要登出嗎？", "確認登出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                main.now_using = null;
                main.page_change(new Login_page(main));
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }
        private string check_size(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is RadioButton rb && rb.Checked)
                {
                    rb.Checked = false;
                    return rb.Text;
                }
            }
            return null;
        }
        private void New_bnt_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string size;
            Orders order = new Orders();
            foreach (var item in this.Controls)
            {
                if (item is GroupBox groupBox)
                {
                    size = check_size(groupBox);
                    if ( size != null)
                    {
                        flag = true;
                        order.set_product(groupBox.Text, size);
                    }
                }
            }
            if (flag)
            {
                main.now_using.AddOrders(order);
                this.myList.Add(order);
                DialogResult result = MessageBox.Show($"新增訂單成功！訂單編號：{order.ID}", "訂單新增成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    return;
                }
            }
            else
            {
                DialogResult result2 = MessageBox.Show($"訂單不可為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result2 == DialogResult.OK)
                {
                    return;
                }

            }
        }

        private void Delete_bnt_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                if (item is Orders order)
                {
                    if (textBox1.Text == order.ID)
                    {
                        order.delete_Order();
                        myList.ResetBindings();
                        DialogResult result = MessageBox.Show($"刪除訂單成功！刪除訂單編號：{order.ID}", "訂單刪除成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            textBox1.Text = "";
                            return;
                        }
                    }
                }
            }
            DialogResult result2 = MessageBox.Show($"訂單編號不存在", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (result2 == DialogResult.OK)
            {
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }

        }

        private void search_bnt_Click(object sender, EventArgs e)
        {
            foreach (Orders item in main.now_using.orders)
            {
                if (textBox1.Text == item.ID)
                {
                    DialogResult result = MessageBox.Show(item.get_order_information(), "訂單刪除成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        textBox1.Text = "";
                        return;
                    }

                }
            }
            DialogResult result2 = MessageBox.Show($"訂單編號不存在", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (result2 == DialogResult.OK)
            {
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }

        }

        private void modify_bnt_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string size;
            foreach (Orders item in main.now_using.orders)
            {
                if (textBox1.Text == item.ID)
                {
                    foreach (var Con in this.Controls)
                    {
                        if (Con is GroupBox groupBox)
                        {
                            size=check_size(groupBox);
                            if (size != null)
                            {
                                if (!flag) item.initialize_order();
                                flag = true;
                                item.set_product(groupBox.Text, size);
                            }
                        }
                    }
                    if (flag)
                    {
                        myList.ResetBindings();
                        DialogResult result = MessageBox.Show($"修改訂單成功！訂單編號：{item.ID}", "訂單修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            textBox1.Text = "";
                            return;
                        }
                    }
                    else
                    {
                        DialogResult result2 = MessageBox.Show($"訂單不可為空", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (result2 == DialogResult.OK)
                        {
                            return;
                        }
                    }
                }
            }
            DialogResult result3 = MessageBox.Show($"訂單編號不存在", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (result3 == DialogResult.OK)
            {
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }


        }
    }
}

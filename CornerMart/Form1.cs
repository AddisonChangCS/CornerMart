using CornerMart.Modles;
using CornerMart.user_controls;
using Microsoft.VisualBasic.ApplicationServices;

namespace CornerMart
{
    public partial class Form1 : Form
    {
        internal List<Users> users;
        internal UserControl uc_now;
        internal Users now_using;
        public Form1()
        {
            InitializeComponent();
            users = new List<Users>();
            page_change(new Login_page(this));
            now_using = null;
        }
        public void page_change(UserControl userControl)
        {
            this.uc_now = userControl;
            userControl.Dock = DockStyle.Fill;
            this.main_penal.Dock = DockStyle.Fill;
            this.main_penal.Controls.Clear();
            this.main_penal.Controls.Add(uc_now);
        }
        
    }
}

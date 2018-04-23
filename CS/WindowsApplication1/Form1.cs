using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void schedulerControl1_PreparePopupMenu(object sender, DevExpress.XtraScheduler.PreparePopupMenuEventArgs e)
        {
            if (e.Menu.Id == DevExpress.XtraScheduler.SchedulerMenuItemId.DefaultMenu)
            {
                e.Menu.Items.Add(new SchedulerMenuItem("test", MyClickHandler));
            }
        }
        public void MyClickHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
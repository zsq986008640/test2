using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SingletonPattern
{
    public partial class FormToolbox : Form
    {
        private static FormToolbox ftb = null;
        private FormToolbox()
        {
            InitializeComponent();
        }

        private void FormToolbox_Load(object sender, EventArgs e)
        {
            this.label1.Text = "我是工具箱，哈哈";
        }

        public static FormToolbox GetChance() 
        {
            if (ftb == null || ftb.IsDisposed) 
            {
                ftb = new FormToolbox();
                ftb.MdiParent = Form1.ActiveForm;
            }
            return ftb;
        }


    }
}

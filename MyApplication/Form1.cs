using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StringUtilNS;

namespace MyApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StringUtil strUtil;
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<int> result = strUtil.IndexesOf(txtText.Text, txtSubText.Text);
            if (result == null || result.Count < 1)
                txtResult.Text = "<No Matches>";
            else
                txtResult.Text =  string.Join(",", result);
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            strUtil = new StringUtil();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
            txtText.Text = string.Empty;
            txtSubText.Text = string.Empty;
        }
    }
}

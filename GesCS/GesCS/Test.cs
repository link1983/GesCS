using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesCS
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utility.SqliteHelper sh = new Utility.SqliteHelper();
            DataSet ds=sh.QueryBySQL("select name from test where id=1");
            textBox1.Text = ds.Tables[0].Rows[0][0].ToString();
        }

        private void 添加用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

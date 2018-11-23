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

        private void button2_Click(object sender, EventArgs e)
        {
            Button btnLogin = new Button();
            //this.button1.Location = new System.Drawing.Point(0, 92);
            //this.button1.Name = "button1";
            //this.button1.Size = new System.Drawing.Size(75, 23);
            //this.button1.TabIndex = 0;
            //this.button1.Text = "button1";
            //this.button1.UseVisualStyleBackColor = true;
            //this.button1.Click += new System.EventHandler(this.button1_Click);

            btnLogin.Location = new System.Drawing.Point(30, 150);
            btnLogin.Text = "Login";
            btnLogin.Click += new EventHandler(btnClick);
            this.Controls.Add(btnLogin);
        }

        private void btnClick(object sender, EventArgs e)
        {
            //Button btn = sender as Button;
            //Type type = Type.GetType("GesCS.Login");
            //Form frm = (Form) Activator.CreateInstance(type);
            //frm.ShowDialog();

            Utility.SqliteHelper sh = new Utility.SqliteHelper();
            DataSet ds = sh.QueryBySQL("select * from sys_menu");
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                //ToolStripMenuItem item = new ToolStripMenuItem() { Name=dr["name"].ToString(),Text=dr["text"].ToString(), Tag = dr["tag"].ToString() };
                //if(Convert.ToInt32(dr["fid"])==0)
                //    menuStrip1.Items.Add(item);
                //foreach (DataRow dr2 in ds.Tables[0].Rows)
                //{
                //    if (Convert.ToInt32(dr2["fid"]) == Convert.ToInt32(dr["id"]))
                //    {
                //        ToolStripMenuItem item2 = new ToolStripMenuItem() { Name = dr["name"].ToString(), Text = dr["text"].ToString(), Tag = dr["tag"].ToString() };
                //        item.DropDownItems.Add(item2);
                //    }
                //}
                MenuAdd(dr);
            }

        }


        private void MenuAdd(DataRow dr)
        {

            //if (Convert.ToInt32(dr["fid"]) == 0)
            //{
            //    menuStrip1.Items.Add(item);
            //}

            //Utility.SqliteHelper sh = new Utility.SqliteHelper();
            //DataSet ds = sh.QueryBySQL("select * from sys_menu");
            //foreach (DataRow dr2 in ds.Tables[0].Rows)
            //{

            //    if (Convert.ToInt32(dr2["fid"]) == Convert.ToInt32(dr["id"]))
            //    {
            //        ToolStripMenuItem item2 = new ToolStripMenuItem() { Name = dr2["name"].ToString(), Text = dr2["text"].ToString(), Tag = dr2["tag"].ToString() };
            //        item.DropDownItems.Add(item2);
            //    }
            //    MenuAdd(dr2);
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

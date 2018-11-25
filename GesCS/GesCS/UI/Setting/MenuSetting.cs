using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesCS.UI.Setting
{
    public partial class MenuSetting : Form
    {
        public MenuSetting()
        {
            InitializeComponent();
        }

        private void MenuSetting_Load(object sender, EventArgs e)
        {
            Utility.MenuTreeViewLoader  mn= new Utility.MenuTreeViewLoader();
            mn.GetTreeView(treeView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("要添加的节点名称不能为空！");
                return;
            }
            //添加根节点
            Utility.SqliteHelper sh = new Utility.SqliteHelper();
            sh.ExecuteNonQuery($"insert into sys_menu (text,tag,xh,fid) values('{textBox1.Text.Trim()}','{textBox2.Text.Trim()}',{Convert.ToInt32(textBox3.Text.Trim())},0)");
            //TreeNode tn = new TreeNode();
            //tn.Text = textBox1.Text.Trim();
            //tn.Tag = textBox2.Text.Trim();
            //treeView1.Nodes.Add(tn);
            Utility.MenuTreeViewLoader mn = new Utility.MenuTreeViewLoader();
            treeView1.Nodes.Clear();
            mn.GetTreeView(treeView1);
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("请选择要删除的节点！");
                return;
            }
            treeView1.SelectedNode.Remove();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("要添加的节点名称不能为空！");
                return;
            }
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("请选择要添加子节点的节点！");
                return;
            }
            TreeNode tn = new TreeNode();
            tn.Text = textBox1.Text.Trim();
            tn.Tag = textBox2.Text.Trim();
            treeView1.SelectedNode.Nodes.Add(tn);
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Utility.SqliteHelper sh = new Utility.SqliteHelper();
            DataSet ds = sh.QueryBySQL($"select * from sys_menu where text='{treeView1.SelectedNode.Text}'");
            DataRow dr = ds.Tables[0].Rows[0];
            textBox1.Text = dr["text"].ToString();
            textBox2.Text = dr["tag"].ToString();
            textBox3.Text = dr["xh"].ToString();
            textBox4.Text = dr["id"].ToString();




        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            NewBiz
        }
    }
}

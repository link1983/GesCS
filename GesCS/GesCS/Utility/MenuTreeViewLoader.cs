using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace GesCS.Utility
{
    public class MenuTreeViewLoader
    {
        DataRowCollection rows = null;
        public MenuTreeViewLoader()
        {
            Utility.SqliteHelper sh = new Utility.SqliteHelper();
            DataSet ds = sh.QueryBySQL("select * from sys_menu");
            rows = ds.Tables[0].Rows;
        }

        public void GetTreeView(TreeView tv)
        {

            foreach (DataRow dr in rows)
            {
                if (Convert.ToInt32(dr["fid"]) == 0)
                {
                    TreeNode tn = new TreeNode() { Text = dr["text"].ToString() };
                    AddNode(tn, dr);

                    tv.Nodes.Add(tn);

                }
            }

        }

        private void AddNode(TreeNode tn,DataRow dr)
        {

            if (!HasChild(dr))
                return;
            else
            {
                foreach(DataRow dr2 in rows)
                {
                    if (Convert.ToInt32(dr2["fid"]) == Convert.ToInt32(dr["id"]))
                    {
                        TreeNode tn2 = new TreeNode() { Text = dr2["text"].ToString() };
                        tn.Nodes.Add(tn2);
                        AddNode(tn2,dr2);

                    }
                }

                return;
            }

        }

        private bool HasChild(DataRow dr)
        {
            foreach(DataRow dr2 in rows)
            {
                if (Convert.ToInt32(dr2["fid"]) == Convert.ToInt32(dr["id"]))
                    return true;
            }
            return false;
        }
    }
}

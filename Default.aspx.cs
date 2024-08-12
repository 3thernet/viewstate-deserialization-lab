using System;
using System.Web.UI;

namespace MyWebAppNamespace
{
    public partial class Default : Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            // 利用 ViewState 保存输入的内容
            ViewState["UserName"] = TextBox1.Text;

            // 显示保存的内容
            if (ViewState["UserName"] != null)
            {
                Label2.Text = "Hello, " + ViewState["UserName"].ToString();
            }
        }
    }
}
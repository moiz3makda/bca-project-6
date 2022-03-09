using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_feedback : System.Web.UI.Page
{

    public SqlCommand cmd;
    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Amta\job_portal\job_portal.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        loaddata();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        con.Open();
        int rowindex = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
        int uid = Convert.ToInt32(gd1.Rows[rowindex].Cells[1].Text);
        cmd = new SqlCommand("delete from feedback where id='" + uid + "'", con);
        cmd.ExecuteNonQuery();
        con.Close();
        loaddata();

    }
    void loaddata()
    {
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("select id , name ,feedback from feedback", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        gd1.DataSource = dt;
        con.Close();
        gd1.DataBind();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Company_List : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Amta\job_portal\job_portal.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    public SqlCommand cmd;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select id , name , type , state , city , office_address , mobile_no , email , company_description from company", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gd1.DataSource = dt;
            con.Close();
            gd1.DataBind();
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        refreshPage();

        
    }

    private void refreshPage()
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-35OT9IE8\SQLEXPRESS;Initial Catalog=webeng;Integrated Security=True");

        DataSet ds = new DataSet();

        SqlDataAdapter adpt = new SqlDataAdapter("Select * from Student", conn);

        adpt.Fill(ds, "Student");

        GridView1.DataSource = ds.Tables["Student"];
        GridView1.DataBind();

        ListBox1.DataSource = ds.Tables["Student"];
        ListBox1.DataTextField = "Name";
        ListBox1.DataValueField = "Id";
        ListBox1.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-35OT9IE8\SQLEXPRESS;Initial Catalog=webeng;Integrated Security=True");

        DataSet ds = new DataSet();

        SqlDataAdapter adpt = new SqlDataAdapter("Select * from Student", conn);

        adpt.Fill(ds, "Student");

        DataRow dr = ds.Tables["Student"].NewRow();
        dr["Name"] = txtStudName.Text;
        dr["Email"] = txtStudEmail.Text;
        dr["Contactno"] = txtContactNo.Text;
        dr["Address"] = txtStudAddress.Text;

        ds.Tables["Student"].Rows.Add(dr);

        SqlCommandBuilder buil = new SqlCommandBuilder(adpt);
        adpt.Update(ds, "Student");
        refreshPage();
        GridView1.DataBind();

    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-35OT9IE8\SQLEXPRESS;Initial Catalog=webeng;Integrated Security=True");

        DataSet ds = new DataSet();

        SqlDataAdapter adpt = new SqlDataAdapter("Select * from Student where Id="+ListBox1.SelectedValue, conn);

        adpt.Fill(ds, "Student");

        foreach (DataRow dr in ds.Tables["Student"].Rows)
        {
            txtStudName.Text = dr["Name"].ToString();
            txtStudAddress.Text = dr["Address"].ToString();
            txtContactNo.Text = dr["Contactno"].ToString();
            txtStudEmail.Text = dr["Email"].ToString();
        }
        btnAdd.Visible = false;
        btnUpdate.Visible = true;
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-35OT9IE8\SQLEXPRESS;Initial Catalog=webeng;Integrated Security=True");

        DataSet ds = new DataSet();

        SqlDataAdapter adpt = new SqlDataAdapter("Select * from Student where Id=" + ListBox1.SelectedValue, conn);

        adpt.Fill(ds, "Student");

        foreach (DataRow dr in ds.Tables["Student"].Rows)
        {
            dr["Name"] = txtStudName.Text;
            dr["Address"] = txtStudAddress.Text;
            dr["Contactno"] = txtContactNo.Text;
            dr["Email"]=txtStudEmail.Text;
        }
        SqlCommandBuilder buil = new SqlCommandBuilder(adpt);
        adpt.Update(ds, "Student");
        refreshPage();

    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-35OT9IE8\SQLEXPRESS;Initial Catalog=webeng;Integrated Security=True");

        DataSet ds = new DataSet();

        SqlDataAdapter adpt = new SqlDataAdapter("Select * from Student where Id=" + ListBox1.SelectedValue, conn);

        adpt.Fill(ds, "Student");

        foreach (DataRow dr in ds.Tables["Student"].Rows)
        {
            dr.Delete();
        }
        SqlCommandBuilder buil = new SqlCommandBuilder(adpt);
        adpt.Update(ds, "Student");
        GridView1.DataBind();
        refreshPage();
    }
}
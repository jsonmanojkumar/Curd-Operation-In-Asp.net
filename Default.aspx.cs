using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page
{
    static int id;
    public int Salery;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            getEmpDetails();
            update.Visible = false;
        }
    }


    //       insert employee data       // 

    protected void Button1_Click(object sender, EventArgs e)
    {      
        try
        {
            Employee emp = new Employee();
            emp.Name = txtName.Text;
            emp.Email = txtEmail.Text;
            emp.Mobile = txtMobile.Text;
            emp.Age = txtAge.Text;
            emp.Department = txtDepartment.Text;
            emp.Salery = int.Parse(txtSalery.Text);
            emp.Address = txtAddress.Text;
            emp.save();
            lblMsg.Text = "Data Successfully Save";
            txtName.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
            txtAge.Text = "";
            txtDepartment.Text = "";
            txtSalery.Text = "";
            txtAddress.Text = "";
        }
        catch (Exception ex)
        {
            lblMsg.Text = ex.Message;
        }
    }




    //         get employeee all data in repter  
    public void getEmpDetails()
    {
        try
        {
            Employee emp = new Employee();
            DataSet ds = emp.getEmpDetails("select * from employee");
            rpEmployee.DataSource = ds;
            rpEmployee.DataBind();
        }
        catch 
        {

        }
    }


    //      edit and delete employee data       // 
    protected void rpEmployee_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        id = int.Parse(e.CommandArgument.ToString());
        string cmdname = e.CommandName.ToString();

        if (cmdname == "delete")
        {
            Employee empdata = new Employee();
            empdata.Delete("DELETE FROM EMPLOYEE WHERE id=" + id);
            getEmpDetails();
        }
        else if(cmdname=="edit")
        {
            EditEmployee();
        }
    }


    //      retrive  employee data  in textboxs     // 
    public void EditEmployee()
    {
        Employee emp = new Employee();
        DataSet ds = emp.getEmpDetails("select * from employee where id=" + id);
        txtName.Text = ds.Tables[0].Rows[0]["name"].ToString();
        txtMobile.Text = ds.Tables[0].Rows[0]["mobile"].ToString();
        txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
        txtAge.Text = ds.Tables[0].Rows[0]["age"].ToString();
        txtDepartment.Text = ds.Tables[0].Rows[0]["department"].ToString();
        txtSalery.Text = ds.Tables[0].Rows[0]["salery"].ToString();
        txtAddress.Text = ds.Tables[0].Rows[0]["address"].ToString();
       
        update.Visible = true;
        Button1.Visible = false;
    }



    //       update employee data       // 
    protected void update_Click(object sender, EventArgs e)
    {
        Employee emp = new Employee();
        emp.Name = txtName.Text;
        emp.Mobile = txtMobile.Text;
        emp.Email = txtEmail.Text;
        emp.Age = txtAge.Text;
        emp.Department = txtDepartment.Text;
        emp.Salery = int.Parse(txtSalery.Text);
        emp.Address = txtAddress.Text;
        emp.Update(id);
        getEmpDetails();
    }


}
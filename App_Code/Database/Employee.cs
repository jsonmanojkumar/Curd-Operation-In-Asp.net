using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

public class Employee
{
 
    public Employee()
    {
        //
        // TODO: Add constructor logic here
    }

    //      save employee data 
    public void save()
    {       
        List<MySqlParameter> param = new List<MySqlParameter>();
        param.Add(new MySqlParameter("@name", Name));
        param.Add(new MySqlParameter("@email", Email));
        param.Add(new MySqlParameter("@mobile", Mobile));
        param.Add(new MySqlParameter("@age", Age));
        param.Add(new MySqlParameter("@department", Department));
        param.Add(new MySqlParameter("@salery", Salery));
        param.Add(new MySqlParameter("@address", Address));
        Connection connect = new Connection();
        connect.ExecStatement("INSERT INTO employee(name,email,mobile,age,department,salery,address) VALUES(@name,@email,@mobile,@age,@department,@salery,@address)", param);
        connect.Dispose();
        connect = null;
    }

    //      delete employee data 
    public void Delete(string query)
    {
        Connection connect = new Connection();
        connect.ExecStatement(query);
        connect.Dispose();
        connect = null;
    }



    //      delete employee data 
    public void Update(int Id)
    {
        List<MySqlParameter> parms = new List<MySqlParameter>();
        parms.Add(new MySqlParameter("@name", Name));
        parms.Add(new MySqlParameter("@mobile", Mobile));
        parms.Add(new MySqlParameter("@email", Email));
        parms.Add(new MySqlParameter("@age", Age));
        parms.Add(new MySqlParameter("@department", Department));
        parms.Add(new MySqlParameter("@salery", Salery));
        parms.Add(new MySqlParameter("@address", Address));
        Connection connect = new Connection();
        connect.ExecStatement("UPDATE EMPLOYEE SET name=@name,mobile=@mobile,email=@email,department=@department,salery=@salery,address=@address where id=" + Id, parms);
        connect.Dispose();
        connect = null;
    }

 

    public DataSet getEmpDetails(String query)
    {
        Connection connect = new Connection();
        List<SqlParameter> param = new List<SqlParameter>();
        DataSet ds = connect.GetDataset(query);
        return ds;
    }


    public int Id { get; set; }
    public string Name { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
    public string Age { get; set; }
    public string Department { get; set; }
    public int Salery { get; set; }
    public string Address { get; set; }
    public bool HasValue { get; set; }
}
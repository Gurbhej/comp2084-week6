﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//refrence the model binding library
using System.Web.ModelBinding;
namespace Week6
{
    public partial class department_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            // connect
            var conn = new gurbhejEntities();

            //use the Student class to create a new department Object
            Department d = new Department();

            // Fill the properties of the new department object
            d.Name = txtName.Text;
            d.Budget = Convert.ToDecimal(txtBudget.Text);
           

            //save the new object to the database
            conn.Departments.Add(d);
            conn.SaveChanges();

            //redirect to the departments page
            Response.Redirect("departments.aspx");

        }
    }
}
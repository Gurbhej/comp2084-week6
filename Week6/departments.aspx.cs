﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// add 2 references to access the database
using System.Web.ModelBinding;

namespace Week6
{
    public partial class departments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // get the departments and display in the gridview
            getDepartments();
        }

        protected void getDepartments()
        {
            // connect to db
            var conn = new gurbhejEntities();

            // run the query using LINQ
            var Departments = from d in conn.Departments
                              select d;

            // display query result in gridview
            grdDepartments.DataSource = Departments.ToList();
            grdDepartments.DataBind();

        }
    }
}
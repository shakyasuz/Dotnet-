using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databasedemo
{
      class displaydemo
    {
        public void retrieve()
        {
            //connection
            String cs="Data Source=DESKTOP-D4FM6E2;Initial Catalog=db_student; Integrated Security=true";
            try
            {
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                //retriving all data from database table 
                string disQuery = "select * from tbl_std";
                SqlCommand sc=new SqlCommand (disQuery, conn);
                SqlDataReader row= sc.ExecuteReader ();
                while (row.Read())
                {
                    Console.WriteLine ("id is " + row["id"]);
                    Console.WriteLine("name is" + row["name"]);
                    Console.WriteLine("gender is" + row["gender"]);
                    Console.WriteLine("faculty is" + row["faculty"]);
                    Console.WriteLine("grade is" + row["grade"]);
                    Console.WriteLine("---------------------------------");                            
                }
                row.Close ();
                Console.WriteLine ("------------------------------------------");
                //display the record of student whose gener is male
                String disMale = "select * from tbl_std where gender='male'";
                SqlCommand sc1=new SqlCommand (disMale, conn);
                SqlDataReader row1= sc1.ExecuteReader ();
                while (row1.Read())
                {
                    Console.WriteLine("id is " + row1["id"]);
                    Console.WriteLine("name is" + row1["name"]);
                    Console.WriteLine("gender is" + row1["gender"]);
                    Console.WriteLine("faculty is" + row1["faculty"]);
                    Console.WriteLine("grade is" + row1["grade"]);
                    Console.WriteLine("---------------------------------");
                }

            }
            catch (SqlException s) {
            Console.WriteLine(s);
            }
        }
    }
}

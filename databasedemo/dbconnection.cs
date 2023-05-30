using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Net.NetworkInformation;

namespace databasedemo
{
    class dbconnection
    {
        public void setConnection()
        {
            //connection string 
            string cs = "Data Source=DESKTOP-D4FM6E2;Initial Catalog=db_student; Integrated Security=true";
            try
            {
                //connecting the database
                SqlConnection conn= new SqlConnection(cs);
                conn.Open();
                //testing connection
                if(conn.State == ConnectionState.Open) {
                    Console.WriteLine("Connected to server and db");
                }
                //creating  table
                //string tblQuery = "create table tbl_std(id int primary key, name varchar(50)," +
                //    "gender varchar(50),faculty varchar(50),grade varchar(50))";
                ////executing query
                //SqlCommand sc = new SqlCommand(tblQuery, conn);
                //int res=sc.ExecuteNonQuery();
                //if (res >= 1)
                //{
                //    Console.WriteLine("Table created");
                //}
                //inserting data in table 
                //string insQuery = "insert into tbl_std values(1,'ram','male','csit','c+')";
                //         SqlCommand scl= new SqlCommand(insQuery, conn);
                //         int res=scl.ExecuteNonQuery();
                //         if(res >= 1 ) {
                //             Console.WriteLine("Data inserted");
                //                 }
                //inserting data using parameter/prepared statement
                Console.WriteLine("enter your id");
              string id=  Console.ReadLine();
                Console.WriteLine("enter your name");
                string name= Console.ReadLine();
                Console.WriteLine("enter your gender");
                string gender= Console.ReadLine();
                Console.WriteLine("enter your faculty");
                string faculty= Console.ReadLine();
                Console.WriteLine("Enter your grade");
                string grade= Console.ReadLine();
                //query
     string insQuery1 = "insert into tbl_std values(@id,@name,@gender,@faculty,@grade)";
                SqlCommand sc2=new SqlCommand(insQuery1,conn);
                sc2.Parameters.AddWithValue("@id", id);
                sc2.Parameters.AddWithValue("@name", name);
                sc2.Parameters.AddWithValue("@gender", gender);
                sc2.Parameters.AddWithValue("@faculty", faculty);
                sc2.Parameters.AddWithValue("@grade", grade);
                int res=sc2.ExecuteNonQuery();
                if(res >= 1) {
                    Console.WriteLine("Data inserted");
                }
            }
            catch(SqlException s)
            {
                Console.WriteLine(s);
            }
        }
    }
}

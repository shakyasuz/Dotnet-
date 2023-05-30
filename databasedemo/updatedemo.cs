using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace databasedemo
{
     class updatedemo
    {
        public void update()
        {
            String cs = "Data Source=DESKTOP-D4FM6E2;Initial Catalog=db_student; Integrated Security=true";
            try
            {
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();
                //update the name of student to hari and grade to A+ whose id is 1
                string upQuery = "update tbl_std set name='Hari', grade='A+' where id=1 ";
                SqlCommand sc = new SqlCommand(upQuery, conn);
                int res = sc.ExecuteNonQuery();
                if(res > 0)
                {
                    Console.WriteLine("Data updated");
                }
            }catch(SqlException s)
            {
                Console.WriteLine(s);   
            }
        }
    }
}

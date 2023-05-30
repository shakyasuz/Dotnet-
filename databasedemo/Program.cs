using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databasedemo
{
    class Program
    {
        static void Main(string[] args)
        {
            dbconnection c1=new dbconnection();
            c1.setConnection();
            //update
            updatedemo u1=new updatedemo();
            u1.update();
            //display
            displaydemo d1=new displaydemo();
            d1.retrieve();
    
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MalamNetCoreWebApi.Models
{
    //טבלת  לקוחות 
    public class Department
    {
        public int DepartmentId { get; set; }     //מספר רץ
        public string DepartmentName { get; set; } // שם חלקה 
        public int ParentID { get; set; } // מחלקת אב      

    }
}

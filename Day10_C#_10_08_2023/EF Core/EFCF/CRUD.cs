using EFCF.Context;
using EFCF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EFCF
{
    internal class CRUD
    {
        public void AddNewDept()
        {
            // using is keyword used to use the context to the entire code
            // context is used to perform some operation on db using empluyeedbcontext - that contain table

            using (var context = new EmployeeDataBase())
            {
                var dept = new Dept()
                {
                    DeptNo = 1,
                    DeptName = "M.Sc Software Systems"
                };

                context.Depts.Add(dept);
                context.SaveChanges();
            }
        } 
        
        public void UpdateDept()
        {
            // using is keywird used to use the context to the entire code
            // context is used to perform some operation on db using empluyeedbcontext - that contain table

            var context = new EmployeeDataBase();

            var seldept = context.Depts.FirstOrDefault(d => d.DeptNo == 1);

            seldept.DeptName = "M.Sc";

            context.SaveChanges();
            
        } 
        
        public void DeleteDept()
        {
            // using is keywird used to use the context to the entire code
            // context is used to perform some operation on db using empluyeedbcontext - that contain table

            var context = new EmployeeDataBase();

            var seldept = context.Depts.FirstOrDefault(d => d.DeptNo == 1);

            context.Depts.Remove(seldept);

            context.SaveChanges();
            
        }



    }
}

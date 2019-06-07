using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Model;

namespace Repository
{
    public class CrudEmployee
    {
        public bool Saved(Empleado EmployeeP)
        {
            using (var context = new BD_BancoEntities())
            {
                context.Empleadoes.Add(EmployeeP);
                context.SaveChanges();
                return true;
            }
        }
    }
}

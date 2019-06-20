using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Model.Model;

namespace Bussiness
{
    public class BussinessEmployee
    {
        CrudEmployee repository = new CrudEmployee();
        public bool Saved(Empleado EmployeeP)
        {
            try
            {
                if (repository.Saved(EmployeeP) != false)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //public bool Delete(Empleado cedula)
        //{
        //    try
        //    {
        //        if (repository.Delete(cedula) != false)
        //            return true;
        //        return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}

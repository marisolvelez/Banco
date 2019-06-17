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
            try
            {
                using (var context = new BD_BancoEntities())
                {
                    context.Empleadoes.Add(EmployeeP);
                    context.SaveChanges();
                    return true;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Empleado Delete(int cedula)
        {
            try
            {
                using (var context = new BD_BancoEntities())
                {
                    var SearchCedula = (from Em in context.Empleadoes
                                       where Em.IdEmployee == cedula
                                       select Em).FirstOrDefault();
                    //SearchCedula.Active = false;
                    //context.SaveChanges();

                    return SearchCedula;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

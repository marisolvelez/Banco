using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Bussiness;
using Model.Model;

namespace ServiceWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.

    public class Service1 : IService1
    {
        BussinessEmployee Bussiness = new BussinessEmployee();

        public bool Saved (Empleado empleadoP)
        {
            if (Bussiness.Saved(empleadoP) != false)
                return true;
            return false;
           
        }

        public bool Update(Empleado EmployeeP)
        {
            throw new NotImplementedException();
        }

        //public bool Update(Empleado EmployeeP)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool Update(EntitiesEmployee EmployeeP)
        //{
        //    //if (Bussiness.Saved(EmployeeP) != false)
        //        return true;
        //    return false;

        //}
    }
}

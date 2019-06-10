using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Helper.DTO
{
    //[Serializable]
    //[DataContract]
    //public class EntitiesEmployee : BindingBase
    //{
    //    [DataMember]
    //    public string FullName { get; set; }
    //    [DataMember]
    //    public string Cargo { get; set; }
    //}

    public class EmployeeDTO : BindingBase
    {
        #region Variables 
        ////debe haver una propiedad privada 
        private string _fullname;
        private string _position;
        private int _id;
        #endregion

        #region Propiedades
        //Propiedades publica es la que va en la vista
        public string FullName
        {
            get { return _fullname; }
            set{SetProperty(ref _fullname, value);}
        }

        public string Position
        {
            get { return _position; }
            set {SetProperty(ref _position, value);}
        }

        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }
        #endregion

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Helper;
using Helper.DTO;

namespace PresentationWPF.Employee
{
    public class EmployeeViewModel : BindingBase
    {
        ServiceReference.Service1Client CallingService = new ServiceReference.Service1Client();

        #region Variables 
        ////debe haver una propiedad privada 
        //private string _fullname;
        //private string _Cargo;
        #endregion

        #region Propiedades
        ////Propiedades publica es la que va en la vista
        //public string fullname
        //{
        //    get { return _fullname; }
        //    set
        //    {
        //        _fullname = value;
        //        OnPropertyChanged();
        //    }
        //}

        //public string Cargo
        //{
        //    get { return _Cargo; }
        //    set
        //    {
        //        _Cargo = value;
        //        OnPropertyChanged();
        //    }
        //}
        #endregion

        private EmployeeDTO _employee = new EmployeeDTO();

        public EmployeeDTO Employee
        {
            get { return _employee; }
            set { _employee = value; }
        }


        #region Commands
        private ICommand _SavedCommand;

        public ICommand SavedCommand
        {
            get
            {
                if (_SavedCommand == null)
                {
                    _SavedCommand = new RelayCommand(param => Saved(), null);
                }
                return _SavedCommand;
            }
        }

        private void Saved()
        {
            try
            {
                Model.Model.Empleado empleadoP = new Model.Model.Empleado();
                empleadoP.FullName = Employee.FullName;
                empleadoP.Position = Employee.Position;
                empleadoP.IdEmployee = Employee.Id;


                CallingService.Saved(empleadoP);
            }
            catch (Exception ex)
            {
                throw ex;
                
            }
        }



        private ICommand _DeleteCommand;

        public ICommand DeleteCommand
        {
            get
            {
                if (_DeleteCommand == null)
                {
                    _DeleteCommand = new RelayCommand(param => Delete(), null);
                }
                return _DeleteCommand;
            }

        }

        public void Delete()
        {

        }


        #endregion

        //public ViewModelMainWindow()
        //{

        //}

        //CallingService service = new CallingService();

    }

}

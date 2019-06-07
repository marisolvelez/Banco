using Helper;
using Helper.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using BindingBase = Helper.BindingBase;

namespace Presentation.EmployeeViewModel
{
        class EmployeeViewModel : BindingBase
        {
            //ServiceTheReference.Service1Client CallingService = new ServiceTheReference.Service1Client();

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
                //entities.FullName = fullname;
                //entities.Cargo = Cargo;

                //CallingService.Saved(entities);
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

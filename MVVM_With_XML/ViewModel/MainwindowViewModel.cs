using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using MVVM_With_XML.Model;

namespace MVVM_With_XML.ViewModel
{
    public class MainwindowViewModel : ViewModelBase
    {
        //private StudentRepository _studentRepository = new StudentRepository();

        private ObservableCollection<Student> _students;
        public ObservableCollection<Student> Students
        {
            get
            {
                if (_students == null)
                {
                    _students = StudentRepository.GetAllCollection();
                }
                return _students;
            }
            set
            {
                _students = value;
                RaisePropertyChanged("Students");
            }
        }

        
    }
}

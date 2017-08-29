using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using MVVM_With_XML.Model;

namespace MVVM_With_XML.ViewModel
{
    public class EditViewModel
    {
        private StudentRepository _studentRepository = new StudentRepository();

        private Student _currentStudent;
        public Student CurrentStudent
        {
            get
            {
                if (_currentStudent == null)
                {
                    _currentStudent = new Student();

                }
                return _currentStudent;
            }
            set
            {
                _currentStudent = value;
            }
        }

        private ICommand _edit;
        public ICommand Edit
        {
            get
            {
                if (_edit == null)
                {
                    _edit = new RelayCommand(() =>
                    {
                        _studentRepository.Edit(new Student() {Id = 0, FirstName = "Edit", LastName = "Edit", Age = 21, Gender = 0});
                    });
                }
                return _edit;
            }
        }

    }
}

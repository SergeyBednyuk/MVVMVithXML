using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;
using GalaSoft.MvvmLight.CommandWpf;
using MVVM_With_XML.Model;

namespace MVVM_With_XML.ViewModel
{
    public class AddViewModel
    {
        private StudentRepository _studentRepository = new StudentRepository();

        private Student _student;
        public Student Student
        {
            get
            {
                if (_student == null)
                {
                    _student = new Student();
                }
                return _student;
            }
            set
            {
                _student = value;
            }
        }

        private ICommand _add;
        public ICommand Add
        {
            get
            {
                if (_add == null)
                {
                    _add = new RelayCommand(() =>
                    {
                        _studentRepository.AddToCollection(_student);
                    });
                }
                return _add;
            }
        }
    }
}

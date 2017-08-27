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
    public class AddWindowViewModel
    {
        private StudentRepository _studentRepository = new StudentRepository();

        public int Id{ get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public int Age{ get; set; }
        public int Gender{ get; set; }


        private ICommand _add;
        public ICommand Add
        {
            get
            {
                if (_add == null)
                {
                    _add = new RelayCommand(() =>
                    {
                        _studentRepository.AddToCollection(new Student()
                        {
                            Id = this.Id,
                            FirstName = this.FirstName,
                            LastName = this.LastName,
                            Age = this.Age,
                            Gender = this.Gender
                        });
                    });
                }
                return _add;
            }
        }
    }
}

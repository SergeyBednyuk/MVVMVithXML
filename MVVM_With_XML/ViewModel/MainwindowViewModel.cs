using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MVVM_With_XML.Model;
using MVVM_With_XML.View;

namespace MVVM_With_XML.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private StudentRepository _studentRepository = new StudentRepository();

        private ObservableCollection<Student> _students;
        public ObservableCollection<Student> Students
        {
            get
            {
                if (_students == null)
                {
                    _students = _studentRepository.GetAllCollection();
                }
                return _students;
            }
            set
            {
                _students = value;
                RaisePropertyChanged("Students");
            }
        }

        public int CurrentSelectId { get; set; }

        private ICommand _add;
        public ICommand Add
        {
            get
            {
                if (_add == null)
                {
                    _add = new RelayCommand(() =>
                    {
                        AddWindowView addWindowView = new AddWindowView();
                        addWindowView.Show();
                    });
                }
                return _add;
            }
        }

        private ICommand _remove;

        public ICommand Remove
        {
            get
            {
                if (_remove == null)
                {
                    _remove = new RelayCommand(() =>
                    {
                        _studentRepository.RemoveIdemTheCollection(CurrentSelectId);
                    });
                }
                return _remove;
            }
        }
      
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVVM_With_XML.Model
{
    public class StudentRepository : INotifyPropertyChanged
    {
        private static XDocument _xDoc = XDocument.Load(@"d:\itstep\WPF\MVVM\MVVM_With_XML\Students.xml");
        private static ObservableCollection<Student> _students;

        public ObservableCollection<Student> Students
        {
            get
            {
                if (_students == null)
                {
                    _students = new ObservableCollection<Student>();
                }
                return _students;
            }
            set
            {
                _students = value;
                OnPropertyChanged("Students");
            }
        }

        public StudentRepository()
        {
            //@"d:\itstep\WPF\MVVM\MVVM_With_XML\Students.xml"

            var data = from node in _xDoc.Element("Students").Elements("Student")
                       select node;

            foreach (XElement node in data)
            {
                Student student = new Student();
                student.Id = Convert.ToInt32(node.Attribute("Id").Value);
                student.FirstName = node.Element("FirstName").Value;
                student.LastName = node.Element("Last").Value;
                student.Age = Convert.ToInt32(node.Element("Age").Value);
                student.Gender = Convert.ToInt32(node.Element("Gender").Value);

                Students.Add(student);
            }
        }

        public ObservableCollection<Student> GetAllCollection()
        {
            return Students;
        }

        public void AddToCollection(Student student)
        {
            XElement newXElement = new XElement("Student",
                new XAttribute("Id", student.Id),
                new XElement("FirstName", student.FirstName),
                new XElement("Last", student.LastName),
                new XElement("Age", student.Age),
                new XElement("Gender", student.Gender));

            _xDoc.Root.Add(newXElement);
            _xDoc.Save(@"d:\itstep\WPF\MVVM\MVVM_With_XML\Students.xml");
        }

        public void RemoveIdemTheCollection(int id)
        {
            var remove = from r in _xDoc.Element("Students").Elements()
                         where r.Attribute("Id").Value == Convert.ToString(id)
                         select r;

            remove.Remove();
            _xDoc.Save(@"d:\itstep\WPF\MVVM\MVVM_With_XML\Students.xml");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

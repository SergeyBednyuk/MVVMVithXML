using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVVM_With_XML.Model
{
    public class StudentRepository
    {
     
        private static ObservableCollection<Student> _students = new ObservableCollection<Student>();

        //public ObservableCollection<Student> Students
        //{
        //    get { return _students; }
        //    set { _students = value; }
        //}

        static StudentRepository()
        {
            //@"d:\itstep\WPF\MVVM\MVVM_With_XML\Students.xml"

            XDocument _xDoc = XDocument.Load(@"d:\itstep\WPF\MVVM\MVVM_With_XML\Students.xml");

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

                _students.Add(student);
            }
        }

        public static ObservableCollection<Student> GetAllCollection()
        {
            return _students;
        }

        public static void AddToCollection()
        {
            
        }
    }
}

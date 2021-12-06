using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabXMLManager
{
    class Student
    {
        public string Group { get; set; } = null;
        public string AreaOfThesis { get; set; } = null;
        public string Professor { get; set; } = null;
        public string Schedule { get; set; } = null;
        public string Stage { get; set; } = null;
        //public IStrategy Alg { get; set; }

        public Student() { }

        public Student(string [] data)
        {
            Group = data[0];
            AreaOfThesis = data[1];
            Professor = data[2];
            Schedule = data[3];
            Stage = data[4];
        }

        public bool Compare(Student student)
        {
            if ((this.Group == student.Group) &&
               (this.AreaOfThesis == student.AreaOfThesis) &&
               (this.Professor == student.Professor) &&
               (this.Schedule == student.Schedule) &&
               (this.Stage == student.Stage))
                return true;
            else
                return false;
        }

        //public Student(IStrategy alg)
        //{
        //    Group = "";
        //    AreaOfThesis = "";
        //    Professor = "";
        //    Schedule = "";
        //    Stage = "";
        //}

        //public List<Student> Algorithm(Student std, string path)
        //{
        //    return Alg.Algorithm(std, path);
        //}
    }
}

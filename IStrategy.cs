using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabXMLManager
{
    interface IStrategy
    {
        List<Student> Algorithm(Student std, string path);
    }
}

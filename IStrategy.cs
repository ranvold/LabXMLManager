using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabXMLManager
{
    /* We use the design pattern Strategy */
    interface IStrategy
    {
        List<Student> Algorithm(Student std, string path);
    }
}

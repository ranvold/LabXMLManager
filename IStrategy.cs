using System.Collections.Generic;

namespace LabXMLManager
{
    /* We use the design pattern Strategy */
    interface IStrategy
    {
        List<Student> Algorithm(Student std, string path);
    }
}

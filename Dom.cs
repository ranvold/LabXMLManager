using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LabXMLManager
{
    class Dom : IStrategy
    {
        XmlDocument doc = new XmlDocument();

        public Dom(string path)
        {
            doc.Load(path);
        }
        public List<Student> Algorithm(Student std, string path)
        {
            throw new NotImplementedException();
        }
    }
}

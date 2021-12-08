
namespace LabXMLManager
{
    class Student
    {
        public string Group { get; set; } = null;
        public string AreaOfThesis { get; set; } = null;
        public string Professor { get; set; } = null;
        public string Schedule { get; set; } = null;
        public string Stage { get; set; } = null;

        public string FullName { get; set; } = "";
        public string ThesisTopic { get; set; } = "";
        public string AuxiliaryMaterials { get; set; } = "";

        public Student() { }

        public Student(string [] info)
        {
            Group = info[0];
            AreaOfThesis = info[1];
            Professor = info[2];
            Schedule = info[3];
            Stage = info[4];
        }

    }
}

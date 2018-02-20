using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3SelfAssessmentLab
{
    public class UProgram
    {
        private string _name;
        private Degree _degree;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Degree Degree
        {
            get { return _degree; }
            set { _degree = value; }
        }

        public UProgram()
        {
            this.Degree = Degree;
        }


        public UProgram(string name)
        {
            this.Name = name;
        }
    }
}

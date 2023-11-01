using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace inhertancelibrary
{
    public class SubjectTeacher : Teacher
    {
        private SubjectTeacher whichSubject;

        public SubjectTeacher WhichSubject
        {
            get { return whichSubject; }
            set { whichSubject = value; }


        }
    }
}

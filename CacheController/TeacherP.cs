using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheController
{
    class TeacherP
    {
        public string uid { get; set; }
        public string teamID { get; set; }
        public TeacherP(string teamID, string teacherID)
        {
            this.uid = teacherID;
            this.teamID = teamID;
        }
    }
}

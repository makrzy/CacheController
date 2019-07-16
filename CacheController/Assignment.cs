using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheController
{

    class Assignment
    {
        private static Random rnd = new Random();
        public string assignmentID { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int avgSubmissionTimes { get; set; }
        public int avgDuration { get; set; }
        public int numOfLateSubmissions { get; set; }
        public int numOntimeSubmissions { get; set; }

        public Assignment(string name, DateTime CreatedTime)
        {
            this.assignmentID = name;
            this.CreatedDateTime = CreatedTime;
            this.avgDuration = rnd.Next(1, 10);
            this.avgSubmissionTimes = rnd.Next(0, 24);
            this.numOfLateSubmissions = rnd.Next(0, 4);
            this.numOntimeSubmissions = rnd.Next(10, 20);
        }
    }
}

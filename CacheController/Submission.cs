using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheController
{
    class Submission
    {
        public string assignmentID { get; set; }
        public string studentID { get; set; }
        public DateTime submissionTime { get; set; }
        public DateTime createdTime { get; set; }
        public DateTime dueDateTime { get; set; }
        public int duration { get; set; }
        public bool ontime { get; set; }
        public Submission(string studentID, string assignmentID, DateTime submissionTime, bool OnTime, int duration, DateTime createdTime, DateTime dueDateTime)
        {
            this.studentID = studentID;
            this.assignmentID = assignmentID;
            this.submissionTime = submissionTime;
            this.duration = duration;
            this.ontime = OnTime;
            this.createdTime = createdTime;
            this.dueDateTime = dueDateTime;
        }
    }
}

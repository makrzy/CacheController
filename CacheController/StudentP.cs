using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheController
{
    class StudentP
    {
        public string uid { get; set; }
        public string teamID { get; set; }
        public int posts { get; set; }
        public int replies { get; set; }
        public int expands { get; set; }
        public int bookmarks { get; set; }

        public List<Submission> submissions = new List<Submission>();
        public StudentP(string teamID, string uid, int post, int reply, int expand, int bookmark)
        {
            this.uid = uid;
            this.teamID = teamID;
            this.posts = post;
            this.replies = reply;
            this.expands = expand;
            this.bookmarks = bookmark;

            DateTime submissionTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 5, 14, 30, 30);
            DateTime createdTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1, 10, 39, 30);
            DateTime dueDateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 8, 10, 39, 30);
            Submission a = new Submission(uid, "HW 1-1", submissionTime, true, 89, createdTime, dueDateTime);

            submissionTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 5, 13, 30, 30);
            createdTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 2, 10, 39, 30);
            dueDateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 9, 10, 39, 30);
            Submission b = new Submission(uid, "HW 1-2", submissionTime, true, 65, createdTime, dueDateTime);

            submissionTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 10, 3, 30, 30);
            createdTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 2, 10, 39, 30);
            dueDateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 9, 10, 39, 30);
            Submission c = new Submission(uid, "HW 1-3", submissionTime, false, 185, createdTime, dueDateTime);

            submissionTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 10, 3, 30, 30);
            createdTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 4, 10, 39, 30);
            dueDateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 11, 10, 39, 30);
            Submission d = new Submission(uid, "HW 2-1", submissionTime, true, 137, createdTime, dueDateTime);

            submissionTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 15, 3, 30, 30);
            createdTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 5, 10, 39, 30);
            dueDateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 12, 10, 39, 30);
            Submission e = new Submission(uid, "HW 2-2", submissionTime, false, 233, createdTime, dueDateTime);

            submissions.Add(a);
            submissions.Add(b);
            submissions.Add(c);
            submissions.Add(d);
            submissions.Add(e);
        }
    }
}

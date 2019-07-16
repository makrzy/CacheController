using System;
using System.Collections.Generic;

namespace CacheController
{
    class Classroom
    {
        public string teamID { get; set; }
        public int postTotal { get; set; }
        public int replyTotal { get; set; }
        public int expandTotal { get; set; }
        public int bookmarkTotal { get; set; }
        public int maxPost { get; set; }
        public int maxReplies { get; set; }
        public int maxBookmarks { get; set; }
        public int maxExpands { get; set; }
        public string maxPostsID { get; set; }
        public string maxExpandsID { get; set; }
        public string maxRepliesID { get; set; }
        public string maxBookmarkID { get; set; }

        public List<Assignment> assignments { get; set; }
        public int[] activity { get; set; }

        public Classroom()
        {
            Random rnd = new Random();
            this.teamID = "da00d372-9efe-4d9a-9662-5fe8198564ad";
            this.postTotal = rnd.Next(0, 100);
            this.replyTotal = rnd.Next(0, 100);
            this.expandTotal = rnd.Next(0, 100);
            this.bookmarkTotal = rnd.Next(0, 100);
            
            int postTotalTemp = this.postTotal;
            int replyTotalTemp = this.replyTotal;
            int expandTotalTemp = this.expandTotal;
            int bookmarkTotalTemp = this.bookmarkTotal;

            int alexPostCount = rnd.Next(0, postTotalTemp);
            postTotalTemp -= alexPostCount;
            int adelePostCount = rnd.Next(0, postTotalTemp);
            postTotalTemp -= adelePostCount;
            int samPostCount = rnd.Next(0, postTotalTemp);
            postTotalTemp -= samPostCount;

            int alexReplyCount = rnd.Next(0, replyTotalTemp);
            replyTotalTemp -= alexReplyCount;
            int adeleReplyCount = rnd.Next(0, replyTotalTemp);
            replyTotalTemp -= adeleReplyCount;
            int samReplyCount = rnd.Next(0, replyTotalTemp);
            replyTotalTemp -= samReplyCount;

            int alexExpandCount = rnd.Next(0, expandTotalTemp);
            expandTotalTemp -= alexExpandCount;
            int adeleExpandCount = rnd.Next(0, expandTotalTemp);
            expandTotalTemp -= adeleExpandCount;
            int samExpandCount = rnd.Next(0, expandTotalTemp);
            expandTotalTemp -= samExpandCount;

            int alexBookmarkCount = rnd.Next(0, bookmarkTotalTemp);
            bookmarkTotalTemp -= alexBookmarkCount;
            int adeleBookmarkCount = rnd.Next(0, bookmarkTotalTemp);
            bookmarkTotalTemp -= adeleBookmarkCount;
            int samBookmarkCount = rnd.Next(0, bookmarkTotalTemp);
            bookmarkTotalTemp -= samBookmarkCount;

            this.maxPostsID = "AlexW@M365EDU552193";
            this.maxRepliesID = "AdeleV@M365EDU552193";
            this.maxExpandsID = "SamuelP@M365EDU552193";
            this.maxBookmarkID = "AlexW@M365EDU552193";

            assignments = new List<Assignment>();
            var time = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1, 10, 39, 30);
            Assignment one = new Assignment("HW 1-1", time);
            assignments.Add(one);
            time = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 2, 10, 39, 30);
            Assignment two = new Assignment("Hw 1-2", time);
            assignments.Add(two);
            time = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 2, 10, 39, 30);
            Assignment three = new Assignment("HW 1-3", time);
            assignments.Add(three);
            time = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 4, 10, 39, 30);
            Assignment four = new Assignment("HW 2-1", time);
            assignments.Add(four);
            time = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 5, 10, 39, 30);
            Assignment five = new Assignment("HW 2-2", time);
            assignments.Add(five);

            int[] activity = { 10, 11, 12, 9, 8, 7, 7, 4, 0, 0, 1, 0, 3, 4, 5, 7, 12, 16, 16, 20, 18, 10, 8, 3};
        }
    }
}

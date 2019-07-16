using System;
using System.Windows.Forms;
using StackExchange.Redis;
using System.Configuration;
using Newtonsoft.Json;

namespace CacheController
{
    static class Program
    {
        /// <summary>
        /// Creates form and all buttons.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 myForm = new Form1();
            Application.Run(myForm);
        }

        private static Lazy<ConnectionMultiplexer> lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
        {
            string cacheConnection = ConfigurationManager.AppSettings["CacheConnection"].ToString();
            var options = ConfigurationOptions.Parse(cacheConnection);
            options.ConnectRetry = 5;
            options.AllowAdmin = true;

            return ConnectionMultiplexer.Connect(options);
        });

        public static ConnectionMultiplexer Connection
        {
            get
            {
                return lazyConnection.Value;
            }
        }

        /// <summary>
        /// Insert sample into Redis Cache as proof of concept.
        /// </summary>
        /// <param name="sender">Button which called 'Insert'</param>
        public static void Insert(object sender, System.EventArgs e)
        {
            string textPrior = ((Button)sender).Text;
            ((Button)sender).Text = "working";

            IDatabase cache = lazyConnection.Value.GetDatabase();

            string cacheCommand = "SET Maciej2 \"Hello! MACIEJS TEST\"";
            Console.WriteLine("\nCache command  : " + cacheCommand + " or StringSet()");
            Console.WriteLine("Cache response : " + cache.StringSet("Maciej2", "Hello! MACIEJS TEST!").ToString());

            ((Button)sender).Text = textPrior;
        }

        /// <summary>
        /// Insert class object into Redis Cache.
        /// </summary>
        /// <param name="sender">Button which called 'InsertClass'</param>
        public static void InsertClass(object sender, System.EventArgs e)
        {
            string textPrior = ((Button)sender).Text;
            ((Button)sender).Text = "working";
            Classroom myClass = new Classroom();

            Random rnd = new Random();
            StudentP alex = new StudentP(myClass.teamID, "AlexW@M365EDU552193",  26 + rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25), 26 + rnd.Next(0, 25));
            StudentP adele = new StudentP(myClass.teamID, "AdeleV@M365EDU552193", rnd.Next(0, 25), 26 + rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25));
            StudentP sam = new StudentP(myClass.teamID, "SamuelP@M365EDU552193", rnd.Next(0, 25), rnd.Next(0, 25), 26 + rnd.Next(0, 25), rnd.Next(0, 25));

            myClass.maxPost = alex.posts;
            myClass.maxReplies = adele.replies;
            myClass.maxBookmarks = alex.bookmarks;
            myClass.maxExpands = sam.expands;

            string myClassString = JsonConvert.SerializeObject(myClass);
            string alexString = JsonConvert.SerializeObject(alex);
            string adeleString = JsonConvert.SerializeObject(adele);
            string samString = JsonConvert.SerializeObject(sam);

            IDatabase cache = lazyConnection.Value.GetDatabase();

            string cacheCommand = "SET " + myClass.teamID + " " + myClassString;
            Console.WriteLine("\nCache command  : " + cacheCommand + " or StringSet()");
            Console.WriteLine("Cache response : " + cache.StringSet(myClass.teamID, myClassString).ToString());

            cacheCommand = "SET " + adele.uid + " " + adeleString;
            Console.WriteLine("\nCache command  : " + cacheCommand + " or StringSet()");
            Console.WriteLine("Cache response : " + cache.StringSet(myClass.teamID + ";" + adele.uid, adeleString).ToString());

            cacheCommand = "SET " + sam.uid + " " + samString;
            Console.WriteLine("\nCache command  : " + cacheCommand + " or StringSet()");
            Console.WriteLine("Cache response : " + cache.StringSet(myClass.teamID + ";" + sam.uid, samString).ToString());

            cacheCommand = "SET " + alex.uid + " " + alexString;
            Console.WriteLine("\nCache command  : " + cacheCommand + " or StringSet()");
            Console.WriteLine("Cache response : " + cache.StringSet(myClass.teamID + ";" + alex.uid, alexString).ToString());

            ((Button)sender).Text = textPrior;
        }
        /**
        /// <summary>
        /// Add an assignment to a class object and reinsert into the Redis cache.
        /// </summary>
        /// <param name="sender">Button which called 'AddAssignmentSubmission'</param>
        public static void AddAssignmentSubmission(object sender, System.EventArgs e)
        {
            string textPrior = ((Button)sender).Text;
            ((Button)sender).Text = "working";
            Classroom myClass = new Classroom();
            Assignment toAdd = new Assignment("HW 2-2", "07:12:2019:14", "07:26:2019:12");
            myClass.assignments.Add(toAdd);

            string myClassString = JsonConvert.SerializeObject(myClass);
            IDatabase cache = lazyConnection.Value.GetDatabase();

            string cacheCommand = "SET " + myClass.teamID + " " + myClassString;
            Console.WriteLine("\nCache command  : " + cacheCommand + " or StringSet()");
            Console.WriteLine("Cache response : " + cache.StringSet(myClass.teamID, myClassString).ToString());

            ((Button)sender).Text = textPrior;
        }
        */
        /// <summary>
        /// Flush all contents of Redis cache. BE CAREFUL.
        /// </summary>
        /// <param name="sender">Button which called 'FlushAll'</param>
        public static void FlushAll(object sender, System.EventArgs e)
        {
            string textPrior = ((Button)sender).Text;
            ((Button)sender).Text = "working";

            IServer server = lazyConnection.Value.GetServer("classroomanalytics.redis.cache.windows.net", 6380);

            string cacheCommand = "FLUSHDB";
            Console.WriteLine("\nCache command  : " + cacheCommand);
            Console.WriteLine("Endpoints : " + lazyConnection.Value.GetEndPoints()[0]);
            server.FlushDatabase();

            ((Button)sender).Text = textPrior;
        }

        /// <summary>
        /// Destroy the connection to the Redis Cache when form closes.
        /// </summary>
        /// <param name="sender">Button which called 'OnFormClose'</param>
        public static void OnFormClose(object sender, System.EventArgs e)
        {
            Console.WriteLine("\nConnection Disposed");
            lazyConnection.Value.Dispose();
        }
    }
}

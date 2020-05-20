using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coursal_IT_2020_spring
{
        public class JournalDBSettings : IJournalDBSettings
        {
            public string DBCollection { get; set; }
            public string connectionStr { get; set; }
            public string DatabaseName { get; set; }
        }

        public interface IJournalDBSettings
        {
            string DBCollection { get; set; }
            string connectionStr { get; set; }
            string DatabaseName { get; set; }
        }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitOne.BuildScreen.Models
{
    using System.ComponentModel;

    public class TestDetailDto
    {
        public string Name { get; internal set; }
        internal DateTime Started { get; set; }
        internal DateTime Completed { get; set; }

        public TimeSpan TimeTaken
        {
            get
            {
                return Completed - Started;
            }
        }

        public TestDetailDto(string name, DateTime started, DateTime completed)
        {
            Name = name;
            Started = started;
            Completed = completed;
        }


    }
}

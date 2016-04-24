using System;

namespace OrbitOne.BuildScreen.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class BuildInfoDto
    {
        public string TeamProjectCollection { get; set; }
        public string TeamProject { get; set; }
        public string Builddefinition { get; set; }
        public string Status { get; set; }
        public string RequestedByName { get; set; }
        public string RequestedByPictureUrl { get; set; }
        public DateTime StartBuildDateTime { get; set; }
        public DateTime FinishBuildDateTime { get; set; }
        public TimeSpan LastBuildTime { get; set; }
        public int TotalNumberOfTests { get; set; }
        public int PassedNumberOfTests { get; set; }
        public string Id { get; set; }
        public string BuildReportUrl { get; set; } 

        //public IList<TestDetailDto> TestDetail { get; set; }

        //public IList<TestDetailDto> WorstTests
        //{
        //    get
        //    {
        //        if (TestDetail != null)
        //        {
        //            return TestDetail.OrderBy(x => x.TimeTaken).Take(5).ToList();
        //        }
        //        return new List<TestDetailDto>();
        //    }
        //}

        public TimeSpan TotalBuildTime
        {
            get
            {
                return FinishBuildDateTime - StartBuildDateTime;
            }
        }
    }
}
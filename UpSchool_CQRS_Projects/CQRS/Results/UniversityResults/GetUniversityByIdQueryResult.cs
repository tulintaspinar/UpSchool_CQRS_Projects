﻿namespace UpSchool_CQRS_Projects.CQRS.Results.UniversityResults
{
    public class GetUniversityByIdQueryResult
    {
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Population { get; set; }
    }
}

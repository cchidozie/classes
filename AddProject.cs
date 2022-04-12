using System;


namespace classes
{
    public class AddProject
    {
        string ProjectName;
        string Status;
        string StartDate;
        string EndDate;
        string Assignee;

        public AddProject(string projectName, string status, string startDate, string endDate, string assignee)
        {
            ProjectName = projectName;
            Status = status;
            StartDate = startDate;
            EndDate = endDate;
            Assignee = assignee;

        }

        public string printProject()
        {

            return string.Format($"Hi {Assignee}, you have been assigned the project {ProjectName} starting today {StartDate} till {EndDate}. Oce completed, please change the project status to {Status}");
        }

    }
}

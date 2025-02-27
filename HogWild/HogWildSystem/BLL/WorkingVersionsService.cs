#nullable disable
using HogWildSystem.DAL;
using HogWildSystem.Entities;
using HogWildSystem.ViewModels;
using Microsoft.EntityFrameworkCore.ChangeTracking;


namespace HogWildSystem.BLL
{
    public class WorkingVersionsService
    {
        //  hog wild context
        private readonly HogWildContext _hogWildContext;

        //  Constructor for the WorkingVersionsService class.
        internal WorkingVersionsService(HogWildContext hogWildContext)
        {
            //  Initialize the _hogWildContext fiekd with the provieded HogWildContext instance.
            _hogWildContext = hogWildContext;
        }

        //  This method retrieves the working version view
        public WorkingVersionsView GetWorkingVersion()
        {
            return _hogWildContext.WorkingVersions
                    .Select(x => new WorkingVersionsView
                    {
                        VersionID = x.VersionId,
                        Major = x.Major,
                        Minor = x.Minor,
                        Build = x.Build,
                        Revision = x.Revision,
                        AsOfDate = x.AsOfDate,
                        Comments = x.Comments
                    }).FirstOrDefault();
        }

    }
}

#nullable disable
using HogWildSystem.DAL;
using HogWildSystem.ViewModels;

namespace HogWildSystem.BLL
{
    public class WorkingVersionsService
    {
        #region Fields
        // hog wild context
        private readonly HogWildContext _hogWildContext;

        #endregion
       //   Constructor for the WorkingVersionsService class
       internal WorkingVersionsService(HogWildContext hgHogWildContext)
       {
            //   Initialize the _hogWildContext field wiht the provided HogWildContext
            _hogWildContext = hgHogWildContext;
        }

       //   this method retrieves the working version
       public WorkingVersionsView GetWorkingVersion()
       {
           return _hogWildContext.WorkingVersions
               .Select(x => new WorkingVersionsView()
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

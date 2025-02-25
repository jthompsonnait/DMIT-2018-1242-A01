using HogWildSystem.DAL;


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

    }
}

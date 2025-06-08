using System.Data;

namespace Pepro.Business {
    public class CJobBLL {
        #region Singleton Design Pattern
        private static CJobBLL instance;

        public static CJobBLL Instance {
            // The null-coalescing operators
            get => instance ?? (instance = new CJobBLL());
            private set => instance = value;
        }

        private CJobBLL() { }
        #endregion

        public DataTable GetAllFromProject(string strProjectId) {
            return DataAccess.CJobDAL.Instance.GetAllFromProject(strProjectId);
        }
        
        public DataTable GetAllByEmployee(string strEmployeeId) {
            return DataAccess.CJobDAL.Instance.GetAllByEmployee(strEmployeeId);
        }
        
        public DataTable GetManager(string strJobId) {
            return DataAccess.CJobDAL.Instance.GetManager(strJobId);
        }
    }
}

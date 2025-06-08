using System.Data;

namespace Pepro.Business {
    public class CProjectBLL {
        #region Singleton Design Pattern
        private static CProjectBLL instance;

        public static CProjectBLL Instance {
            get => instance ?? (instance = new CProjectBLL());
            private set => instance = value;
        }

        private CProjectBLL() { }
        #endregion

        public DataTable GetProjectList() {
            return DataAccess.CProjectDAL.Instance.GetProjectList();
        }
    }
}

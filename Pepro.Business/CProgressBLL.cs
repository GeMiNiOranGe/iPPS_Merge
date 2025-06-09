using Pepro.DataAccess;
using Pepro.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pepro.Business
{
    public class CProgressBLL
    {
        public static string getNumberofDocumentbyJobID(string jobID)
        {
            return CProgressDAL.Instance.getNumberofDocumentbyJobID(jobID);
        }
        public static string getTotalDocumentbyJobID(string jobID)
        {
            return CProgressDAL.Instance.getTotalDocumentbyJobID(jobID);
        }
    }
}

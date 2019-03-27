using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PTSLibraryRecent
{
  public  class CustomerFacade : SuperFacade
    {
        private DAO.CustomerDAO dao;
        public CustomerFacade(): base(new DAO.CustomerDAO())
        {
            dao = (DAO.CustomerDAO)base.dao;
        }
        public Project[] GetListOfProjects(int customerId)
        {
            return (dao.GetListOfProjects(customerId)).ToArray();
        }
        public int Authenticate(string username, string password)
        {
            if (username == "" || password == "")
            {
                throw new Exception("Missing Data");
            }
            return dao.Authenticate(username, password);
        }
    }
}
        
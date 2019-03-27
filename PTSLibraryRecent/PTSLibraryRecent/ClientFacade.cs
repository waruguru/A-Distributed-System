using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibraryRecent
{
  public  class ClientFacade :SuperFacade
    {
        private DAO.ClientDAO dao;

        public ClientFacade()
            :base(new DAO.ClientDAO())
        {
            dao = (DAO.ClientDAO)base.dao;
        }
        public TeamLeader Authenticate(string username, string password)
        {
            if(username== "" || password == "")
            {
                throw new Exception("Missing Data");

            }
            return dao.Authenticate(username, password);
        }
        public Project[] GetListOfProjects(int teamId)
        {
            return (dao.GetListOfProjects(teamId)).ToArray();
        }

    }
}

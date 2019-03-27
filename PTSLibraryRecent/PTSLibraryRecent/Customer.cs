using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibraryRecent
{
    [Serializable]
 public   class Customer:User
    {
        public Customer () {}
    
    
        public Customer(string name,int id)
        {
            //name  and id are inherited from the user
            this.name = name;
           this.id = id;
        }
    }
}

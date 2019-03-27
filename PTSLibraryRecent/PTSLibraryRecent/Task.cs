using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibraryRecent
{
    [Serializable]
     public class Task
    {
        private Guid taskId;
        private string name;
        private Status status;

        public Task() { }
        public string NameAndStatus
        {
            get { return name + " - " + status; }
        }

        public Guid TaskId
        {
            get { return taskId; }
            set { taskId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Status theStatus
        {
            get { return status; }
            set { status = value; }
        }
        public Task( Guid id,string name, Status status)
        {
            this.taskId = id;
            this.name = name;
            this.status=status;
        }
    }
}

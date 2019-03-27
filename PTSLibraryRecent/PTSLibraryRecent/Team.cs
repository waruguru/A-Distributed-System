﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibraryRecent
{
     [Serializable]
    public class Team
    {
        private int id;
        private string location;
        private string name;
        private TeamLeader leader;

        public Team() { }

        public int TeamId
        {
            get { return id; }
            set { id = value; }

        }
        public TeamLeader Leader
        {
            get { return leader; }
            set { leader = value; }
        }
public string Location
{
    get{return location;}
    set{location=value;}
}
        public string Name
{
    get { return name; }
    set { name = value; }
}
    public Team(int id,string location, string name,TeamLeader leader)
    {
        this.location = location;
        this.name = name;
        this.id = id;
            this.leader=leader;

    }
       public string NameAndStatus
    {
        get
        { return name + "-" + status; }
    }



       public string status { get; set; }
    }
}

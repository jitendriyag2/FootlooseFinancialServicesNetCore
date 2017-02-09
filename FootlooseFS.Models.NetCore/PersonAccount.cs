﻿namespace FootlooseFS.Models
{
    public class PersonAccount
    {
        public int PersonID { get; set; }
        public int AccountID { get; set; }
        public int RelationshipTypeID { get; set; }

        public virtual Account Account { get; set; }
        public virtual RelationshipType RelationshipType { get; set; }
    }
}

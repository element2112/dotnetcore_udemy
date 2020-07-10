using System;

namespace Domain
{
    // code first: write code first then create the db scripts
    public class Value
    {
        public int Id { get; set; } // entity framework will automatically see an Id property and use this as the primary key
        public string Name { get; set; }


    }
}

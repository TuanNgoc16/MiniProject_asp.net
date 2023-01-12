﻿namespace ShowRooms.Models
{
    public class Store
    {
        public int ID { get; set; }

        public string? Name { get; set; }


        public ICollection<Car_store>? Car_store { get; set; }

       public List<Contact>? Contacts { get; set; }
        public List<Service>? Service { get; set; }


    }
}

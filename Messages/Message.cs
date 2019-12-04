using System;

namespace Message
{
    public class Message
    {
        public Message(int id, string name, DateTime createdDate)
        {
            Id = id;
            Name = name;
            CreatedDate = createdDate;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public DateTime CreatedDate { get; private set; }
    }
}

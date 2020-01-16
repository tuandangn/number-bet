using System;

namespace NB.Crawler.Core
{
    [Serializable]
    public class BaseEntity
    {
        public BaseEntity() { }

        public BaseEntity(int id) => Id = id;

        public int Id { get; protected set; }
    }
}

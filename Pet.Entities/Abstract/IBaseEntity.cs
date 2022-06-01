namespace Pet.Entities.Abstract
{
    public interface IBaseEntity
    {
        public Guid Id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = Guid.NewGuid();
            }
        }


        public DateTime CreateTime
        {
            get { return CreateTime; }
            set { value = DateTime.UtcNow; }
        }

        public DateTime UpdateTime
        {
            get { return CreateTime; }
            set { value = DateTime.UtcNow; }

        }

    }
}

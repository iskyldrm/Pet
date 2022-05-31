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

        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime 
        { 
            get
            {
                return DateTime.UtcNow;
            } 
            set
            {
                CreateTime = value;
            }
        }

    }
}

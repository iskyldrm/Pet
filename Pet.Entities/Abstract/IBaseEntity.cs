namespace Pet.Entities.Abstract
{
    public interface IBaseEntity
    {
        public int Id { get; set; }

        
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

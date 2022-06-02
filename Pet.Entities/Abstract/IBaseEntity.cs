namespace Pet.Entities.Abstract
{
    public interface IBaseEntity<T> where T : struct
    {
        public T Id { get; set; }
        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

    }
}

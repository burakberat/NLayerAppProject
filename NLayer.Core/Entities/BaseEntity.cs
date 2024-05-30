namespace NLayer.Core.Entities
{
    public abstract class BaseEntity //new'lenemez.
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}

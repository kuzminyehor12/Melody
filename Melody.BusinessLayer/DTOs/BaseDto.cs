namespace Melody.BusinessLayer.DTOs
{
    public class BaseDto
    {
        public Guid? Id { get; set; } = null;
    }

    public class HasCreatorDto : BaseDto
    {
        public Guid CreatorId { get; set; }
    }
}

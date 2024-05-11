namespace Melody.BusinessLayer.DTOs
{
    public class BaseDto
    {
        public Guid Id { get; set; }
    }

    public class HasCreatorDto : BaseDto
    {
        public Guid CreatorId { get; set; }
    }
}

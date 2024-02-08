namespace Melody.DataLayer.EFCore.Entities
{
    public class DisplayableEntity : BaseEntity
    {
        public string DisplayName { get; set; }

        public string? Coversheet { get; set; }
    }
}

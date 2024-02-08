namespace Melody.BusinessLayer.Requests.Player
{
    public class IncrementItemListeningsRequest
    {
        public Guid ItemId { get; set; }

        public Type ItemType { get; set; }
    }
}

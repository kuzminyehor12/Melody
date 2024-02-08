namespace Melody.BusinessLayer.Requests.Queue
{
    public class EnqueueItemRequest
    {
        public Guid UserId { get; set; }

        public Guid AudioItemId { get; set; }
    }
}

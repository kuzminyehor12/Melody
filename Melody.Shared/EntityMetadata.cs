namespace Melody.Shared
{
    public class EntityMetadata
    {
        public Guid EntityId { get; set; }

        public string Method { get; set; }

        public static EntityMetadata CreateMetadata(Guid entityId, string method)
        {
            return new EntityMetadata { EntityId = entityId, Method = method };
        }
    }
}

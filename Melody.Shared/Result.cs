namespace Melody.Shared
{
    public class Result
    {
        public bool IsSuccess { get; set; }

        public bool IsFailure => !IsSuccess;

        public EntityMetadata? Metadata { get; set; }

        public IEnumerable<string> Errors { get; set; } = Enumerable.Empty<string>();

        public static Result Success(EntityMetadata? metadata = null)
        {
            return new Result { IsSuccess = true, Metadata = metadata };
        }

        public static Result Success(Guid entityId, string method)
        {
            return new Result { IsSuccess = true, Metadata = EntityMetadata.CreateMetadata(entityId, method) };
        }

        public static Result Failure(params Exception[] exceptions)
        {
            return new Result { IsSuccess = false, Errors = exceptions.Select(e => e.Message) };
        }
    }
}

namespace Coverlet1139Repro
{
    public class Class
    {
        public string Property { get; set; }
    }

    public class ClassWithPropertyInit
    {
        public string Property { get; set; } = string.Empty;
    }

    public record AutoRecord(string Prop1, string Prop2);

    public record RecordWithPropertyInit
    {
        public string Id { get; init; } = string.Empty;
    }
}

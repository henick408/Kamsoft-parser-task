namespace Kamsoft.Dto;

public class ParseResponse {
    public bool Success { get; set; }
    public int Count { get; set; }
    public IList<IDictionary<string, object?>> Data { get; set; } = [];
}
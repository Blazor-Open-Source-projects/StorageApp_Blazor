namespace depooo.Shared
{
    public class DataResponse<T>
    {
        public T Data { get; set; }
        public string? Message { get; set; }
        public bool Success { get; set; } = false;
    }
}

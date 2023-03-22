namespace M3_DaveatCorn_WebAPI.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete {  get; set; }
        public string? Secret { get; set; }
    }
}

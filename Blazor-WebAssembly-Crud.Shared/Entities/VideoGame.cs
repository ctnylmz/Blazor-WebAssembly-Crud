namespace Blazor_WebAssembly_Crud.Shared.Entities
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Publisher { get; set; }
        public int? ReleaseYear { get; set; }
    }
}

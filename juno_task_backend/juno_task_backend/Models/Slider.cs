namespace juno_task_backend.Models
{
    public class Slider
    {
        public int Id { get; set; }

        public string Image { get; set; }
        public string Title { get; set; }

        public string SubTitle { get; set; }

        public byte Discount { get; set; }
        public string DiscoverUrl { get; set; }
    }
}

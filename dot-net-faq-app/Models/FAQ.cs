namespace dot_net_faq_app.Models
{
    public class FAQ
    {
        public int FAQId { get; set; }
        public String Question { get; set; } = null!;
        public String Answer { get; set; } = null!;
        public String TopicId { get; set; } = null!;
        public Topic Topic { get; set; } = null!;
        public String CategoryId { get; set; } = null!;
        public Category Category { get; set; } = null!;
    }
}

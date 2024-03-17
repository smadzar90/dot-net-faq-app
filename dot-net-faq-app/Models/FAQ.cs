namespace dot_net_faq_app.Models
{
    public class FAQ
    {
        public int FAQId { get; set; }
        public String Question { get; set; }
        public String Answer { get; set; }
        public String TopicId { get; set; }
        public Topic Topic { get; set; }
        public String CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

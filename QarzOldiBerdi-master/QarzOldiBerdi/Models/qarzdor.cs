namespace QarzOldiBerdi.Models
{
    public class qarzdor
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public ICollection<qarz> qarzlar { get; set; }
    }
    
}

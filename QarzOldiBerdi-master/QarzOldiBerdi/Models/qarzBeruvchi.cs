
namespace QarzOldiBerdi.Models
{
    public class qarzBeruvchi
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public int QarzOluvchiId { get; set; }
            public string Muddat { get; set; }
            public ICollection<qarz> qarzlar{ get; set; }
    }
    
}

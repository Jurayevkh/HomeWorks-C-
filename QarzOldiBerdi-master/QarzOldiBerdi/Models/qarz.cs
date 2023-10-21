
using System.ComponentModel.DataAnnotations.Schema;

namespace QarzOldiBerdi.Models
{
    public class qarz
    {
       
            public int Id { get; set; }


            [ForeignKey(nameof(qarzBeruvchi))]
            public int qarzBeruvchiId { get; set; }


            [ForeignKey(nameof(qarzOluvchi))]
            public int qarzOluvchiId { get; set; }


            public qarzBeruvchi qarzBeruvchi { get; set; }
            public qarz qarzOluvchi { get; set; }
        

    }
}

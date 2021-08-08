using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CODEFIRST_RELATION_WINDEMO
{
    //Key Annotation
   [Table("Results")]
   public class Result
    {
       public Result()
       {

       }
        [Key]
        public int Id { get; set; }
        [ForeignKey("Participant")]
        public int PartId { get; set; }
        public int MathsMrk { get; set; }
        public int PhyMrk { get; set; }
        public int ChemMrk { get; set; }
        public int Total { get; set; }
        public float Perc { get; set; }
       // public ICollection<Participant> Participants { get; set; }
       public Participant Participant { get; set; }

    }
}

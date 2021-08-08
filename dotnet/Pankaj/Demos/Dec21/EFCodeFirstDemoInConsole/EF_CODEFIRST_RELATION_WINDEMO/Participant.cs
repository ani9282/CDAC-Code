using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EF_CODEFIRST_RELATION_WINDEMO
{
    [Table("Participants")]
    public class Participant
    {
        public Participant()
        {
            
        }
       [Key]//
       [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PartId { get; set; }
        public string PartName { get; set; }
        public ICollection<Result> Results { get; set; }

       // public Result Result { get; set; }
        
    }
}

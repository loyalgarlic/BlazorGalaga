using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RankServer.Data
{
    [Table("Ranker")]
    public class Ranker
    {
        [Key]
        public string NickName { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
    }
}

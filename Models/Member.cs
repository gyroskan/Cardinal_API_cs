using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Cardinal_api.Models
{
    public class Member
    {

        [Key]
        public int ID { get; set; }
        [Key]
        public int GuildID__ { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public Guild guild { get; set; }
    }
}
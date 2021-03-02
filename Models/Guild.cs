using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Cardinal_api.Models
{
    public class Guild
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? OwnerID { get; set; }
        public Member Owner { get; set; }
        public List<Member> Members { get; set; }
    }
}
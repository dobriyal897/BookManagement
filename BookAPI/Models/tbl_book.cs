namespace BookAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("tbl_book")]
    public class tbl_book
    {
        [Key]
        
        public int Id { get; set; }

        public string name { get; set; }

        public string authorName { get; set; }

    }
}



using System.ComponentModel.DataAnnotations;

namespace EfDemo.Models.Data
{
    [MetadataType(typeof(AuthorMetaData))]
    public partial class author
    {

    }

    public class AuthorMetaData
    {
        [Required]
        [Display(Name = "First Name")]
        public string au_fname { get; set; }


        [Required]
        [Display(Name = "Last Name")]
        public string au_lname { get; set; }
    }
}
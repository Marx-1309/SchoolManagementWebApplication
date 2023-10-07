using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementWebApp.Models
{
    public class Faculty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long FacultyId { get; set; }

        [Required]
        [StringLength(100)]
        public string FacultyName { get; set; }

        public virtual ICollection<Student>? Students { get; set; }
    }
}

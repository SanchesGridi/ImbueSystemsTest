using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImbueSystemsTest.Database.Entities.Base;

public interface IEntity<TAny>
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    TAny Id { get; set; }
}

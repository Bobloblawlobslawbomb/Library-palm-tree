using System.Collections.Generic;
using System.ComponentModel;

namespace Library.Models
{
  public class Author
  {
    public Author()
    {
      this.JoinEntities = new HashSet<AuthorBook>();
    }
    public int AuthorId { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }

    public virtual ApplicationUser User { get; set; } //new line

    public virtual ICollection<AuthorBook> JoinEntities { get; set; }
  }
}
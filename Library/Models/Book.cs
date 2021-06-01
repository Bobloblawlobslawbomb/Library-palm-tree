using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
  public class Book
  {
    public Book()
    {
      this.JoinEntities = new HashSet<AuthorBook>();
      this.JoinEntitiesDueDate = new HashSet<BookDueDate>();
    }
    public int BookId { get; set; }
    public string Title { get; set; }
    public int Quantity { get; set; }

    [DisplayName("CheckOut")]
    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime CheckOut { get; set; }

    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<AuthorBook> JoinEntities { get; }//set?
    public virtual ICollection<BookDueDate> JoinEntitiesDueDate { get; }//set?
  }
}
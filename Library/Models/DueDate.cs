using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
  public class DueDate
  {
    public DueDate()
    {
      this.JoinEntitiesDueDate = new HashSet<BookDueDate>();
    }

    public int DueDateId { get; set; }

    [DisplayName("ReturnDate")]
    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime ReturnDate { get; set; }

    public virtual ICollection<BookDueDate> JoinEntitiesDueDate { get; set; }
  }
}
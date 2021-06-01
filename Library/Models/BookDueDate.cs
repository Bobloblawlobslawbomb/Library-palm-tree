namespace Library.Models
{
  public class BookDueDate
  {
    public int BookDueDateId { get; set; }
    public int BookId { get; set; }
    public int DueDateId { get; set; }
    public virtual Book Book { get; set; }
    public virtual DueDate DueDate { get; set; }
  }
}
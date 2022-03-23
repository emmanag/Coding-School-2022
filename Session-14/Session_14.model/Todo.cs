using System.ComponentModel.DataAnnotations;

namespace TodoApp.Model;

public class Todo : BaseEntity
{
    public Todo(string title)
    {
        Title = title;
        Detail = new TodoDetail();
    }

    [Required]
    [MaxLength(200)]
    public string Title { get; set; }

    public bool Finished { get; set; }

    public TodoDetail Detail { get; set; }

    public List<TodoComment> Comments { get; set; }
}

namespace Tryitter.Models
{
  public class Student
  {
    public int StudentId { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public string? Modulo { get; set; }
    public string? Status { get; set; }
    public string? Senha { get; set; }
    public string? ImagemUrl { get; set; }
    public ICollection<Post>? Post { get; set; }
  }
}
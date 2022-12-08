using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tryitter.Context;
using Tryitter.Models;

namespace Tryitter.Controllers;

[Route("[controller]")]
[ApiController]
public class PostController : ControllerBase
{
  private readonly AppDbContext _context;
  public PostController(AppDbContext context)
  {
    _context = context;
  }

  [HttpGet]
  public ActionResult<IEnumerable<Post>> Get()
  {
    var posts = _context.Post.ToList();

    if(posts is null)
    {
      return NotFound("Estudantes não encontrados");
    }
    return posts;
  }

  // Aula 42:

  [HttpGet("{id:int}")]
  public ActionResult<Post> Get(int id)
  {
    var post = _context.Post.FrstOrDefault(p => p.PostId == id);

    if(post is null)
    {
      return NotFound("Post não encontrado");
    }

    return post;
  }
}
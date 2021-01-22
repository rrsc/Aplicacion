using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class UsuariosController : ControllerBase
  {
    private readonly DataContext _contexto;

    public UsuariosController(DataContext contexto)
    {
      _contexto = contexto;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
    {
      var usuarios = await _contexto.Usuarios.ToListAsync();

      return usuarios;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Usuario>> GetUsuario(int id)
    {
      var usuario = await _contexto.Usuarios.FindAsync(id);

      return usuario;
    }

  }
}
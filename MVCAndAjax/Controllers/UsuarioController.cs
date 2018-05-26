using System;
using System.Collections.Generic;
using MVCAndAjax.Models;
using System.Web.Mvc;

namespace MVCAndAjax.Controllers
{
    public class UsuarioController : Controller
    {
        List<Usuario> lstUsuario = new List<Usuario>();

        private void InicializarLista()
        {
            lstUsuario.Add(new Usuario { Id = 1, Login = "mrsantos", Senha = "123", DataCadastro = new DateTime(2018, 05, 26) });
            lstUsuario.Add(new Usuario { Id = 1, Login = "daniel", Senha = "123", DataCadastro = new DateTime(2018, 05, 26) });
            lstUsuario.Add(new Usuario { Id = 1, Login = "maria", Senha = "123", DataCadastro = new DateTime(2018, 05, 26) });
            lstUsuario.Add(new Usuario { Id = 1, Login = "isabel", Senha = "123", DataCadastro = new DateTime(2018, 05, 26) });
            lstUsuario.Add(new Usuario { Id = 1, Login = "osvaldo", Senha = "123", DataCadastro = new DateTime(2018, 05, 26) });
        }

        // GET: Usuario
        public ActionResult Index()
        {
            ViewBag.listausuario = lstUsuario; ;
            return View();
        }
        [HttpPost]
        public JsonResult CriarUsuario(Usuario usuario)
        {
            try
            {
                #region Valição
                if (usuario == null)
                    throw new ArgumentNullException("Usuário nao pode ser nulo");

                if (usuario.Login == null || usuario.Login.Equals(""))
                    throw new ArgumentNullException("Usuário.Login nao pode ser nulo");
                if (usuario.Senha == null || usuario.Senha.Equals(""))
                    throw new ArgumentNullException("Usuário.Senha nao pode ser nulo");
                #endregion
            

            this.lstUsuario.Add(usuario);
            return Json(new { status = true, mensagem = "Usuário cadastrado com sucesso" }
                );
            }
            catch (Exception e)
            {
                return Json(new  { status = false, mensagem = $"{e.Message}" });
            }
        }
        
    }
}

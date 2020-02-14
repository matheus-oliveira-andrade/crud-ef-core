using AutoMapper;
using EFCoreCRUD.Models.Contexts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EFCoreCRUD.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly Models.Dados.Usuario _dados;
        private readonly IMapper _mapper;

        public UsuarioController(EFCoreCRUDContext context, IMapper mapper)
        {
            _dados = new Models.Dados.Usuario(context);
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return RedirectToAction(nameof(Listar));
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var usuarios = _dados.List();

            return View(_mapper.Map<List<Models.ViewModels.Usuario>>(usuarios));
        }

        [HttpGet]
        public ActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Inserir(Models.ViewModels.Usuario modelo)
        {
            try
            {
                var usuario = _mapper.Map<Models.Entidades.Usuario>(modelo);

                _dados.Add(usuario);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        // GET: Usuario/Edit/5
        public ActionResult Editar(int codigo)
        {
            var usuario = _dados.ListById(codigo)[0];
            var modelo = _mapper.Map<Models.ViewModels.Usuario>(usuario);

            return View(modelo);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(int codigo, Models.ViewModels.Usuario modelo)
        {
            try
            {
                var usuario = _mapper.Map<Models.Entidades.Usuario>(modelo);

                _dados.Update(usuario);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Excluir(int codigo)
        {
            _dados.Delete(codigo);

            return RedirectToAction(nameof(Listar));
        }
    }
}
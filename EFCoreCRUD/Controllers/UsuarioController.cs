using AutoMapper;
using EFCoreCRUD.Models.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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

        // GET: Usuario
        public ActionResult Index()
        {
            return RedirectToAction(nameof(Listar));
        }

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

        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Inserir(Models.ViewModels.Usuario modelo)
        {
            try
            {
                var usuario = _mapper.Map<Models.Usuario>(modelo);

                _dados.Add(usuario);

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        [HttpGet]
        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
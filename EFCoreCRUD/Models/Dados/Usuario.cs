using EFCoreCRUD.Models.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCRUD.Models.Dados
{

    public class Usuario
    {
        private readonly EFCoreCRUDContext _context;

        public Usuario(EFCoreCRUDContext context)
        {
            _context = context;
        }

        public List<Models.Usuario> List()
        {
            return _context.Usuario.ToList();
        }

        public void Add(Models.Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
        }

        public void Update(Models.Usuario usuario)
        {
            _context.Update(usuario);
            _context.SaveChanges();
        }

        public void Delete(int codigo)
        {
            var usuario = _context.Usuario.FirstOrDefault(u => u.Codigo == codigo);

            if (usuario != null)
            {
                _context.Usuario.Remove(usuario);
                _context.SaveChanges();
            }
            else
                throw new ArgumentException("Falha ao excluir!");
        }
    }
}

﻿using ExoAPI.Contexts;
using ExoAPI.Interfaces;
using ExoAPI.Models;

namespace ExoAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly dbExoAPIContext _context;
        public UsuarioRepository(dbExoAPIContext context)
        {
            _context = context;
        }
        public List<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }
        public Usuario BuscarPorId(int id)
        {
            return _context.Usuarios.Find(id);
        }
        public void Cadastrar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

        }
        public void Atualizar(int id, Usuario usuario)
        {
            Usuario usuarioEncontrado = _context.Usuarios.Find(id);
            if (usuarioEncontrado != null)
            {
                usuarioEncontrado.Email = usuario.Email;
                usuarioEncontrado.Senha = usuario.Senha;
                usuarioEncontrado.Tipo = usuario.Tipo;

                _context.Usuarios.Update(usuarioEncontrado);
                _context.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            Usuario usuario = _context.Usuarios.Find(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }

        public Usuario Login(string email, string senha)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Email == email && x.Senha == senha);
        }
    }
}

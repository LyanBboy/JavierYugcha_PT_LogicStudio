﻿namespace ItemsDeTrabajo.Data.Repositorio
{
    using Data.Interfaces;
    using Entidad.Dto;

    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private List<DtoUsuarioVista>? listaUsuarios = null;

        public UsuarioRepositorio()
        {
            this.CargarUsuarios();
        }

        protected void CargarUsuarios()
        {
            this.listaUsuarios = new List<DtoUsuarioVista>();

            for (int i = 0; i < 3; i++)
            {
                DtoUsuarioVista usuario = new DtoUsuarioVista();
                usuario.UserName = String.Format("usuario{0}", i + 1);
                this.listaUsuarios.Add(usuario);
            }
        }

        public List<DtoUsuarioVista> ObtenerUsuarios()
        {
            return this.listaUsuarios ?? new List<DtoUsuarioVista>();
        }
    }
}

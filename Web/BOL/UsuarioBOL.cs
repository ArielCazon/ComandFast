using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.DTO;
using Web.DAL;

namespace Web.BOL
{
    public static class UsuarioBOL
    {
        public static void CrearUsuario(UsuarioDTO usuarioDTO)
        {
            try
            {
                UsuarioDb.CrearUsuario(usuarioDTO);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static UsuarioDTO CrearUsuarioDTO(string nombre, string apellido, DateTime fechaNacimiento, string usuario, string password)
        {
            UsuarioDTO usuarioDTO = new UsuarioDTO();
            usuarioDTO.Nombre = nombre;
            usuarioDTO.Apellido = apellido;
            usuarioDTO.FechaNacimiento = fechaNacimiento;
            usuarioDTO.Usuario = usuario;
            usuarioDTO.Password = password;
            usuarioDTO.TipoUsuario = 1;
            return usuarioDTO;
        }
    }
}
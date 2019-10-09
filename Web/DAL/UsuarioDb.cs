using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.DTO;
using Web.Models;
using Web.data;

namespace Web.DAL
{
    public static class UsuarioDb
    {
        public static void CrearUsuario(UsuarioDTO usuarioDTO)
        {
            try
            {
                COMANDFASTEntities entities = new COMANDFASTEntities();

                Usuario usuario = new Usuario() {
                Apellido = usuarioDTO.Apellido,
                Fecha_Nac = usuarioDTO.FechaNacimiento,
                Nombre = usuarioDTO.Nombre,
                Id_Tipo_Usuario = usuarioDTO.TipoUsuario.ToString(),
                Pass = usuarioDTO.Password
                };

                entities.Usuario.Add(usuario);
                entities.SaveChanges();

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.data;
using Web.DTO;
using Web.Models;

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
                Login_Usuario = usuarioDTO.Usuario,
                Id_Tipo_Usuario = usuarioDTO.TipoUsuario,
                Pass = usuarioDTO.Password
                };  


                entities.Usuario.Add(usuario);
                entities.SaveChanges();

            }
            catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException ex)
            {
                throw ex.InnerException;
            }
            catch (System.Data.Entity.Core.EntityCommandCompilationException ex)
            {
                throw ex.InnerException;
            }
            catch (System.Data.Entity.Core.UpdateException ex)
            {
                throw ex.InnerException;
            }

            catch (System.Data.Entity.Infrastructure.DbUpdateException ex) //DbContext
            {
                throw ex.InnerException;
            }

            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
    }
}
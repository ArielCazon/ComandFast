﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Usuario { get; set; }

        public string Password { get; set; }

        public int TipoUsuario { get; set; }
    }
}
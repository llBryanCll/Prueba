﻿using System;
using System.Collections.Generic;

namespace ProyectoSenaLmour.Models;

public partial class Usuario
{
    public int NroDocumento { get; set; }

    public int IdTipoDocumento { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Celular { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Genero { get; set; } = null!;

    public int Estado { get; set; }

    public int? IdRol { get; set; }

    public virtual Role? IdRolNavigation { get; set; }

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}

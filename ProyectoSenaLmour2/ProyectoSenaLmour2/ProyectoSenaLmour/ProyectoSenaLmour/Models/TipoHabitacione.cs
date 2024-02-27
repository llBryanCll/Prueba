using System;
using System.Collections.Generic;

namespace ProyectoSenaLmour.Models;

public partial class TipoHabitacione
{
    public int IdTipoHabitacion { get; set; }

    public string NomTipoHabitacion { get; set; } = null!;

    public int NumeroPersonas { get; set; }

    public int Estado { get; set; }

    public virtual ICollection<Habitacione> Habitaciones { get; set; } = new List<Habitacione>();
}

﻿using System;
using System.Collections.Generic;

namespace ELAM20250324S2.AppWebMVC.Models;

public partial class Estudiante
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public DateTime? FechaNacimiento { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? Telefono { get; set; }

    public int Grado { get; set; }

    public decimal? Promedio { get; set; }

    public DateTime? FechaInscripcion { get; set; }
}

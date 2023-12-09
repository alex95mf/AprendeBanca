using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class GenMedida
{
    public int GenmedId { get; set; }

    public string GenmedDescripcion { get; set; } = null!;

    public bool? GenmedEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<GenProducto> GenProductos { get; set; } = new List<GenProducto>();
}

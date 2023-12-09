using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class GenCategorium
{
    public int GencatId { get; set; }

    public string GencatDescripcion { get; set; } = null!;

    public bool? GencatEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<GenProducto> GenProductos { get; set; } = new List<GenProducto>();
}

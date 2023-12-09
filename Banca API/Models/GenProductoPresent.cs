using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class GenProductoPresent
{
    public int GenprodpresId { get; set; }

    public string GenprodpresDescripcion { get; set; } = null!;

    public bool? GenprodpresEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<GenProducto> GenProductos { get; set; } = new List<GenProducto>();
}

using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class SegPermisosMnu
{
    public int SegpermnuId { get; set; }

    public string SegpermnuDescripcion { get; set; } = null!;

    public string? SegpermnuObservaciones { get; set; }

    public bool? SegpermnuEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<SegRolpermiso> SegRolpermisos { get; set; } = new List<SegRolpermiso>();
}

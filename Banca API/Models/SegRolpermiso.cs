using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class SegRolpermiso
{
    public int SegrolperId { get; set; }

    public int SegrolId { get; set; }

    public int SegpermnuId { get; set; }

    public string? SegrolperObservaciones { get; set; }

    public bool? SegrolperEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual SegPermisosMnu Segpermnu { get; set; } = null!;

    public virtual SegRole Segrol { get; set; } = null!;
}

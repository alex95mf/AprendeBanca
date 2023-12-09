using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class SegRole
{
    public int SegrolId { get; set; }

    public string SegrolDescripcion { get; set; } = null!;

    public string? SegrolObservaciones { get; set; }

    public bool? SegrolEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<SegAutoregistro> SegAutoregistros { get; set; } = new List<SegAutoregistro>();

    public virtual ICollection<SegRolpermiso> SegRolpermisos { get; set; } = new List<SegRolpermiso>();

    public virtual ICollection<SegUsuario> SegUsuarios { get; set; } = new List<SegUsuario>();
}

using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class SegAutoregistro
{
    public int SegautoregId { get; set; }

    public int GenempId { get; set; }

    public int SegrolId { get; set; }

    public string SegcodAutoregistro { get; set; } = null!;

    public bool? SegautoregEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual GenEmpresa Genemp { get; set; } = null!;

    public virtual SegRole Segrol { get; set; } = null!;
}

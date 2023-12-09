using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class SegEstadoSn
{
    public int SegestadoSnId { get; set; }

    public string SegestadoSnDescripcion { get; set; } = null!;

    public bool? SegestadoSnEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<ConCuentaNivel> ConCuentaNivels { get; set; } = new List<ConCuentaNivel>();

    public virtual ICollection<ConCuentaPlan> ConCuentaPlans { get; set; } = new List<ConCuentaPlan>();

    public virtual ICollection<ConDiarioDet> ConDiarioDetConDiarioReqAuxSnNavigations { get; set; } = new List<ConDiarioDet>();

    public virtual ICollection<ConDiarioDet> ConDiarioDetConDiarioReqCcoSnNavigations { get; set; } = new List<ConDiarioDet>();

    public virtual ICollection<ConDiarioTipo> ConDiarioTipos { get; set; } = new List<ConDiarioTipo>();

    public virtual ICollection<GenAnio> GenAnios { get; set; } = new List<GenAnio>();

    public virtual ICollection<GenMe> GenMes { get; set; } = new List<GenMe>();
}

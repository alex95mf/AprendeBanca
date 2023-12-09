using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class GenStockDet
{
    public int GenstkdetId { get; set; }

    public int GenempId { get; set; }

    public int GenstkcabId { get; set; }

    public DateTime GenstkdetFechaAdq { get; set; }

    public int GenstkdetCantComp { get; set; }

    public int GenstkdetCantDisp { get; set; }

    public decimal GenstkdetCostCompTotal { get; set; }

    public decimal GenstkdetCostCompUnidad { get; set; }

    public decimal GenstkdetPorcentaje { get; set; }

    public decimal GenstkdetPrecioVtaAplicar { get; set; }

    public bool? GenstkdetEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual GenEmpresa Genemp { get; set; } = null!;

    public virtual GenStockCab Genstkcab { get; set; } = null!;
}

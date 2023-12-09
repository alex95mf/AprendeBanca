using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class GenStockCab
{
    public int GenstkcabId { get; set; }

    public int GenempId { get; set; }

    public int GenstkcabProdId { get; set; }

    public int GenstkcabCantDisp { get; set; }

    public decimal GenstkcabCostProme { get; set; }

    public decimal GenstkcabCostMin { get; set; }

    public decimal GenstkcabCostMax { get; set; }

    public decimal GenstkcabPrecVtaMin { get; set; }

    public decimal GenstkcabPrecVtaMax { get; set; }

    public decimal GenstkcabPrecVtaSugerido { get; set; }

    public decimal GenstkcabPrecioVtaAplicar { get; set; }

    public DateTime GenstkcabFechaAdqPrim { get; set; }

    public DateTime GenstkcabFechaAdqUlt { get; set; }

    public bool? GenstkcabEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<GenStockDet> GenStockDets { get; set; } = new List<GenStockDet>();

    public virtual GenEmpresa Genemp { get; set; } = null!;

    public virtual GenProducto GenstkcabProd { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class GenProducto
{
    public int GenprodId { get; set; }

    public int GenempId { get; set; }

    public string GenprodCodigo { get; set; } = null!;

    public string GenprodDescripcion { get; set; } = null!;

    public int GenprodTipId { get; set; }

    public int GenprodCatId { get; set; }

    public int GenprodMarId { get; set; }

    public int GenprodPresentId { get; set; }

    public int GenprodMedId { get; set; }

    public byte[]? GenprodImagen { get; set; }

    public string? GenprodNomImagen { get; set; }

    public byte[]? GenprodBarra { get; set; }

    public bool? GenprodEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual ICollection<GenStockCab> GenStockCabs { get; set; } = new List<GenStockCab>();

    public virtual GenEmpresa Genemp { get; set; } = null!;

    public virtual GenCategorium GenprodCat { get; set; } = null!;

    public virtual GenMarca GenprodMar { get; set; } = null!;

    public virtual GenMedida GenprodMed { get; set; } = null!;

    public virtual GenProductoPresent GenprodPresent { get; set; } = null!;

    public virtual GenProductoTipo GenprodTip { get; set; } = null!;

    public virtual ICollection<VentaFacturaDet> VentaFacturaDets { get; set; } = new List<VentaFacturaDet>();
}

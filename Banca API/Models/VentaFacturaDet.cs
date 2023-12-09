using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class VentaFacturaDet
{
    public int VtafactDetId { get; set; }

    public int GenempId { get; set; }

    public int? VtafactCabId { get; set; }

    public string? GenprodId { get; set; }

    public int? VtafactDetCantidad { get; set; }

    public decimal? VtafactDetSubtotal { get; set; }

    public int? VtafactDetDescuento { get; set; }

    public int VtafactSriivaId { get; set; }

    public int VtafactSriivaPorcent { get; set; }

    public decimal? VtafactDetIvaTotal { get; set; }

    public int VtafactSriiceId { get; set; }

    public int VtafactSriicePorcent { get; set; }

    public decimal? VtafactDetSriiceTotal { get; set; }

    public decimal? VtafactDetDescuentoTt { get; set; }

    public decimal? VtafactDetTotal { get; set; }

    public bool? VtafactEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual GenEmpresa Genemp { get; set; } = null!;

    public virtual GenProducto? Genprod { get; set; }

    public virtual VentaFacturaCab? VtafactCab { get; set; }

    public virtual SriIce VtafactSriice { get; set; } = null!;

    public virtual SriIva VtafactSriiva { get; set; } = null!;
}

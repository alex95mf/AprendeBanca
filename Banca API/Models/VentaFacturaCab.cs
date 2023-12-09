using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class VentaFacturaCab
{
    public int VtafactCabId { get; set; }

    public int GenempId { get; set; }

    public string? SriidentCodigoSri { get; set; }

    public string GencliIdentificaNum { get; set; } = null!;

    public string GencliTelefono { get; set; } = null!;

    public string GencliCorreo { get; set; } = null!;

    public DateTime VtafactCabFechaEmision { get; set; }

    public int VtafactCabTalonario { get; set; }

    public string VtafactCabComprobanteTipo { get; set; } = null!;

    public string VtafactCabEmision { get; set; } = null!;

    public string VtafactCabEstablecimiento { get; set; } = null!;

    public string VtafactCabSecuencia { get; set; } = null!;

    public string VtafactCabNumFactura { get; set; } = null!;

    public string? VtafactCabAmbienteTipo { get; set; }

    public string VtafactCabCodNumerico { get; set; } = null!;

    public string? VtafactCabTipoEmision { get; set; }

    public string? VtafactCabDigVerificador { get; set; }

    public string VtafactCabClaveAcceso { get; set; } = null!;

    public string? VtafactCabBarra { get; set; }

    public int VtafactCabFormpag { get; set; }

    public decimal? VtafactCabSubtotal12 { get; set; }

    public decimal? VtafactCabSubtotal0 { get; set; }

    public decimal? VtafactCabSubtotalNoIva { get; set; }

    public decimal? VtafactCabSubtotalSinImpuestos { get; set; }

    public int? VtafactCabDescuentoF { get; set; }

    public decimal? VtafactCabDescuentoTt { get; set; }

    public decimal? VtafactCabTtIva { get; set; }

    public decimal? VtafactCabSriiceTt { get; set; }

    public decimal? VtafactCabTotal { get; set; }

    public bool? VtafactCabEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual GenCliente GencliIdentificaNumNavigation { get; set; } = null!;

    public virtual GenEmpresa Genemp { get; set; } = null!;

    public virtual ICollection<VentaFacturaDet> VentaFacturaDets { get; set; } = new List<VentaFacturaDet>();

    public virtual SriFormaPago VtafactCabFormpagNavigation { get; set; } = null!;
}

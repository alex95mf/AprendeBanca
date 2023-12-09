using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class GenCliente
{
    public int GencliId { get; set; }

    public int GenempId { get; set; }

    public int GencliIdentificaTip { get; set; }

    public string GencliIdentificaNum { get; set; } = null!;

    public string GencliNombres { get; set; } = null!;

    public string GencliApellidos { get; set; } = null!;

    public string? GencliTelefono { get; set; }

    public string? GencliDireccion { get; set; }

    public DateTime? GencliFechaDeNacimiento { get; set; }

    public string GencliCorreo { get; set; } = null!;

    public byte[]? GencliImagen { get; set; }

    public string? GencliNomImagen { get; set; }

    public bool? GencliEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual SriIdentificacion GencliIdentificaTipNavigation { get; set; } = null!;

    public virtual GenEmpresa Genemp { get; set; } = null!;

    public virtual ICollection<VentaFacturaCab> VentaFacturaCabs { get; set; } = new List<VentaFacturaCab>();
}

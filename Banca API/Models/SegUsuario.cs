using System;
using System.Collections.Generic;

namespace Banca_API.Models;

public partial class SegUsuario
{
    public int SeguserId { get; set; }

    public string SeguserCorreo { get; set; } = null!;

    public string SeguserUsuario { get; set; } = null!;

    public int GenempId { get; set; }

    public int SegrolId { get; set; }

    public int SegcodAutoregistro { get; set; }

    public string SeguserNombres { get; set; } = null!;

    public string SeguserApellidos { get; set; } = null!;

    public byte[] SeguserContraseña { get; set; } = null!;

    public string? SeguserTelefono { get; set; }

    public string? SeguserDireccion { get; set; }

    public DateTime? SeguserFechaNacimiento { get; set; }

    public bool? SeguserConfirmado { get; set; }

    public byte[]? SeguserImagen { get; set; }

    public string? SeguserNomImagen { get; set; }

    public bool? SeguserEstado { get; set; }

    public string AudUsuarioIngreso { get; set; } = null!;

    public DateTime AudFechaIngreso { get; set; }

    public string AudPcIngreso { get; set; } = null!;

    public string AudUsuarioModifica { get; set; } = null!;

    public DateTime AudFechaModifica { get; set; }

    public string AudPcModifica { get; set; } = null!;

    public virtual GenEmpresa Genemp { get; set; } = null!;

    public virtual SegRole Segrol { get; set; } = null!;
}

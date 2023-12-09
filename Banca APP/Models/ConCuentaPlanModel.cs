using System.ComponentModel.DataAnnotations;

namespace Banca_APP.Models
{
    public class PlanCuentasViewModel
    {
        public List<ConCuentaPlanModel> PlanesCuenta { get; set; }
    }
    public partial class ConCuentaPlanModel
    {
        public int ConCtaplaId { get; set; }

        public int GenempId { get; set; }

        public int GenanioId { get; set; }

        public int ConCtanivId { get; set; }

        public int ConCtatipId { get; set; }

        public int ConCtaclsId { get; set; }

        public string ConCtaplaCuenta { get; set; } = null!;

        public string ConCtaplaNombre { get; set; } = null!;

        public int ConCtaplaReqCcSn { get; set; }

        public bool? ConCtaplaEstado { get; set; }

        public string AudUsuarioIngreso { get; set; } = null!;

        public DateTime AudFechaIngreso { get; set; }

        public string AudPcIngreso { get; set; } = null!;

        public string AudUsuarioModifica { get; set; } = null!;

        public DateTime AudFechaModifica { get; set; }

        public string AudPcModifica { get; set; } = null!;

        //public virtual ICollection<ConCentroCosto> ConCentroCostos { get; set; } = new List<ConCentroCosto>();

        //public virtual ConCuentaClase ConCtacls { get; set; } = null!;

        //public virtual ConCuentaNivel ConCtaniv { get; set; } = null!;

        //public virtual SegEstadoSn ConCtaplaReqCcSnNavigation { get; set; } = null!;

        //public virtual ConCuentaTipo ConCtatip { get; set; } = null!;

        //public virtual ICollection<ConDiarioDet> ConDiarioDets { get; set; } = new List<ConDiarioDet>();

        //public virtual GenAnio Genanio { get; set; } = null!;

        //public virtual GenEmpresa Genemp { get; set; } = null!;
    }


}
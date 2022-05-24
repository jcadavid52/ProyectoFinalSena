//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppAjaxSpiritualArt.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web;
    
    public partial class REGISTRO_ARTISTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public REGISTRO_ARTISTA()
        {
            this.NOTIFICACION = new HashSet<NOTIFICACION>();
            this.PRODUCTO = new HashSet<PRODUCTO>();
        }
    
        public int PK_ID_ARTISTA { get; set; }
        public string NOMBRE_ARTISTA { get; set; }
        public string PRIMER_APELLIDO_ARTISTA { get; set; }
        public string SEGUNDO_APELLIDO_ARTISTA { get; set; }
        public string TELEFONO { get; set; }
        public string CORREO { get; set; }
        public string PAIS { get; set; }
        public string CIUDAD { get; set; }
        public string LOCALIDAD { get; set; }
        public string DIRECCION { get; set; }
        public Nullable<int> CLAVE { get; set; }
        public Nullable<int> FK_TIPO_PLAN { get; set; }
        public Nullable<bool> ESTADO { get; set; }
        public string IMAGEN { get; set; }

        public HttpPostedFileBase archivo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTIFICACION> NOTIFICACION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO> PRODUCTO { get; set; }
        public virtual TIPO_PLAN TIPO_PLAN { get; set; }
    }
}
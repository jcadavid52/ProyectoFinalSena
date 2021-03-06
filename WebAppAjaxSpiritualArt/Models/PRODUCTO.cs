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

    public partial class PRODUCTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCTO()
        {
            this.NOTIFICACION = new HashSet<NOTIFICACION>();
        }
    
        public int PK_ID_PRODUCTO { get; set; }
        public string NOMBRE_PRODUCTO { get; set; }
        public Nullable<double> PRECIO { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<int> CANTIDAD { get; set; }
        public Nullable<bool> ESTADO { get; set; }
        public string IMAGEN_PRODUCTO { get; set; }
        public Nullable<int> FK_CATEGORIA { get; set; }
        public Nullable<int> FK_ARTISTA { get; set; }
        public HttpPostedFileBase archivoProducto { get; set; }
        public virtual CATEGORIA CATEGORIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTIFICACION> NOTIFICACION { get; set; }
        public virtual REGISTRO_ARTISTA REGISTRO_ARTISTA { get; set; }
    }
}

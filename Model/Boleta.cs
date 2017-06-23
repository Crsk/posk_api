namespace posk_api.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Boleta
    {
        public int id { get; set; }
        public Nullable<int> numero_boleta { get; set; }
        public System.DateTime fecha { get; set; }
        public Nullable<int> puntos_cantidad { get; set; }
        public Nullable<int> total { get; set; }
        [ForeignKey("clientes")]
        public Nullable<int> cliente_id { get; set; }
        [ForeignKey("usuarios")]
        public Nullable<int> usuario_id { get; set; }
    }
}
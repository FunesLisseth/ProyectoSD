﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace CondominioService.Contrato.Dominio
{
    [DataContract]
    public class TipoVivienda
    {
        [DataMember]
        public int CodigoTipoVivienda { get; set; }

        [DataMember]
        public string NombreTipoVivienda { get; set; }

        [DataMember]
        public Boolean Estado { get; set; }

        [DataMember]
        public string UsuarioCreacion { get; set; }

        [DataMember]
        public string UsuarioModificacion { get; set; }
    }
}
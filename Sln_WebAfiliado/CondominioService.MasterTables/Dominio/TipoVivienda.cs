﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace CondominioService.MasterTables.Dominio
{
    [DataContract]
    public class TipoVivienda
    {
        [DataMember]
        public int CodigoTipoVivienda { get; set; }

        [DataMember]
        public string NombreTipoVivienda { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace mcl.frotas.infra.Facade
{
    public class DetranOptions
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string BaseUrl { get; set; }
        public string VistoriaUri { get; set; }
        public int QuantidadeDiasParaAgendamento { get; set; }
    }
}

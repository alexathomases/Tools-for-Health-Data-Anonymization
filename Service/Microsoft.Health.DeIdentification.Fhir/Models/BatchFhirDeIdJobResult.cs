﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Health.DeIdentification.Fhir.Models
{
    public class BatchFhirDeIdJobResult
    {
        public List<OutputInfo> outputs { get; set; }
    }
}

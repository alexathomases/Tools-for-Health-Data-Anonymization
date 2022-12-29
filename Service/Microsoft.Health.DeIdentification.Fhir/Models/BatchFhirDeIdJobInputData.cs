﻿using Microsoft.Health.DeIdentification.Contract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Microsoft.Health.DeIdentification.Fhir.Models
{
    public class BatchFhirDeIdJobInputData
    {
        public string dataSourceType { get; set; }

        public List<Dictionary<string, string>> sourceDataset { get; set; }

        public DestinationDataset destinationDataset { get; set; }

        public string deIdConfiguration { get; set; }
    }
}

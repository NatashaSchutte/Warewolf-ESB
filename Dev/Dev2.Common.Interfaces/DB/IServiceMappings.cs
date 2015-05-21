﻿using System.Collections.Generic;

namespace Dev2.Common.Interfaces.DB
{
    public interface IServiceMappings
    {
        string MappingsHeader { get; }
        ICollection<IServiceInput> Inputs { get; }
        IList<IServiceOutputMapping> OutputMapping { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MerchanCountriesWorker.Core.Models
{
    public interface IScopedProcessingService
    {
        Task DoWorkAsync(CancellationToken stoppingToken);
    }
}
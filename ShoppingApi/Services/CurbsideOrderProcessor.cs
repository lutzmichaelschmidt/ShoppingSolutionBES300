using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ShoppingApi.Services
{
    public class CurbsideOrderProcessor : BackgroundService
    {
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            return null;
            //throw new NotImplementedException();
        }
    }
}

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VemiMicroservice.Application.Models;
using VemiMicroservice.Domain.Models;
using VemiMicroservice.Application.Commands.Example;
using VemiMicroservice.Application.Queries.Example;
using MediatR;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;
using VemiMicroservice.Application.Commands.Readiness;
using VemiMicroservice.Infrastructure;
using Serilog;

namespace VemiMicroservice.Api.HealthChecks
{
    public class ReadinessCheck : IHealthCheck
    {
        private readonly ILogger _logger;
        private readonly IMediator _mediator;

        public ReadinessCheck(
            ILogger logger,
            IMediator mediator
        )
        {
            _logger = logger;
            _mediator = mediator;
        }


        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            try
            {
                var performReadinessCheckCommand = new PerformReadinessCheckCommand();

                var result = await _mediator.Send(performReadinessCheckCommand);
                if (result.Type != CommandResultTypeEnum.Success)
                {
                    throw new Exception(result.Result);
                }

                return HealthCheckResult.Healthy();
            }
            catch (Exception e)
            {
                _logger.Error(e, "ReadinessController has encountered an error: {0}", e.Message);
                throw;
            }
        }
    }
}

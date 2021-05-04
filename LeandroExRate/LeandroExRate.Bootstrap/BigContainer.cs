﻿using LeandroExRate.Application.AppServices;
using LeandroExRate.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace LeandroExRate.Bootstrap
{
    public static class BigContainer
    {
        public static IServiceCollection RegisterAppServices(this IServiceCollection service)
        {
            service.AddTransient<RateAppService>();
            return service;
        }

        public static IServiceCollection RegisterServices(this IServiceCollection service)
        {
            //service.AddTransient<IRateService, RateBusiness>();
            return service;
        }
    }
}

global using EcommerceDDD.Core.CQRS.CommandHandling;
global using EcommerceDDD.Core.CQRS.QueryHandling;
global using EcommerceDDD.Core.Domain;
global using EcommerceDDD.Core.Exceptions;
global using EcommerceDDD.Core.Infrastructure;
global using EcommerceDDD.Core.Infrastructure.Http;
global using EcommerceDDD.Core.Infrastructure.Identity;
global using EcommerceDDD.Core.Infrastructure.Integration;
global using EcommerceDDD.Core.Infrastructure.Marten;
global using EcommerceDDD.Core.Infrastructure.WebApi;
global using EcommerceDDD.Core.Persistence;
global using EcommerceDDD.CustomerManagement.Api.Application.GettingCustomerDetails;
global using EcommerceDDD.CustomerManagement.Api.Application.GettingCustomerDetailsWithToken;
global using EcommerceDDD.CustomerManagement.Api.Application.RegisteringCustomer;
global using EcommerceDDD.CustomerManagement.API.Controllers.Requests;
global using EcommerceDDD.CustomerManagement.Application.GettingCreditLimit;
global using EcommerceDDD.CustomerManagement.Application.GettingCustomerEventHistory;
global using EcommerceDDD.CustomerManagement.Application.RegisteringCustomer;
global using EcommerceDDD.CustomerManagement.Domain;
global using EcommerceDDD.CustomerManagement.Domain.Commands;
global using EcommerceDDD.CustomerManagement.Domain.Events;
global using EcommerceDDD.CustomerManagement.Infrastructure.Projections;
global using Marten;
global using Marten.Events;
global using Marten.Events.Aggregation;
global using Marten.Events.Projections;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.Extensions.Options;
global using Newtonsoft.Json;
global using System.ComponentModel.DataAnnotations;

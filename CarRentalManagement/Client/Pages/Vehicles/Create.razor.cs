﻿using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Create
    {
        [Inject] private IHttpRepository<Vehicle> _client { get; set; }
        [Inject] private NavigationManager _navManager { get; set; }
        [Inject] private HttpInterceptorService _interceptor { get; set; }

        private Vehicle vehicle = new Vehicle();

        private async Task CreateVehicle()
        {
            await _client.Create(Endpoints.VehiclesEndpoint, vehicle);
            _navManager.NavigateTo("/vehicles/");
        }
    }
}
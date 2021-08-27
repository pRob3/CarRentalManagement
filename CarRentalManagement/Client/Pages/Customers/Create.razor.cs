using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Create
    {
        [Inject] private IHttpRepository<Customer> _client { get; set; }
        [Inject] private NavigationManager _navManager { get; set; }

        private Customer customer = new Customer();

        private async Task CreateCustomer()
        {
            await _client.Create(Endpoints.CustomersEndpoint, customer);
            _navManager.NavigateTo("/customers/");
        }
    }
}
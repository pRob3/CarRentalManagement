using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Colours
{
    public partial class Create
    {
        [Inject] private IHttpRepository<Colour> _client { get; set; }
        [Inject] private NavigationManager _navManager { get; set; }

        private Colour colour = new Colour();

        private async Task CreateColour()
        {
            await _client.Create(Endpoints.ColoursEndpoint, colour);
            _navManager.NavigateTo("/colours/");
        }
    }
}
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Colours
{
    public partial class Index
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] IJSRuntime _js { get; set; }

		private List<Colour> Model;

		protected async override Task OnInitializedAsync()
		{
			Model = await _client.GetFromJsonAsync<List<Colour>>($"{Endpoints.ColoursEndpoint}");
		}

		private async Task Delete(int id)
		{
			var model = Model.FirstOrDefault(q => q.Id == id);

			var confirm = await _js.InvokeAsync<bool>("confirm", $"Do you want to delete { model.Name }?");
			if (confirm)
			{
				await _client.DeleteAsync($"{Endpoints.ColoursEndpoint}/{id}");
				await OnInitializedAsync();
			}
		}
	}
}

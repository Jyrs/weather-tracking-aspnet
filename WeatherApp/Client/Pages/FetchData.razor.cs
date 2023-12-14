using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using WeatherApp.Shared;

namespace WeatherApp.Client.Pages
{
    public partial class FetchData
    {

        private WeatherForecast[]? forecasts;
        private int rowCount = 0;
        private string row;
        protected override async Task OnInitializedAsync()
        {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }

        private void AddBtnHandler()
        {
            row = "<tr>" +
                "<td>sdfsdf<td>" +
                "</tr>";
            StateHasChanged();
        }


    }
}

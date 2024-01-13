using BlazorBootstrap;
using System.Net.Http.Json;
using WeatherApp.AppCore.DTO;

namespace WeatherApp.Client.Pages
{
    public partial class Dictionary
    {
        private IEnumerable<RegionDTO> regions;
        private BlazorBootstrap.Grid<RegionDTO> grid = default!;

        protected override async Task OnInitializedAsync()
        {
            regions = await Http.GetFromJsonAsync<IEnumerable<RegionDTO>>("http://localhost:5141/api/ClimatDayInfo/regions_list");
        }


        private async Task<GridDataProviderResult<RegionDTO>> RegionDataProvider(GridDataProviderRequest<RegionDTO> request)
        {
            return await Task.FromResult(request.ApplyTo(regions));
        }
    }
}

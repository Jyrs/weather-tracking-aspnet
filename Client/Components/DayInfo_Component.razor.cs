using BlazorBootstrap;
using System.Net.Http.Json;
using WeatherApp.AppCore.DTO;



namespace WeatherApp.Client.Components
{
    public partial class DayInfo_Component
    {
        Grid<ClimateDayInfoDTO> grid = default!;
        private List<ClimateDayInfoDTO> characts;
        private IEnumerable<RegionDTO> regions;
        private string region {  get; set; }

        protected override async Task OnInitializedAsync()
        {
            regions = await Http.GetFromJsonAsync<IEnumerable<RegionDTO>>(RequestLinks.GetRegionsList);
            characts = await Http.GetFromJsonAsync<List<ClimateDayInfoDTO>>(RequestLinks.GetClimateList);
        }

        private async Task<AutoCompleteDataProviderResult<RegionDTO>> RegionsDataProvider(AutoCompleteDataProviderRequest<RegionDTO> request)
        {
            return await Task.FromResult(request.ApplyTo(regions.OrderBy(region => region.Reg_name)));
        }

        private void OnAutoCompleteChanged(RegionDTO region)
        {
            // TODO: handle your own logic

            // NOTE: do null check
           // Console.WriteLine($"'{customer?.CustomerName}' selected.");
        }



    }
}

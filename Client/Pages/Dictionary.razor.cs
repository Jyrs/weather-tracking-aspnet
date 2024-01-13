using BlazorBootstrap;
using System.Collections.Generic;
using System.Net.Http.Json;
using WeatherApp.AppCore.DTO;

namespace WeatherApp.Client.Pages
{
    public partial class Dictionary
    {
        private List<RegionDTO> regions;
        private BlazorBootstrap.Grid<RegionDTO> grid = default!;

        protected override async Task OnInitializedAsync()
        {
            regions = await Http.GetFromJsonAsync<List<RegionDTO>>("http://localhost:5141/api/ClimatDayInfo/regions_list");
        }

        private async Task AddRegion()
        {
            var createdReg = CreateRegion();
            regions.Add(createdReg);
            await Http.PostAsJsonAsync("http://localhost:5141/api/ClimatDayInfo", createdReg);
            await grid.RefreshDataAsync();
        }


        private RegionDTO CreateRegion()
        {
            var reg = new RegionDTO();
            reg.Reg_name = $"reg {reg.Reg_Id}";
            reg.Reg_code = 0;
            return reg;
        }

    }
}

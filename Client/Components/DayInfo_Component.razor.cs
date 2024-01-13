using BlazorBootstrap;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using WeatherApp.AppCore.DTO;

namespace WeatherApp.Client.Components
{
    public partial class DayInfo_Component
    {
        // private WeatherForecast[]? forecasts;

        BlazorBootstrap.Grid<ClimateDayInfoDTO> grid = default!;
        private List<ClimateDayInfoDTO> characts;
        private List<RegionDTO> regions;

        [Parameter]
        public bool Collapsed { get; set; } = true;

        // void Toggle()
        // {
        //     Collapsed = !Collapsed;
        // }

        private async Task<GridDataProviderResult<ClimateDayInfoDTO>> WeatherDataProvider(GridDataProviderRequest<ClimateDayInfoDTO> request)
        {
            return await Task.FromResult(request.ApplyTo(characts));
        }

        //private async Task AddCharacteristic()
        //{
        //    // for the same employees collection, we are adding an object
        //    // explicit grid refresh required
        //    // characts.Add(CreateCharact());
        //    await grid.RefreshDataAsync();
        //}

        protected override async Task OnInitializedAsync()
        {
            regions = await Http.GetFromJsonAsync<List<RegionDTO>>("http://localhost:5141/api/ClimatDayInfo/regions_list");
            characts = await Http.GetFromJsonAsync<List<ClimateDayInfoDTO>>("http://localhost:5141/api/ClimatDayInfo/climate_list");
        }


        /// <summary>
        /// модальное окно с полями добавления новой характеристики
        /// </summary>
        private Modal modal;
        private async Task OnShowModalClick()
        {
            await modal?.ShowAsync();
        }
        private async Task OnHideModalClick()
        {
            await modal?.HideAsync();
        }


    }
}

using BlazorBootstrap;
using System.Net.Http.Json;
using WeatherApp.AppCore.DTO;
using WeatherApp.Client.Components;

namespace WeatherApp.Client.Pages
{
    public partial class Dictionary
    {
        private List<RegionDTO> regions;
        private HashSet<RegionDTO> selectedRegions = new();


        private bool CollapsedInputError { get; set; } = true;
        public bool disableDeleteButton {  get; set; } = true;

        private static string newRegion_Input { get; set; } = string.Empty;
        private static string? newRegionCode_Input { get; set; }

        private Grid<RegionDTO> grid = default!;

        private Modal modalAddRegion;
        private Modal modalDeleteRegion;


        protected override async Task OnInitializedAsync()
        {
            regions = await Http.GetFromJsonAsync<List<RegionDTO>>(RequestLinks.GetRegionsList);
        }

        private Task OnSelectedItemsChanged(HashSet<RegionDTO> selectedRegionsFromTable)
        {
            selectedRegions = selectedRegionsFromTable is not null && selectedRegionsFromTable.Any() ? selectedRegionsFromTable : new();
            
            if(selectedRegions.Count > 0) 
                disableDeleteButton = false;
            else
                disableDeleteButton = true;
            
            return Task.CompletedTask;
        }

        private async Task AddRegion()
        {
            if(newRegion_Input == String.Empty || newRegionCode_Input == null || newRegionCode_Input == "")
            {
                if(CollapsedInputError) CollapsedInputError = !CollapsedInputError;   
            }
            else
            {
                var createdReg = CreateRegion();
                regions.Add(createdReg);
                await Http.PostAsJsonAsync(RequestLinks.PostRegion, createdReg);
                await grid.RefreshDataAsync();
                CollapsedInputError = true;
                await OnHideModalAddClick();
            }
        }
        private RegionDTO CreateRegion()
        {
            var reg = new RegionDTO();
            reg.Reg_name = newRegion_Input;
            reg.Reg_code = newRegionCode_Input;
            return reg;
        }

        private async Task DeleteRegion()
        {
            if (selectedRegions.Count > 0)
            {
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Content = JsonContent.Create(selectedRegions),
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(RequestLinks.DeleteRegion, UriKind.Relative)
                };
                foreach (var region in selectedRegions)
                    regions.Remove(region);
                await Http.SendAsync(request);
                await OnHideModalDeleteClick();
                await grid.RefreshDataAsync();

            }
        }
        //!!!!!!!реализовать функционал  Refresh Data Async таблицы через DataProvider,
        //где будет запрос на получение листа!!!!!!!!!!!

        private async Task OnShowModalDeleteClick()
        {
            await modalDeleteRegion?.ShowAsync();
        }
        private async Task OnHideModalDeleteClick()
        {
            await modalDeleteRegion?.HideAsync();
        }


        private async Task OnShowModalAddClick()
        {
            await modalAddRegion?.ShowAsync();
        }
        private async Task OnHideModalAddClick()
        {
            newRegion_Input = String.Empty;
            newRegionCode_Input = "";
            CollapsedInputError = true;
            await modalAddRegion?.HideAsync();
        }



    }
}

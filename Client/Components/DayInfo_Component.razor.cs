using BlazorBootstrap;
using System.Net.Http.Json;
using WeatherApp.AppCore.DTO;
using WeatherApp.AppCore.Models;



namespace WeatherApp.Client.Components
{
    public partial class DayInfo_Component
    {
        Grid<Tuple<string, string, string>> grid = default!;
        //private List<ClimateDayInfoDTO> characts;
        private IEnumerable<RegionDTO> regions;
        private List<Tuple<string,string,string>> charact;
        private InfoDisplay infoAboutDate;


        //private string RegCode = "78";
        //private readonly DateTime a = DateTime.ParseExact("2023-10-20", "YYYY-MM-DD", null);

        private string selectedRegion {  get; set; }
        private DateTime selectedDate { get; set; }

        protected override async Task OnInitializedAsync()
        {
            infoAboutDate = await Http.GetFromJsonAsync<InfoDisplay>(RequestLinks.GetListTest + $"Санкт-Петербург/2023-10-20");
            if (infoAboutDate != null)
            {
                charact = infoAboutDate.char_Values;
                await grid.RefreshDataAsync();
            }
            regions = await Http.GetFromJsonAsync<IEnumerable<RegionDTO>>(RequestLinks.GetRegionsList);
            //characts = await Http.GetFromJsonAsync<List<ClimateDayInfoDTO>>(RequestLinks.GetClimateList);
        }

        private async Task<AutoCompleteDataProviderResult<RegionDTO>> RegionsDataProvider(AutoCompleteDataProviderRequest<RegionDTO> request)
        {
            return await Task.FromResult(request.ApplyTo(regions.OrderBy(region => region.Reg_name)));
        }

        private void OnAutoCompleteChanged(RegionDTO region)
        {
           
        }

        private async Task btn_click(Microsoft.AspNetCore.Components.Web.MouseEventArgs e)
        {
           string a = RequestLinks.GetListTest + $"{selectedRegion}/{selectedDate.ToString("yyyy-MM-dd")}";
           infoAboutDate = await Http.GetFromJsonAsync<InfoDisplay>(a);
           if(infoAboutDate != null)
           {
                charact = infoAboutDate.char_Values;
                await grid.RefreshDataAsync();
           }
           else
           {
                charact = new List<Tuple<string, string, string>>();
                grid.RefreshDataAsync();
            }
            
        }
    }
}

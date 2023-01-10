using BlazorClient.Services;
using IdentityModel.Client;
using Microsoft.AspNetCore.Components;


namespace BlazorClient.Pages
{
    public partial class SampleResource
    {
        private List<API.Models.SampleResource> _resources = new();
        [Inject] private HttpClient HttpClient { get; set; }
        [Inject] private IConfiguration Configuration { get; set; }
        [Inject] private ITokenService TokenService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var tokenResponse = await TokenService.GetToken("API.read");
            HttpClient.SetBearerToken(tokenResponse.AccessToken);

            var result = await HttpClient.GetAsync(Configuration["apiUrl"] + "/api/sampleresource");
            if(result.IsSuccessStatusCode)
            {
                _resources = await result.Content.ReadFromJsonAsync<List<API.Models.SampleResource>>();
            }
        }

    }
}

namespace TabbedPageSample;

public partial class LinkPage : ContentPage
{
	private HttpResponseMessage response = new HttpResponseMessage();
	private string uri = string.Empty;
	private HttpClient httpClient = new()
    {
        BaseAddress = new Uri("https://raw.githubusercontent.com/seoshinwoo99/Test/refs/heads/main/LinkURL.txt")
    };

	public LinkPage()
	{
		InitializeComponent();
	}

	private async void OpenBrowser(object sender, EventArgs e)
	{
		try
		{
			response = await httpClient.GetAsync(httpClient.BaseAddress);
			uri = await response.Content.ReadAsStringAsync();
			await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
		}
		catch (Exception ex)
		{
			// 
		}
	}
}


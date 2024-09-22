namespace TabbedPageSample;

public partial class VideoPage : ContentPage
{
	int count = 0;

	public VideoPage()
	{
		InitializeComponent();

		VideoPlayer.HeightRequest = DeviceDisplay.Current.MainDisplayInfo.Height / DeviceDisplay.Current.MainDisplayInfo.Density
		 	 - 100; 
		//Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific.AppCompat.NavigationPage.GetBarHeight(this) * 2;
	}
}


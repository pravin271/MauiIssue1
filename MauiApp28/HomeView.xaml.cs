using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace MauiApp28;

public partial class HomeView : Microsoft.Maui.Controls.TabbedPage
{
	public HomeView()
	{
		InitializeComponent();

        On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
        On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetIsSwipePagingEnabled(true);
        On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetIsSmoothScrollEnabled(true);
        On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetOffscreenPageLimit(2);
    }
}
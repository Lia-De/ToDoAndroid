namespace ToDo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            //InitializeComponent();
            var webView = new WebView
            {
                Source = GetWebViewSource()
            };

            Content = new StackLayout
            {
                Children = { webView }
            };
        }

        // Helper method to get the correct URI for the WebView
        private Uri GetWebViewSource()
        {
            // Get the local HTML file from the app's resources
            var htmlFilePath = Path.Combine(FileSystem.AppDataDirectory, "index.html");
            return new Uri($"file://{htmlFilePath}");
        }

    }

}

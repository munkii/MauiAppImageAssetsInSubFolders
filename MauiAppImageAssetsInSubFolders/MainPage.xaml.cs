namespace MauiAppImageAssetsInSubFolders
{
    public partial class MainPage : ContentPage
    {
        bool usingSubfolder = true;

        public MainPage()
        {
            InitializeComponent();

            this.ImageOne.Source = Microsoft.Maui.Controls.ImageSource.FromFile("dotnet_bot.png");
            this.ImageTwo.Source = Microsoft.Maui.Controls.ImageSource.FromFile("subfolder/dotnet_bot_red.png");

            FileImageSource fis = this.ImageTwo.Source as FileImageSource;

            this.CounterBtn.Text = fis.File;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            if (usingSubfolder)
            {
                this.ImageTwo.Source = Microsoft.Maui.Controls.ImageSource.FromFile("dotnet_bot_red.png");
                this.usingSubfolder = false;
            }
            else
            {
                this.ImageTwo.Source = Microsoft.Maui.Controls.ImageSource.FromFile("subfolder/dotnet_bot_red.png");
                this.usingSubfolder = true;
            }

            FileImageSource fis = this.ImageTwo.Source as FileImageSource;

            this.CounterBtn.Text = fis.File;
            SemanticScreenReader.Announce(fis.File);
        }
    }

}

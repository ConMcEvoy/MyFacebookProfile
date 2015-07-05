using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Facebook;
using Facebook.Client;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyFacebookProfile
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private FacebookClient client;

       

        private void OnSessionStateChanged(object sender, Facebook.Client.Controls.SessionStateChangedEventArgs e)
        {
            this.ContentPanel.Visibility = (e.SessionState == Facebook.Client.Controls.FacebookSessionState.Opened) ?
                                        Visibility.Visible : Visibility.Collapsed;
        }
    }
}

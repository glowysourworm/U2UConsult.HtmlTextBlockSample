namespace U2UConsult.HtmlTextBlock.Sample
{
    using System.Windows;
    using Microsoft.Windows.Controls;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StatusInformation si = new StatusInformation();

        public MainWindow()
        {
            InitializeComponent();

            // Formatting
            this.HtmlFormattingRichTextBox.TextFormatter = new HtmlFormatter();
            this.HtmlFormattingRichTextBox.Text =
                @"<u>Scissors</u> cuts <i>paper</i>, <i>paper</i> covers <span style='color:orange'>rock</span>, <span style='color:orange'>rock</span> crushes <b style='color:blue'>lizard</b>, " +
                "<b style='color:blue'>lizard</b> poisons <b>Spock</b>, <b>Spock</b> smashes <u>scissors</u>, <u>scissors</u> decapitates <b style='color:blue'>lizard</b>, " +
                "<b style='color:blue'>lizard</b> eats <i>paper</i>, <i>paper</i> disproves <b>Spock</b>, <b>Spock</b> vaporizes <span style='color:orange'>rock</span>, " +
                "and —as it <span style='font-size:24'><i>always</i></span> has— <span style='color:orange'>rock</span> crushes <u>scissors</u>";

            // Tables
            this.HtmlTableRichTextBox.Text = @"<table>" +
                                              "<tr><td><span style='color: blue'>&nbsp;top left</span></td><td>&nbsp;top right</td></tr>" +
                                              "<tr><td><a href='http://www.u2uconsult.com'>&nbsp;middle left</a></td><td>&nbsp;middle right</td></tr>" +
                                              "<tr><td><i>&nbsp;bottom left</i></td><td><span style='font-size:18'>&nbsp;bottom right</span></td></tr>" +
                                              "</table>";

            // Binding
            this.BoundHtmlRichTextBox.DataContext = this.si;

            // Roll your own
            // this.DiyRichTextBox.DataContext = this.YourHtml; // converter doesn'l like this
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.si.Culture = "nl";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.si.Culture = "fr";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.si.Culture = "en";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.DiyRichTextBox.Text = this.YourHtml.Text;
        }
    }
}

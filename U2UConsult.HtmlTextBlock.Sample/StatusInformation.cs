namespace U2UConsult.HtmlTextBlock.Sample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.ComponentModel;

    /// <summary>
    /// Just a sample class to illustrate the bindings ...
    /// </summary>
    public class StatusInformation : INotifyPropertyChanged
    {
        private string message = "no message yet";

        private string culture;

        public string Culture
        {
            get { return this.culture; }
            set
            {
                this.culture = value;
                switch (this.culture)
                {
                    case "nl":
                        this.Message = "Het rapport werd naar <b>uw lokale printer</b> gestuurd.<br/><br/>Druk <u style='color:red'>Enter</u> om verder te gaan of <u style='color: red'>Keerekeweere</u> om opnieuw af te drukken.";
                        break;
                    case "fr":
                        this.Message = "Le rapport a été envoyé a <b>votre imprimante locale</b>.<br/><br/>Appuyez sur <u style='color:red'>Entrée</u> pour continuer, ou <u style='color: red'>Retour</u> pour réimprimer.";
                        break;
                    default:
                        this.Message = "The report was sent to <b>your local printer</b>.<br/><br/>Press <u style='color:red'>Enter</u> to continue or <u style='color:red'>Back</u> to print again.";
                        break;
                }
            }
        }


        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
                this.OnPropertyChanged("Message");
            }
        }

        /// <summary>
        /// Change notification.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// PropertyChanged Event Raiser.
        /// </summary>
        /// <param name="propertyName">Name of the modified property.</param>
        private void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

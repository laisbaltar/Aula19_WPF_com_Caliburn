using System;
using Caliburn.Micro;
using Wpf.Aplicativo.ViewModels;

namespace Wpf.Aplicativo.ViewModels
{
    public class MainViewModel : Screen
    {

        private string nomeCompleto;

        public string NomeCompleto
        {
            get
            {
                return nomeCompleto;
            }
            set
            {
                nomeCompleto = value;
                // Observa se o atributo/instância FirstName recebeu alguma atualização.
                base.NotifyOfPropertyChange(() => NomeCompleto);
            }
        }
    }
}

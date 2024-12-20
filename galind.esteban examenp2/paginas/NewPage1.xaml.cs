using System;
using System.IO;
using Microsoft.Maui.Controls;

namespace galind.esteban_examenp2.paginas
{
    public partial class Pagina1 : ContentPage
    {
        private const string FileName = "MateoPillajo.txt";

        public Pagina1()
        {
            InitializeComponent();
            LoadLastRecharge();
        }

        private void OnRechargeClicked(object sender, EventArgs e)
        {
            string phoneNumber = egalindo_entryPhoneNumber.Text;
            string name = egalindo_entryName.Text;

            if (string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(name))
            {
                DisplayAlert("Error", "Por favor ingrese todos los datos.", "OK");
                return;
            }

            string filePath = Path.Combine(FileSystem.AppDataDirectory, FileName);
            string rechargeInfo = $"Nombre: {name}\nN�mero: {phoneNumber}";

            File.WriteAllText(filePath, rechargeInfo);

            DisplayAlert("�xito", "Recarga realizada con �xito.", "OK");
            LoadLastRecharge();
            ClearInputs();
        }

        private void LoadLastRecharge()
        {
            string filePath = Path.Combine(FileSystem.AppDataDirectory, FileName);

            if (File.Exists(filePath))
            {
                string lastRecharge = File.ReadAllText(filePath);
                egalindo_labelLastRecharge.Text = lastRecharge;
            }
        }

        private void ClearInputs()
        {
            egalindo_entryPhoneNumber.Text = string.Empty;
            egalindo_entryName.Text = string.Empty;
        }
    }
}
tiene men� contextual
namespace galind.esteban_examenp2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(paginas.NewPage1), typeof(paginas.NewPage1));
        }
    }
}

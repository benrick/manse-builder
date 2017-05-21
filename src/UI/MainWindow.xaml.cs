using System.Windows;
using ManseBuilder.Core.DataAccess;
using ManseBuilder.Core.Model;
using ManseBuilder.Infrastructure.DataAccess;
using ManseBuilder.UI.ViewModels;

namespace ManseBuilder.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly IRepository<Manse> _manseRepository = new JsonFileManseRepository();

        public MainWindow()
        {
            InitializeComponent();
            var manses = _manseRepository.GetAll();
            var mainViewModel = new MainViewModel(manses);
            DataContext = mainViewModel;
        }
    }
}

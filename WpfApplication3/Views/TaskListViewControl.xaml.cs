using System.Windows.Controls;
using WpfApplication3.ViewModel;

namespace WpfApplication3.Views
{
    /// <summary>
    /// Interaction logic for TaskListViewControl.xaml
    /// </summary>
    public partial class TaskListViewControl : UserControl
    {
        public TaskListViewControl()
        {
            InitializeComponent();
            this.DataContext = new TaskListViewModel();
        }
    }
}

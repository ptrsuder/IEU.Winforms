using System.Windows.Forms;
using ReactiveUI;

namespace ImageEnhancingUtility.Winforms
{
    public partial class PropertiesForm : Form, IViewFor<ReactiveObject>
    {
        public ReactiveObject ViewModel { get; set; }
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (ReactiveObject)value;
        }

        public PropertiesForm(ReactiveObject viewModel, int height = 650)
        {            
            InitializeComponent();

            ViewModel = viewModel;

            settings_propertyGrid.SelectedObject = ViewModel;
            this.Height = height;
            this.CenterToParent();
            //this.OneWayBind(ViewModel, vm => vm., v => v.settings_propertyGrid.SelectedObject);
        }
    }
}

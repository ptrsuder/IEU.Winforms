using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cyotek.Windows.Forms;
using DynamicData;
using GitHubUpdate;
using ImageEnhancingUtility.Core;
using ImageEnhancingUtility.Core.Utility;
using ReactiveUI;
using Tulpep.NotificationWindow;
using Rule = ImageEnhancingUtility.Core.Rule;

namespace ImageEnhancingUtility.Winforms
{
    public partial class PropertiesForm : Form, IViewFor<IEU>
    {
        public IEU ViewModel { get; set; }
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (IEU)value;
        }

        public PropertiesForm(IEU viewModel)
        {            
            InitializeComponent();

            ViewModel = viewModel;

            settings_propertyGrid.SelectedObject = ViewModel;
            //this.OneWayBind(ViewModel, vm => vm., v => v.settings_propertyGrid.SelectedObject);
        }
    }
}

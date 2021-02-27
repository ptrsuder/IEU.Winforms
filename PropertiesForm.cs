using System;
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

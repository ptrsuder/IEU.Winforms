using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageEnhancingUtility.Core;
using ReactiveUI;

namespace ImageEnhancingUtility.Winforms
{
    public class MainViewModel: ReactiveObject
    {
        private IEU _ieu;
        public IEU IEU
        {
            get => _ieu;
            set => this.RaiseAndSetIfChanged(ref _ieu, value);
        }

        private Config _config;
        public Config Config
        {
            get => _config;
            set => this.RaiseAndSetIfChanged(ref _config, value);
        }

        public MainViewModel()
        {
            IEU = new IEU();
            Config = new Config();
        }

    }
}

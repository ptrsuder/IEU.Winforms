﻿using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ReactiveUI;

namespace ImageEnhancingUtility.Winforms
{
    [JsonObject]
    public class Config : ReactiveObject
    {
        public Config() { }

        public void ReadSettings()
        {
            if (!File.Exists("ieu.winforms.cfg"))
                return;
            var json = File.ReadAllText("ieu.winforms.cfg");
            JsonConvert.PopulateObject(json, this);
        }
        public void SaveSettings()
        {
            var json = JsonConvert.SerializeObject(this);
            File.WriteAllText("ieu.winforms.cfg", json);
        }

        private double _windowWidth = 1000;
        public double WindowWidth
        {
            get => _windowWidth;
            set => this.RaiseAndSetIfChanged(ref _windowWidth, value);
        }

        private double _windowHeight = 650; 
        public double WindowHeight
        {
            get => _windowHeight;
            set => this.RaiseAndSetIfChanged(ref _windowHeight, value);
        }

        private Point _windowLocation = new Point(0,0);
        public Point WindowLocation
        {
            get => _windowLocation;
            set => this.RaiseAndSetIfChanged(ref _windowLocation, value);
        }

        private FormWindowState _windowState = FormWindowState.Normal;
        public FormWindowState WindowState
        {
            get => _windowState;
            set => this.RaiseAndSetIfChanged(ref _windowState, value);
        }

        private double _logPanelWidth = 400; 
        public double LogPanelWidth
        {
            get => _logPanelWidth;
            set => this.RaiseAndSetIfChanged(ref _logPanelWidth, value);
        }

        private int _activeTab = 0;
        public int ActiveTab
        {
            get => _activeTab;
            set => this.RaiseAndSetIfChanged(ref _activeTab, value);
        }

        bool _checkForUpdates = true;
        public bool CheckForUpdates
        {
            get => _checkForUpdates;
            set => this.RaiseAndSetIfChanged(ref _checkForUpdates, value);
        }

        bool _windowOnTop = false;      
        public bool WindowOnTop
        {
            get => _windowOnTop;
            set => this.RaiseAndSetIfChanged(ref _windowOnTop, value);
        }

        bool _showPopups = true;       
        public bool ShowPopups
        {
            get => _showPopups;
            set => this.RaiseAndSetIfChanged(ref _showPopups, value);
        }

        Color _comparisonColor = Color.FromArgb(225, 0, 104);
        public Color ComparisonColor
        {
            get => _comparisonColor;
            set => this.RaiseAndSetIfChanged(ref _comparisonColor, value);
        }

        int _comparisonModSelectedIndex = 2;
        public int ComparisonModSelectedIndex
        {
            get => _comparisonModSelectedIndex;
            set => this.RaiseAndSetIfChanged(ref _comparisonModSelectedIndex, value);
        }


        bool _showPreviewSaveDialog = false;
        public bool ShowPreviewSaveDialog
        {
            get => _showPreviewSaveDialog;
            set => this.RaiseAndSetIfChanged(ref _showPreviewSaveDialog, value);
        }

        bool _darkTheme = true;
        public bool DarkTheme
        {
            get => _darkTheme;
            set => this.RaiseAndSetIfChanged(ref _darkTheme, value);
        }

        string _lastPreviewSavePath = "";
        public string LastPreviewSavePath
        {
            get => _lastPreviewSavePath;
            set => this.RaiseAndSetIfChanged(ref _lastPreviewSavePath, value);
        }
    }
}

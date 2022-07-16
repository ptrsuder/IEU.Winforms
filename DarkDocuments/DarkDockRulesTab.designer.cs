using System.Windows.Forms;
using AltUI.Controls;

namespace ImageEnhancingUtility.Winforms
{
    partial class DarkDockRulesTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {           
            this.disableRuleSystem_checkBox = new AltUI.Controls.DarkCheckBox();
            this.rules_groupBox = new System.Windows.Forms.GroupBox();
            this.rulePriority_numericUpDown = new AltUI.Controls.DarkNumericUpDown();
            this.deleteRule_button = new AltUI.Controls.DarkButton();
            this.rules_listBox = new System.Windows.Forms.ListBox();
            this.newRuleName_textBox = new AltUI.Controls.DarkTextBox();
            this.ruleProfiles_comboBox = new AltUI.Controls.DarkComboBox();
            this.ruleFilters_comboBox = new AltUI.Controls.DarkComboBox();
            this.saveRuleFromCurrent_button = new AltUI.Controls.DarkButton();
            this.saveRule_button = new AltUI.Controls.DarkButton();
            this.loadRule_button = new AltUI.Controls.DarkButton();
            this.filters_groupBox = new System.Windows.Forms.GroupBox();
            this.deleteFilter_button = new AltUI.Controls.DarkButton();
            this.filterExtensions_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.newFilterName_textBox = new AltUI.Controls.DarkTextBox();
            this.filtersSize_groupBox = new System.Windows.Forms.GroupBox();
            this.filtersSizeOn_checkBox = new AltUI.Controls.DarkCheckBox();
            this.filterSizeWidth_numericUpDown = new AltUI.Controls.DarkNumericUpDown();
            this.filterSizeHeight_numericUpDown = new AltUI.Controls.DarkNumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.filterSizeOr_checkBox = new AltUI.Controls.DarkCheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.saveFilter_button = new AltUI.Controls.DarkButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.filterFolderNameCaseSensitive_checkBox = new AltUI.Controls.DarkCheckBox();
            this.filterFolderNameContains_checkBox = new AltUI.Controls.DarkCheckBox();
            this.filterFolderNameContains_textBox = new AltUI.Controls.DarkTextBox();
            this.filterFolderNameNotContains_checkBox = new AltUI.Controls.DarkCheckBox();
            this.filterFolderNameNotContains_textBox = new AltUI.Controls.DarkTextBox();
            this.filtersFilename_groupBox = new System.Windows.Forms.GroupBox();
            this.filterFilenameCaseSensitive_checkBox = new AltUI.Controls.DarkCheckBox();
            this.filterFilenameContains_checkBox = new AltUI.Controls.DarkCheckBox();
            this.filterFilenameContains_textBox = new AltUI.Controls.DarkTextBox();
            this.filterFilenameNotContains_checkBox = new AltUI.Controls.DarkCheckBox();
            this.filterFilenameNotContains_textBox = new AltUI.Controls.DarkTextBox();
            this.loadFilter_button = new AltUI.Controls.DarkButton();
            this.checkBox3 = new AltUI.Controls.DarkCheckBox();
            this.filters_listBox = new System.Windows.Forms.ListBox();
            this.filtersAlpha_groupBox = new System.Windows.Forms.GroupBox();
            this.filterAlpha_comboBox = new AltUI.Controls.DarkComboBox();
            this.rules_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulePriority_numericUpDown)).BeginInit();
            this.filters_groupBox.SuspendLayout();
            this.filtersSize_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterSizeWidth_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterSizeHeight_numericUpDown)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.filtersFilename_groupBox.SuspendLayout();
            this.filtersAlpha_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // disableRuleSystem_checkBox
            // 
            this.disableRuleSystem_checkBox.AutoSize = true;
            this.disableRuleSystem_checkBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.disableRuleSystem_checkBox.Location = new System.Drawing.Point(565, 494);
            this.disableRuleSystem_checkBox.Name = "disableRuleSystem_checkBox";
            this.disableRuleSystem_checkBox.Offset = 1;
            this.disableRuleSystem_checkBox.Size = new System.Drawing.Size(131, 19);
            this.disableRuleSystem_checkBox.TabIndex = 44;
            this.disableRuleSystem_checkBox.Text = "Disable Rule System";
            this.disableRuleSystem_checkBox.Visible = false;
            // 
            // rules_groupBox
            // 
            this.rules_groupBox.Controls.Add(this.rulePriority_numericUpDown);
            this.rules_groupBox.Controls.Add(this.deleteRule_button);
            this.rules_groupBox.Controls.Add(this.rules_listBox);
            this.rules_groupBox.Controls.Add(this.newRuleName_textBox);
            this.rules_groupBox.Controls.Add(this.loadRule_button);
            this.rules_groupBox.Controls.Add(this.ruleProfiles_comboBox);
            this.rules_groupBox.Controls.Add(this.ruleFilters_comboBox);
            this.rules_groupBox.Controls.Add(this.saveRuleFromCurrent_button);
            this.rules_groupBox.Controls.Add(this.saveRule_button);
            this.rules_groupBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rules_groupBox.Location = new System.Drawing.Point(565, 3);
            this.rules_groupBox.Name = "rules_groupBox";
            this.rules_groupBox.Size = new System.Drawing.Size(200, 485);
            this.rules_groupBox.TabIndex = 43;
            this.rules_groupBox.TabStop = false;
            this.rules_groupBox.Text = "Rules";
            // 
            // rulePriority_numericUpDown
            // 
            this.rulePriority_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rulePriority_numericUpDown.Location = new System.Drawing.Point(134, 274);
            this.rulePriority_numericUpDown.Name = "rulePriority_numericUpDown";
            this.rulePriority_numericUpDown.ReadOnly = true;
            this.rulePriority_numericUpDown.Size = new System.Drawing.Size(47, 23);
            this.rulePriority_numericUpDown.TabIndex = 59;
            this.rulePriority_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deleteRule_button
            // 
            this.deleteRule_button.FlatBottom = false;
            this.deleteRule_button.FlatTop = false;
            this.deleteRule_button.HoldColour = false;
            this.deleteRule_button.Location = new System.Drawing.Point(20, 433);
            this.deleteRule_button.Name = "deleteRule_button";
            this.deleteRule_button.Padding = new System.Windows.Forms.Padding(5);
            this.deleteRule_button.Size = new System.Drawing.Size(161, 38);
            this.deleteRule_button.TabIndex = 58;
            this.deleteRule_button.Text = "Delete rule";
            // 
            // rules_listBox
            // 
            this.rules_listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rules_listBox.FormattingEnabled = true;
            this.rules_listBox.ItemHeight = 15;
            this.rules_listBox.Location = new System.Drawing.Point(20, 25);
            this.rules_listBox.Name = "rules_listBox";
            this.rules_listBox.Size = new System.Drawing.Size(161, 182);
            this.rules_listBox.TabIndex = 1;
            // 
            // newRuleName_textBox
            // 
            this.newRuleName_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.newRuleName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newRuleName_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.newRuleName_textBox.Location = new System.Drawing.Point(20, 274);
            this.newRuleName_textBox.Name = "newRuleName_textBox";
            this.newRuleName_textBox.Size = new System.Drawing.Size(110, 23);
            this.newRuleName_textBox.TabIndex = 57;
            // 
            // ruleProfiles_comboBox
            // 
            this.ruleProfiles_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ruleProfiles_comboBox.FormattingEnabled = true;
            this.ruleProfiles_comboBox.Location = new System.Drawing.Point(20, 242);
            this.ruleProfiles_comboBox.Name = "ruleProfiles_comboBox";
            this.ruleProfiles_comboBox.Size = new System.Drawing.Size(161, 24);
            this.ruleProfiles_comboBox.TabIndex = 0;
            // 
            // ruleFilters_comboBox
            // 
            this.ruleFilters_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ruleFilters_comboBox.FormattingEnabled = true;
            this.ruleFilters_comboBox.Location = new System.Drawing.Point(20, 216);
            this.ruleFilters_comboBox.Name = "ruleFilters_comboBox";
            this.ruleFilters_comboBox.Size = new System.Drawing.Size(161, 24);
            this.ruleFilters_comboBox.TabIndex = 0;
            // 
            // saveRuleFromCurrent_button
            // 
            this.saveRuleFromCurrent_button.FlatBottom = false;
            this.saveRuleFromCurrent_button.FlatTop = false;
            this.saveRuleFromCurrent_button.HoldColour = false;
            this.saveRuleFromCurrent_button.Location = new System.Drawing.Point(20, 347);
            this.saveRuleFromCurrent_button.Name = "saveRuleFromCurrent_button";
            this.saveRuleFromCurrent_button.Padding = new System.Windows.Forms.Padding(5);
            this.saveRuleFromCurrent_button.Size = new System.Drawing.Size(161, 45);
            this.saveRuleFromCurrent_button.TabIndex = 55;
            this.saveRuleFromCurrent_button.Text = "Save from current filter/profile";
            // 
            // saveRule_button
            // 
            this.saveRule_button.FlatBottom = false;
            this.saveRule_button.FlatTop = false;
            this.saveRule_button.HoldColour = false;
            this.saveRule_button.Location = new System.Drawing.Point(20, 303);
            this.saveRule_button.Name = "saveRule_button";
            this.saveRule_button.Padding = new System.Windows.Forms.Padding(5);
            this.saveRule_button.Size = new System.Drawing.Size(161, 45);
            this.saveRule_button.TabIndex = 55;
            this.saveRule_button.Text = "Save from selected filter/profile";
            // 
            // loadRule_button
            // 
            this.loadRule_button.FlatBottom = false;
            this.loadRule_button.FlatTop = false;
            this.loadRule_button.HoldColour = false;
            this.loadRule_button.Location = new System.Drawing.Point(20, 389);
            this.loadRule_button.Name = "loadRule_button";
            this.loadRule_button.Padding = new System.Windows.Forms.Padding(5);
            this.loadRule_button.Size = new System.Drawing.Size(161, 38);
            this.loadRule_button.TabIndex = 56;
            this.loadRule_button.Text = "Load rule";
            // 
            // filters_groupBox
            // 
            this.filters_groupBox.Controls.Add(this.deleteFilter_button);
            this.filters_groupBox.Controls.Add(this.filterExtensions_checkedListBox);
            this.filters_groupBox.Controls.Add(this.newFilterName_textBox);
            this.filters_groupBox.Controls.Add(this.filtersSize_groupBox);
            this.filters_groupBox.Controls.Add(this.saveFilter_button);
            this.filters_groupBox.Controls.Add(this.groupBox10);
            this.filters_groupBox.Controls.Add(this.filtersFilename_groupBox);
            this.filters_groupBox.Controls.Add(this.loadFilter_button);
            this.filters_groupBox.Controls.Add(this.checkBox3);
            this.filters_groupBox.Controls.Add(this.filters_listBox);
            this.filters_groupBox.Controls.Add(this.filtersAlpha_groupBox);
            this.filters_groupBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.filters_groupBox.Location = new System.Drawing.Point(3, 3);
            this.filters_groupBox.Name = "filters_groupBox";
            this.filters_groupBox.Size = new System.Drawing.Size(537, 631);
            this.filters_groupBox.TabIndex = 42;
            this.filters_groupBox.TabStop = false;
            this.filters_groupBox.Text = "Filters";
            // 
            // deleteFilter_button
            // 
            this.deleteFilter_button.FlatBottom = false;
            this.deleteFilter_button.FlatTop = false;
            this.deleteFilter_button.HoldColour = false;
            this.deleteFilter_button.Location = new System.Drawing.Point(162, 583);
            this.deleteFilter_button.Name = "deleteFilter_button";
            this.deleteFilter_button.Padding = new System.Windows.Forms.Padding(5);
            this.deleteFilter_button.Size = new System.Drawing.Size(149, 31);
            this.deleteFilter_button.TabIndex = 58;
            this.deleteFilter_button.Text = "Delete filter";
            // 
            // filterExtensions_checkedListBox
            // 
            this.filterExtensions_checkedListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterExtensions_checkedListBox.CheckOnClick = true;
            this.filterExtensions_checkedListBox.FormattingEnabled = true;
            this.filterExtensions_checkedListBox.Location = new System.Drawing.Point(388, 27);
            this.filterExtensions_checkedListBox.Name = "filterExtensions_checkedListBox";
            this.filterExtensions_checkedListBox.Size = new System.Drawing.Size(128, 182);
            this.filterExtensions_checkedListBox.TabIndex = 10;
            // 
            // newFilterName_textBox
            // 
            this.newFilterName_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.newFilterName_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newFilterName_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.newFilterName_textBox.Location = new System.Drawing.Point(165, 443);
            this.newFilterName_textBox.Name = "newFilterName_textBox";
            this.newFilterName_textBox.Size = new System.Drawing.Size(149, 23);
            this.newFilterName_textBox.TabIndex = 57;
            // 
            // filtersSize_groupBox
            // 
            this.filtersSize_groupBox.Controls.Add(this.filtersSizeOn_checkBox);
            this.filtersSize_groupBox.Controls.Add(this.filterSizeWidth_numericUpDown);
            this.filtersSize_groupBox.Controls.Add(this.filterSizeHeight_numericUpDown);
            this.filtersSize_groupBox.Controls.Add(this.label11);
            this.filtersSize_groupBox.Controls.Add(this.filterSizeOr_checkBox);
            this.filtersSize_groupBox.Controls.Add(this.label10);
            this.filtersSize_groupBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.filtersSize_groupBox.Location = new System.Drawing.Point(140, 274);
            this.filtersSize_groupBox.Name = "filtersSize_groupBox";
            this.filtersSize_groupBox.Size = new System.Drawing.Size(242, 86);
            this.filtersSize_groupBox.TabIndex = 9;
            this.filtersSize_groupBox.TabStop = false;
            this.filtersSize_groupBox.Text = "Size";
            // 
            // filtersSizeOn_checkBox
            // 
            this.filtersSizeOn_checkBox.AutoSize = true;
            this.filtersSizeOn_checkBox.Location = new System.Drawing.Point(7, 42);
            this.filtersSizeOn_checkBox.Name = "filtersSizeOn_checkBox";
            this.filtersSizeOn_checkBox.Offset = 1;
            this.filtersSizeOn_checkBox.Size = new System.Drawing.Size(83, 19);
            this.filtersSizeOn_checkBox.TabIndex = 11;
            this.filtersSizeOn_checkBox.Text = "Not bigger";
            // 
            // filterSizeWidth_numericUpDown
            // 
            this.filterSizeWidth_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterSizeWidth_numericUpDown.Enabled = false;
            this.filterSizeWidth_numericUpDown.Location = new System.Drawing.Point(89, 29);
            this.filterSizeWidth_numericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.filterSizeWidth_numericUpDown.Name = "filterSizeWidth_numericUpDown";
            this.filterSizeWidth_numericUpDown.Size = new System.Drawing.Size(55, 23);
            this.filterSizeWidth_numericUpDown.TabIndex = 3;
            this.filterSizeWidth_numericUpDown.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // filterSizeHeight_numericUpDown
            // 
            this.filterSizeHeight_numericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterSizeHeight_numericUpDown.Enabled = false;
            this.filterSizeHeight_numericUpDown.Location = new System.Drawing.Point(89, 52);
            this.filterSizeHeight_numericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.filterSizeHeight_numericUpDown.Name = "filterSizeHeight_numericUpDown";
            this.filterSizeHeight_numericUpDown.Size = new System.Drawing.Size(55, 23);
            this.filterSizeHeight_numericUpDown.TabIndex = 3;
            this.filterSizeHeight_numericUpDown.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(145, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "Height";
            // 
            // filterSizeOr_checkBox
            // 
            this.filterSizeOr_checkBox.AutoSize = true;
            this.filterSizeOr_checkBox.Enabled = false;
            this.filterSizeOr_checkBox.Location = new System.Drawing.Point(190, 42);
            this.filterSizeOr_checkBox.Name = "filterSizeOr_checkBox";
            this.filterSizeOr_checkBox.Offset = 1;
            this.filterSizeOr_checkBox.Size = new System.Drawing.Size(42, 19);
            this.filterSizeOr_checkBox.TabIndex = 4;
            this.filterSizeOr_checkBox.Text = "OR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(145, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Width";
            // 
            // saveFilter_button
            // 
            this.saveFilter_button.FlatBottom = false;
            this.saveFilter_button.FlatTop = false;
            this.saveFilter_button.HoldColour = false;
            this.saveFilter_button.Location = new System.Drawing.Point(162, 514);
            this.saveFilter_button.Name = "saveFilter_button";
            this.saveFilter_button.Padding = new System.Windows.Forms.Padding(5);
            this.saveFilter_button.Size = new System.Drawing.Size(149, 31);
            this.saveFilter_button.TabIndex = 55;
            this.saveFilter_button.Text = "Save filter";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.filterFolderNameCaseSensitive_checkBox);
            this.groupBox10.Controls.Add(this.filterFolderNameContains_checkBox);
            this.groupBox10.Controls.Add(this.filterFolderNameContains_textBox);
            this.groupBox10.Controls.Add(this.filterFolderNameNotContains_checkBox);
            this.groupBox10.Controls.Add(this.filterFolderNameNotContains_textBox);
            this.groupBox10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox10.Location = new System.Drawing.Point(3, 116);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(378, 94);
            this.groupBox10.TabIndex = 8;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Folder name";
            // 
            // filterFolderNameCaseSensitive_checkBox
            // 
            this.filterFolderNameCaseSensitive_checkBox.AutoSize = true;
            this.filterFolderNameCaseSensitive_checkBox.Location = new System.Drawing.Point(112, 15);
            this.filterFolderNameCaseSensitive_checkBox.Name = "filterFolderNameCaseSensitive_checkBox";
            this.filterFolderNameCaseSensitive_checkBox.Offset = 1;
            this.filterFolderNameCaseSensitive_checkBox.Size = new System.Drawing.Size(99, 19);
            this.filterFolderNameCaseSensitive_checkBox.TabIndex = 3;
            this.filterFolderNameCaseSensitive_checkBox.Text = "Case sensitive";
            // 
            // filterFolderNameContains_checkBox
            // 
            this.filterFolderNameContains_checkBox.AutoSize = true;
            this.filterFolderNameContains_checkBox.Location = new System.Drawing.Point(9, 39);
            this.filterFolderNameContains_checkBox.Name = "filterFolderNameContains_checkBox";
            this.filterFolderNameContains_checkBox.Offset = 1;
            this.filterFolderNameContains_checkBox.Size = new System.Drawing.Size(73, 19);
            this.filterFolderNameContains_checkBox.TabIndex = 1;
            this.filterFolderNameContains_checkBox.Text = "Contains";
            // 
            // filterFolderNameContains_textBox
            // 
            this.filterFolderNameContains_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.filterFolderNameContains_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterFolderNameContains_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.filterFolderNameContains_textBox.Location = new System.Drawing.Point(118, 38);
            this.filterFolderNameContains_textBox.Name = "filterFolderNameContains_textBox";
            this.filterFolderNameContains_textBox.ReadOnly = true;
            this.filterFolderNameContains_textBox.Size = new System.Drawing.Size(247, 23);
            this.filterFolderNameContains_textBox.TabIndex = 2;
            // 
            // filterFolderNameNotContains_checkBox
            // 
            this.filterFolderNameNotContains_checkBox.AutoSize = true;
            this.filterFolderNameNotContains_checkBox.Location = new System.Drawing.Point(9, 65);
            this.filterFolderNameNotContains_checkBox.Name = "filterFolderNameNotContains_checkBox";
            this.filterFolderNameNotContains_checkBox.Offset = 1;
            this.filterFolderNameNotContains_checkBox.Size = new System.Drawing.Size(109, 19);
            this.filterFolderNameNotContains_checkBox.TabIndex = 1;
            this.filterFolderNameNotContains_checkBox.Text = "Doesn\'t contain";
            // 
            // filterFolderNameNotContains_textBox
            // 
            this.filterFolderNameNotContains_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.filterFolderNameNotContains_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterFolderNameNotContains_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.filterFolderNameNotContains_textBox.Location = new System.Drawing.Point(118, 64);
            this.filterFolderNameNotContains_textBox.Name = "filterFolderNameNotContains_textBox";
            this.filterFolderNameNotContains_textBox.ReadOnly = true;
            this.filterFolderNameNotContains_textBox.Size = new System.Drawing.Size(247, 23);
            this.filterFolderNameNotContains_textBox.TabIndex = 2;
            // 
            // filtersFilename_groupBox
            // 
            this.filtersFilename_groupBox.Controls.Add(this.filterFilenameCaseSensitive_checkBox);
            this.filtersFilename_groupBox.Controls.Add(this.filterFilenameContains_checkBox);
            this.filtersFilename_groupBox.Controls.Add(this.filterFilenameContains_textBox);
            this.filtersFilename_groupBox.Controls.Add(this.filterFilenameNotContains_checkBox);
            this.filtersFilename_groupBox.Controls.Add(this.filterFilenameNotContains_textBox);
            this.filtersFilename_groupBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.filtersFilename_groupBox.Location = new System.Drawing.Point(4, 22);
            this.filtersFilename_groupBox.Name = "filtersFilename_groupBox";
            this.filtersFilename_groupBox.Size = new System.Drawing.Size(378, 94);
            this.filtersFilename_groupBox.TabIndex = 8;
            this.filtersFilename_groupBox.TabStop = false;
            this.filtersFilename_groupBox.Text = "Filename";
            // 
            // filterFilenameCaseSensitive_checkBox
            // 
            this.filterFilenameCaseSensitive_checkBox.AutoSize = true;
            this.filterFilenameCaseSensitive_checkBox.Location = new System.Drawing.Point(112, 15);
            this.filterFilenameCaseSensitive_checkBox.Name = "filterFilenameCaseSensitive_checkBox";
            this.filterFilenameCaseSensitive_checkBox.Offset = 1;
            this.filterFilenameCaseSensitive_checkBox.Size = new System.Drawing.Size(99, 19);
            this.filterFilenameCaseSensitive_checkBox.TabIndex = 3;
            this.filterFilenameCaseSensitive_checkBox.Text = "Case sensitive";
            // 
            // filterFilenameContains_checkBox
            // 
            this.filterFilenameContains_checkBox.AutoSize = true;
            this.filterFilenameContains_checkBox.Location = new System.Drawing.Point(9, 39);
            this.filterFilenameContains_checkBox.Name = "filterFilenameContains_checkBox";
            this.filterFilenameContains_checkBox.Offset = 1;
            this.filterFilenameContains_checkBox.Size = new System.Drawing.Size(73, 19);
            this.filterFilenameContains_checkBox.TabIndex = 1;
            this.filterFilenameContains_checkBox.Text = "Contains";
            // 
            // filterFilenameContains_textBox
            // 
            this.filterFilenameContains_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.filterFilenameContains_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterFilenameContains_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.filterFilenameContains_textBox.Location = new System.Drawing.Point(118, 38);
            this.filterFilenameContains_textBox.Name = "filterFilenameContains_textBox";
            this.filterFilenameContains_textBox.ReadOnly = true;
            this.filterFilenameContains_textBox.Size = new System.Drawing.Size(247, 23);
            this.filterFilenameContains_textBox.TabIndex = 2;
            // 
            // filterFilenameNotContains_checkBox
            // 
            this.filterFilenameNotContains_checkBox.AutoSize = true;
            this.filterFilenameNotContains_checkBox.Location = new System.Drawing.Point(9, 65);
            this.filterFilenameNotContains_checkBox.Name = "filterFilenameNotContains_checkBox";
            this.filterFilenameNotContains_checkBox.Offset = 1;
            this.filterFilenameNotContains_checkBox.Size = new System.Drawing.Size(109, 19);
            this.filterFilenameNotContains_checkBox.TabIndex = 1;
            this.filterFilenameNotContains_checkBox.Text = "Doesn\'t contain";
            // 
            // filterFilenameNotContains_textBox
            // 
            this.filterFilenameNotContains_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.filterFilenameNotContains_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterFilenameNotContains_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.filterFilenameNotContains_textBox.Location = new System.Drawing.Point(118, 64);
            this.filterFilenameNotContains_textBox.Name = "filterFilenameNotContains_textBox";
            this.filterFilenameNotContains_textBox.ReadOnly = true;
            this.filterFilenameNotContains_textBox.Size = new System.Drawing.Size(247, 23);
            this.filterFilenameNotContains_textBox.TabIndex = 2;
            // 
            // loadFilter_button
            // 
            this.loadFilter_button.FlatBottom = false;
            this.loadFilter_button.FlatTop = false;
            this.loadFilter_button.HoldColour = false;
            this.loadFilter_button.Location = new System.Drawing.Point(162, 548);
            this.loadFilter_button.Name = "loadFilter_button";
            this.loadFilter_button.Padding = new System.Windows.Forms.Padding(5);
            this.loadFilter_button.Size = new System.Drawing.Size(149, 31);
            this.loadFilter_button.TabIndex = 56;
            this.loadFilter_button.Text = "Load filter";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(855, 218);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Offset = 1;
            this.checkBox3.Size = new System.Drawing.Size(119, 19);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Already has result";
            this.checkBox3.Visible = false;
            // 
            // filters_listBox
            // 
            this.filters_listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filters_listBox.FormattingEnabled = true;
            this.filters_listBox.ItemHeight = 15;
            this.filters_listBox.Location = new System.Drawing.Point(8, 443);
            this.filters_listBox.Name = "filters_listBox";
            this.filters_listBox.Size = new System.Drawing.Size(149, 167);
            this.filters_listBox.TabIndex = 54;
            // 
            // filtersAlpha_groupBox
            // 
            this.filtersAlpha_groupBox.Controls.Add(this.filterAlpha_comboBox);
            this.filtersAlpha_groupBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.filtersAlpha_groupBox.Location = new System.Drawing.Point(4, 274);
            this.filtersAlpha_groupBox.Name = "filtersAlpha_groupBox";
            this.filtersAlpha_groupBox.Size = new System.Drawing.Size(130, 86);
            this.filtersAlpha_groupBox.TabIndex = 0;
            this.filtersAlpha_groupBox.TabStop = false;
            this.filtersAlpha_groupBox.Text = "Alpha";
            // 
            // filterAlpha_comboBox
            // 
            this.filterAlpha_comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.filterAlpha_comboBox.FormattingEnabled = true;
            this.filterAlpha_comboBox.Location = new System.Drawing.Point(9, 38);
            this.filterAlpha_comboBox.Name = "filterAlpha_comboBox";
            this.filterAlpha_comboBox.Size = new System.Drawing.Size(111, 24);
            this.filterAlpha_comboBox.TabIndex = 0;
            // 
            // DarkDockRulesTab
            // 
            this.Controls.Add(this.disableRuleSystem_checkBox);
            this.Controls.Add(this.rules_groupBox);
            this.Controls.Add(this.filters_groupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DarkDockRulesTab";
            this.Size = new System.Drawing.Size(841, 655);
            this.Load += new System.EventHandler(this.DockDocument_Load);
            this.rules_groupBox.ResumeLayout(false);
            this.rules_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulePriority_numericUpDown)).EndInit();
            this.filters_groupBox.ResumeLayout(false);
            this.filters_groupBox.PerformLayout();
            this.filtersSize_groupBox.ResumeLayout(false);
            this.filtersSize_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterSizeWidth_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterSizeHeight_numericUpDown)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.filtersFilename_groupBox.ResumeLayout(false);
            this.filtersFilename_groupBox.PerformLayout();
            this.filtersAlpha_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DarkCheckBox disableRuleSystem_checkBox;
        public System.Windows.Forms.GroupBox rules_groupBox;
        public DarkNumericUpDown rulePriority_numericUpDown;
        public DarkButton deleteRule_button;
        public System.Windows.Forms.ListBox rules_listBox;
        public DarkTextBox newRuleName_textBox;
        public DarkComboBox ruleProfiles_comboBox;
        public DarkComboBox ruleFilters_comboBox;
        public DarkButton saveRuleFromCurrent_button;
        public DarkButton saveRule_button;
        public DarkButton loadRule_button;
        public System.Windows.Forms.GroupBox filters_groupBox;
        public DarkButton deleteFilter_button;
        public System.Windows.Forms.CheckedListBox filterExtensions_checkedListBox;
        public DarkTextBox newFilterName_textBox;
        public System.Windows.Forms.GroupBox filtersSize_groupBox;
        public DarkCheckBox filtersSizeOn_checkBox;
        public DarkNumericUpDown filterSizeWidth_numericUpDown;
        public DarkNumericUpDown filterSizeHeight_numericUpDown;
        public System.Windows.Forms.Label label11;
        public DarkCheckBox filterSizeOr_checkBox;
        public System.Windows.Forms.Label label10;
        public DarkButton saveFilter_button;
        public System.Windows.Forms.GroupBox groupBox10;
        public DarkCheckBox filterFolderNameCaseSensitive_checkBox;
        public DarkCheckBox filterFolderNameContains_checkBox;
        public DarkTextBox filterFolderNameContains_textBox;
        public DarkCheckBox filterFolderNameNotContains_checkBox;
        public DarkTextBox filterFolderNameNotContains_textBox;
        public System.Windows.Forms.GroupBox filtersFilename_groupBox;
        public DarkCheckBox filterFilenameCaseSensitive_checkBox;
        public DarkCheckBox filterFilenameContains_checkBox;
        public DarkTextBox filterFilenameContains_textBox;
        public DarkCheckBox filterFilenameNotContains_checkBox;
        public DarkTextBox filterFilenameNotContains_textBox;
        public DarkButton loadFilter_button;
        public DarkCheckBox checkBox3;
        public System.Windows.Forms.ListBox filters_listBox;
        public System.Windows.Forms.GroupBox filtersAlpha_groupBox;
        public DarkComboBox filterAlpha_comboBox;
    }
}

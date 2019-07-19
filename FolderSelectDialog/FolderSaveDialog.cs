using System;
using System.Windows.Forms;

// ------------------------------------------------------------------
// Wraps System.Windows.Forms.OpenFileDialog to make it present
// a vista-style dialog.
// ------------------------------------------------------------------

namespace FolderSelectDialog
{
	/// <summary>
	/// Wraps System.Windows.Forms.OpenFileDialog to make it present
	/// a vista-style dialog.
	/// </summary>
	public class FolderSaveDialog
	{
		// Wrapped dialog
		System.Windows.Forms.SaveFileDialog sfd = null;

		/// <summary>
		/// Default constructor
		/// </summary>
		public FolderSaveDialog()
		{
			sfd = new System.Windows.Forms.SaveFileDialog();

			sfd.Filter = "Folders|\n";
			sfd.AddExtension = false;
			sfd.CheckFileExists = false;
			sfd.DereferenceLinks = true;
			//sfd.Multiselect = false;
            //sfd.CheckPathExists = false;
		}

		#region Properties

		/// <summary>
		/// Gets/Sets the initial folder to be selected. A null value selects the current directory.
		/// </summary>
		public string InitialDirectory
		{
			get { return sfd.InitialDirectory; }
			set { sfd.InitialDirectory = value == null || value.Length == 0 ? Environment.CurrentDirectory : value; }
		}

		/// <summary>
		/// Gets/Sets the title to show in the dialog
		/// </summary>
		public string Title
		{
			get { return sfd.Title; }
			set { sfd.Title = value == null ? "Select a folder" : value; }
		}

		/// <summary>
		/// Gets the selected folder
		/// </summary>
		public string FileName
		{
			get { return sfd.FileName; }
		}

		#endregion

		#region Methods

		/// <summary>
		/// Shows the dialog
		/// </summary>
		/// <returns>True if the user presses OK else false</returns>
		public bool ShowDialog()
		{
			return ShowDialog(IntPtr.Zero);
		}

		/// <summary>
		/// Shows the dialog
		/// </summary>
		/// <param name="hWndOwner">Handle of the control to be parent</param>
		/// <returns>True if the user presses OK else false</returns>
		public bool ShowDialog(IntPtr hWndOwner)
		{
			bool flag = false;

			if (Environment.OSVersion.Version.Major >= 6)
			{
				var r = new Reflector("System.Windows.Forms");

				uint num = 0;
				Type typeIFileDialog = r.GetType("FileDialogNative.IFileDialog");
				object dialog = r.Call(sfd, "CreateVistaDialog");
				r.Call(sfd, "OnBeforeVistaDialog", dialog);

				uint options = (uint)r.CallAs(typeof(System.Windows.Forms.FileDialog), sfd, "GetOptions");
				options |= (uint)r.GetEnum("FileDialogNative.FOS", "FOS_PICKFOLDERS");
				r.CallAs(typeIFileDialog, dialog, "SetOptions", options);

				object pfde = r.New("FileDialog.VistaDialogEvents", sfd);
				object[] parameters = new object[] { pfde, num };
				r.CallAs2(typeIFileDialog, dialog, "Advise", parameters);
				num = (uint)parameters[1];
				try
				{
					int num2 = (int)r.CallAs(typeIFileDialog, dialog, "Show", hWndOwner);
					flag = 0 == num2;
				}
				finally
				{
					r.CallAs(typeIFileDialog, dialog, "Unadvise", num);
					GC.KeepAlive(pfde);
				}
			}
			else
			{
				var fbd = new FolderBrowserDialog();
				fbd.Description = this.Title;
				fbd.SelectedPath = this.InitialDirectory;
				fbd.ShowNewFolderButton = false;
				if (fbd.ShowDialog(new WindowWrapper(hWndOwner)) != DialogResult.OK) return false;
				sfd.FileName = fbd.SelectedPath;
				flag = true;
			}

			return flag;
		}

		#endregion
	}

	/// <summary>
	/// Creates IWin32Window around an IntPtr
	/// </summary>
	public class WindowWrapper : System.Windows.Forms.IWin32Window
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="handle">Handle to wrap</param>
		public WindowWrapper(IntPtr handle)
		{
			_hwnds = handle;
		}

		/// <summary>
		/// Original ptr
		/// </summary>
		public IntPtr Handle
		{
			get { return _hwnds; }
		}

		private IntPtr _hwnds;
	}

}

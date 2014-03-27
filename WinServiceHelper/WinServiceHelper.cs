using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;
using System.IO;

namespace WinServiceHelper
{
    public partial class WinServiceHelper : Form
    {
        public WinServiceHelper()
        {
            InitializeComponent();

            //if the list of services to start/stop has not been initialised, initialise it
            if (Properties.Settings.Default.Services == null)
            {
                Properties.Settings.Default.Services = new System.Collections.Specialized.StringCollection();
                Properties.Settings.Default.Services.Add("ArgusTVRecorder");
            }
            
            if (Properties.Settings.Default.StartService)//execute if the user has enabled the feature
                Manager.StartAllSelectedServices(Properties.Settings.Default.Services.Cast<string>().ToArray(), Properties.Settings.Default.ServiceTimeout * 1000); //start all services previously selected by the user

            populateForm(); //populate the form fields with saved data

            //execute if the user has enabled the feature
            if (Properties.Settings.Default.StartApplication)
                Manager.ExecuteWinApplication(Properties.Settings.Default.ApplicationPath, Properties.Settings.Default.ApplicationDelay * 1000); //execute the win application previously selected by thr user
        }      

        /// <summary>
        /// Populates the fields in the main form with all system services and saved data.
        /// </summary>
        private void populateForm()
        {
            populateListView();

            //fill other service section fields
            checkBoxStartService.Checked = Properties.Settings.Default.StartService;
            checkBoxStopService.Checked = Properties.Settings.Default.StopService;
            numericUpDownServiceTimeout.Value = Properties.Settings.Default.ServiceTimeout;

            //fill windows application section fields
            checkBoxExecuteApplication.Checked = Properties.Settings.Default.StartApplication;
            numericUpDownAppLaunchDelay.Value = Properties.Settings.Default.ApplicationDelay;
            textBoxWinAppPath.Text = Properties.Settings.Default.ApplicationPath;
        }

        /// <summary>
        /// Populates the list view with details of all local windows services.
        /// If the user has previously selected them, tick them.
        /// </summary>
        private void populateListView()
        {
            //get all services on the system and fill the checked list box    
            listViewServices.Items.Clear();
            foreach (ServiceController service in ServiceController.GetServices())
            {
                ListViewItem item = new ListViewItem(service.ServiceName); //add the service name
                item.Tag = service; //add the service object as a tag so it can be used later
                item.SubItems.Add(service.Status.ToString()); //add the current status
                item.SubItems.Add(service.DisplayName); //add the friendly name

                //if the user has selected then then tick them
                if (Properties.Settings.Default.Services.Contains(service.ServiceName))
                    item.Checked = true;

                listViewServices.Items.Add(item);
            }
        }

        /// <summary>
        /// Stops all services selected by the user.
        /// Waits a user defined amount of time before timeout.
        /// This method executes on the form closing event. This ensures that services are stopped when 
        /// the computer is being shut down.
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.StopService)
                Manager.StopAllSelectedServices(Properties.Settings.Default.Services.Cast<string>().ToArray(), Properties.Settings.Default.ServiceTimeout * 1000);
            
        }  

        /// <summary>
        /// Returns all fields on the form to their saved values.
        /// </summary>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            populateForm();
        }

        /// <summary>
        /// Saves all currently entered field entries.
        /// </summary>
        private void buttonApply_Click(object sender, EventArgs e)
        {
            //get all checked services in the listview and add them to the saved collection
            Properties.Settings.Default.Services.Clear();

            foreach (ListViewItem service in listViewServices.CheckedItems)
            {
                ServiceController serviceObject = (ServiceController)service.Tag;
                Properties.Settings.Default.Services.Add(serviceObject.ServiceName);
            }

            //save other win service fields
            Properties.Settings.Default.StartService = checkBoxStartService.Checked;
            Properties.Settings.Default.StopService = checkBoxStopService.Checked;
            Properties.Settings.Default.ServiceTimeout = (int)numericUpDownServiceTimeout.Value;

            //save win application fields
            Properties.Settings.Default.StartApplication = checkBoxExecuteApplication.Checked;
            Properties.Settings.Default.ApplicationDelay = (int)numericUpDownAppLaunchDelay.Value;
            Properties.Settings.Default.ApplicationPath = textBoxWinAppPath.Text;

            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Keeps the application descrete by hiding the icon in the taskbar tray
        /// The form showInTaskbar proprty is set to false and a notifyIcon object has been configured for the tray
        /// So this method just hides the form.
        /// </summary>
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(3000);
            }
        }

        /// <summary>
        /// Allows the user to select the window application that will be executed.
        /// </summary>
        private void buttonSelectApplication_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            openFileDialog1.InitialDirectory = Path.GetDirectoryName(Properties.Settings.Default.ApplicationPath);
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)          
                textBoxWinAppPath.Text = openFileDialog1.FileName;           
        }

        /// <summary>
        /// Displays the form when the user double clicks on the tray icon.
        /// </summary>
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// Displays the form when the user clicks on the tray icon.
        /// </summary>
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// Refreshes the services list view, updating all service statuses.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            populateListView();
        }
    }
}

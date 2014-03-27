using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.ServiceProcess;
using System.ComponentModel;

namespace WinServiceHelper
{
    class Manager
    {
        /// <summary>
        /// Attempts to start all services selected by the user.
        /// Uses a timeout limit also set by the user.
        /// </summary>
        /// <param name="services">The list of service names to start</param>
        /// <param name="millisecondTimeout">The period to wait before timeout</param>
        internal static void StartAllSelectedServices(string[] services, int millisecondTimeout)
        {
            foreach (string service in services)
                startService(service, millisecondTimeout);             
        }

        /// <summary>
        /// Attempts to stop all services selected by the user.
        /// Uses a timeout limit also set by the user.
        /// </summary>
        /// <param name="services">The list of service names to stop</param>
        /// <param name="millisecondTimeout">The period to wait before timeout</param>
        internal static void StopAllSelectedServices(string[] services, int millisecondTimeout)
        {
            foreach (string service in services)
                stopService(service, millisecondTimeout);
        }

        /// <summary>
        /// Executes the windows application selected by the user.
        /// Asynchronously waits a set period of time (set by the user) before excecution.
        /// </summary>
        internal static void ExecuteWinApplication(string fullPath, int delay)
        {
            try
            {
                BackgroundWorker waiter = new BackgroundWorker();
                waiter.RunWorkerCompleted += new RunWorkerCompletedEventHandler(waiter_RunWorkerCompleted);
                waiter.DoWork += new DoWorkEventHandler(waiter_DoWork);
                waiter.RunWorkerAsync(new ExecuteWinAppArgs(fullPath, delay));         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Asynchronouly waits a user set period of time, then executes the specified application in the main thread
        /// </summary>
        static void waiter_DoWork(object sender, DoWorkEventArgs e)
        {
            ExecuteWinAppArgs args = e.Argument as ExecuteWinAppArgs;
            e.Result = args;
            Thread.Sleep(args.WaitTime);
        }

        /// <summary>
        /// Executes the specified application
        /// </summary>
        static void waiter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ExecuteWinAppArgs args = e.Result as ExecuteWinAppArgs;
            try
            {
                Process.Start(args.AppPath);
                writeEvent("Application successfully started: " + Environment.NewLine + Environment.NewLine + args.AppPath, false, false, 200);
            }
            catch (Exception ex)
            {
                writeEvent("Failed to start application: " + Environment.NewLine + Environment.NewLine + args.AppPath + Environment.NewLine + Environment.NewLine + ex.ToString(), true, false, 201);
            }
        }

        /// <summary>
        /// Starts an individual windows service.
        /// </summary>
        /// <param name="serviceName">The name of the service to start</param>
        /// <param name="timeoutMilliseconds">The number of milliseconds to wait before timeout</param>
        private static void startService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                writeEvent("Service successfully started: " + serviceName, false, false, 100);
            }
            catch (Exception ex)
            {
                if (ex.InnerException.Message == "An instance of the service is already running")
                    writeEvent("Failed to start service because it was already running: " + serviceName + Environment.NewLine + Environment.NewLine + ex.ToString(), false, true, 109);
                else
                    writeEvent("Failed to start service: " + serviceName + Environment.NewLine + Environment.NewLine + ex.ToString(), true, false, 101);
            }
        }

        /// <summary>
        /// Stops an individual windows service
        /// </summary>
        /// <param name="serviceName">The name of the service to stop</param>
        /// <param name="timeoutMilliseconds">The number of milliseconds to wait before timeout</param>
        private static void stopService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                writeEvent("Service successfully stopped: " + serviceName, false, false, 300);
            }
            catch (Exception ex)
            {
                writeEvent("Failed to stop service: " + serviceName + Environment.NewLine + Environment.NewLine + ex.ToString(), true, false, 301);
            }
        }

        /// <summary>
        /// Writes an entry in the windows system log
        /// </summary>
        /// <param name="message">The message to write</param>
        /// <param name="error">A bool indictating if the message is an error or not.</param>
        private static void writeEvent(string message, bool error, bool warning, int code)
        {
            string sSource = "WinServiceHelper";
            string sLog = "WinServiceHelper";

            try
            {
                if (!EventLog.SourceExists(sSource))
                    EventLog.CreateEventSource(sSource, sLog);

                if (error)
                    EventLog.WriteEntry(sSource, message, EventLogEntryType.Error, code);
                else if (warning)
                    EventLog.WriteEntry(sSource, message, EventLogEntryType.Warning, code);
                else
                    EventLog.WriteEntry(sSource, message, EventLogEntryType.Information, code);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to write entry in system log: " + Environment.NewLine + Environment.NewLine + ex.ToString());
            }
        }

        class ExecuteWinAppArgs
        {
            public int WaitTime { get; private set; }
            public string AppPath { get; private set; }

            public ExecuteWinAppArgs(string appPath, int waitTime)
            {
                WaitTime = waitTime;
                AppPath = appPath;
            }
        }
    }
}

# Windows 7 Service Manager #

Developed for use with a HTPC, this application was originally intended to solve hardware compatibility issues with Windows 7 Home Premium running [XBMC](http://xbmc.org/about/).  

Features:

- Displays a list of all services installed on the local machine, together with their status (Stopped, Running, etc.).
- Writes application events to the Windows log file.
- Automatically minimises the app to the notification area on startup.

Allows a user to:

- Select which services should be started/stopped on application start up/shut down.
- Set the seconds before a timeout occurs.
- Specify an application to launch X seconds after the application starts up.
- By adding this application to the Windows startup folder, selected services are started/stopped at Windows start and shutdown.
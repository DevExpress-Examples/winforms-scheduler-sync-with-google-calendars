# Synchronize Scheduler Appointments with Google Events

This sample illustrates how to sync Scheduler Appointments with Events from Google calendar.
To launch run the application you need follow steps 1 to 3b of [this article](https://developers.google.com/calendar/quickstart/dotnet) to  download the _"credentials.json"_ file and include it into your project.

You will also need to remove all Google assemblies referenced in the project, then go to **Project - Manage NuGet Packages...** and remove installed packages. To quickly re-install these packages and reference required libraries, drop a new **DXGoogleCalendarSync** component from the VS Toolbox onto the form and click _"Accept"_ in the appeared dialog. After all packages are successfully installed, you can remove this **DXGoogleCalendarSync** component.
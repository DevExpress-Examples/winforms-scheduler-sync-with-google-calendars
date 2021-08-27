<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/151589853/18.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830508)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Synchronize Scheduler Appointments with Google Events

This sample illustrates how to sync Scheduler Appointments with Events from Google calendar.
To launch run the application you need follow steps 1 to 3b of [this article](https://developers.google.com/calendar/quickstart/dotnet) to  download the _"credentials.json"_ file and include it into your project.

You will also need to remove all Google assemblies referenced in the project, then go to **Project - Manage NuGet Packages...** and remove installed packages. To quickly re-install these packages and reference required libraries, drop a new **DXGoogleCalendarSync** component from the VS Toolbox onto the form and click _"Accept"_ in the appeared dialog. After all packages are successfully installed, you can remove this **DXGoogleCalendarSync** component.

See the [Synchronization With Google Calendars](https://documentation.devexpress.com/WindowsForms/120605/Controls-and-Libraries/Scheduler/Export-and-Import/Synchronization-With-Google-Calendars) documentation article for instructions.

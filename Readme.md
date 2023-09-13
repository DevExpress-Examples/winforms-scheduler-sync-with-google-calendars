<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/151589853/18.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830508)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WinForms Scheduler - Synchronize appointments with Google events

This sample illustrates how to sync Scheduler appointments with events from your Google calendars.

Read the following [article](https://developers.google.com/calendar/quickstart/dotnet) and follow steps **1** to **3b** before you run the application (download the *credentials.json* file and include it into your project).

You should also remove all Google assemblies referenced in the project. Then go to **Project > Manage NuGet Packages...** and remove installed packages. To quickly re-install these packages and reference required libraries, drop the `DXGoogleCalendarSync` component from the Toolbox onto the form and click **Accept** in the appeared dialog. After all packages are successfully installed, you can remove the `DXGoogleCalendarSync` component.

Read the following help topic for additional information and instructions: [Synchronization With Google Calendars](https://documentation.devexpress.com/WindowsForms/120605/Controls-and-Libraries/Scheduler/Export-and-Import/Synchronization-With-Google-Calendars).

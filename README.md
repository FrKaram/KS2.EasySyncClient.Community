# EasySyncClient
A Dropbox-like for Alfresco ECM

This sofware extend Alfresco ECM with offline sync capabilities similar to what Dropbox / OneDrive / etc... do.

The software is made in C# and requires .NET Framework 4.5.2 to run on Windows.
It is the first working version. As such, the code is very rough and would need some rework but due to lack of time, I can't refactor it for now.

It has been fully tested on Windows and being validated for MacOs.

The software is using :
  - dotCMIS library -> https://chemistry.apache.org/dotnet/dotcmis.html
  - DynamicLogViewer -> http://tringi.trimcore.cz/Dynamic_Log_Viewer
  - SQLite -> https://www.sqlite.org/
  - Mono (for the MacOs version) -> http://www.mono-project.com/
  
#How does it work<br/>
1 - Download the latest release<br/>
2 - Run Easysyncclient.exe<br/>
3 - You will be prompted to enter your Alfresco's credential as well a your Alfresco's CMIS endpoint URL. You have 3 choices depending on your version of Alfresco :<br/>
	-> `http://<hostname>:<port>/alfresco/cmisatom`<br/>
	-> `http://<hostname>:<port>/alfresco/api/-default-/public/cmis/versions/1.0/atom`<br/>
	-> `http://<hostname>:<port>/alfresco/api/-default-/public/cmis/versions/1.1/atom`<br/>

4 - Select the site you want to synchronize<br/>
5 - Select the local folder on your workstation where to synchonize<br/>
6 - That's it ! You're syncing !

Update 2020-03-03  : Merging both community version and regular version into one source. Will be posted soon in the repo

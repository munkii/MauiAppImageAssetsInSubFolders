Repo to demonstrate the use case for MAUI bug, https://github.com/dotnet/maui/issues/22887

Repro Steps

1. Run sample in iOS
2. On first load you will only see one racing car and the caption for the button is showing that a subfolder is being used (sorry bloody terrible UX) 
3. Press the button and now the second racing car will appear. It has switched to no longer using the subfolder in the path despite the file only being in the subfolder. Note this is the "workaround"


This workaround is not needed in Android
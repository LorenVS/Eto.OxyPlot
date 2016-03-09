:set echo off

nuget pack ../Source/Eto.OxyPlot/Eto.OxyPlot.csproj -Prop Configuration=Release -Version 1.2.0-beta
nuget pack ../Source/Eto.OxyPlot.Wpf/Eto.OxyPlot.Wpf.csproj -Prop Configuration=Release -Version 1.2.0-beta
nuget pack ../Source/Eto.OxyPlot.Gtk/Eto.OxyPlot.Gtk.csproj -Prop Configuration=Release -Version 1.2.0-beta
nuget push *.nupkg
del *.nupkg

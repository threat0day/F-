
module MainWindow

open System 
open System.Windows 
open System.IO
open System.Windows.Markup

open System.Reflection

let mySr = new StreamReader(Assembly.Load("MainFsharp").GetManifestResourceStream("MainWindow.xaml"))   // XAML - MUST be Embedded Resource 
let mutable this : Window = XamlReader.Load(mySr.BaseStream):?> Window  // Load XAML

[<STAThread>] 
[<EntryPoint>]

do (new Application()).Run(this) |> ignore


 


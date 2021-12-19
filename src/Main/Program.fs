module Program

open System
open System.Windows.Forms

[<STAThread; EntryPoint>]
let main argv =
    Application.EnableVisualStyles()
    Application.SetCompatibleTextRenderingDefault false
    new MainForm.View() |> Application.Run
    0

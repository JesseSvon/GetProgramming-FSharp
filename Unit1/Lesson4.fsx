/// Rewrite original script (in comment) to tightly defined scopes.
/// Unit 1: Lesson 4

//=================================
//open System
//open System.Net
//open System.Windows.Forms

//let webClient = new WebClient()
//let fsharpOrg = webClient.DownloadString(Uri "http://fsharp.org")
//let browser =
//    new WebBrowser(ScriptErrorsSuppressed = true,
//        Dock = DockStyle.Fill,
//        DocumentText = fsharpOrg)

//let form = new Form(Text = "Hello from F#!")
//form.Controls.Add browser
//form.Show()
//=================================

open System
open System.Net
open System.Windows.Forms

let showBrowserFormOfUrl (urlString, formMessage) =
    let downloadStringFromUrl urlString =
        let webClient = new WebClient()
        let fsharpOrg = webClient.DownloadString(Uri urlString)
        fsharpOrg

    let browser =
        new WebBrowser(ScriptErrorsSuppressed = true,
            Dock = DockStyle.Fill,
            DocumentText = downloadStringFromUrl(urlString))

    let form = new Form(Text = formMessage)
    form.Controls.Add browser
    form.Show()

showBrowserFormOfUrl("http://fsharp.org", "Hello from F#!")
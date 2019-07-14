Option Explicit
Dim ie:Set ie=CreateObject("InternetExplorer.Application")
Sub ieWait: While ie.Busy Or 4<>ie.readyState: WScript.Sleep 100: Wend: End Sub
ie.Visible=True
ie.Navigate "http://google.com/"

ieWait
ie.document.getElementsByName("q")(0).value="Hello World"

WScript.Sleep 5000
ie.document.getElementsByName("f")(0).submit

WScript.Sleep 5000
ie.Quit

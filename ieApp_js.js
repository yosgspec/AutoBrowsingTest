var ie=new ActiveXObject("InternetExplorer.Application");
var ieWait=function(){while(ie.Busy || 4!=ie.readyState) WScript.Sleep(100);};
ie.Visible=true;
ie.Navigate("http://google.com/");

ieWait()
ie.document.getElementsByName("q")[0].value="Qiita";

WScript.Sleep(5000);
ie.document.getElementsByName("f")[0].submit();

WScript.Sleep(5000);
ie.Quit();

echo("+- \c2Loading LE Registration Management... \c6-+");
if(!isObject(NW_LEManager))
{
  new ScriptObject(NW_LEManager);
	echo("+- Created LE National Warfare Manager");
}
else
	error("ERROR: LE National Warfare Manager is already a script object, continuing with execution...");

package NW_LEManager
{
	function NW_LEManager::retryRegistration(%this)
	{
		canvas.popDialog(NW_RegERRGUI);
		canvas.pushDialog(NW_RegistrationGUI);
	}
};
activatePackage(NW_LEManager);

package NW_Registration
{
	function clientCmdNW_CheckRegCode()
	{
		%filePath = "config/client/National Warfare/Registration Code.txt";
		if(isFile(%filePath))
		{
			%file = new FileObject();
			%file.openForRead(%filePath);
			%code = %file.readLine();
			if(%code !$= "")
			{
				commandToServer('NW_UploadRegCode',%code);
				echo("\c2+- Limited Edition Registration Code found... uploading to server");
				%file.close();
				%file.delete();
			}
			else
			{
				echo("/-/ \c2ERROR: Could not locate National Warfare Client Limited Edition Code - popping up err gui");
				warn("/-/ Please input your Limited Edition Registration Code in the Client GUI.");
				clientCmdNW_regCodeErr();
			}
		}
		else
		{
			echo("/-/ \c2ERROR: Could not locate "@%filepath@" - creating new file");
			%newFile = new FileObject();
			%newFile.openForWrite(%filePath);
			clientcmdNW_checkRegCode();
			echo("/-/ File Creating Complete, checking for LE Client Reg. Code...");
			%newFile.close();
			%newFile.delete();
		}
	}
	
	function clientCmdNW_regCodeErr(%tog)
	{
		%tog = NW_RegErrGUI.isAwake();
		if(%tog == 1)
		{
			canvas.popDialog(NW_RegErrGUI);
			canvas.PushDialog(NW_RegistrationGUI);
		}
		else
		{
			canvas.pushDialog(NW_RegErrGUI);
		}
	}
};
activatePackage(NW_Registration);
echo("+- \c2Loading Done.");

$NWar::Client::PrefLimit = 50;


if(!isFile("./Limited.cs"))
{
  error("+- ERROR: Corrupted Add-on! \"Add-ons/Client_LENWarfare/Limited.cs\" file is missing!");
	warn("+- National Warfare Client will not work without \"Add-ons/Client_LENWarfare/Limited.cs\"");
	clientCmdNW_NotifyPlayer("Your National Warfare Limited Edition Client add-on will not work without the \"Limited.cs\" file, please contact the creator.","File Error Notification");
}

if(isObject(NW_HitmarkerGUI))
{
	NW_HitmarkerGUI.delete();
}
if(isObject(NW_Barracks))
{
	NW_Barracks.delete();
}
if(isObject(NW_Leaderboards))
{
	NW_Leaderboards.delete();
}
if(isObject(NW_Settings))
{
	NW_Settings.delete();
}
if(isObject(NW_NotifyPLGUI))
{
	NW_NotifyPLGUI.delete();
}
if(isObject(NW_RegERRGUI))
{
	NW_RegERRGUI.delete();
}
if(isObject(NW_RegistrationGUI))
{
	NW_RegistrationGUI.delete();
}
if(isObject(NW_LobbyGUI))
{
	NW_LobbyGUI.delete();
}
if(isObject(NW_Loadouts))
{
	NW_Loadouts.delete();
}
if(isObject(NW_Administration))
{
	NW_Administration.delete();
}
if(isObject(NW_Posts))
{
	NW_Posts.delete();
}

exec("./Limited.cs");
exec("./GUI_System.cs");
exec("./GUI/NW_HitmarkerGUI.gui");
exec("./GUI/NW_RegERRGUI.gui");
exec("./GUI/NW_RegistrationGUI.gui");
exec("./GUI/NW_LobbyGUI.gui");
exec("./GUI/NW_Loadouts.gui");
exec("./GUI/NW_NotifyPLGUI.gui");
exec("./GUI/NW_Administration.gui");
//exec("./GUI/NW_Posts.gui");
//exec("./GUI/NW_Settings.gui");
exec("./GUI/NW_Barracks.gui");
//exec("./GUI/NW_Leaderboards.gui");
exec("config/client/National Warfare/prefs.cs");
playGUI.add(NW_HitmarkerGUI);

//functions for GUI
function getTime()
{
	return getWord(1,getDateTime());
}

function getDate()
{
	return getWord(0,getDateTime());
}

function NW_toggleGUI(%obj)
{
	if(isObject(%obj))
	{
		%tog = %obj.isAwake();
		if(%tog == 1)
		{
			canvas.popDialog(%obj);
		}
		else
		{
			canvas.pushDialog(%obj);
		}
	}
	else
		error("Cannot find " SPC %obj);
}

function clientCmdNW_DisplayHitmarker()
{
	canvas.pushDialog(NW_HitmarkerGUI);
	schedule(500,0,clientCmdNW_HitmarkerDis);
}

function NW_HitmarkerDis()
{
	canvas.popDialog(NW_HitmarkerGUI);
}

//clientCmdCheckPlayerID();

package NW_ClientCommands
{
	function clientCmdNW_ReceiveStats(%stats,%check)
	{
		if(%stats $= "admin")
		{
			if(%check == 1)
			{
				$NWar::Client::isAdmin = 1;
			}
			else
			{
				$NWar::Client::isAdmin = 0;
			}
		}	
		if(getWord(%stats,0) $= "stats")
		{
			$NWar::Client::Level = getWord(%stats,1);
			$NWar::Client::Rank = getWord(%stats,2);
			$NWar::Client::EXP = getWord(%stats,3);
			$NWar::Client::NeededEXP = getWord(%stats,4);
			$NWar::Client::Name = $Pref::Player::NetName;
			$NWar::Client::BLID = getWord(%stats,5);
			$NWar::Client::PLID = getWord(%stats,6);
			//$NWar::Client::Wins = getWord(%stats,7);
			//$NWar::Client::Losses = getWord(%stats,8);
			//$NWar::Client::Kills = getWord(%stats,9);
			//$NWar::Client::Deaths = getWord(%stats,10);
		}
		echo(%stats SPC %check);
	}
	
	function clientCmdNW_SendStats(%stats,%check)
	{
	}
	
	function clientCmdNW_RequestStats(%stats,%check)
	{
	}
	
	function clientCmdNW_CheckPlayerID()
	{
		if($NWar::Client::PLID $= "")
		{
			%filePath = "config/client/National Warfare/Player ID.txt";
			if(isFile(%filePath))
			{
				%file = new FileObject();
				%file.openForRead(%filePath);
				%plid = %file.readLine();
				if(%plid !$= "")
				{
					if($ServerInfo::Name $= "Lt. Jamergaman's National Warfare BETA" || $ServerInfo::Name $= "National Warfare BETA")
					{
						commandToServer('NW_UploadPLID',%plid);
						echo("+- \c2Player ID Found... uploading to server");
					}
					else
					{
						error("ERROR: Client is not in server, cannot upload PLID to server.");
					}
				}
				else
				{
					error("ERROR: Could not locate NWarfare Client Player ID - creating new Player ID");
					%newFile = new FileObject();
					%newFile.openForWrite(%filePath);
					%playerID = getRandomString(3)@"-"@getRandomString(5)@"-"@getRandom(100,999);
					%newFile.writeLine(%playerID);
					echo("+- New Player ID created.");
					echo("+-\c2 Your new Player ID is "@%playerID);
					$NWar::Client::PLID = %playerID;
					//clientCmdNW_SavePref("NWar::Client::PLID",%playerID);
					%newFile.close();
					%newFile.delete();
				}
				%file.close();
				%file.delete();
			}
			else
			{
				echo("\c2ERROR: Could not locate "@%filepath@" - creating new file");
				%newFile2 = new FileObject();
				%newFile2.openForWrite(%filePath);
				clientCmdNW_checkPlayerID();
				echo("+- \c2File Creating Complete, checking for Player ID...");
				%newFile2.close();
				%newFile2.delete();
			}
		}
	}
	
	function NW_CreateProfile(%name,%blid,%plid,%rcode,%arg,%con,%path)
	{
		%name = $Pref::Server::NetName;
		%blid = $NWar::Client::BLID;
		%plid = $NWar::Client::PLID;
		%path = "config/client/National Warfare/Profile/"@%name@".txt";
		%file = new FileObject();
		echo("+- \c2Starting profile creation.");
		%file.openForWrite(%path);
		echo("Path "@%path);
		%file.writeLine("Name: "@%name);
		%file.writeLine("BLID: "@%blid);
		%file.writeLine("PLID: "@%plid);
		if(isFile("Add-ons/Client_LENWarfare"))
		{
			if(isFile("config/client/National Warfare/Registration Code.txt"))
			{
				if(isFile("Add-ons/Client_LENWarfare/Limited.cs"))
				{
					%rcFile = new FileObject();
					%rcFile.openForRead("config/client/National Warfare/Registration Code.txt");
					%rcode = %rcFile.readLine();
					%rcFile.close();
					%rcFile.delete();
					echo("+- \c3Client has Limited Edition package.");
					%file.writeLine("Registration Code: "@%rcode);
				}
			}
		}
		%file.writeLine("-------------");
		warn("Ending basic profile creation...");
		warn("Starting multiplayer profile creation...");
		%file.writeLine("Level: "@clientCmdNW_ReceiveStats("Level",1));
		%file.writeLine("XP: "@clientCmdNW_ReceiveStats("XP",1));
		warn("Writing multiplayer stats...");
		%file.writeLine("-----END-----");
		%file.close();
		echo("\c2Closing file...");
		%file.delete();
		echo("\c2Deleting temp file...");
		echo("\c3PROFILE CREATION COMPLETE | CLIENT CAN NOW PLAY GAME");
	}
	
	//function clientCmdNW_SavePref(%pref,%val)
	//{
		//%pref = "$"@%pref;
		//%filepath = "config/client/National Warfare/prefs.cs";
		//new FileObject(NW_Pref);
		//NW_Pref.openForAppend(%filepath);
		//NW_Pref.writeLine(%pref SPC "=" SPC %val@";");
		//echo("+- Saving pref "@%pref@"...");
		//echo("+- Closing file");
		//NW_Pref.close();
		//echo("+- Deleting file");
		//NW_Pref.delete();
		//exec(%filepath);
	//}
	
	//function clientCmdNW_ClearPrefsList()
	//{
		//%filepath = "config/client/National Warfare/prefs.cs";
		//%file = new FileObject();
		//%file.open
	
	function clientCmdNW_NotifyPlayer(%msg,%title)
	{
		NW_NotifyPLGUI_Message.setValue(NW_NotifyPLGUI_Message.text @ %msg);
		NW_NotifyPLGUI_Title.setValue(NW_NotifyPLGUI_Title.text @ %title);
		canvas.pushDialog(NW_NotifyPLGUI);
		echo("+- Notifying player with \""@%msg@"\" : \""@%title@"\"");
	}
};
activatePackage(NW_ClientCommands);

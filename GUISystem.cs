package NW_OtherGUIStuff
{
  function Canvas::pushDialog(%this,%gui,%num)
	{
		parent::pushDialog(%this,%gui,%name);
		if(%gui $= "NW_LobbyGUI")
		{
			if($ServerInfo::Name $= "Lt. Jamergaman's National Warfare BETA" || %gui $= "National Warfare BETA" || %gui $= "Lt. Jamergaman's National Warfare" || %gui $= "National Warfare")
			{
				echo("DODODODO");	
			}
			else
			{
				canvas.popDialog(%gui);
				clientCmdNW_NotifyPlayer("You cannot open any National Warfare GUI when not in the National Warfare server.","GUI Error");
			}
		}
	}
	
	function Canvas::popDialog(%this,%gui,%num)
	{
		parent::popDialog(%this,%gui,%name);
		//if(%gui $= "NW_SelectedLoadout")
		//{
			//echo("EUEUEHUEHEUHEUHEUEHUEHEUHEUHEUH");
		//}
	}
};
activatePackage(NW_OtherGUIStuff);

package NW_LoadoutsGUISystem
{
	function NW_Loadouts::openWeaponMenu(%this,%val)
	{
		NW_WeaponMenu.visible = 1;
		if(%val == 1)
		{
			NW_Pistols.visible = 0;
			NW_Melee.visible = 0;
			NW_Extras.visible = 0;
			NW_ARs.visible = 1;
			NW_SMGs.visible = 1;
			NW_LMGs.visible = 1;
			NW_Shotguns.visible = 1;
			NW_SniperRifles.visible = 1;
		}
		if(%val == 2)
		{
			NW_ARs.visible = 0;
			NW_SMGs.visible = 0;
			NW_LMGs.visible = 0;
			NW_Shotguns.visible = 0;
			NW_SniperRifles.visible = 0;
			NW_Extras.visible = 0;
			NW_Pisotls.visible = 1;
			NW_Melee.visible = 1;
		}
		if(%val == 3)
		{
			NW_ARs.visible = 0;
			NW_SMGs.visible = 0;
			NW_LMGs.visible = 0;
			NW_Shotguns.visible = 0;
			NW_SniperRifles.visible = 0;
			NW_Pisotls.visible = 0;
			NW_Melee.visible = 0;
			NW_Extras.visible = 1;
		}
	}
	
	function NW_Loadouts::closeWeaponMenu(%this)
	{
		NW_WeaponsSelection.visible = 0;
		NW_WeaponMenu.visible = 0;
	}
	
	//blah?
	function NW_Weapons_List::chooseItem(%this,%item) //blah?
	{
		NW_Loadouts.closeWeaponMenu();
		//commandToServer('NW_chooseItem',%item);
	}
	
	function NW_WeaponMenu::openList(%this,%list)
	{
		NW_WeaponSelection.visible = 1;
		if(%list $= "ARs")
		{
			for(%i = 0; %i <= getWordCount($NWar::Weapons::ARs); %i++)
			{
				NW_Weapons_List.addRow(%i,getWord($NWar::Weapons::ARs,%i),0);
			}
		}
		if(%list $= "SMGs")
		{
			for(%i = 0; %i <= getWordCount($NWar::Weapons::SMGs); %i++)
			{
				NW_Weapons_List.addRow(%i,getWord($NWar::Weapons::SMGs,%i),0);
			}
		}
		if(%list $= "LMGs")
		{
			for(%i = 0; %i <= getWordCount($NWar::Weapons::LMGs); %i++)
			{
				NW_Weapons_List.addRow(%i,getWord($NWar::Weapons::LMGs,%i),0);
			}
		}
		if(%list $= "Shotguns")
		{
			for(%i = 0; %i <= getWordCount($NWar::Weapons::Shotguns); %i++)
			{
				NW_Weapons_List.addRow(%i,getWord($NWar::Weapons::Shotguns,%i),0);
			}
		}
		if(%list $= "Sniper Rifles")
		{
			for(%i = 0; %i <= getWordCount($NWar::Weapons::SniperRifles); %i++)
			{
				NW_Weapons_List.addRow(%i,getWord($NWar::Weapons::SniperRifles,%i),0);
			}
		}
		if(%list $= "Pistols")
		{
			for(%i = 0; %i <= getWordCount($NWar::Weapons::Pistols); %i++)
			{
				NW_Weapons_List.addRow(%i,getWord($NWar::Weapons::Pistols,%i),0);
			}
		}
		if(%list $= "Melee")
		{
			for(%i = 0; %i <= getWordCount($NWar::Weapons::Melee); %i++)
			{
				NW_Weapons_List.addRow(%i,getWord($NWar::Weapons::Melee,%i),0);
			}
		}
		if(%list $= "Extras")
		{
			for(%i = 0; %i <= getWordCount($NWar::Weapons::Extras); %i++)
			{
				NW_Weapons_List.addRow(%i,getWord($NWar::Weapons::Extras,%i),0);
			}
		}
	}

	function NW_Loadouts::SaveLoadout(%this,%loadout)
	{
		echo("+- Saving Loadout...");
		%primary = NW_SelectedLoadout_PWeapon.item;
		%secondary = NW_SelectedLoadout_SWeapon.item;
		//%extra = NW_SelectedLoadout_Extra.item;
		//%character = NW_SelectedLoadout_Character.item;
		%filepath = "config/client/National Warfare/Loadouts.txt";
		%file = new FileObject();
		%file.openForWrite(%filepath);
		%file.writeLine(%primary SPC %secondary SPC "NONE" SPC "NONE");
		%file.close();
		%file.delete();
		echo("+- Loadout Saved - Closing Loadout Overlay");
		NW_SaveLoadoutBtn.command = "";
		NW_SelectedLoadout.setVisible(0);
		%loadout.color = $NWar::Loadouts::ogColor;
		$NWar::GUI::SelectedLoadout = "";
	}
	
	//wip
	function NW_Loadouts::openLoadout(%this,%loadout)
	{
		$NWar::Loadouts::ogColor = "185 185 185 205";
		%filepath = "config/client/National Warfare/Loadouts.txt";
		if(isFile(%filepath))
		{
			new FileObject(NW_ReadLoadout);
			NW_ReadLoadout.openForRead(%filepath);
			for(%i = 0;%i < 7;%i++)
			{
				NW_ReadLoadout.readLine();
			}
			if(NW_ReadLoadout.readLine() $= "//Multiplayer Loadouts")
			{
				%items = NW_ReadLoadout.readLine();
				%primary = getWord(%items,0);
				%secondary = getWord(%items,1);
				%extra = getWord(%items,2);
				%character = getWord(%items,3);
				%loadout = "NW_L"@%loadout;
				if(%loadout !$= $NWar::GUI::SelectedLoadout)
				{
					if($NWar::GUI::SelectedLoadout !$= "")
					{
						$NWar::GUI::SelectedLoadout.color = $NWar::Loadouts::ogColor;
						NW_Loadouts.saveLoadout($NWar::GUI::SelectedLoadout);
						$NWar::GUI::SelectedLoadout = "";
					}
					$NWar::GUI::SelectedLoadout = %loadout;
					NW_SelectedLoadout_PWeapon.bitmap = "add-ons/Client_LENWarfare/UI/Weapons/icon_"@%primary@"";
					NW_SelectedLoadout_PWeapon.item = %primary;
					NW_SelectedLoadout_SWeapon.bitmap = "add-ons/Client_LENWarfare/UI/Weapons/icon_"@%secondary@"";
					NW_SelectedLoadout_SWeapon.item = %secondary;
					//NW_SelectedLoadout_Extra.bitmap = "add-ons/Client_LENWarfare/UI/Weapons/icon_"@%extra@"";
					//NW_SelectedLoadout_Extra.item = %extra;
					//NW_SelectedLoadout_Character.bitmap = "add-ons/Client_LENWarfare/UI/"@%character@"";
					//NW_SelectedLoadout_Character.item = %character;
					NW_SelectedLoadout.setVisible(1);
					%loadout.color = "155 135 15 205";
					NW_SaveLoadoutBtn.command = "NW_Loadouts.saveLoadout("@%loadout@");";
				}
				else
				{
					clientCmdNW_NotifyPlayer("You already have selected that loadout to edit.","Oops! Let's not do that one again!");
				}
			}
			else
			{
				error("ERROR: Invalid file");
				clientCmdNW_NotifyPlayer("Cannot get the info for your loadouts because there is an error with your profile.","Oops! Something isn't right...");
			}
			NW_ReadLoadout.close();
			NW_ReadLoadout.delete();
		}
		else
		{
			commandToServer('NW_RequestStats',"Loadouts");
		}
	}
	
	function NW_Loadouts::SelectLoadout(%this,%client,%loadout)
	{
	}
};
activatePackage(NW_LoadoutsGUISystem);

package NW_LobbyGUISystem
{	
	function NW_LobbyGUI::openAdministration(%this)
	{
		if($ServerInfo::Name $= "Lt. Jamergaman's National Warfare BETA" || $ServerInfo::Name $= "National Warfare BETA")
		{
			commandToServer('NW_RequestStats',"admin",1);
			if($NWar::Client::isAdmin == 1)
			{
				canvas.popDialog(NW_LobbyGUI);
				canvas.pushDialog(NW_Administration);
			}
			else
			{
				error("ERROR: Cannot open National Warfare Administration GUI, client is not admin.");
			}
		}
		else
			error("ERROR: Client is not in National Warfare Server, cannot open GUI.");
	}
	
	function NW_LobbyGUI::openBarracks(%this)
	{
		commandToServer('NW_RequestStats',"stats",0);
		//commandToServer('NW_RequestStats',"WLKD");
		canvas.pushDialog(NW_Barracks);
		schedule(1000,0,NW_Barracks.setValues(%this));
		clientCmdNW_NotifyPlayer("Cannot access your career statistics \"Wins : Losses : Kills : Deaths\", sorry about that. :(","Warning Notification");
	}
	
	function NW_LobbyGUI::setLobbyTimer(%this,%time)
	{
		NW_LobbyTimer.setValue("<just:center><font:arial black:18><color:EEAA33>Intermission: "@%time);
	}
	
	function clientCmdNW_SetLobbyTimer(%time)
	{
		NW_LobbyGUI.setLobbyTimer(%time);
	}
};
activatePackage(NW_LobbyGUISystem);

package NW_BarracksGUISystem
{
	function NW_Barracks::setValues(%this)
	{
		//NW_Stats_Wins.setValue($NWar::Client::Wins);
		//NW_Stats_Losses.setValue($NWar::Client::Losses);
		//NW_Stats_Kills.setValue($NWar::Client::Kills);
		//NW_Stats_Deaths.setValue($NWar::Client::Deaths);
		NW_Stats_Level.setValue($NWar::Client::Level);
		NW_Stats_Rank.setValue($NWar::Client::Rank);
		NW_Stats_EXP.setValue($NWar::Client::EXP@"\c6/"@$NWar::Client::NeededEXP);
		NW_Stats_Name.setValue($NWar::Client::Name);
		NW_Stats_BLID.setValue($NWar::Client::BLID);
		NW_Stats_PLID.setValue($NWar::Client::PLID);
	}
};
activatePackage(NW_BarracksGUISystem);

function setGUIVisibility(%this,%check)
{
	if(isObject(%this))
	{
		if(%check == 1 || %check == 0)
		{
			%this.setVisible(%check);
		}
		else
		{
			error("+- You must input 0 or 1, no other characters are allowed.");
		}
	}
	else
	{
		error("+- "@%this@" was not found.");
	}
}

package NW_AdminButton
{
	function adminGui::onWake(%this)
	{
		parent::onWake(%this);
		//%admingui = %this;
		//%adminguiobject = %admingui.getObject(0);
		if(isObject(NWAdmin_AdminGuiButton))
		{
			return;
		}
	
		%button = new GuiBitmapButtonCtrl(NWAdmin_AdminGuiButton) {
			profile = "BlockButtonProfile";
			horizSizing = "left";
			vertSizing = "bottom";
			position = "214 175";
			extent = "98 38";
			minExtent = "8 2";
			enabled = "1";
			visible = "1";
			clipToParent = "1";
			command = "NW_LobbyGUI.openAdministration();";
			text = "NW Admin";
			groupNum = "-1";
			buttonType = "PushButton";
			bitmap = "base/client/ui/button1";
			lockAspectRatio = "0";
			alignLeft = "0";
			alignTop = "0";
			overflowImage = "0";
			mKeepCached = "0";
			mColor = "235 175 25 255";
		};
	
		adminGui.getObject(0).add(%button);
	}
};
activatePackage(NW_AdminButton);

package NW_EscapeMenu
{
	function escapeMenu::onWake(%this)
	{
		//%escMenu = %this;
		//%escMenuObj = %escMenu.getObject(0);
		if(!isObject(EM_NWButton))
		{
			//%escMenuObj.extent = "221 466";
			%plList = EM_PlayerList;
			%miniGames = EM_MiniGames;
			%adminMenu = EM_AdminMenu;
			%plList.position = "7 113";
			%miniGames.position = "7 153";
			%adminMenu.position = "7 193";
		
			%btn = new GuiBitmapButtonCtrl(EM_NWButton) 
			{
				profile = "BlockButtonProfile";
				horizSizing = "center";
				vertSizing = "bottom";
				position = "7 73";
				extent = "207 36";
				minExtent = "8 2";
				visible = "1";
				command = "canvas.pushDialog(NW_LobbyGUI);";
				text = "National Warfare Lobby";
				groupNum = "-1";
				buttonType = "PushButton";
				bitmap = "base/client/ui/button1";
				lockAspectRatio = "0";
				alignLeft = "0";
				overflowImage = "0";
				mKeepCached = "0";
				mColor = "235 175 25 255";
				wrap = "0";
			};
		
			escapeMenu.getObject(0).add(%btn);
		}
	}
};
activatePackage(NW_EscapeMenu);

package Shop
{
  function servercmdShop(%client,%msg1,%msg2)
	{
		if(%msg1 $= "")
		{
			messageClient(%client,'',"\c6Say /shop [category] to view the weapons in that category. Example: /shop pistols");
			messageClient(%client,'',"\c6--\c0Pistols");
			messageClient(%client,'',"\c6--\c1Assault Rifles");
			messageClient(%client,'',"\c6--\c2Sub-Machine Guns");
			messageClient(%client,'',"\c6--\c3Light-Machine Guns");
			messageClient(%client,'',"\c6--\c4Shotguns");
			messageClient(%client,'',"\c6--\c5Sniper Rifles");
			messageClient(%client,'',"\c6--<color:CC3300>Explosives");
			messageClient(%client,'',"\c6--<color:66FFCC>Melee");
			messageClient(%client,'',"\c6--<color:AA33DD>Special");
			messageClient(%client,'',"\c6--<color:CCFFCC>Armor");
			messageClient(%client,'',"\c6--<color:CCFF00>Player-Types");
			messageClient(%client,'',"\c6Pageup to view all categories.");
		}
		
		if(%msg1 $= "Pistols")
		{
			messageClient(%client,'',"    \c4--\c0Pistols Category\c4--");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>1000 \c3Pistol Akimbo");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>10000 \c3Machine Pistol");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>12000 \c3Snubnose - \c0Required Level: 4");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>12500 \c3Retro Pistol - \c0Required Level: 6");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>15000 \c3Magnum - \c0Required Level: 10");
		}
		
		if(%msg1 $= "Assault" && %msg2 $= "Rifles")
		{
			messageClient(%client,'',"    \c4--\c1Assault Rifles Category\c4--");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>12000 \c3Assault Rifle - \c0Required Level: 6");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>20500 \c3Bullpup - \c0Required Level: 12");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>25000 \c3Battle Rifle - \c0Required Level: 15");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>30000 \c3Sniper Carbine - \c0Required Level: 20");
		}

		if(%msg1 $= "Sub-Machine" && %msg2 $= "Guns")
		{
			messageClient(%client,'',"    \c4--\c2Sub-Machine Guns Category\c4--");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>8000 \c3SMG Silenced - \c0Required Level: 5");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>15000 \c3SMG Micro - \c0Required Level: 8");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>40000 \c3SMG Akimbo - \c0Required Level: 20");
		}
		
		if(%msg1 $= "Light-Machine" && %msg2 $= "Guns")
		{
			messageClient(%client,'',"    \c4--\c3Light-Machine Guns Category\c4--");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>5000 \c3Blocky MG - \c0Required Level: 2");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>25000 \c3Drum MG - \c0Required Level: 10");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>500000 \c3Vulcan - \c0Required Level: 50");
		}
		
		if(%msg1 $= "Shotguns")
		{
			messageClient(%client,'',"    \c4--\c4Shotguns Category\c4--");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>12000 \c3Ballistic Shotgun - \c0Required Level 8");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>15000 \c3Auto-Shotgun - \c0Required Level: 12");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>18000 \c3APG - \c0Required Level: 15");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>21000 \c3Tactical Shotgun - \c0Required Level: 18");
		}
		
		if(%msg1 $= "Sniper" && %msg2 $= "Rifles")
		{
			messageClient(%client,'',"    \c4--\c5Sniper Rifles Category\c4--");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>1200 \c3Sport Rifle");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>4050 \c3Hunting Rifle - \c0Required Level: 3");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>12000 \c3Military Sniper - \c0Required Level: 12");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>20000 \c3Magnified Sniper - \c0Required Level: 15");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>35000 \c3Bolt-Action Rifle - \c0Required Level: 20");
		}
		
		if(%msg1 $= "Explosives")
		{
			messageClient(%client,'',"    \c4--<color:CC3300>Explosives Category\c4--");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>800 \c3Frag Grenade - \c0Required Level: 3");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>3500 \c3HE Grenade - \c0Required Level: 5");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>5000 \c3Impact Grenade - \c0Required Level: 8");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>15000 \c3Impact Launcher - \c0Required Level: 15");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>45000 \c3Strike Launcher - \c0Required Level: 25");
		}
		
		if(%msg1 $= "Melee")
		{
			messageClient(%client,'',"    \c4--<color:66FFCC>Melee Category\c4--");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>2500 \c3Combat Knife");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>5000 \c3Butterfly Knife - \c0Required Level: 5");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>11500 \c3Black Knife (throwing knife) - \c0Required Level: 10");
		}
		
		if(%msg1 $= "Special")
		{
			messageClient(%client,'',"    \c4--<color:AA33DD>Special Category\c4--");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>5000 \c3EXP Boost 2x");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>20000 \c3EXP Boost 5x");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>45000 \c3EXP Boost 10x");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>75000 \c3EXP Boost 20x");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>200000 \c3EXP Boost 50x");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>??? \c3Inventory Slot Upgrade \c0(WIP)");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>??? \c3Mobile Spawn \c0(WIP)");
		}
		
		if(%msg1 $= "Armor")
		{
			messageClient(%client,'',"    \c4--<color:CCFFCC>Armor category\c4--");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>2000 \c3Weak Armor \c6(25)");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>5000 \c3Light Armor \c6(50)");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>8000 \c3Heavy Armor \c6(100)");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>12500 \c3Very-Heavy Armor \c6(150)");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>20000 \c3Max Armor \c6(200)");
		}
		
		if(%msg1 $= "Player-Types")
		{
			messageClient(%client,'',"    \c4--<color:CCFF00>Player-Types category\c4--");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>0 \c3Default Player \c6(100 Health, Normal Movement & Jumps Normal)");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>15000 \c3Upgraded Player \c6(150 Health, Fast Movement & Jumps High)");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>12500 \c3Heavy Player \c6(200 Health, Slow Movement & Doesn't Jump High)");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>12500 \c3Light Player \c6(80 Health, Very Fast Movement & Jumps High)");
			messageClient(%client,'',"\c3[\c0J\c3]<color:FFFFFF>12500 \c3Fuel-Jet Player \c6(100 Health, Normal Movement & Jumps Normal + Can Jet)");
		}
	}
	
	function serverCmdBuy(%client,%image,%image2,%image3)
	{
		//pistols
		if(%image $= "Pistol" && %image2 $= "Akimbo")
		{
			if(%client.Jamolas >= 1000)
			{
				buyThing(%client,AkimboPistolItem);
				%client.Jamolas -= 1000;
				messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>1000");
				addToBank(1000);
			}
			else
			{
				messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $1000 and you have $"@%client.getJamolas()@".");
			}
		}
		if(%image $= "Machine" && %image2 $= "Pistol")
		{
			if(%client.Jamolas >= 10000)
			{
				buyThing(%client,MachstilItem);
				%client.Jamolas -= 10000;
				messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>10000");
				addToBank(10000);
			}
			else
			{
				messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $10000 and you have $"@%client.getJamolas()@".");
			}
		}
		if(%image $= "Snubnose")
		{
			if(%client.level >= 4)
			{
				if(%client.Jamolas >= 12000)
				{
					buyThing(%client,SnubnoseItem);
					%client.Jamolas -= 12000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>12000");
					addToBank(12000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image@", it costs $12000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 4 or higher to buy this weapon.");
			}
		}
		if(%image $= "Retro" && %image2 $= "Pistol")
		{
			if(%client.level >= 6)
			{
				if(%client.Jamolas >= 12500)
				{
					buyThing(%client,RetroPistolItem);
					%client.Jamolas -= 12500;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>12500");
					addToBank(12500);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $12500 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 6 or higher to buy this weapon.");
			}
		}
		if(%image $= "Magnum")
		{
			if(%client.level >= 10)
			{
				if(%client.Jamolas >= 15000)
				{
					buyThing(%client,MagnumItem);
					%client.Jamolas -= 15000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>15000");
					addToBank(15000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image@", it costs $15000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 10 or higher to buy this weapon.");
			}
		}
		//assault rifles
		if(%image $= "Assault" && %image2 $= "Rifle")
		{
			if(%client.level >= 6)
			{
				if(%client.Jamolas >= 12000)
				{
					buyThing(%client,TAssaultRifleItem);
					%client.Jamolas -= 12000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>12000");
					addToBank(12000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $12000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 6 or higher to buy this weapon.");
			}
		}
		if(%image $= "Bullpup")
		{
			if(%client.level >= 12)
			{
				if(%client.Jamolas >= 20500)
				{
					buyThing(%client,BullpupItem);
					%client.Jamolas -= 20500;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>20500");
					addToBank(20500);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image@", it costs $20500 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 12 or higher to buy this weapon.");
			}
		}
		if(%image $= "Battle" && %image2 $= "Rifle")
		{
			if(%client.level >= 15)
			{
				if(%client.Jamolas >= 25000)
				{
					buyThing(%client,BattleRifleItem);
					%client.Jamolas -= 25000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>25000");
					addToBank(25000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $25000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 15 or higher to buy this weapon.");
			}
		}
		if(%image $= "Sniper" && %image2 $= "Carbine")
		{
			if(%client.level >= 20)
			{
				if(%client.Jamolas >= 30000)
				{
					buyThing(%client,SniperCarbineItem);
					%client.Jamolas -= 30000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>30000");
					addToBank(30000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $30000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 20 or higher to buy this weapon.");
			}
		}
		//sub-machine guns
		if(%image $= "SMG" && %image2 $= "Silenced")
		{
			if(%client.level >= 5)
			{
				if(%client.Jamolas >= 8000)
				{
					buyThing(%client,SilencedSMGItem);
					%client.Jamolas -= 8000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>8000");
					addToBank(8000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image@", it costs $8000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 5 or higher to buy this weapon.");
			}
		}
		if(%image $= "SMG" && %image2 $= "Micro")
		{
			if(%client.level >= 8)
			{
				if(%client.Jamolas >= 15000)
				{
					buyThing(%client,MicroSMGItem);
					%client.Jamolas -= 15000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>15000");
					addToBank(15000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $15000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 8 or higher to buy this weapon.");
			}
		}
		if(%image $= "SMG" && %image2 $= "Akimbo")
		{
			if(%client.level >= 20)
			{
				if(%client.Jamolas >= 40000)
				{
					buyThing(%client,DualSMGsItem);
					%client.Jamolas -= 40000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>40000");
					addToBank(40000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image@", it costs $40000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 20 or higher to buy this weapon.");
			}
		}

		//light-machine guns
		if(%image $= "Blocky" && %image2 $= "MG")
		{
			if(%client.level >= 2)
			{
				if(%client.Jamolas >= 5000)
				{
					buyThing(%client,BlockyLMGItem);
					%client.Jamolas -= 5000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>5000");
					addToBank(5000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $5000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 2 or higher to buy this weapon.");
			}
		}
		if(%image $= "Drum" && %image2 $= "MG")
		{
			if(%client.level >= 12)
			{
				if(%client.Jamolas >= 25000)
				{
					buyThing(%client,ClassicLMGItem);
					%client.Jamolas -= 25000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>25000");
					addToBank(25000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $25000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 12 or higher to buy this weapon.");
			}
		}
		if(%image $= "Vulcan")
		{
			if(%client.level >= 50)
			{
				if(%client.Jamolas >= 500000)
				{
					buyThing(%client,VulcanItem);
					%client.Jamolas -= 500000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>500000");
					addToBank(500000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image@", it costs $500000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 50 or higher to buy this weapon.");
			}
		}
		//shotguns
		if(%image $= "Ballistic" && %image2 $= "Shotgun")
		{
			if(%client.level >= 8)
			{
				if(%client.Jamolas >= 12000)
				{
					buyThing(%client,ballisticShotgunItem);
					%client.Jamolas -= 12000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>12000");
					addToBank(12000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image@", it costs $12000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 8 or higher to buy this weapon.");
			}
		}
		if(%image $= "Auto-Shotgun")
		{
			if(%client.level >= 12)
			{
				if(%client.Jamolas >= 15000)
				{
					buyThing(%client,automaticshotgunItem);
					%client.Jamolas -= 15000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>15000");
					addToBank(15000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image@", it costs $15000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 12 or higher to buy this weapon.");
			}
		}
		if(%image $= "APG")
		{
			if(%client.level >= 15)
			{
				if(%client.Jamolas >= 18000)
				{
					buyThing(%client,APGItem);
					%client.Jamolas -= 18000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>18000");
					addToBank(18000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image@", it costs $18000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 15 or higher to buy this weapon.");
			}
		}
		if(%image $= "Tactical" && %image2 $= "Shotgun")
		{
			if(%client.level >= 18)
			{
				if(%client.Jamolas >= 21000)
				{
					buyThing(%client,tacticalShotgunItem);
					%client.Jamolas -= 21000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>21000");
					addToBank(21000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $21000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 18 or higher to buy this weapon.");
			}
		}
		//sniper rifles
		if(%image $= "Sport" && %image2 $= "Rifle")
		{
			if(%client.Jamolas >= 1200)
			{
				buyThing(%client,SportRifleItem);
				%client.Jamolas -= 1200;
				messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>1200");
				addToBank(1200);
			}
			else
			{
				messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $1200 and you have $"@%client.getJamolas()@".");
			}
		}
		if(%image $= "Hunting" && %image2 $= "Rifle")
		{
			if(%client.level >= 3)
			{
				if(%client.Jamolas >= 4050)
				{
					buyThing(%client,HuntingRifleItem);
					%client.Jamolas -= 4050;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>4050");
					addToBank(4050);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $4050 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 3 or higher to buy this weapon.");
			}
		}
		if(%image $= "Military" && %image2 $= "Sniper")
		{
			if(%client.level >= 12)
			{
				if(%client.Jamolas >= 12000)
				{
					buyThing(%client,MilitarySniperItem);
					%client.Jamolas -= 12000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>12000");
					addToBank(12000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $12000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 12 or higher to buy this weapon.");
			}
		}
		if(%image $= "Magnified" && %image2 $= "Sniper")
		{
			if(%client.level >= 15)
			{
				if(%client.Jamolas >= 20000)
				{
					buyThing(%client,MagnifiedSniperRifleItem);
					%client.Jamolas -= 20000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>20000");
					addToBank(20000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $20000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 15 or higher to buy this weapon.");
			}
		}
		if(%image $= "Bolt-Action" && %image2 $= "Rifle")
		{
			if(%client.level >= 20)
			{
				if(%client.Jamolas >= 35000)
				{
					buyThing(%client,RetroRifleItem);
					%client.Jamolas -= 35000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>35000");
					addToBank(35000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $35000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 20 or higher to buy this weapon.");
			}
		}
		//explosives
		if(%image $= "Frag" && %image2 $= "Grenade")
		{
			if(%client.level >= 3)
			{
				if(%client.Jamolas >= 800)
				{
					buyThing(%client,fragGrenadeItem);
					%client.Jamolas -= 800;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>800");
					addToBank(800);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $800 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 3 or higher to buy this weapon.");
			}
		}
		if(%image $= "HE" && %image2 $= "Grenade")
		{
			if(%client.level >= 5)
			{
				if(%client.Jamolas >= 3500)
				{
					buyThing(%client,hegrenadeItem);
					%client.Jamolas -= 3500;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>3500");
					addToBank(3500);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $3500 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 5 or higher to buy this weapon.");
			}
		}
		if(%image $= "Impact" && %image2 $= "Grenade")
		{
			if(%client.level >= 8)
			{
				if(%client.Jamolas >= 5000)
				{
					buyThing(%client,ImpactGrenadeItem);
					%client.Jamolas -= 5000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>5000");
					addToBank(5000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $5000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 8 or higher to buy this weapon.");
			}
		}
		if(%image $= "Impact" && %image2 $= "Launcher")
		{
			if(%client.level >= 15)
			{
				if(%client.Jamolas >= 15000)
				{
					buyThing(%client,ImpactLauncherItem);
					%client.Jamolas -= 15000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>15000");
					addToBank(15000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $15000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 15 or higher to buy this weapon.");
			}
		}
		if(%image $= "Strike" && %image2 $= "Launcher")
		{
			if(%client.level >= 25)
			{
				if(%client.Jamolas >= 45000)
				{
					buyThing(%client,StrikeLauncherItem);
					%client.Jamolas -= 45000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>45000");
					addToBank(45000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $45000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 25 or higher to buy this weapon.");
			}
		}
		//melee
		if(%image $= "Combat" && %image2 $= "Knife")
		{
			if(%client.Jamolas >= 2500)
			{
				buyThing(%client,CombatKnifeItem);
				%client.Jamolas -= 2500;
				messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>2500");
				addToBank(2500);
			}
			else
			{
				messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $2500 and you have $"@%client.getJamolas()@".");
			}
		}
		if(%image $= "Butterfly" && %image2 $= "Knife")
		{
			if(%client.level >= 5)
			{
				if(%client.Jamolas >= 5000)
				{
					buyThing(%client,butterflyknifeItem);
					%client.Jamolas -= 5000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>5000");
					addToBank(5000);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $5000 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 5 or higher to buy this weapon.");
			}
		}
		if(%image $= "Black" && %image2 $= "Knife")
		{
			if(%client.level >= 10)
			{
				if(%client.Jamolas >= 11500)
				{
					buyThing(%client,blackknifeItem);
					%client.Jamolas -= 11500;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>11500");
					addToBank(11500);
				}
				else
				{
					messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $11500 and you have $"@%client.getJamolas()@".");
				}
			}
			else
			{
				messageClient(%client,'',"Your level must be 10 or higher to buy this weapon.");
			}
		}
		//special
		if(%image $= "EXP" && %image2 $= "Boost" && %image3 $= "2x")
		{
			if(%client.Jamolas >= 5000)
			{
				messageClient(%client,'',"\c3You have bought a\c2 2x EXP Boost \c3that lasts for\c2 2 minutes\c3.");
				messageClient(%client,'',"\c0WARNING\c6: Your \c3EXP Boost \c6does not save when you exit the server!");
				%client.EXPBoost("2x");
				%client.Jamolas -= 5000;
				messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>5000");
				addToBank(5000);
			}
			else
			{
				messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2 SPC %image3@", it costs $5000 and you have $"@%client.getJamolas()@".");
			}
		}
		if(%image $= "EXP" && %image2 $= "Boost" && %image3 $= "5x")
		{
			if(%client.Jamolas >= 20000)
			{
				messageClient(%client,'',"\c3You have bought a\c2 5x EXP Boost \c3that lasts for\c2 5 minutes\c3.");
				messageClient(%client,'',"\c0WARNING\c6: Your \c3EXP Boost \c6does not save when you exit the server!");
				%client.EXPBoost("5x");
				%client.Jamolas -= 20000;
				messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>20000");
				addToBank(20000);
			}
			else
			{
				messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2 SPC %image3@", it costs $20000 and you have $"@%client.getJamolas()@".");
			}
		}
		if(%image $= "EXP" && %image2 $= "Boost" && %image3 $= "10x")
		{
			if(%client.Jamolas >= 45000)
			{
				messageClient(%client,'',"\c3You have bought a\c2 10x EXP Boost \c3that lasts for\c2 10 minutes\c3.");
				messageClient(%client,'',"\c0WARNING\c6: Your \c3EXP Boost \c6does not save when you exit the server!");
				%client.EXPBoost("10x");
				%client.Jamolas -= 45000;
				messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>45000");
				addToBank(45000);
			}
			else
			{
				messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2 SPC %image3@", it costs $45000 and you have $"@%client.getJamolas()@".");
			}
		}
		if(%image $= "EXP" && %image2 $= "Boost" && %image3 $= "20x")
		{
			if(%client.Jamolas >= 75000)
			{
				messageClient(%client,'',"\c3You have bought a\c2 20x EXP Boost \c3that lasts for\c2 20 minutes\c3.");
				messageClient(%client,'',"\c0WARNING\c6: Your \c3EXP Boost \c6does not save when you exit the server!");
				%client.EXPBoost("20x");
				%client.Jamolas -= 75000;
				messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>75000");
				addToBank(75000);
			}
			else
			{
				messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2 SPC %image3@", it costs $75000 and you have $"@%client.getJamolas()@".");
			}
		}
		if(%image $= "EXP" && %image2 $= "Boost" && %image3 $= "50x")
		{
			if(%client.Jamolas >= 200000)
			{
				messageClient(%client,'',"\c3You have bought a\c2 50x EXP Boost \c3that lasts for\c2 20 minutes\c3.");
				messageClient(%client,'',"\c0WARNING\c6: Your \c3EXP Boost \c6does not save when you exit the server!");
				%client.EXPBoost("20x");
				%client.Jamolas -= 200000;
				messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>200000");
				addToBank(200000);
			}
			else
			{
				messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2 SPC %image3@", it costs $200000 and you have $"@%client.getJamolas()@".");
			}
		}
		//armor
		if(%image $= "Weak" && %image2 $= "Armor")
		{
			if(%client.Jamolas >= 2000)
			{
				messageClient(%client,'',"\c3You have bought \c0Weak Armor (25)\c3.");
				messageClient(%client,'',"\c0WARNING\c6: Your \c3Armor \c6does not save when you exit the server or get killed!");
				%client.Jamolas -= 2000;
				%client.player.armor = 25;
				messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>2000");
				addToBank(2000);
			}
			else
			{
				messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $2000 and you have $"@%client.getJamolas()@".");
			}
		}
		if(%image $= "Light" && %image2 $= "Armor")
		{
			if(%client.Jamolas >= 5000)
			{
				messageClient(%client,'',"\c3You have bought <color:FF3300>Light Armor (50)\c3.");
				messageClient(%client,'',"\c0WARNING\c6: Your \c3Armor \c6does not save when you exit the server or get killed!");
				%client.Jamolas -= 5000;
				%client.player.armor = 50;
				messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>5000");
				addToBank(5000);
			}
			else
			{
				messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $5000 and you have $"@%client.getJamolas()@".");
			}
		}
		if(%image $= "Heavy" && %image2 $= "Armor")
		{
			if(%client.Jamolas >= 8000)
			{
				messageClient(%client,'',"\c3You have bought \c3Heavy Armor (100).");
				messageClient(%client,'',"\c0WARNING\c6: Your \c3Armor \c6does not save when you exit the server or get killed!");
				%client.Jamolas -= 8000;
				%client.player.armor = 100;
				messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>8000");
				addToBank(8000);
			}
			else
			{
				messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $8000 and you have $"@%client.getJamolas()@".");
			}
		}
		if(%image $= "Very-Heavy" && %image2 $= "Armor")
		{
			if(%client.Jamolas >= 12500)
			{
				messageClient(%client,'',"\c3You have bought \c2Very-Heavy Armor (150)\c3.");
				messageClient(%client,'',"\c0WARNING\c6: Your \c3Armor \c6does not save when you exit the server or get killed!");
				%client.Jamolas -= 12500;
				%client.player.armor = 150;
				messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>12500");
				addToBank(12500);
			}
			else
			{
				messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $12500 and you have $"@%client.getJamolas()@".");
			}
		}
		if(%image $= "Max" && %image2 $= "Armor")
		{
			if(%client.Jamolas >= 20000)
			{
				messageClient(%client,'',"\c3You have bought \c4Max Armor (200)\c3.");
				messageClient(%client,'',"\c0WARNING\c6: Your \c3Armor \c6does not save when you exit the server or get killed!");
				%client.Jamolas -= 20000;
				%client.player.armor = 200;
				messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>20000");
				addToBank(20000);
			}
			else
			{
				messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $20000 and you have $"@%client.getJamolas()@".");
			}
		}
		//player-types
		if(%image $= "Default" && %image2 $= "Player")
		{
			if(%client.player.getDatablock().uiName $= "No-Jet Player")
			{
				messageClient(%client,'',"\c6Seriously, stop being a dumbass you haven't bought any other player-type.");
			}
			else
			{
				%client.player.changeDatablock(PlayerNoJet);
				%client.savePlayerData();
				messageClient(%client,'',"\c6Your player is now the \c4Default Player-Type\c6.");
			}
		}
		if(%image $= "Upgraded" && %image2 $= "Player")
		{
			if(%client.Jamolas >= 15000)
			{
				if(%client.player.getDatablock().uiname $= "No-Jet Player Upgraded")
				{
					messageClient(%client,'',"\c6Seriously, stop being a dumbass you already bought this player-type.");
				}
				else
				{
					%client.player.changeDatablock(PlayerNoJetUpgraded);
					%client.savePlayerData();
					messageClient(%client,'',"\c6Your player is now the \c4Upgraded Player-Type\c6.");
					%client.Jamolas -= 15000;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>15000");
					addToBank(15000);
				}
			}
			else
			{
				messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $15000 and you have $"@%client.getJamolas()@".");
			}
		}
		if(%image $= "Heavy" && %image2 $= "Player")
		{
			if(%client.Jamolas >= 12500)
			{
				if(%client.player.getDatablock().uiname $= "No-Jet Player Heavy")
				{
					messageClient(%client,'',"\c6Seriously, stop being a dumbass you already bought this player-type.");
				}
				else
				{
					%client.player.changeDatablock(PlayerNoJetHeavy);
					%client.savePlayerData();
					messageClient(%client,'',"\c6Your player is now the \c4Heavy Player-Type\c6.");
					%client.Jamolas -= 12500;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>12500");
					addToBank(12500);
				}
			}
			else
			{
				messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $12500 and you have $"@%client.getJamolas()@".");
			}
		}
		if(%image $= "Light" && %image2 $= "Player")
		{
			if(%client.Jamolas >= 12500)
			{
				if(%client.player.getDatablock().uiname $= "No-Jet Player Light")
				{
					messageClient(%client,'',"\c6Seriously, stop being a dumbass you already bought this player-type.");
				}
				else
				{
					%client.player.changeDatablock(PlayerNoJetLight);
					%client.savePlayerData();
					messageClient(%client,'',"\c6Your player is now the \c4Light Player-Type\c6.");
					%client.Jamolas -= 12500;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>12500");
					addToBank(12500);
				}
			}
			else
			{
				messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $12500 and you have $"@%client.getJamolas()@".");
			}
		}
		if(%image $= "Fuel-Jet" && %image2 $= "Player")
		{
			if(%client.Jamolas >= 12500)
			{
				if(%client.player.getDatablock().uiname $= "Fuel-Jet Player")
				{
					messageClient(%client,'',"\c6Seriously, stop being a dumbass you already bought this player-type.");
				}
				else
				{
					%client.player.changeDatablock(PlayerFuelJet);
					%client.savePlayerData();
					messageClient(%client,'',"\c6Your player is now the \c4Fuel-Jet Player-Type\c6.");
					%client.Jamolas -= 12500;
					messageClient(%client,'',"\c0-\c3[\c0J\c3]<color:FFFFFF>12500");
					addToBank(12500);
				}
			}
			else
			{
				messageClient(%client,'',"You do not have enough Jamolas to buy a "@%image SPC %image2@", it costs $12500 and you have $"@%client.getJamolas()@".");
			}
		}
	}

	function buyThing(%client,%thing)
	{
		%slot = -1;
		%item = %thing.getID();
		for(%x = 0; %x <= 4; %x++)
		{
			if(%client.player.tool[%x] == 0)
				%slot = %x;

			if(%client.player.tool[%x] == %item || %client.inventorySlot[%x] == %item)
			{
				MessageClient(%client,'',"You already have a "@%thing.uiName@". If it's not in your Tool Slots, check your inventory. (say /inventory)");
				return;
			}
		}
		if(%slot == -1)
		{
			MessageClient(%client,'',"Your Tool Slots are full. Try removing a weapon from one of your Tool Slots.");
			return;
		}
		%client.player.tool[%slot] = %item;
		%client.addItemToInventory(%thing);
		MessageClient(%client,'MsgItemPickup','',%slot,%item);
	}
};

package Special_Things
{
	function GameConnection::EXPBoost(%this,%Boost)
	{
		if(%Boost $= "2x" && %Boost !$= "5x" && %Boost !$= "10x" && %Boost !$= "20x" && %Boost !$= "50x")
		{
			%this.EXPBoost = "2x";
			schedule(120*1000,0,deactivateEXPBoost,%this);
		}
		if(%Boost $= "5x" && %Boost !$= "2x" && %Boost !$= "10x" && %Boost !$= "20x")
		{
			%this.EXPBoost = "5x";
			schedule(300*1000,0,deactivateEXPBoost,%this);
		}
		if(%Boost $= "10x" && %Boost !$= "2x" && %Boost !$= "5x" && %Boost !$= "20x" && %Boost !$= "50x")
		{
			%this.EXPBoost = "10x";
			schedule(600*1000,0,deactivateEXPBoost,%this);
		}
		if(%Boost $= "20x" && %Boost !$= "2x" && %Boost !$= "5x" && %Boost !$= "10x" && %Boost !$= "50x")
		{
			%this.EXPBoost = "20x";
			schedule(1200000,0,deactivateEXPBoost,%this);
		}
		if(%Boost $= "50x" & %Boost !$= "2x" && %Boost !$= "5x" && %Boost !$= "10x" && %Boost !$= "20x")
		{
			%this.EXPBoost = "50x";
			schedule(3000000,0,deactivateEXPBoost,%this);
		}
	}
	
	function deactivateEXPBoost(%client)
	{
		%client.EXPBoost = "None";
		messageClient(%client,'',"\c3Your EXP Boost as ended.");
	}
};

using UnityEngine;  //Needed for most Unity Enginer manipulations: Vectors, GameObjects, Audio, etc.
using System.IO;    //For data read/write methods
using System;    //For data read/write methods
using System.Collections.Generic;   //Working with Lists and Collections
using System.Linq;   //More advanced manipulation of lists/collections
using System.Threading;
using Harmony;
using ReikaKalseki;
using ReikaKalseki.FortressCore;

namespace ReikaKalseki.IconFixer
{
  public class IconFixerMod : FortressCraftMod
  {
    public const string MOD_KEY = "ReikaKalseki.IconFixer";
    public const string CUBE_KEY = "ReikaKalseki.IconFixer_Key";

    public override ModRegistrationData Register()
    {
        ModRegistrationData registrationData = new ModRegistrationData();
        /*
        var harmony = HarmonyInstance.Create("ReikaKalseki.IconFixer");
        HarmonyInstance.DEBUG = true;
        FileLog.Log("Ran mod register, started harmony (harmony log)");
        FUtil.log("Ran mod register, started harmony");
        try {
			harmony.PatchAll();
        }
        catch (Exception e) {
			FileLog.Log("Caught exception when running patcher!");
			FileLog.Log(e.Message);
			FileLog.Log(e.StackTrace);
			FileLog.Log(e.ToString());
        }
        */
       
       setIcon("HighOctaneFuel");
       setIcon("GlowStick");
       setIcon("BasicMissile");
       setIcon("ClusterMissile");
       setIcon("PowerCoil");
       setIcon("CargoLiftImproved", "ImprovedCargoLift");
       setIcon("CargoLiftBulk", "BulkCargoLift");
       setIcon("AntimatterDrillMotor", "AntimatterMotor");
        
        return registrationData;
    }
    
    private static void setIcon(string item, string icon = null) {
    	if (icon == null)
    		icon = item;
       ItemEntry.mEntriesByKey[item].Sprite = "ReikaKalseki."+icon;
       FUtil.log("Setting icon for "+item+" to "+ItemEntry.mEntriesByKey[item].Sprite);
    }
    
    private static void setModel(string item, SpawnableObjectEnum mdl) {
       ItemEntry.mEntriesByKey[item].Object = mdl;
       FUtil.log("Setting world model for "+item+" to # "+((int)mdl)+" = "+mdl.ToString());
    }

  }
}

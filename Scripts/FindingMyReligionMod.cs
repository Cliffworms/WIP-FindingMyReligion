// Project:         FindingMyReligion for Daggerfall Unity (http://www.dfworkshop.net)
// Copyright:       Copyright (C) 2022 Cliffworms
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Author:          Cliffworms/Magicono43 (statue activation)

using System;
using UnityEngine;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Game.Guilds;
using DaggerfallWorkshop.Game.Serialization;
using DaggerfallWorkshop.Game.Utility;
using DaggerfallWorkshop.Game.Utility.ModSupport;
using DaggerfallWorkshop.Utility.AssetInjection;


namespace FindingMyReligion
{
    public class FindingMyReligionMod : MonoBehaviour
    {
        static Mod mod;

        [Invoke(StateManager.StateTypes.Start, 0)]
        public static void Init(InitParams initParams)
        {
            mod = initParams.Mod;
            var go = new GameObject(mod.Title);
            go.AddComponent<FindingMyReligionMod>();
        }

        void Awake()
        {
            Debug.Log("Begin mod init: FindingMyReligion");
			
			// Magicono43's Messy Hacky Code For Statue Clicking Text
			PlayerActivate.RegisterCustomActivation(mod, 1230, 10, MaraActivation);
			PlayerActivate.RegisterCustomActivation(mod, 1230, 11, MaraActivation);

            PlayerActivate.RegisterCustomActivation(mod, 1230, 3, ArkayActivation);
            PlayerActivate.RegisterCustomActivation(mod, 1230, 4, ArkayActivation);

            PlayerActivate.RegisterCustomActivation(mod, 1230, 18, ZenitharActivation);
            PlayerActivate.RegisterCustomActivation(mod, 1230, 19, ZenitharActivation);
            PlayerActivate.RegisterCustomActivation(mod, 1230, 20, ZenitharActivation);
            PlayerActivate.RegisterCustomActivation(mod, 1230, 21, ZenitharActivation);
            PlayerActivate.RegisterCustomActivation(mod, 1230, 22, ZenitharActivation);

            PlayerActivate.RegisterCustomActivation(mod, 1230, 5, StendarrActivation);

            PlayerActivate.RegisterCustomActivation(mod, 1230, 13, KynarethActivation);
            PlayerActivate.RegisterCustomActivation(mod, 1230, 14, KynarethActivation);
            PlayerActivate.RegisterCustomActivation(mod, 1230, 15, KynarethActivation);
            PlayerActivate.RegisterCustomActivation(mod, 1230, 16, KynarethActivation);
            PlayerActivate.RegisterCustomActivation(mod, 1230, 17, KynarethActivation);

            PlayerActivate.RegisterCustomActivation(mod, 1230, 6, JulianosActivation);
            PlayerActivate.RegisterCustomActivation(mod, 1230, 7, JulianosActivation);
            PlayerActivate.RegisterCustomActivation(mod, 1230, 8, JulianosActivation);

            PlayerActivate.RegisterCustomActivation(mod, 1230, 9, DibellaActivation);

            PlayerActivate.RegisterCustomActivation(mod, 1230, 2, AkatoshActivation);

            PlayerActivate.RegisterCustomActivation(mod, 1230, 12, TalosActivation);

			// Magicono43's Messy Hacky Code For Statue Clicking Text

            InitMod();
            mod.IsReady = true;
            Debug.Log("Finished mod init: FindingMyReligion");
        }

        public static void InitMod()
        {
            if (!GuildManager.RegisterCustomGuild(FactionFile.GuildGroups.HolyOrder, typeof(TempleFMR)))
                Debug.Log("Unable to register FindingMyReligion Temple guild class override.");
        }
		
		#region Magicono43's Messy Hacky Code For Statue Clicking Text
		
		private static void MaraActivation(RaycastHit hit)
        {
            DaggerfallUI.AddHUDText("You see a statue of Mara, the Mother Goddess", 5f);
            DaggerfallUI.AddHUDText("", 5f);
            DaggerfallUI.AddHUDText("A plaque reads :", 5f);            
            DaggerfallUI.AddHUDText("'Live soberly and peacefully.", 5f);
            DaggerfallUI.AddHUDText("Honor your parents, and preserve the peace", 5f);
            DaggerfallUI.AddHUDText("and security of home and family.'", 5f);
        }

        private static void ArkayActivation(RaycastHit hit)
        {
            DaggerfallUI.AddHUDText("You see a statue of Arkay, Birth and Death God", 5f);
            DaggerfallUI.AddHUDText("", 5f);
            DaggerfallUI.AddHUDText("A plaque reads :", 5f);
            DaggerfallUI.AddHUDText("'Honor the earth, its creatures, and the spirits, living and dead.", 5f);
            DaggerfallUI.AddHUDText("Guard and tend the bounties of the mortal world, and do not", 5f);
            DaggerfallUI.AddHUDText("profane the spirits of the dead.'", 5f);
        }

        private static void ZenitharActivation(RaycastHit hit)
        {
            DaggerfallUI.AddHUDText("You see a statue of Zenithar, God of Commerce", 5f);
            DaggerfallUI.AddHUDText("", 5f);
            DaggerfallUI.AddHUDText("A plaque reads :", 5f);
            DaggerfallUI.AddHUDText("'Work hard, and you will be rewarded.", 5f);
            DaggerfallUI.AddHUDText("Spend wisely, and you will be comfortable.", 5f);
            DaggerfallUI.AddHUDText("Never steal, or you will be punished.'", 5f);
        }

        private static void StendarrActivation(RaycastHit hit)
        {
            DaggerfallUI.AddHUDText("You see a statue of Stendarr, God of Mercy", 5f);
            DaggerfallUI.AddHUDText("", 5f);
            DaggerfallUI.AddHUDText("A plaque reads :", 5f);            
            DaggerfallUI.AddHUDText("'Be kind and generous to the people of Tamriel.", 5f);
            DaggerfallUI.AddHUDText("Protect the weak, heal the sick, and give to the needy.'", 5f);
        }

        private static void KynarethActivation(RaycastHit hit)
        {
            DaggerfallUI.AddHUDText("You see a statue of Kynareth, Goddess of Air", 5f);
            DaggerfallUI.AddHUDText("", 5f);
            DaggerfallUI.AddHUDText("A plaque reads :", 5f);                 
            DaggerfallUI.AddHUDText("'Use Nature's gifts wisely.", 5f);
            DaggerfallUI.AddHUDText("Respect her power, and fear her fury.'", 5f);
        }

        private static void JulianosActivation(RaycastHit hit)
        {
            DaggerfallUI.AddHUDText("You see a statue of Julianos, God of Logic", 5f);
            DaggerfallUI.AddHUDText("", 5f);
            DaggerfallUI.AddHUDText("A plaque reads :", 5f);                
            DaggerfallUI.AddHUDText("'Know the truth. Observe the law.", 5f);
            DaggerfallUI.AddHUDText("When in doubt, seek wisdom from the wise.'", 5f);
        }

        private static void DibellaActivation(RaycastHit hit)
        {
            DaggerfallUI.AddHUDText("You see a statue of Dibella, Goddess of Beauty", 5f);
            DaggerfallUI.AddHUDText("", 5f);
            DaggerfallUI.AddHUDText("A plaque reads :", 5f);                  
            DaggerfallUI.AddHUDText("'Open your heart to the noble secrets of art and love.", 5f);
            DaggerfallUI.AddHUDText("Treasure the gifts of friendship.", 5f);
            DaggerfallUI.AddHUDText("Seek joy and inspiration in the mysteries of love.'", 5f);
        }

        private static void AkatoshActivation(RaycastHit hit)
        {
            DaggerfallUI.AddHUDText("You see a statue of Akatosh, God of Time", 5f);
            DaggerfallUI.AddHUDText("", 5f);
            DaggerfallUI.AddHUDText("A plaque reads :", 5f);                  
            DaggerfallUI.AddHUDText("'Serve and obey your Emperor. Study the Covenants.", 5f);
            DaggerfallUI.AddHUDText("Worship the Eight, do your duty, and heed the", 5f);
            DaggerfallUI.AddHUDText("commands of the saints and priests.'", 5f);
        }

        private static void TalosActivation(RaycastHit hit)
        {
            DaggerfallUI.AddHUDText("You see a statue of Talos, hero-god of Mankind", 5f);
            DaggerfallUI.AddHUDText("", 5f);
            DaggerfallUI.AddHUDText("A plaque reads :", 5f);                  
            DaggerfallUI.AddHUDText("'Be strong for war..", 5f);
            DaggerfallUI.AddHUDText("Be bold against enemies and evil,", 5f);
            DaggerfallUI.AddHUDText("and defend the people of Tamriel.'", 5f);
        }

		#endregion
		
    }
}
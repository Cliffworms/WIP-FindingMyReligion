// Project:         FindingMyReligion for Daggerfall Unity (http://www.dfworkshop.net)
// Copyright:       Copyright (C) 2022 Cliffworms
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Author:          Cliffworms

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
        private const string variantAnticlere = "_anticlere";
        private const string variantHebu = "_hebu";



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

            SaveLoadManager.OnLoad += SaveLoadManager_OnLoad;
            StartGameBehaviour.OnStartGame += StartGameBehaviour_OnStartGame;

            InitMod();
            mod.IsReady = true;
            Debug.Log("Finished mod init: FindingMyReligion");
        }

        public void StartGameBehaviour_OnStartGame(object sender, EventArgs e)
        {
            InitVariants();
        }

        void SaveLoadManager_OnLoad(SaveData_v1 saveData)
        {
            InitVariants();
        }

        void InitVariants()
        {
            // Hebu (161) in region 22
            if (WorldDataVariants.GetBuildingVariant(22, 161, "TEMPAAH0.RMB", 13) == null)
            {
                int locHebu = WorldDataReplacement.MakeLocationKey(22, 161);
                WorldDataVariants.SetBuildingVariant("TEMPAAH0.RMB", 13, variantHebu, locHebu);
            }  
            
            // Anticlere (600) in region 21
            if (WorldDataVariants.GetBuildingVariant(21, 600, "TEMPAAC0.RMB", 0) == null)
            {
                int locAnticlere = WorldDataReplacement.MakeLocationKey(21, 600);
                WorldDataVariants.SetBuildingVariant("TEMPAAC0.RMB", 21, variantAnticlere, locAnticlere);
            }
        }

        public static void InitMod()
        {
            if (!GuildManager.RegisterCustomGuild(FactionFile.GuildGroups.HolyOrder, typeof(TempleFMR)))
                Debug.Log("Unable to register FindingMyReligion Temple guild class override.");
        }
    }
}
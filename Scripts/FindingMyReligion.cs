// Project:         FindingMyReligion mod for Daggerfall Unity (http://www.dfworkshop.net)
// Copyright:       Copyright (C) 2022 Cliffworms & Hazelnut
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Author:          Hazelnut

namespace DaggerfallWorkshop.Game.Guilds
{
    public class TempleFMR : Temple
    {
        public TempleFMR(Divines deity) : base(deity)
        {
        }

        public override bool CanRest()
        {
            return IsMember();
        }
    }
if (!GuildManager.RegisterCustomGuild(FactionFile.GuildGroups.HolyOrder, typeof(TempleFMR)))
    Debug.Log("Unable to register Temple guild class override.");    
}



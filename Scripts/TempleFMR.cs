// Project:         FindingMyReligion for Daggerfall Unity (http://www.dfworkshop.net)
// Copyright:       Copyright (C) 2022 Cliffworms
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Author:          Cliffworms

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
}

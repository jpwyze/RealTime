﻿// <copyright file="CitizenState.cs" company="dymanoid">
// Copyright (c) dymanoid. All rights reserved.
// </copyright>

namespace RealTime.AI
{
    internal enum CitizenState
    {
        Unknown,
        LeftCity,
        MovingHome,
        AtHome,
        MovingToTarget,
        AtSchoolOrWork,
        AtLunch,
        Shopping,
        AtLeisureArea,
        Visiting,
        Evacuating
    }
}

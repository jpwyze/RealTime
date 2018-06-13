﻿// <copyright file="Configuration.cs" company="dymanoid">
// Copyright (c) dymanoid. All rights reserved.
// </copyright>

namespace RealTime.Config
{
    /// <summary>
    /// The mod's configuration.
    /// </summary>
    internal sealed class Configuration
    {
        /// <summary>
        /// Gets or sets the current mod configuration.
        /// </summary>
        public static Configuration Current { get; set; } = new Configuration();

        /// <summary>
        /// Gets or sets a value indicating whether the weekends are enabled. Cims don't go to work on weekends.
        /// </summary>
        public bool IsWeekendEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether Cims should go out at lunch for food.
        /// </summary>
        public bool IsLunchTimeEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets the percentage of the Cims that will go out for lunch.
        /// Valid values are 0..100.
        /// </summary>
        public int LunchQuota { get; set; } = 80;

        /// <summary>
        /// Gets or sets a value indicating whether Cims will search locally for buildings to visit,
        /// rather than heading to a random building.
        /// </summary>
        public bool AllowLocalBuildingSearch { get; set; } = true;

        /// <summary>
        /// Gets or sets the percentage of the population that will search locally for buildings.
        /// Valid values are 0..100.
        /// </summary>
        public int LocalBuildingSearchQuota { get; set; } = 60;

        /// <summary>
        /// Gets or sets the percentage of the Cims that will go to and leave their work or school
        /// on time (no overtime!).
        /// Valid values are 0..100.
        /// </summary>
        public int OnTimeQuota { get; set; } = 80;

        /// <summary>
        /// Gets or sets the maximum overtime for the Cims. They come to work earlier or stay at work longer for at most this
        /// amout of hours. This applies only for those Cims that are not on time, see <see cref="OnTimeQuota"/>.
        /// The young Cims (school and university) don't do overtime.
        /// </summary>
        public float MaxOvertime { get; set; } = 2f;

        /// <summary>
        /// Gets or sets the the school start daytime hour. The young Cims must be at school or university.
        /// </summary>
        public float SchoolBegin { get; set; } = 8f;

        /// <summary>
        /// Gets or sets the daytime hour when the young Cims return from school or university.
        /// </summary>
        public float SchoolEnd { get; set; } = 14f;

        /// <summary>
        /// Gets or sets the work start daytime hour. The adult Cims must be at work.
        /// </summary>
        public float WorkBegin { get; set; } = 9f;

        /// <summary>
        /// Gets or sets the daytime hour when the adult Cims return from work.
        /// </summary>
        public float WorkEnd { get; set; } = 18f;

        /// <summary>
        /// Gets or sets the daytime hour when the Cims go out for lunch.
        /// </summary>
        public float LunchBegin { get; set; } = 12f;

        /// <summary>
        /// Gets or sets the lunch time duration.
        /// </summary>
        public float LunchEnd { get; set; } = 13f;
    }
}

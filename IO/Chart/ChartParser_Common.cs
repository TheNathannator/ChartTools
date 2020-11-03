﻿using System;
using System.Collections.Generic;

namespace ChartTools.IO.Chart
{
    internal static partial class ChartParser
    {
        /// <summary>
        /// Part names of <see cref="Instruments"/> without the difficulty
        /// </summary>
        private static readonly Dictionary<Instruments, string> partNames = new Dictionary<Instruments, string>()
        {
            { Instruments.Drums, "Drums" },
            { Instruments.GHLGuitar, "GHLGuitar" },
            { Instruments.GHLBass, "GHLBass" },
            { Instruments.LeadGuitar, "Single" },
            { Instruments.RhythmGuitar, "DoubleRhythm" },
            { Instruments.CoopGuitar, "DoubleGuitar" },
            { Instruments.Bass, "DoubleBass" },
            { Instruments.Keys, "Keyboard" }
        };

        /// <summary>
        /// Gets the full part name for a track.
        /// </summary>
        /// <exception cref="ArgumentException"/>
        private static string GetFullPartName(Instruments instrument, Difficulty difficulty) => Enum.IsDefined(typeof(Difficulty), difficulty)
                ? $"{difficulty}{partNames[instrument]}"
                : throw new ArgumentException("Difficulty is undefined.");

        /// <summary>
        /// Gets the exception to throw when a <see cref="Instruments"/> value is not defined.
        /// </summary>
        /// <returns>Instance of <see cref="ArgumentException"/> to throw</returns>
        private static ArgumentException GetUndefinedInstrumentException() => new ArgumentException("Instrument is not defined.");
    }
}

﻿using System;
using System.Threading.Tasks;

using MicaForEveryone.Models;

namespace MicaForEveryone.Interfaces
{
    public interface IRuleService : IDisposable
    {
        void StartService();
        void StopService();
        Task MatchAndApplyRuleToAllWindowsAsync();
        void MatchAndApplyRuleToWindow(TargetWindow target);

        TitlebarColorMode SystemTitlebarColorMode { get; set; }
    }
}

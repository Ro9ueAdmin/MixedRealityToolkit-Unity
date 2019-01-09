﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.MixedReality.Toolkit.Core.Services;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Tests.Services
{
    internal class TestExtensionService2 : BaseExtensionService, ITestExtensionService2
    {
        public TestExtensionService2(string name, uint priority, ScriptableObject profil) : base(name, priority, profil) { }

        public bool IsEnabled { get; private set; }

        public override void Enable()
        {
            IsEnabled = true;
        }

        public override void Disable()
        {
            IsEnabled = false;
        }

        public override void Destroy()
        {
        }
    }
}
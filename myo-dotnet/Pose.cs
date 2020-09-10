// Copyright 2015 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thalmic.Myo
{
    public enum Pose
    {
        Rest = libmyo.PoseType.Rest,
        Fist = libmyo.PoseType.Fist,
        WaveIn = libmyo.PoseType.WaveIn,
        WaveOut = libmyo.PoseType.WaveOut,
        FingersSpread = libmyo.PoseType.FingersSpread,
        DoubleTap = libmyo.PoseType.DoubleTap,
        Unknown = libmyo.PoseType.Unknown
    }
}

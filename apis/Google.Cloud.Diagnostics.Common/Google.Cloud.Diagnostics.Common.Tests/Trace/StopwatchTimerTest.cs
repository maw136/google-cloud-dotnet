﻿// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Threading;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class StopwatchTimerTest
    {
        [Fact]
        public void GetElapsedMilliseconds()
        {
            StopwatchTimer timer = StopwatchTimer.Create();
            timer.Start();

            long first = timer.GetElapsedMilliseconds();
            Thread.Sleep(10);
            long second = timer.GetElapsedMilliseconds();
            Thread.Sleep(20);
            long third = timer.GetElapsedMilliseconds();

            Assert.True(second > first);
            Assert.True(third > second);
        }

        [Fact]
        public void GetElapsedMilliseconds_NoStart()
        {
            StopwatchTimer timer = StopwatchTimer.Create();

            Assert.Equal(0, timer.GetElapsedMilliseconds());
            Thread.Sleep(10);
            Assert.Equal(0, timer.GetElapsedMilliseconds());
        }
    }
}
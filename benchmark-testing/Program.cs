﻿using benchmark_testing;
using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run<Md5VsSha256>();
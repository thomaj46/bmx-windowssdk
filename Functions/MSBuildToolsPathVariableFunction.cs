﻿using Inedo.BuildMaster.Extensibility;
using Inedo.BuildMaster.Extensibility.VariableFunctions;

namespace Inedo.BuildMasterExtensions.WindowsSdk.Functions
{
    [VariableFunctionProperties(
        "MSBuildToolsPath",
        "Placeholder. Will be implemented in a future version.",
        Category = "Server",
        Scope = VariableFunctionScope.Server)]
    public sealed class MSBuildToolsPathVariableFunction : ScalarVariableFunctionBase
    {
        protected override object EvaluateScalar(IGenericBuildMasterContext context) => string.Empty;
    }
}
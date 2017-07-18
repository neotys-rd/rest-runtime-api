/*
 * Copyright (c) 2016, Neotys
 * All rights reserved.
 */
using System;

namespace Neotys.RuntimeAPI.Model
{
    /// <summary>
    /// Builder for object <seealso cref="StartTestParams"/>.
    /// 
    /// @author anouvel
    /// 
    /// </summary>
    public class StartTestParamsBuilder
    {
        public string ScenarioName { get; set; }
        public string TestResultName { get; set; }
        public string Description { get; set; }
        public bool Debug { get; set; }
        public bool NLWeb { get; set; }
        public string NLWebToken { get; set; }
        public ExecutionContext ExecutionContext { get; set; }

        /// 
        /// <param name="scenarioName"> </param>
        public StartTestParamsBuilder(string scenarioName)
        {
            this.ScenarioName = scenarioName;
            this.TestResultName = "";
            this.Description = "";
            this.Debug = false;
            this.NLWeb = false;
            this.NLWebToken = "";
            this.ExecutionContext = null;
        }

        public StartTestParamsBuilder scenarioName(string scenarioName)
        {
            this.ScenarioName = scenarioName;
            return this;
        }

        public StartTestParamsBuilder testResultName(string testResultName)
        {
            this.TestResultName = testResultName;
            return this;
        }

        public StartTestParamsBuilder description(string description)
        {
            this.Description = description;
            return this;
        }

        public StartTestParamsBuilder debug(bool debug)
        {
            this.Debug = debug;
            return this;
        }

        public StartTestParamsBuilder nlWeb(bool nlWeb)
        {
            this.NLWeb = nlWeb;
            return this;
        }

        public StartTestParamsBuilder nlWebToken(string nlWebToken)
        {
            this.NLWebToken = nlWebToken;
            return this;
        }

        public StartTestParamsBuilder executionContext(ExecutionContext executionContext)
        {
            this.ExecutionContext = executionContext;
            return this;
        }

        public StartTestParams Build()
        {
            return new StartTestParams(this);
        }
    }
}

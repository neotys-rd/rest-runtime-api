/*
 * Copyright (c) 2016, Neotys
 * All rights reserved.
 */
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

        /// 
        /// <param name="scenarioName"> </param>
        public StartTestParamsBuilder(string scenarioName)
        {
            this.ScenarioName = scenarioName;
            this.TestResultName = "";
            this.Description = "";
            this.Debug = false;
        }

        public StartTestParams Build()
        {
            return new StartTestParams(this);
        }
    }
}

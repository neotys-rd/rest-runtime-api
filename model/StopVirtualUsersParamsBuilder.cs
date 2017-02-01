/*
 * Copyright (c) 2016, Neotys
 * All rights reserved.
 */
namespace Neotys.RuntimeAPI.Model
{
    /// <summary>
    /// Builder for object <seealso cref="StopVirtualUsersParams"/>.
    /// 
    /// @author anouvel
    /// 
    /// </summary>
    public class StopVirtualUsersParamsBuilder
    {
        public string PopulationName { get; set; }
        public int VirtualUserCount { get; set; }
        public StopPolicy StopPolicy { get; set; }

        /// 
        /// <param name="scenarioName"> </param>
        public StopVirtualUsersParamsBuilder(string populationName, int virtualUserCount)
        {
            this.PopulationName = populationName;
            this.VirtualUserCount = virtualUserCount;
            this.StopPolicy = StopPolicy.APPLY_DEFINED;
        }

        public StopVirtualUsersParams Build()
        {
            return new StopVirtualUsersParams(this);
        }
    }
}

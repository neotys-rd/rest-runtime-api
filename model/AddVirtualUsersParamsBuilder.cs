/*
 * Copyright (c) 2016, Neotys
 * All rights reserved.
 */
namespace Neotys.RuntimeAPI.Model
{
    /// <summary>
    /// Builder for object <seealso cref="AddVirtualUsersParams"/>.
    /// 
    /// @author anouvel
    /// 
    /// </summary>
    public class AddVirtualUsersParamsBuilder
    {
        public string PopulationName { get; set; }
        public int VirtualUserCount { get; set; }

        /// 
        /// <param name="scenarioName"> </param>
        public AddVirtualUsersParamsBuilder(string populationName, int virtualUserCount)
        {
            this.PopulationName = populationName;
            this.VirtualUserCount = virtualUserCount;
        }

        public AddVirtualUsersParams Build()
        {
            return new AddVirtualUsersParams(this);
        }
    }
}

/*
 * Copyright (c) 2016, Neotys
 * All rights reserved.
 */
namespace Neotys.RuntimeAPI.Model
{
    /// <summary>
    /// Builder for object <seealso cref="StopTestParams"/>.
    /// 
    /// @author anouvel
    /// 
    /// </summary>
    public class StopTestParamsBuilder
    {
        public bool ForceStop { get; set; }

        public StopTestParamsBuilder()
        {
            this.ForceStop = false;
        }

        public StopTestParams Build()
        {
            return new StopTestParams(this);
        }
    }
}
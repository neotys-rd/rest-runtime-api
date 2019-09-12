/*
 * Copyright (c) 2016, Neotys
 * All rights reserved.
 */
using NeotysRestCommonAPI.Data;

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
        public QualityStatus? QualityStatus { get; set; }

        public StopTestParamsBuilder()
        {
            this.ForceStop = false;
            this.QualityStatus = null;
        }

        public StopTestParams Build()
        {
            return new StopTestParams(this);
        }
    }
}
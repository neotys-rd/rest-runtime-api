using Neotys.CommonAPI.Utils;
using NeotysRestCommonAPI.Data;
using System;
/*
 * Copyright (c) 2016, Neotys
 * All rights reserved.
 */

namespace Neotys.RuntimeAPI.Model
{
    /// <summary>
    /// StopTest is the method sent to the Runtime API Server.
    /// 
    /// @author anouvel
    /// 
    /// </summary>
    public class StopTestParams : IComparable<StopTestParams>
    {
        private readonly bool forceStop;
        private readonly QualityStatus? qualityStatus;

        internal StopTestParams(StopTestParamsBuilder stopTestBuilder)
        {
            this.forceStop = stopTestBuilder.ForceStop;
            this.qualityStatus = stopTestBuilder.QualityStatus;
        }

        public virtual bool ForceStop
        {
            get
            {
                return forceStop;
            }
        }

        public virtual QualityStatus? QualityStatus
        {
            get
            {
                return qualityStatus;
            }
        }

        public override string ToString()
        {
            return new ToStringBuilder<StopTestParams>(this).ReflectionToString(this);
        }

        public virtual int CompareTo(StopTestParams o)
        {
            return this.ToString().CompareTo(o.ToString());
        }

        public override int GetHashCode()
        {
            return new HashCodeBuilder<StopTestParams>(this)
                .With(m => m.forceStop)
                .With(m => m.qualityStatus)
                .HashCode;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is StopTestParams))
            {
                return false;
            }

            return new EqualsBuilder<StopTestParams>(this, obj)
                .With(m => m.forceStop)
                .With(m => m.qualityStatus)
                .Equals();
        }
    }
}

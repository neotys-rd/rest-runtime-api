using Neotys.CommonAPI.Utils;
using System;

/*
 * Copyright (c) 2016, Neotys
 * All rights reserved.
 */
namespace Neotys.RuntimeAPI.Model
{
    /// <summary>
    /// StopVirtualUsers is the method sent to the Runtime API Server.
    /// 
    /// @author anouvel
    /// 
    /// </summary>
    public class StopVirtualUsersParams : IComparable<StopVirtualUsersParams>
    {
        private readonly string populationName;
        private readonly int virtualUserCount;
        private readonly StopPolicy stopPolicy;

        internal StopVirtualUsersParams(StopVirtualUsersParamsBuilder stopVirtualUserBuilder)
        {
            this.populationName = stopVirtualUserBuilder.PopulationName;
            this.virtualUserCount = stopVirtualUserBuilder.VirtualUserCount;
            this.stopPolicy = stopVirtualUserBuilder.StopPolicy;
        }

        public virtual string PopulationName
        {
            get
            {
                return populationName;
            }
        }

        public virtual int VirtualUserCount
        {
            get
            {
                return virtualUserCount;
            }
        }

        public virtual StopPolicy StopPolicy
        {
            get
            {
                return stopPolicy;
            }
        }

        public override string ToString()
        {
            return new ToStringBuilder<StopVirtualUsersParams>(this).ReflectionToString(this);
        }

        public virtual int CompareTo(StopVirtualUsersParams o)
        {
            return this.ToString().CompareTo(o.ToString());
        }

        public override int GetHashCode()
        {
            return new HashCodeBuilder<StopVirtualUsersParams>(this)
                .With(m => m.populationName)
                .With(m => m.virtualUserCount)
                .With(m => m.stopPolicy)
                .HashCode;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is StopVirtualUsersParams))
            {
                return false;
            }

            return new EqualsBuilder<StopVirtualUsersParams>(this, obj)
                .With(m => m.populationName)
                .With(m => m.virtualUserCount)
                .With(m => m.stopPolicy)
                .Equals();
        }
    }
}

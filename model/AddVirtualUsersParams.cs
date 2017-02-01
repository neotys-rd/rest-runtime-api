using Neotys.CommonAPI.Utils;
using System;

/*
 * Copyright (c) 2016, Neotys
 * All rights reserved.
 */
namespace Neotys.RuntimeAPI.Model
{
    /// <summary>
    /// AddVirtualUsers is the method sent to the Runtime API Server.
    /// 
    /// @author anouvel
    /// 
    /// </summary>
    public class AddVirtualUsersParams : IComparable<AddVirtualUsersParams>
    {
        private readonly string populationName;
        private readonly int virtualUserCount;

        internal AddVirtualUsersParams(AddVirtualUsersParamsBuilder addVirtualUserBuilder)
        {
            this.populationName = addVirtualUserBuilder.PopulationName;
            this.virtualUserCount = addVirtualUserBuilder.VirtualUserCount;
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

        public override string ToString()
        {
            return new ToStringBuilder<AddVirtualUsersParams>(this).ReflectionToString(this);
        }

        public virtual int CompareTo(AddVirtualUsersParams o)
        {
            return this.ToString().CompareTo(o.ToString());
        }

        public override int GetHashCode()
        {
            return new HashCodeBuilder<AddVirtualUsersParams>(this)
                .With(m => m.populationName)
                .With(m => m.virtualUserCount)
                .HashCode;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is AddVirtualUsersParams))
            {
                return false;
            }

            return new EqualsBuilder<AddVirtualUsersParams>(this, obj)
                .With(m => m.populationName)
                .With(m => m.virtualUserCount)
                .Equals();
        }
    }
}

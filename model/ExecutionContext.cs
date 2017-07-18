/*
 * Copyright (c) 2017, Neotys
 * All rights reserved.
 */
using Neotys.CommonAPI.Utils;
using System.Collections.Generic;

namespace Neotys.RuntimeAPI.Model
{
    public class ExecutionContext : System.IComparable<ExecutionContext>
    {
        private readonly IDictionary<string, string> variables;

        public ExecutionContext(ExecutionContextBuilder builder)
        {
            this.variables = builder.Variables;
        }

        public virtual IDictionary<string, string> Variables
        {
            get
            {
                return variables;
            }
        }

        public override string ToString()
        {
            return new ToStringBuilder<ExecutionContext>(this).ReflectionToString(this);
        }

        public virtual int CompareTo(ExecutionContext o)
        {
            return this.ToString().CompareTo(o.ToString());
        }

        public override int GetHashCode()
        {
            return new HashCodeBuilder<ExecutionContext>(this)
                .With(m => m.variables)
                .HashCode;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ExecutionContext))
            {
                return false;
            }

            return new EqualsBuilder<ExecutionContext>(this, obj)
                .With(m => m.variables)
                .Equals();
        }
    }
}
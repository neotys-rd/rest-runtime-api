/*
 * Copyright (c) 2017, Neotys
 * All rights reserved.
 */
using System.Collections.Generic;

namespace Neotys.RuntimeAPI.Model
{
    public class ExecutionContextBuilder
    {
        public IDictionary<string, string> Variables { get; }

        public ExecutionContextBuilder()
        {
            this.Variables = new Dictionary<string, string>();
        }

        public ExecutionContextBuilder variable(string name, string value)
        {
            Variables[name]= value;
            return this;
        }

        public ExecutionContext Build()
        {
            return new ExecutionContext(this);
        }
    }
}

using Neotys.CommonAPI.Utils;
using System;
/*
 * Copyright (c) 2016, Neotys
 * All rights reserved.
 */

namespace Neotys.RuntimeAPI.Model
{
    /// <summary>
    /// StartTest is the method sent to the Runtime API Server.
    /// 
    /// @author anouvel
    /// 
    /// </summary>
    public class StartTestParams : IComparable<StartTestParams>
    {
        private readonly string scenarioName;
        private readonly string testResultName;
        private readonly string description;
        private readonly bool debug;
        private readonly bool nlWeb;
        private readonly string nlWebToken;
        private readonly ExecutionContext executionContext;

        internal StartTestParams(StartTestParamsBuilder startTestBuilder)
        {
            this.scenarioName = startTestBuilder.ScenarioName;
            this.testResultName = startTestBuilder.TestResultName;
            this.description = startTestBuilder.Description;
            this.debug = startTestBuilder.Debug;
            this.nlWeb = startTestBuilder.NLWeb;
            this.nlWebToken = startTestBuilder.NLWebToken;
            this.executionContext = startTestBuilder.ExecutionContext;
        }

        public virtual string ScenarioName
        {
            get
            {
                return scenarioName;
            }
        }

        public virtual string TestResultName
        {
            get
            {
                return testResultName;
            }
        }

        public virtual string Description
        {
            get
            {
                return description;
            }
        }

        public virtual bool Debug
        {
            get
            {
                return debug;
            }
        }

        public virtual bool NLWeb
        {
            get
            {
                return nlWeb;
            }
        }

        public virtual string NLWebToken
        {
            get
            {
                return nlWebToken;
            }
        }

        public virtual ExecutionContext ExecutionContext
        {
            get
            {
                return executionContext;
            }
        }

        public override string ToString()
        {
            return new ToStringBuilder<StartTestParams>(this).ReflectionToString(this);
        }

        public virtual int CompareTo(StartTestParams o)
        {
            return this.ToString().CompareTo(o.ToString());
        }

        public override int GetHashCode()
        {
            return new HashCodeBuilder<StartTestParams>(this)
                .With(m => m.scenarioName)
                .With(m => m.testResultName)
                .With(m => m.description)
                .With(m => m.debug)
                .With(m => m.nlWeb)
                .With(m => m.nlWebToken)
                .With(m => m.executionContext)
                .HashCode;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is StartTestParams))
            {
                return false;
            }

            return new EqualsBuilder<StartTestParams>(this, obj)
                .With(m => m.scenarioName)
                .With(m => m.testResultName)
                .With(m => m.description)
                .With(m => m.debug)
                .With(m => m.nlWeb)
                .With(m => m.nlWebToken)
                .With(m => m.executionContext)
                .Equals();
        }
    }
}

using Neotys.CommonAPI.Error;
using Neotys.RuntimeAPI.Model;
using System.Collections.Generic;
using System;
using Newtonsoft.Json.Linq;

namespace Neotys.RuntimeAPI.Utils
{

    class RuntimeApiUtils
    {
        public const string API_KEY = "ApiKey";

        // StartTest
        public const string START_TEST = "StartTest";
        public const string SCENARIO_NAME = "ScenarioName";
        public const string TEST_RESULT_NAME = "TestResultName";
        public const string DESCRIPTION = "Description";
        public const string DEBUG = "Debug";
        public const string NLWEB = "NLWeb";
        public const string NLWEBTOKEN = "NLWebToken";
        public const string VARIABLES = "Variables";

        // StoptTest
        public const string STOP_TEST = "StopTest";
        public const string FORCE_STOP = "ForceStop";
        public const string QUALITY_STATUS = "QualityStatus";

        // AddVirtualUsers,
        public const string ADD_VIRTUAL_USERS = "AddVirtualUsers";
	    public const string POPULATION_NAME = "PopulationName";
	    public const string VIRTUAL_USER_COUNT = "VirtualUserCount";
	    public const string ADDED_VIRTUAL_USER = "AddedVirtualUser";

	    // StopVirtualUsers
	    public const string STOP_VIRTUAL_USERS = "StopVirtualUsers";
	    public const string STOP_POLICY = "StopPolicy";
	    public const string STOPPED_VIRTUAL_USER = "StoppedVirtualUser";

        // GetStatus
        public const string GET_STATUS = "GetStatus";
        public const string STATUS = "Status";

        public static IDictionary<string, object> getStartTestProperties(StartTestParams startTestParams)
        {
            IDictionary<string, object> properties = new Dictionary<string, object>();
            properties[SCENARIO_NAME]= startTestParams.ScenarioName;
            properties[TEST_RESULT_NAME]= startTestParams.TestResultName;
            properties[DESCRIPTION]= startTestParams.Description;
            properties[DEBUG]= startTestParams.Debug;
            properties[NLWEB] = startTestParams.NLWeb;
            properties[NLWEBTOKEN] = startTestParams.NLWebToken;
            if(startTestParams.ExecutionContext != null)
            {
                addExecutionContextProperties(properties, startTestParams.ExecutionContext);
            }
            return properties;
        }

        private static void addExecutionContextProperties(IDictionary<string, object> properties, ExecutionContext executionContext)
        {
            JObject variablesJson = new JObject();
            foreach (KeyValuePair<String, String> entry in executionContext.Variables)
            {
                variablesJson[entry.Key] =entry.Value;
            }
            properties[VARIABLES] = variablesJson.ToString();
        }

        public static IDictionary<string, object> getStopTestProperties(StopTestParams stopTestParams)
        {
            IDictionary<string, object> properties = new Dictionary<string, object>();
            properties[FORCE_STOP] = stopTestParams.ForceStop;
            if(stopTestParams.QualityStatus != null)
            {
                properties[QUALITY_STATUS] = stopTestParams.QualityStatus;
            }
            return properties;
        }

        public static IDictionary<string, object> getAddVirtualUsersProperties(AddVirtualUsersParams addVirtualUsersParam)
        {
            IDictionary<string, object> properties = new Dictionary<string, object>();
            properties[POPULATION_NAME] = addVirtualUsersParam.PopulationName;
            properties[VIRTUAL_USER_COUNT] = addVirtualUsersParam.VirtualUserCount;
            return properties;
        }

        public static IDictionary<string, object> getStopVirtualUsersProperties(StopVirtualUsersParams stopVirtualUsersParam)
        {
            IDictionary<string, object> properties = new Dictionary<string, object>();
            properties[POPULATION_NAME] = stopVirtualUsersParam.PopulationName;
            properties[VIRTUAL_USER_COUNT] = stopVirtualUsersParam.VirtualUserCount;
            properties[STOP_POLICY] = stopVirtualUsersParam.StopPolicy;
            return properties;
        }

        public static int getAddedVirtualUser(IDictionary<string, object> properties)
        {
            object objectAdded = properties[ADDED_VIRTUAL_USER];
            if (objectAdded == null)
            {
                throw new NeotysAPIException(NeotysAPIException.ErrorType.NL_RUNTIME_CANNOT_GET_ADDED_VIRTUAL_USER);
            }
            return int.Parse(objectAdded.ToString());
        }

        public static int getStoppedVirtualUser(IDictionary<string, object> properties)
        {
            object objectStopped = properties[STOPPED_VIRTUAL_USER];
            if (objectStopped == null)
            {
                throw new NeotysAPIException(NeotysAPIException.ErrorType.NL_RUNTIME_CANNOT_GET_STOPPED_VIRTUAL_USER);
            }
            return int.Parse(objectStopped.ToString());
        }

        public static Status getStatus(IDictionary<string, object> properties)
        {
            object objectStatus = properties[STATUS];
            if (objectStatus == null)
            {
                throw new NeotysAPIException(NeotysAPIException.ErrorType.NL_RUNTIME_CANNOT_GET_STATUS);
            }
            return (Status)Status.Parse(typeof(Status), objectStatus.ToString(), true);
        }
    }
}

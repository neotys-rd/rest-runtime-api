using System.Collections.Generic;
using Simple.OData.Client;

/*
 * Copyright (c) 2016, Neotys
 * All rights reserved.
 */
namespace Neotys.RuntimeAPI.Client
{
    using Model;
    using CommonAPI.Client;
    using Utils;
    using NeotysAPIException = CommonAPI.Error.NeotysAPIException;

    /// <summary>
    /// An implementation of a Runtime API Client, based on Apache Olingo framework.
    /// 
    /// @author anouvel
    /// 
    /// </summary>
    internal sealed class RuntimeAPIClientOlingo : NeotysAPIClientOlingo, IRuntimeAPIClient
    {

        private readonly string apiKey;

        /// <summary>
        /// Create a new Runtime API client, connected to the server at the end point 'url' and authenticating with 'apiKey'. </summary>
        /// <param name="url"> </param>
        /// <param name="apiKey"> </param>
        /// <exception cref="GeneralSecurityException"> </exception>
        /// <exception cref="IOException"> </exception>
        /// <exception cref="ODataException"> </exception>
        /// <exception cref="URISyntaxException"> </exception>
        /// <exception cref="NeotysAPIException"> </exception>
        internal RuntimeAPIClientOlingo(string url, string apiKey) : base(url)
        {
            if (Enabled)
            {
                this.apiKey = apiKey != null ? apiKey : "";
            }
            else
            {
                this.apiKey = "";
            }
        }

        /// <summary>
        /// Start a test. </summary>
        /// <param name="startTestParams"> </param>
        /// <exception cref="ODataException"> </exception>
        /// <exception cref="GeneralSecurityException"> </exception>
        /// <exception cref="IOException"> </exception>
        /// <exception cref="URISyntaxException"> </exception>
        /// <exception cref="NeotysAPIException"> </exception>
        public void StartTest(StartTestParams startTestParams)
        {
            if (!Enabled)
            {
                return;
            }
            IDictionary<string, object> properties = RuntimeApiUtils.getStartTestProperties(startTestParams);
            properties[RuntimeApiUtils.API_KEY] = apiKey;
            try
            {
                CreateEntity(RuntimeApiUtils.START_TEST, properties);
            }
            catch (Microsoft.OData.Core.ODataException oDataException)
            {
                throw new NeotysAPIException(oDataException);
            }
        }

        /// <summary>
        /// Stop a test. </summary>
        /// <param name="stopTestParams"> </param>
        /// <exception cref="ODataException"> </exception>
        /// <exception cref="GeneralSecurityException"> </exception>
        /// <exception cref="IOException"> </exception>
        /// <exception cref="URISyntaxException"> </exception>
        /// <exception cref="NeotysAPIException"> </exception>
        public void StopTest(StopTestParams stopTestParams)
        {
            if (!Enabled)
            {
                return;
            }
            IDictionary<string, object> properties = RuntimeApiUtils.getStopTestProperties(stopTestParams);
            properties[RuntimeApiUtils.API_KEY] = apiKey;
            try
            {
                CreateEntity(RuntimeApiUtils.STOP_TEST, properties);
            }
            catch (Microsoft.OData.Core.ODataException oDataException)
            {
                throw new NeotysAPIException(oDataException);
            }
        }

        /// <summary>
        /// Get the test status. </summary>
        /// <param name="stopTestParams"> </param>
        /// <exception cref="ODataException"> </exception>
        /// <exception cref="GeneralSecurityException"> </exception>
        /// <exception cref="IOException"> </exception>
        /// <exception cref="URISyntaxException"> </exception>
        /// <exception cref="NeotysAPIException"> </exception>
        public Status getStatus()
        {
            if (!Enabled)
            {
                return Status.BUSY;
            }
            IDictionary<string, object> properties = new Dictionary<string, object>();
            properties[RuntimeApiUtils.API_KEY] = apiKey;
            try
            {
                ODataEntry entity = ReadEntity(RuntimeApiUtils.GET_STATUS, properties);
                return RuntimeApiUtils.getStatus(entity.AsDictionary());
            }
            catch (Microsoft.OData.Core.ODataException oDataException)
            {
                throw new NeotysAPIException(oDataException);
            }
        }

        /// <summary>
        /// Add Virtual Users. </summary>
        /// <param name="addVirtualUsersParams"> </param>
        /// <exception cref="ODataException"> </exception>
        /// <exception cref="GeneralSecurityException"> </exception>
        /// <exception cref="IOException"> </exception>
        /// <exception cref="URISyntaxException"> </exception>
        /// <exception cref="NeotysAPIException"> </exception>
        public int AddVirtualUsers(AddVirtualUsersParams addVirtualUsersParams)
        {
            if (!Enabled)
            {
                return 0;
            }
            IDictionary<string, object> properties = RuntimeApiUtils.getAddVirtualUsersProperties(addVirtualUsersParams);
            properties[RuntimeApiUtils.API_KEY] = apiKey;
            try
            {
                ODataEntry entity = ReadEntity(RuntimeApiUtils.ADD_VIRTUAL_USERS, properties);
                return RuntimeApiUtils.getAddedVirtualUser(entity.AsDictionary());
            }
            catch (Microsoft.OData.Core.ODataException oDataException)
            {
                throw new NeotysAPIException(oDataException);
            }
        }

        /// <summary>
        /// Stop Virtual Users. </summary>
        /// <param name="stopVirtualUsersParams"> </param>
        /// <exception cref="ODataException"> </exception>
        /// <exception cref="GeneralSecurityException"> </exception>
        /// <exception cref="IOException"> </exception>
        /// <exception cref="URISyntaxException"> </exception>
        /// <exception cref="NeotysAPIException"> </exception>
        public int StopVirtualUsers(StopVirtualUsersParams stopVirtualUsersParams)
        {
            if (!Enabled)
            {
                return 0;
            }
            IDictionary<string, object> properties = RuntimeApiUtils.getStopVirtualUsersProperties(stopVirtualUsersParams);
            properties[RuntimeApiUtils.API_KEY] = apiKey;
            try
            {
                ODataEntry entity = ReadEntity(RuntimeApiUtils.STOP_VIRTUAL_USERS, properties);
                return RuntimeApiUtils.getStoppedVirtualUser(entity.AsDictionary());
            }
            catch (Microsoft.OData.Core.ODataException oDataException)
            {
                throw new NeotysAPIException(oDataException);
            }
        }

    }
}

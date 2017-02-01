/*
 * Copyright (c) 2016, Neotys
 * All rights reserved.
 */
namespace Neotys.RuntimeAPI.Client
{
    using Model;

    /// <summary>
    /// Neotys Runtime API Client interface.
    /// 
    /// @author anouvel
    /// 
    /// </summary>
    public interface IRuntimeAPIClient
    {
        /// <summary>
        /// Start a test. </summary>
        /// <param name="startTestParams"> </param>
        /// <exception cref="GeneralSecurityException"> </exception>
        /// <exception cref="IOException"> </exception>
        /// <exception cref="URISyntaxException"> </exception>
        /// <exception cref="NeotysAPIException"> </exception>
        void StartTest(StartTestParams startTestParams);

        /// <summary>
        /// Stop a test. </summary>
        /// <param name="stopTestParams"> </param>
        /// <exception cref="GeneralSecurityException"> </exception>
        /// <exception cref="IOException"> </exception>
        /// <exception cref="URISyntaxException"> </exception>
        /// <exception cref="NeotysAPIException"> </exception>
        void StopTest(StopTestParams stopTestParams);

        /// <summary>
        /// Get the status of NeoLoad. </summary>
        /// <exception cref="GeneralSecurityException"> </exception>
        /// <exception cref="IOException"> </exception>
        /// <exception cref="URISyntaxException"> </exception>
        /// <exception cref="NeotysAPIException"> </exception>
        Status getStatus();

        /// <summary>
        /// Add Virtual Users. </summary>
        /// <param name="addVirtualUsersParam"> </param>
        /// <exception cref="GeneralSecurityException"> </exception>
        /// <exception cref="IOException"> </exception>
        /// <exception cref="URISyntaxException"> </exception>
        /// <exception cref="NeotysAPIException"> </exception>
        int AddVirtualUsers(AddVirtualUsersParams addVirtualUsersParam);

        /// <summary>
        /// Stop Virtual Users. </summary>
        /// <param name="stopVirtualUsersParams"> </param>
        /// <exception cref="GeneralSecurityException"> </exception>
        /// <exception cref="IOException"> </exception>
        /// <exception cref="URISyntaxException"> </exception>
        /// <exception cref="NeotysAPIException"> </exception>
        int StopVirtualUsers(StopVirtualUsersParams stopVirtualUsersParams);
    }
}

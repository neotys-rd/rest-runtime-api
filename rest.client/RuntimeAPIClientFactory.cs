/*
 * Copyright (c) 2016, Neotys
 * All rights reserved.
 */
namespace Neotys.RuntimeAPI.Client
{
    using NeotysAPIException = CommonAPI.Error.NeotysAPIException;

    /// <summary>
    /// Factory to build RuntimeAPIClient based on Apache Olingo implementation.
    /// 
    /// @author anouvel
    /// 
    /// </summary>
    public sealed class RuntimeAPIClientFactory
    {
        private RuntimeAPIClientFactory()
        {
            throw new System.AccessViolationException();
        }

        /// <summary>
        /// Create a new Runtime API client, connected to the server at the end point 'url'. </summary>
        /// <param name="url"> </param>
        /// <exception cref="NeotysAPIException"> </exception>
        public static IRuntimeAPIClient NewClient(string url)
        {
            return NewClient(url, "");
        }

        /// <summary>
        /// Create a new Runtime API client, connected to the server at the end point 'url', with authenticating with 'apiKey'. </summary>
        /// <param name="url"> </param>
        /// <param name="apiKey"> </param>
        /// <exception cref="NeotysAPIException"> </exception>
        public static IRuntimeAPIClient NewClient(string url, string apiKey)
        {
            return new RuntimeAPIClientOlingo(url, apiKey);
        }
    }
}

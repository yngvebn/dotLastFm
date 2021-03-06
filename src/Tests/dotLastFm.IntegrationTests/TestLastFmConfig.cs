﻿//-----------------------------------------------------------------------
// <copyright file="TestLastFmConfig.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.IntegrationTests
{
    using Api;

    /// <summary>
    /// DotLastFm's config for testing
    /// </summary>
    public class TestLastFmConfig : ILastFmConfig
    {
        /// <summary>
        /// Gets the base Last.fm's URL.
        /// </summary>
        public string BaseUrl
        {
            get
            {
                return "http://ws.audioscrobbler.com/2.0";
            }
        }

        /// <summary>
        /// Gets the Last.fm's API key.
        /// </summary>
        public string ApiKey
        {
            get
            {
                return "b25b959554ed76058ac220b7b2e0a026";
            }
        }

        /// <summary>
        /// Gets the Last.fm's secret.
        /// </summary>
        public string Secret
        {
            get
            {
                return "-- NOT USED --";
            }
        }
    }
}

﻿// OsmSharp - OpenStreetMap (OSM) SDK
// Copyright (C) 2013 Abelshausen Ben
// 
// This file is part of OsmSharp.
// 
// OsmSharp is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// OsmSharp is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with OsmSharp. If not, see <http://www.gnu.org/licenses/>.

using Nancy.Hosting.Self;
using OsmSharp.Routing;
using System;

namespace OsmSharp.Service.Routing
{
    /// <summary>
    /// Defines a few self hosting facility methods.
    /// </summary>
    public static class SelfHost
    {
        /// <summary>
        /// Starts a self-hosted instance of the routing API.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="transitServiceWrapper"></param>
        public static void Start(Uri uri, RoutingServiceWrapperBase routingServiceWrapper)
        {
            // initialize API.
            Bootstrapper.Initialize(routingServiceWrapper);

            // start host.
            using (var host = new NancyHost(uri))
            {
                host.Start();
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Starts a self-hosted instance of the transit API.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="router"></param>
        public static void Start(Uri uri, Router router)
        {
            // initialize API.
            Bootstrapper.Initialize(router);

            // start host.
            using (var host = new NancyHost(uri))
            {
                host.Start();
                Console.WriteLine("Routing service listening at: {0}", uri.ToInvariantString());
                Console.ReadLine();
            }
        }
    }
}
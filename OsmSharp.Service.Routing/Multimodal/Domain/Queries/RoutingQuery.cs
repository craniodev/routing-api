﻿// OsmSharp - OpenStreetMap (OSM) SDK
// Copyright (C) 2015 Abelshausen Ben
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

namespace OsmSharp.Service.Routing.Multimodal.Domain.Queries
{
    class RoutingQuery
    {
        public string loc { get; set; }

        public string vehicle { get; set; }

        public string instructions { get; set; }

        public string format { get; set; }

        public string complete { get; set; }

        public string modi { get; set; }

        public string operators { get; set; }

        public string time { get; set; }

        public string departure { get; set; }

        public string type { get; set; }
    }
}
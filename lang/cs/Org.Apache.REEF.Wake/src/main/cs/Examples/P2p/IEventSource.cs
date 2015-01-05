/**
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace Wake.Examples.P2p
{
    /// <summary>
    /// The pull side of the interface: Clients implement this and register it with
    /// the PullToPush class.
    /// </summary>
    /// <typeparam name="T">The event type</typeparam>
    public interface IEventSource<T>
    {
        /// <summary>
        /// Gets the next event
        /// </summary>
        /// <returns>The next event</returns>
        T GetNext();
    }
}
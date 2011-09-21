﻿/*
 * Copyright 2011 LinkedIn
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

namespace Kafka.Client.Serialization
{
    using System.Text;
    using Kafka.Client.Messages;

    /// <summary>
    /// Serializes data to <see cref="Message" /> format using UTF-8 encoding
    /// </summary>
    public class StringEncoder : IEncoder<string>
    {
        /// <summary>
        /// Serializes given data to <see cref="Message" /> format using UTF-8 encoding
        /// </summary>
        /// <param name="data">
        /// The data to serialize.
        /// </param>
        /// <returns>
        /// Serialized data
        /// </returns>
        public Message ToMessage(string data)
        {
            byte[] encodedData = Encoding.UTF8.GetBytes(data);
            return new Message(encodedData);
        }
    }
}
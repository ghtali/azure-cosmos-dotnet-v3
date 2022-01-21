//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

// This file isn't generated, but this comment is necessary to exclude it from StyleCop analysis.
// <auto-generated/>

using System;

using static System.BitConverter;

namespace Microsoft.Data.Encryption.Cryptography.Serializers
{
    /// <summary>
    /// Contains the methods for serializing and deserializing <see cref="char"/> type data objects.
    /// </summary>
    internal class CharSerializer : Serializer<char>
    {
        /// <summary>
        /// The <see cref="Identifier"/> uniquely identifies a particular Serializer implementation.
        /// </summary>
        public override string Identifier => "Character";

        /// <summary>
        /// Deserializes the provided <paramref name="bytes"/>
        /// </summary>
        /// <param name="bytes">The data to be deserialized</param>
        /// <returns>The serialized data</returns>
        /// <exception cref="MicrosoftDataEncryptionException">
        /// <paramref name="bytes"/> is null.
        /// -or-
        /// The length of <paramref name="bytes"/> is less than 2.
        /// </exception>
        public override char Deserialize(byte[] bytes)
        {
            bytes.ValidateNotNull(nameof(bytes));
            bytes.ValidateGreaterThanSize(sizeof(char), nameof(bytes));

            return ToChar(bytes, 0);
        }

        /// <summary>
        /// Serializes the provided <paramref name="value"/>
        /// </summary>
        /// <param name="value">The value to be serialized</param>
        /// <returns>
        /// An array of bytes with length 2.
        /// </returns>
        public override byte[] Serialize(char value) => GetBytes(value);
    }
}

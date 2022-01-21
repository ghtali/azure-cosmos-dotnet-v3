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
    /// Contains the methods for serializing and deserializing <see cref="long"/> type data objects
	/// that is compatible with the Always Encrypted feature in SQL Server and Azure SQL.
    /// </summary>
    internal sealed class SqlBigIntSerializer : Serializer<long>
    {
        /// <summary>
        /// The <see cref="Identifier"/> uniquely identifies a particular Serializer implementation.
        /// </summary>
        public override string Identifier => "SQL_BigInt";

        /// <summary>
        /// Deserializes the provided <paramref name="bytes"/>
        /// </summary>
        /// <param name="bytes">The data to be deserialized</param>
        /// <returns>The serialized data</returns>
        /// <exception cref="MicrosoftDataEncryptionException">
        /// <paramref name="bytes"/> is null.
        /// -or-
        /// The length of <paramref name="bytes"/> is less than 8.
        /// </exception>
        public override long Deserialize(byte[] bytes)
        {
            bytes.ValidateNotNull(nameof(bytes));
            bytes.ValidateSize(sizeof(long), nameof(bytes));

            return ToInt64(bytes, 0);
        }

        /// <summary>
        /// Serializes the provided <paramref name="value"/>
        /// </summary>
        /// <param name="value">The value to be serialized</param>
        /// <returns>
        /// An array of bytes with length 8.
        /// </returns>
        public override byte[] Serialize(long value) => GetBytes(value);
    }
}

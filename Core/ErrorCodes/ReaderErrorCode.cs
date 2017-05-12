﻿//---------------------------------------------------------------------
// This file is part of ediFabric
//
// Copyright (c) ediFabric. All rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, WHETHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
// PURPOSE.
//---------------------------------------------------------------------

namespace EdiFabric.Core.ErrorCodes
{
    /// <summary>
    /// The internal error codes for all known error conditions.
    /// </summary>
    public enum ReaderErrorCode
    {
        /// <summary>
        /// N/A
        /// </summary>
        Unknown,

        /// <summary>
        /// Interchange control structure is invalid.
        /// </summary>
        InvalidControlStructure,

        /// <summary>
        /// Invalid interchange content.
        /// </summary>
        InvalidInterchangeContent,

        /// <summary>
        /// Unprocessed segments found before the end of the file.
        /// </summary>
        ImproperEndOfFile,
    }
}
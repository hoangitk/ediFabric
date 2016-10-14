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

using EdiFabric.Framework.Exceptions;

namespace EdiFabric.Framework.Items
{
    /// <summary>
    /// EDI error with custom error code.
    /// </summary>
    public class EdiError : EdiItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdiError"/> class.
        /// </summary>
        /// <param name="exception">The exception.</param>
        public EdiError(ParsingException exception)
            : base(exception)
        {
        }
    }
}

﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using Microsoft.Owin.Security.Provider;

namespace Microsoft.Owin.Security.Notifications
{
    public class AuthenticationFailedNotification<TMessage, TOptions> : BaseContext<TOptions>
    {
        public AuthenticationFailedNotification(IOwinContext context, TOptions options)
            : base(context, options)
        {
        }

        public bool Cancel { get; set; }
        public Exception Exception { get; set; }
        public TMessage ProtocolMessage { get; set; }
    }
}
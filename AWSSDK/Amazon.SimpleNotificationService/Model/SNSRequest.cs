﻿/*******************************************************************************
 *  Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleNotificationService.Model
{
    public abstract class SNSRequest : IRequestEvents
    {
        internal event RequestEventHandler BeforeRequestEvent;

        void IRequestEvents.AddBeforeRequestHandler(RequestEventHandler handler)
        {
            BeforeRequestEvent += handler;
        }

        void IRequestEvents.FireBeforeRequestEvent(object sender, RequestEventArgs args)
        {
            if (BeforeRequestEvent != null)
                BeforeRequestEvent(sender, args);
        }
    }
}
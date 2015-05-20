/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ec2-2015-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CancelSpotFleetRequests operation.
    /// Cancels the specified Spot fleet requests.
    /// </summary>
    public partial class CancelSpotFleetRequestsRequest : AmazonEC2Request
    {
        private List<string> _spotFleetRequestIds = new List<string>();
        private bool? _terminateInstances;

        /// <summary>
        /// Gets and sets the property SpotFleetRequestIds. 
        /// <para>
        /// The IDs of the Spot fleet requests.
        /// </para>
        /// </summary>
        public List<string> SpotFleetRequestIds
        {
            get { return this._spotFleetRequestIds; }
            set { this._spotFleetRequestIds = value; }
        }

        // Check to see if SpotFleetRequestIds property is set
        internal bool IsSetSpotFleetRequestIds()
        {
            return this._spotFleetRequestIds != null && this._spotFleetRequestIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TerminateInstances. 
        /// <para>
        /// Indicates whether to terminate instances for a Spot fleet request if it is canceled
        /// successfully.
        /// </para>
        /// </summary>
        public bool TerminateInstances
        {
            get { return this._terminateInstances.GetValueOrDefault(); }
            set { this._terminateInstances = value; }
        }

        // Check to see if TerminateInstances property is set
        internal bool IsSetTerminateInstances()
        {
            return this._terminateInstances.HasValue; 
        }

    }
}
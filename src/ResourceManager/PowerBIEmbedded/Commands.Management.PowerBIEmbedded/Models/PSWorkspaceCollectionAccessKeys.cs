﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Management.PowerBIEmbedded.Models;

namespace Microsoft.Azure.Commands.Management.PowerBIEmbedded.Models
{
    public class PSWorkspaceCollectionAccessKeys
    {
        public string Key1 { get; set; }
        public string Key2 { get; set; }

        public static PSWorkspaceCollectionAccessKeys Create(WorkspaceCollectionAccessKeys accessKeys)
        {
            return new PSWorkspaceCollectionAccessKeys
            {
                Key1 = accessKeys.Key1,
                Key2 = accessKeys.Key2
            };
        }

        /// <summary>
        /// Return a string representation of this storage account
        /// </summary>
        /// <returns>null</returns>
        public override string ToString()
        {
            // Allow listing workspace collection contents through piping
            return null;
        }
    }
}

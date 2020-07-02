/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.dataworks_public.Transform;
using Aliyun.Acs.dataworks_public.Transform.V20200518;

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
    public class GetFileRequest : RpcAcsRequest<GetFileResponse>
    {
        public GetFileRequest()
            : base("dataworks-public", "2020-05-18", "GetFile", "dide", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? projectId;

		private string projectIdentifier;

		private long? fileId;

		public long? ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(BodyParameters, "ProjectId", value.ToString());
			}
		}

		public string ProjectIdentifier
		{
			get
			{
				return projectIdentifier;
			}
			set	
			{
				projectIdentifier = value;
				DictionaryUtil.Add(BodyParameters, "ProjectIdentifier", value);
			}
		}

		public long? FileId
		{
			get
			{
				return fileId;
			}
			set	
			{
				fileId = value;
				DictionaryUtil.Add(BodyParameters, "FileId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetFileResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetFileResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

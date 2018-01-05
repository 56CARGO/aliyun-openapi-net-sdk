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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cms.Model.V20170301;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Transform.V20170301
{
    public class CreateMyGroupsResponseUnmarshaller
    {
        public static CreateMyGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			CreateMyGroupsResponse createMyGroupsResponse = new CreateMyGroupsResponse();

			createMyGroupsResponse.HttpResponse = context.HttpResponse;
			createMyGroupsResponse.RequestId = context.StringValue("CreateMyGroups.RequestId");
			createMyGroupsResponse.Success = context.BooleanValue("CreateMyGroups.Success");
			createMyGroupsResponse.ErrorCode = context.IntegerValue("CreateMyGroups.ErrorCode");
			createMyGroupsResponse.ErrorMessage = context.StringValue("CreateMyGroups.ErrorMessage");
			createMyGroupsResponse.GroupId = context.LongValue("CreateMyGroups.GroupId");
        
			return createMyGroupsResponse;
        }
    }
}
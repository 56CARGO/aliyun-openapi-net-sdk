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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class QueryAppDeviceListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string code;

		private int? page;

		private int? pageSize;

		private int? pageCount;

		private int? total;

		private List<QueryAppDeviceList_DataItem> data;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public int? Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? PageCount
		{
			get
			{
				return pageCount;
			}
			set	
			{
				pageCount = value;
			}
		}

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<QueryAppDeviceList_DataItem> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class QueryAppDeviceList_DataItem
		{

			private string productName;

			private string productKey;

			private string deviceName;

			private int? nodeType;

			private string status;

			private string activeTime;

			private string lastOnlineTime;

			private string createTime;

			private long? childDeviceCount;

			private string utcActiveTime;

			private string utcLastOnlineTime;

			private string utcCreateTime;

			public string ProductName
			{
				get
				{
					return productName;
				}
				set	
				{
					productName = value;
				}
			}

			public string ProductKey
			{
				get
				{
					return productKey;
				}
				set	
				{
					productKey = value;
				}
			}

			public string DeviceName
			{
				get
				{
					return deviceName;
				}
				set	
				{
					deviceName = value;
				}
			}

			public int? NodeType
			{
				get
				{
					return nodeType;
				}
				set	
				{
					nodeType = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string ActiveTime
			{
				get
				{
					return activeTime;
				}
				set	
				{
					activeTime = value;
				}
			}

			public string LastOnlineTime
			{
				get
				{
					return lastOnlineTime;
				}
				set	
				{
					lastOnlineTime = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public long? ChildDeviceCount
			{
				get
				{
					return childDeviceCount;
				}
				set	
				{
					childDeviceCount = value;
				}
			}

			public string UtcActiveTime
			{
				get
				{
					return utcActiveTime;
				}
				set	
				{
					utcActiveTime = value;
				}
			}

			public string UtcLastOnlineTime
			{
				get
				{
					return utcLastOnlineTime;
				}
				set	
				{
					utcLastOnlineTime = value;
				}
			}

			public string UtcCreateTime
			{
				get
				{
					return utcCreateTime;
				}
				set	
				{
					utcCreateTime = value;
				}
			}
		}
	}
}

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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Kms.Transform;
using Aliyun.Acs.Kms.Transform.V20160120;
using System.Collections.Generic;

namespace Aliyun.Acs.Kms.Model.V20160120
{
    public class ListKeysRequest : RpcAcsRequest<ListKeysResponse>
    {
        public ListKeysRequest()
            : base("Kms", "2016-01-20", "ListKeys")
        {
        }

		private int? pageNumber;

		private int? pageSize;

		private string sTSToken;

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string STSToken
		{
			get
			{
				return sTSToken;
			}
			set	
			{
				sTSToken = value;
				DictionaryUtil.Add(QueryParameters, "STSToken", value);
			}
		}

        public override ListKeysResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ListKeysResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
﻿/*
 *  Copyright Beijing 58 Information Technology Co.,Ltd.
 *
 *  Licensed to the Apache Software Foundation (ASF) under one
 *  or more contributor license agreements.  See the NOTICE file
 *  distributed with this work for additional information
 *  regarding copyright ownership.  The ASF licenses this file
 *  to you under the Apache License, Version 2.0 (the
 *  "License"); you may not use this file except in compliance
 *  with the License.  You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing,
 *  software distributed under the License is distributed on an
 *  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 *  KIND, either express or implied.  See the License for the
 *  specific language governing permissions and limitations
 *  under the License.
 */
//----------------------------------------------------------------------
//<Copyright company="58.com">
//      Team:SPAT
//      Blog:http://blog.58.com/spat/  
//      Website:http://www.58.com
//</Copyright>
//-----------------------------------------------------------------------

namespace Com.Bj58.Spat.Gaea.Client.Communication.Protocol.SFP
{
    internal class SFPStruct
    {
        public static readonly int Version = 1;
        public static readonly int TotalLen = 4;
        public static readonly int SessionId = 4;
        public static readonly int ServerId = 1;
        public static readonly int SDPType = 1;
        public static readonly int CompressType = 1;
        public static readonly int SerializeType = 1;
        public static readonly int Platform = 1;
    }
}

// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.Dns.Models;

namespace Microsoft.Azure.Management.Dns.Models
{
    /// <summary>
    /// Represents the properties of the records in the RecordSet.
    /// </summary>
    public partial class RecordSetProperties
    {
        private IList<AaaaRecord> _aaaaRecords;
        
        /// <summary>
        /// Optional. Gets or sets the list of AAAA records in the RecordSet.
        /// </summary>
        public IList<AaaaRecord> AaaaRecords
        {
            get { return this._aaaaRecords; }
            set { this._aaaaRecords = value; }
        }
        
        private IList<ARecord> _aRecords;
        
        /// <summary>
        /// Optional. Gets or sets the list of A records in the RecordSet.
        /// </summary>
        public IList<ARecord> ARecords
        {
            get { return this._aRecords; }
            set { this._aRecords = value; }
        }
        
        private CnameRecord _cnameRecord;
        
        /// <summary>
        /// Optional. Gets or sets the CNAME record in the RecordSet.
        /// </summary>
        public CnameRecord CnameRecord
        {
            get { return this._cnameRecord; }
            set { this._cnameRecord = value; }
        }
        
        private IDictionary<string, string> _metadata;
        
        /// <summary>
        /// Optional. Gets or sets the metadata attached to the resource.
        /// </summary>
        public IDictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }
        
        private IList<MxRecord> _mxRecords;
        
        /// <summary>
        /// Optional. Gets or sets the list of MX records in the RecordSet.
        /// </summary>
        public IList<MxRecord> MxRecords
        {
            get { return this._mxRecords; }
            set { this._mxRecords = value; }
        }
        
        private IList<NsRecord> _nsRecords;
        
        /// <summary>
        /// Optional. Gets or sets the list of NS records in the RecordSet.
        /// </summary>
        public IList<NsRecord> NsRecords
        {
            get { return this._nsRecords; }
            set { this._nsRecords = value; }
        }
        
        private IList<PtrRecord> _ptrRecords;
        
        /// <summary>
        /// Optional. Gets or sets the list of PTR records in the RecordSet.
        /// </summary>
        public IList<PtrRecord> PtrRecords
        {
            get { return this._ptrRecords; }
            set { this._ptrRecords = value; }
        }
        
        private SoaRecord _soaRecord;
        
        /// <summary>
        /// Optional. Gets or sets the SOA record in the RecordSet.
        /// </summary>
        public SoaRecord SoaRecord
        {
            get { return this._soaRecord; }
            set { this._soaRecord = value; }
        }
        
        private IList<SrvRecord> _srvRecords;
        
        /// <summary>
        /// Optional. Gets or sets the list of SRV records in the RecordSet.
        /// </summary>
        public IList<SrvRecord> SrvRecords
        {
            get { return this._srvRecords; }
            set { this._srvRecords = value; }
        }
        
        private uint _ttl;
        
        /// <summary>
        /// Optional. Gets or sets the TTL of the records in the RecordSet.
        /// </summary>
        public uint Ttl
        {
            get { return this._ttl; }
            set { this._ttl = value; }
        }
        
        private IList<TxtRecord> _txtRecords;
        
        /// <summary>
        /// Optional. Gets or sets the list of TXT records in the RecordSet.
        /// </summary>
        public IList<TxtRecord> TxtRecords
        {
            get { return this._txtRecords; }
            set { this._txtRecords = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RecordSetProperties class.
        /// </summary>
        public RecordSetProperties()
        {
            this.Metadata = new LazyDictionary<string, string>();
        }
    }
}

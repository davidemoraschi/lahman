#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;

namespace oDataModel	
{
	public partial class vTeam
	{
		private string _teamID;
		public virtual string teamID
		{
			get
			{
				return this._teamID;
			}
			set
			{
				this._teamID = value;
			}
		}
		
		private string _name;
		public virtual string name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		
		private short? _MAXRank;
		public virtual short? MAXRank
		{
			get
			{
				return this._MAXRank;
			}
			set
			{
				this._MAXRank = value;
			}
		}
		
	}
}
#pragma warning restore 1591

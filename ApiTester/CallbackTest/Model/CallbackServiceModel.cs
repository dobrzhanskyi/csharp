using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CallbackTest.Model
{
	public class CallbackServiceModel
	{
		public DateTime Date { get; set; }

		[JsonProperty("version")]
		public string Version { get; set; }

		[JsonProperty("resourceUrn")]
		public string ResourceUrn { get; set; }

		[JsonProperty("hook")]
		public Hook Hook { get; set; }

		[JsonProperty("payload")]
		public Payload Payload { get; set; }
	}

	public class Myobject
	{
		[JsonProperty("nested")]
		public bool Nested { get; set; }
	}

	public class HookAttribute
	{
		[JsonProperty("myfoo")]
		public int Myfoo { get; set; }

		[JsonProperty("projectId")]
		public string ProjectId { get; set; }

		[JsonProperty("myobject")]
		public Myobject Myobject { get; set; }
	}

	public class Scope
	{
		[JsonProperty("folder")]
		public string Folder { get; set; }
	}

	public class Hook
	{
		[JsonProperty("system")]
		public string System { get; set; }

		[JsonProperty("event")]
		public string Event { get; set; }

		[JsonProperty("hookId")]
		public string HookId { get; set; }

		[JsonProperty("tenant")]
		public string Tenant { get; set; }

		[JsonProperty("callbackUrl")]
		public string CallbackUrl { get; set; }

		[JsonProperty("createdBy")]
		public string CreatedBy { get; set; }

		[JsonProperty("createdDate")]
		public DateTime CreatedDate { get; set; }

		[JsonProperty("creatorType")]
		public string CreatorType { get; set; }

		[JsonProperty("filter")]
		public string Filter { get; set; }

		[JsonProperty("hookAttribute")]
		public HookAttribute HookAttribute { get; set; }

		[JsonProperty("scope")]
		public Scope Scope { get; set; }

		[JsonProperty("urn")]
		public string Urn { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("__self__")]
		public string Self { get; set; }
	}

	public class UserInfo
	{
		[JsonProperty("id")]
		public string Id { get; set; }
	}

	public class Ancestor
	{
		[JsonProperty("urn")]
		public string Urn { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class Payload
	{
		[JsonProperty("ext")]
		public string Ext { get; set; }

		[JsonProperty("modifiedTime")]
		public DateTime ModifiedTime { get; set; }

		[JsonProperty("creator")]
		public string Creator { get; set; }

		[JsonProperty("lineageUrn")]
		public string LineageUrn { get; set; }

		[JsonProperty("sizeInBytes")]
		public int SizeInBytes { get; set; }

		[JsonProperty("hidden")]
		public bool Hidden { get; set; }

		[JsonProperty("indexable")]
		public bool Indexable { get; set; }

		[JsonProperty("project")]
		public string Project { get; set; }

		[JsonProperty("source")]
		public string Source { get; set; }

		[JsonProperty("version")]
		public string Version { get; set; }

		[JsonProperty("user_info")]
		public UserInfo UserInfo { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("createdTime")]
		public DateTime CreatedTime { get; set; }

		[JsonProperty("modifiedBy")]
		public string ModifiedBy { get; set; }

		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("parentFolderUrn")]
		public string ParentFolderUrn { get; set; }

		[JsonProperty("ancestors")]
		public IList<Ancestor> Ancestors { get; set; }

		[JsonProperty("tenant")]
		public string Tenant { get; set; }
	}
}
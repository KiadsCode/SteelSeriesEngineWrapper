using System;
using System.Reflection;

namespace FullSerializer
{
	public class fsConfig
	{
		public Type[] SerializeAttributes = new Type[]
		{
			typeof(fsPropertyAttribute)
		};

		public Type[] IgnoreSerializeAttributes = new Type[]
		{
			typeof(NonSerializedAttribute),
			typeof(fsIgnoreAttribute)
		};

		public fsMemberSerialization DefaultMemberSerialization = fsMemberSerialization.Default;

		public Func<string, MemberInfo, string> GetJsonNameFromMemberName = (string name, MemberInfo info) => name;

		public bool SerializeNonAutoProperties;

		public bool SerializeNonPublicSetProperties = true;

		public string CustomDateTimeFormatString;

		public bool Serialize64BitIntegerAsString;

		public bool SerializeEnumsAsInteger;
	}
}

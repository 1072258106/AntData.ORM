using System;

namespace AntData.ORM.Common
{
	public static class Configuration
	{
		public static bool IsStructIsScalarType = true;
		public static bool AvoidSpecificDataProviderAPI;
		

		public static class Linq
		{
			public static bool PreloadGroups;
			public static bool IgnoreEmptyUpdate;
			public static bool AllowMultipleQuery;
			public static bool GenerateExpressionTest;
            /// <summary>
            /// ����ȫ�� �����Ƿ����null�ֶ�
            /// </summary>
            public static bool IgnoreNullInsert;
            /// <summary>
            /// ����ȫ�� �޸��Ƿ����null�ֶ�
            /// </summary>
            public static bool IgnoreNullUpdate;

            /// <summary>
            /// ����ȫ�� mapping ���л���ʱ�� �Ƿ�����ֶδ�Сд Ĭ�Ϻ���
            /// </summary>
            public static StringComparison? ColumnComparisonOption = StringComparison.OrdinalIgnoreCase;
        }

		public static class LinqService
		{
			public static bool SerializeAssemblyQualifiedName;
			public static bool ThrowUnresolvedTypeException;
		}
	}
}

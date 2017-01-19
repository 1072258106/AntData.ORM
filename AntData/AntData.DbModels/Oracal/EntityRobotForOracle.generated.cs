using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AntData.ORM;
using AntData.ORM.Linq;
using AntData.ORM.Mapping;

namespace DbModels.Oracle
{
	/// <summary>
	/// Database       : orcl
	/// Data Source    : dbtest
	/// Server Version : 11.2.0.1.0
	/// </summary>
	public partial class Entitys : IEntity
	{
		/// <summary>
		/// �û���
		/// </summary>
		public ITable<Person> People  { get { return this.Get<Person>(); } }
		/// <summary>
		/// ѧУ��
		/// </summary>
		public ITable<School> Schools { get { return this.Get<School>(); } }

		private readonly IDataContext con;

		public ITable<T> Get<T>()
			 where T : class
		{
			return this.con.GetTable<T>();
		}

		public Entitys(IDataContext con)
		{
			this.con = con;
		}
	}

	/// <summary>
	/// �û���
	/// </summary>
	[Table(Schema="TEST", Comment="�û���", Name="person")]
	public partial class Person : BaseEntity
	{
		#region Column

		/// <summary>
		/// ����
		/// </summary>
		[Column("Id",                  DataType=DataType.Decimal,  Length=22, Precision=15, Scale=0, Comment="����"), PrimaryKey, NotNull]
		public long Id { get; set; } // NUMBER (15,0)

		/// <summary>
		/// ����
		/// </summary>
		[Column("Name",                DataType=DataType.VarChar,  Length=50, Comment="����"),    Nullable]
		public string Name { get; set; } // VARCHAR2(50)

		/// <summary>
		/// ���
		/// </summary>
		[Column("Age",                 DataType=DataType.Decimal,  Length=22, Precision=5, Scale=0, Comment="���"),    Nullable]
		public int? Age { get; set; } // NUMBER (5,0)

		/// <summary>
		/// School���
		/// </summary>
		[Column("SchoolId",            DataType=DataType.Decimal,  Length=22, Precision=15, Scale=0, Comment="School���"),    Nullable]
		public long? SchoolId { get; set; } // NUMBER (15,0)

		/// <summary>
		/// ������ʱ��
		/// </summary>
		[Column("DataChange_LastTime", DataType=DataType.DateTime, Length=7, Comment="������ʱ��"),    Nullable]
		public DateTime? DataChangeLastTime { get; set; } // DATE

		#endregion

		#region Associations

		/// <summary>
		/// persons_school
		/// </summary>
		[Association(ThisKey="SchoolId", OtherKey="Id", CanBeNull=true, KeyName="persons_school", BackReferenceName="persons")]
		public School Personsschool { get; set; }

		#endregion
	}

	/// <summary>
	/// ѧУ��
	/// </summary>
	[Table(Schema="TEST", Comment="ѧУ��", Name="school")]
	public partial class School : BaseEntity
	{
		#region Column

		[Column("Id",                  DataType=DataType.Decimal,  Length=22, Precision=15, Scale=0), PrimaryKey, NotNull]
		public long Id { get; set; } // NUMBER (15,0)

		/// <summary>
		/// ѧУ����
		/// </summary>
		[Column("Name",                DataType=DataType.VarChar,  Length=50, Comment="ѧУ����"),    Nullable]
		public string Name { get; set; } // VARCHAR2(50)

		/// <summary>
		/// ѧУ��ַ
		/// </summary>
		[Column("Address",             DataType=DataType.VarChar,  Length=100, Comment="ѧУ��ַ"),    Nullable]
		public string Address { get; set; } // VARCHAR2(100)

		/// <summary>
		/// ������ʱ��
		/// </summary>
		[Column("DataChange_LastTime", DataType=DataType.DateTime, Length=7, Comment="������ʱ��"),    Nullable]
		public DateTime? DataChangeLastTime { get; set; } // DATE

		#endregion

		#region Associations

		/// <summary>
		/// persons_school_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="SchoolId", CanBeNull=true, IsBackReference=true)]
		public IEnumerable<Person> Persons { get; set; }

		#endregion
	}

	public static partial class TableExtensions
	{
		public static Person FindByBk(this ITable<Person> table, long Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static async Task<Person> FindByBkAsync(this ITable<Person> table, long Id)
		{
			return await table.FirstOrDefaultAsync(t =>
				t.Id == Id);
		}

		public static School FindByBk(this ITable<School> table, long Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static async Task<School> FindByBkAsync(this ITable<School> table, long Id)
		{
			return await table.FirstOrDefaultAsync(t =>
				t.Id == Id);
		}
	}
}

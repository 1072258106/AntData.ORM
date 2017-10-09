using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AntData.ORM;
using AntData.ORM.Data;
using AntData.ORM.Linq;
using AntData.ORM.Mapping;

namespace DbModels.Mysql
{
	/// <summary>
	/// Database       : testorm
	/// Data Source    : localhost
	/// Server Version : 5.1.49-community
	/// </summary>
	public partial class TestormEntitys : IEntity
	{
		public IQueryable<Person> People  { get { return this.Get<Person>(); } }
		public IQueryable<School> Schools { get { return this.Get<School>(); } }

		private readonly DataConnection con;

		public DataConnection DbContext
		{
			get { return this.con; }
		}

		public IQueryable<T> Get<T>()
			 where T : class
		{
			return this.con.GetTable<T>();
		}

		public TestormEntitys(DataConnection con)
		{
			this.con = con;
		}
	}

	[Table("person")]
	public partial class Person : BaseEntity
	{
		#region Column

		/// <summary>
		/// ����
		/// </summary>
		[Column("Id",                  DataType=AntData.ORM.DataType.Int64,    Comment="����"), PrimaryKey, Identity]
		public long Id { get; set; } // bigint(20)

		/// <summary>
		/// ������ʱ��
		/// </summary>
		[Column("DataChange_LastTime", DataType=AntData.ORM.DataType.DateTime, Comment="������ʱ��"), NotNull]
		public DateTime DataChangeLastTime // datetime
		{
			get { return _DataChangeLastTime; }
			set { _DataChangeLastTime = value; }
		}

		/// <summary>
		/// ����
		/// </summary>
		[Column("Name",                DataType=AntData.ORM.DataType.VarChar,  Length=50, Comment="����"), NotNull]
		public string Name { get; set; } // varchar(50)

		/// <summary>
		/// ���
		/// </summary>
		[Column("Age",                 DataType=AntData.ORM.DataType.Int32,    Comment="���"),    Nullable]
		public int? Age { get; set; } // int(11)

		/// <summary>
		/// ѧУ����
		/// </summary>
		[Column("SchoolId",            DataType=AntData.ORM.DataType.Int64,    Comment="ѧУ����"),    Nullable]
		public long? SchoolId { get; set; } // bigint(20)

		#endregion

		#region Field

		private DateTime _DataChangeLastTime = System.Data.SqlTypes.SqlDateTime.MinValue.Value;

		#endregion

		#region Associations

		/// <summary>
		/// persons_school
		/// </summary>
		[Association(ThisKey="SchoolId", OtherKey="Id", CanBeNull=true, KeyName="persons_school", BackReferenceName="persons")]
		public School School { get; set; }

		#endregion
	}

	[Table("school")]
	public partial class School : BaseEntity
	{
		#region Column

		/// <summary>
		/// ����
		/// </summary>
		[Column("Id",                  DataType=AntData.ORM.DataType.Int64,    Comment="����"), PrimaryKey, Identity]
		public long Id { get; set; } // bigint(20)

		/// <summary>
		/// ѧУ����
		/// </summary>
		[Column("Name",                DataType=AntData.ORM.DataType.VarChar,  Length=50, Comment="ѧУ����"),    Nullable]
		public string Name { get; set; } // varchar(50)

		/// <summary>
		/// ѧУ��ַ
		/// </summary>
		[Column("Address",             DataType=AntData.ORM.DataType.VarChar,  Length=100, Comment="ѧУ��ַ"),    Nullable]
		public string Address { get; set; } // varchar(100)

		/// <summary>
		/// ������ʱ��
		/// </summary>
		[Column("DataChange_LastTime", DataType=AntData.ORM.DataType.DateTime, Comment="������ʱ��"), NotNull]
		public DateTime DataChangeLastTime // datetime
		{
			get { return _DataChangeLastTime; }
			set { _DataChangeLastTime = value; }
		}

		#endregion

		#region Field

		private DateTime _DataChangeLastTime = System.Data.SqlTypes.SqlDateTime.MinValue.Value;

		#endregion

		#region Associations

		/// <summary>
		/// persons_school_BackReference
		/// </summary>
		[Association(ThisKey="Id", OtherKey="SchoolId", CanBeNull=true, IsBackReference=true)]
		public IEnumerable<Person> PersonList { get; set; }

		#endregion
	}

	public static partial class TableExtensions
	{
		public static Person FindByBk(this IQueryable<Person> table, long Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static async Task<Person> FindByBkAsync(this IQueryable<Person> table, long Id)
		{
			return await table.FirstOrDefaultAsync(t =>
				t.Id == Id);
		}

		public static School FindByBk(this IQueryable<School> table, long Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static async Task<School> FindByBkAsync(this IQueryable<School> table, long Id)
		{
			return await table.FirstOrDefaultAsync(t =>
				t.Id == Id);
		}
	}
}

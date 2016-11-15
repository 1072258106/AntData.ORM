using System;
using System.Linq;

using AntData.ORM;
using AntData.ORM.Mapping;
using AntData.ORM.Mysql.Base;

namespace DbModels.Mysql
{
	/// <summary>
	/// Database       : iworkcloudbagdb
	/// Data Source    : 127.0.0.1
	/// Server Version : 5.6.26-log
	/// </summary>
	public partial class Entitys : IEntity
	{
		/// <summary>
		/// �����������û���Ϣ��¼��
		/// </summary>
		public IQueryable<Account>                  Accounts                 { get { return this.Get<Account>(); } }
		public IQueryable<Config>                   Configs                  { get { return this.Get<Config>(); } }
		/// <summary>
		/// �����Ӧ����ʾ�������ȡ���Ķ�����(����ֻ����һ����¼)
		/// </summary>
		public IQueryable<CurrentOrderId>           CurrentOrderId           { get { return this.Get<CurrentOrderId>(); } }
		/// <summary>
		/// ʡ�е�����
		/// </summary>
		public IQueryable<District>                 Districts                { get { return this.Get<District>(); } }
		/// <summary>
		/// ��������ߴ�۸����ñ�
		/// </summary>
		public IQueryable<DistrictGoods>            DistrictGoods            { get { return this.Get<DistrictGoods>(); } }
		/// <summary>
		/// ��������ߴ�۸������м��
		/// </summary>
		public IQueryable<DistrictGoodsPackageType> DistrictGoodsPackageType { get { return this.Get<DistrictGoodsPackageType>(); } }
		/// <summary>
		/// ���з������Ͷ�Ӧ��
		/// </summary>
		public IQueryable<DistrictService>          DistrictService          { get { return this.Get<DistrictService>(); } }
		/// <summary>
		/// �������ñ�
		/// </summary>
		public IQueryable<InsuranceType>            InsuranceType            { get { return this.Get<InsuranceType>(); } }
		/// <summary>
		/// �������
		/// </summary>
		public IQueryable<OneUbt>                   OneUbt                   { get { return this.Get<OneUbt>(); } }
		/// <summary>
		/// ������
		/// </summary>
		public IQueryable<Order>                    Orders                   { get { return this.Get<Order>(); } }
		/// <summary>
		/// ����Ƕ����ŷ�������Ķ���������
		/// </summary>
		public IQueryable<OrderIds>                 OrderIds                 { get { return this.Get<OrderIds>(); } }
		/// <summary>
		/// ����������Ϣ��
		/// </summary>
		public IQueryable<OrderMessage>             OrderMessage             { get { return this.Get<OrderMessage>(); } }
		/// <summary>
		/// �����µ�����ߴ�۸���ϸ��
		/// </summary>
		public IQueryable<OrderPackageDetail>       OrderPackageDetail       { get { return this.Get<OrderPackageDetail>(); } }
		/// <summary>
		/// ����֧����Ϣ��
		/// </summary>
		public IQueryable<OrderPayment>             OrderPayment             { get { return this.Get<OrderPayment>(); } }
		/// <summary>
		/// ��������
		/// </summary>
		public IQueryable<OrderRule>                OrderRule                { get { return this.Get<OrderRule>(); } }
		/// <summary>
		/// ����״̬���ļ�¼��
		/// </summary>
		public IQueryable<OrderStateChange>         OrderStateChange         { get { return this.Get<OrderStateChange>(); } }
		/// <summary>
		/// ����ϵͳ�û���
		/// </summary>
		public IQueryable<OrderUser>                OrderUser                { get { return this.Get<OrderUser>(); } }
		/// <summary>
		/// ����ߴ�۸���ϸ����
		/// </summary>
		public IQueryable<PackageType>              PackageType              { get { return this.Get<PackageType>(); } }
		/// <summary>
		/// �ṩ�ķ����Ʒ��
		/// </summary>
		public IQueryable<Product>                  Products                 { get { return this.Get<Product>(); } }
		/// <summary>
		/// ��Ʒ��Ӧ����ߴ�۸����ñ�
		/// </summary>
		public IQueryable<ProductPackageType>       ProductPackageType       { get { return this.Get<ProductPackageType>(); } }
		/// <summary>
		/// ��Ӧ�̱�
		/// </summary>
		public IQueryable<Provider>                 Providers                { get { return this.Get<Provider>(); } }
		/// <summary>
		/// ��Ӧ�̶�����
		/// </summary>
		public IQueryable<ProviderOrder>            ProviderOrder            { get { return this.Get<ProviderOrder>(); } }
		/// <summary>
		/// ��Ӧ���ṩ�ķ����Ʒ��
		/// </summary>
		public IQueryable<ProviderProduct>          ProviderProduct          { get { return this.Get<ProviderProduct>(); } }
		/// <summary>
		/// ��Ӧ���û���
		/// </summary>
		public IQueryable<ProviderUser>             ProviderUser             { get { return this.Get<ProviderUser>(); } }
		public IQueryable<SystemMenu>               SystemMenu               { get { return this.Get<SystemMenu>(); } }
		public IQueryable<SystemRole>               SystemRole               { get { return this.Get<SystemRole>(); } }
		public IQueryable<SystemUser>               SystemUser               { get { return this.Get<SystemUser>(); } }
		/// <summary>
		/// ���ӷ�ʽ���ñ�
		/// </summary>
		public IQueryable<TransferType>             TransferType             { get { return this.Get<TransferType>(); } }

		private readonly IDataContext con;

		public IQueryable<T> Get<T>()
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
	/// �����������û���Ϣ��¼��
	/// </summary>
	[Table("accounts")]
	public partial class Account : LinqToDBEntity
	{
		/// <summary>
		/// �û�Uid
		/// </summary>
		[Column("Uid",                 DataType=DataType.VarChar,  Length=36),    Nullable]
		public string Uid { get; set; } // varchar(36)

		/// <summary>
		/// �û�����
		/// </summary>
		[Column("UserName",            DataType=DataType.VarChar,  Length=50),    Nullable]
		public string UserName { get; set; } // varchar(50)

		/// <summary>
		/// �û��ֻ���
		/// </summary>
		[Column("UserPhone",           DataType=DataType.VarChar,  Length=24),    Nullable]
		public string UserPhone { get; set; } // varchar(24)

		/// <summary>
		/// �û�����
		/// </summary>
		[Column("Email",               DataType=DataType.VarChar,  Length=50),    Nullable]
		public string Email { get; set; } // varchar(50)

		/// <summary>
		/// �û����֤�Ż��߻��պ�
		/// </summary>
		[Column("CardNo",              DataType=DataType.VarChar,  Length=50),    Nullable]
		public string CardNo { get; set; } // varchar(50)
	}

	[Table("config")]
	public partial class Config : LinqToDBEntity
	{
		/// <summary>
		/// ����1:��ҳ�ֲ�
		/// </summary>
		[Column("Type",                DataType=DataType.Int32)   ,    Nullable]
		public int? Type { get; set; } // int(11)

		/// <summary>
		/// ��������
		/// </summary>
		[Column("Value",               DataType=DataType.VarChar,  Length=10480),    Nullable]
		public string Value { get; set; } // varchar(10480)
	}

	/// <summary>
	/// �����Ӧ����ʾ�������ȡ���Ķ�����(����ֻ����һ����¼)
	/// </summary>
	[Table("current_order_id")]
	public partial class CurrentOrderId : LinqToDBEntity
	{
		/// <summary>
		/// Ψһ������
		/// </summary>
		[Column("CurrentId",           DataType=DataType.Int64)   ,    Nullable]
		public long? CurrentId { get; set; } // bigint(20)
	}

	/// <summary>
	/// ʡ�е�����
	/// </summary>
	[Table("district")]
	public partial class District : LinqToDBEntity
	{
		/// <summary>
		/// ����
		/// </summary>
		[Column("Name",                DataType=DataType.VarChar,  Length=90),    Nullable]
		public string Name { get; set; } // varchar(90)

		/// <summary>
		/// ����
		/// </summary>
		[Column("Parentid",            DataType=DataType.Int64)   ,    Nullable]
		public long? Parentid { get; set; } // bigint(20)

		/// <summary>
		/// ����˵��
		/// </summary>
		[Column("Extra",               DataType=DataType.VarChar,  Length=135),    Nullable]
		public string Extra { get; set; } // varchar(135)

		/// <summary>
		/// ��׺
		/// </summary>
		[Column("Suffix",              DataType=DataType.VarChar,  Length=45),    Nullable]
		public string Suffix { get; set; } // varchar(45)

		/// <summary>
		/// ������
		/// </summary>
		[Column("AreaId",              DataType=DataType.VarChar,  Length=30),    Nullable]
		public string AreaId { get; set; } // varchar(30)

		/// <summary>
		/// ����
		/// </summary>
		[Column("OrderRule",           DataType=DataType.Int32)   ,    Nullable]
		public int? OrderRule { get; set; } // int(11)

		/// <summary>
		/// �Ƿ���Ч
		/// </summary>
		[Column("IsActive",            DataType=DataType.Boolean) , NotNull]
		public bool IsActive { get; set; } // tinyint(1)

		/// <summary>
		/// �Ƿ����ȵ�
		/// </summary>
		[Column("IsHot",               DataType=DataType.Boolean) , NotNull]
		public bool IsHot { get; set; } // tinyint(1)

		/// <summary>
		/// ���� 0���� 1���� 2����
		/// </summary>
		[Column("Type",                DataType=DataType.Int32)   , NotNull]
		public int Type { get; set; } // int(11)
	}

	/// <summary>
	/// ��������ߴ�۸����ñ�
	/// </summary>
	[Table("district_goods")]
	public partial class DistrictGoods : LinqToDBEntity
	{
		/// <summary>
		/// 1����վ 2������ 3�ӻ�վ 4�ӻ���
		/// </summary>
		[Column("Type",                DataType=DataType.Int32)   ,    Nullable]
		public int? Type { get; set; } // int(11)

		/// <summary>
		/// ����Tid
		/// </summary>
		[Column("DistrictTid",         DataType=DataType.Int64)   ,    Nullable]
		public long? DistrictTid { get; set; } // bigint(20)

		/// <summary>
		/// �Ƿ���Ч
		/// </summary>
		[Column("IsActive",            DataType=DataType.Boolean) , NotNull]
		public bool IsActive { get; set; } // tinyint(1)

		/// <summary>
		/// ����
		/// </summary>
		[Column("Title",               DataType=DataType.VarChar,  Length=150),    Nullable]
		public string Title { get; set; } // varchar(150)

		/// <summary>
		/// ͼƬ
		/// </summary>
		[Column("Photo",               DataType=DataType.VarChar,  Length=200),    Nullable]
		public string Photo { get; set; } // varchar(200)

		/// <summary>
		/// ��Ʒ�ص�
		/// </summary>
		[Column("Remark",              DataType=DataType.VarChar,  Length=10280),    Nullable]
		public string Remark { get; set; } // varchar(10280)
	}

	/// <summary>
	/// ��������ߴ�۸������м��
	/// </summary>
	[Table("district_goods_package_type")]
	public partial class DistrictGoodsPackageType : LinqToDBEntity
	{
		/// <summary>
		/// ������ƷTid
		/// </summary>
		[Column("DistrictGoodsTid",    DataType=DataType.Int64)   ,    Nullable]
		public long? DistrictGoodsTid { get; set; } // bigint(20)

		/// <summary>
		/// ��������Tid
		/// </summary>
		[Column("PackageTypeTid",      DataType=DataType.Int64)   ,    Nullable]
		public long? PackageTypeTid { get; set; } // bigint(20)

		/// <summary>
		/// �Ƿ���Ч
		/// </summary>
		[Column("IsActive",            DataType=DataType.Boolean) , NotNull]
		public bool IsActive { get; set; } // tinyint(1)
	}

	/// <summary>
	/// ���з������Ͷ�Ӧ��
	/// </summary>
	[Table("district_service")]
	public partial class DistrictService : LinqToDBEntity
	{
		/// <summary>
		/// ����Tid
		/// </summary>
		[Column("DistrictTid",         DataType=DataType.Int64)   ,    Nullable]
		public long? DistrictTid { get; set; } // bigint(20)

		/// <summary>
		/// ��������
		/// </summary>
		[Column("ServiceName",         DataType=DataType.VarChar,  Length=100),    Nullable]
		public string ServiceName { get; set; } // varchar(100)

		/// <summary>
		/// �������� 1����վ 2������ 3�ӻ�վ 4�ӻ���
		/// </summary>
		[Column("ServiceType",         DataType=DataType.Int32)   ,    Nullable]
		public int? ServiceType { get; set; } // int(11)

		/// <summary>
		/// �Ƿ���Ч
		/// </summary>
		[Column("IsActive",            DataType=DataType.Boolean) , NotNull]
		public bool IsActive { get; set; } // tinyint(1)
	}

	/// <summary>
	/// �������ñ�
	/// </summary>
	[Table("insurance_type")]
	public partial class InsuranceType : LinqToDBEntity
	{
		/// <summary>
		/// ����Tid
		/// </summary>
		[Column("DistrictTid",         DataType=DataType.Int64)   ,    Nullable]
		public long? DistrictTid { get; set; } // bigint(20)

		/// <summary>
		/// X(Ԫ/��)
		/// </summary>
		[Column("Fee",                 DataType=DataType.Decimal,  Precision=10, Scale=0),    Nullable]
		public decimal? Fee { get; set; } // decimal(10,0)

		/// <summary>
		/// ������Ϣ
		/// </summary>
		[Column("Description",         DataType=DataType.VarChar,  Length=100),    Nullable]
		public string Description { get; set; } // varchar(100)

		/// <summary>
		/// �Ƿ���Ч
		/// </summary>
		[Column("IsActive",            DataType=DataType.Boolean) , NotNull]
		public bool IsActive { get; set; } // tinyint(1)
	}

	/// <summary>
	/// �������
	/// </summary>
	[Table("one_ubt")]
	public partial class OneUbt : LinqToDBEntity
	{
		/// <summary>
		/// ��ťID
		/// </summary>
		[Column("ControlID",           DataType=DataType.VarChar,  Length=45),    Nullable]
		public string ControlID { get; set; } // varchar(45)

		/// <summary>
		/// ��ť����
		/// </summary>
		[Column("ControlName",         DataType=DataType.VarChar,  Length=45),    Nullable]
		public string ControlName { get; set; } // varchar(45)

		/// <summary>
		/// ��ť����
		/// </summary>
		[Column("ControlDescription",  DataType=DataType.VarChar,  Length=100),    Nullable]
		public string ControlDescription { get; set; } // varchar(100)

		/// <summary>
		/// �û�ID
		/// </summary>
		[Column("UID",                 DataType=DataType.VarChar,  Length=45),    Nullable]
		public string UID { get; set; } // varchar(45)

		/// <summary>
		/// �û��豸ID
		/// </summary>
		[Column("CID",                 DataType=DataType.VarChar,  Length=45),    Nullable]
		public string CID { get; set; } // varchar(45)

		/// <summary>
		/// �����ҳ����ࣩ
		/// </summary>
		[Column("Category",            DataType=DataType.Int32)   ,    Nullable]
		public int? Category { get; set; } // int(11)

		/// <summary>
		/// �������ƣ���ҳ��������ƣ�
		/// </summary>
		[Column("CategoryName",        DataType=DataType.VarChar,  Length=45),    Nullable]
		public string CategoryName { get; set; } // varchar(45)

		/// <summary>
		/// ��ƷID
		/// </summary>
		[Column("ProductID",           DataType=DataType.VarChar,  Length=45),    Nullable]
		public string ProductID { get; set; } // varchar(45)

		/// <summary>
		/// ��Ʒ����
		/// </summary>
		[Column("ProductName",         DataType=DataType.VarChar,  Length=45),    Nullable]
		public string ProductName { get; set; } // varchar(45)

		/// <summary>
		/// ��Ʒ���
		/// </summary>
		[Column("Price",               DataType=DataType.Decimal,  Precision=18, Scale=2), NotNull]
		public decimal Price { get; set; } // decimal(18,2)

		/// <summary>
		/// ��Ʒ����
		/// </summary>
		[Column("Url",                 DataType=DataType.VarChar,  Length=2000),    Nullable]
		public string Url { get; set; } // varchar(2000)

		/// <summary>
		/// ��������
		/// </summary>
		[Column("ObjectType",          DataType=DataType.Int32)   ,    Nullable]
		public int? ObjectType { get; set; } // int(11)

		/// <summary>
		/// ��������ID
		/// </summary>
		[Column("ObjectID",            DataType=DataType.VarChar,  Length=45),    Nullable]
		public string ObjectID { get; set; } // varchar(45)

		/// <summary>
		/// ������Ŀ����
		/// </summary>
		[Column("ObejctName",          DataType=DataType.VarChar,  Length=45),    Nullable]
		public string ObejctName { get; set; } // varchar(45)

		/// <summary>
		/// �������
		/// </summary>
		[Column("Exinfo",              DataType=DataType.VarChar,  Length=1000),    Nullable]
		public string Exinfo { get; set; } // varchar(1000)

		/// <summary>
		/// �豸����ʱ��
		/// </summary>
		[Column("LocalTime",           DataType=DataType.DateTime),    Nullable]
		public DateTime? LocalTime { get; set; } // datetime

		/// <summary>
		/// ������ʱ��
		/// </summary>
		[Column("ServerTime",          DataType=DataType.DateTime),    Nullable]
		public DateTime? ServerTime { get; set; } // datetime

		/// <summary>
		/// ��������
		/// </summary>
		[Column("ActionType",          DataType=DataType.Int32)   ,    Nullable]
		public int? ActionType { get; set; } // int(11)

		/// <summary>
		/// ��������
		/// </summary>
		[Column("ActionName",          DataType=DataType.VarChar,  Length=45),    Nullable]
		public string ActionName { get; set; } // varchar(45)

		/// <summary>
		/// �ͻ��ỰID
		/// </summary>
		[Column("SessionID",           DataType=DataType.VarChar,  Length=45),    Nullable]
		public string SessionID { get; set; } // varchar(45)

		/// <summary>
		/// �ͻ���IP
		/// </summary>
		[Column("ClientIP",            DataType=DataType.VarChar,  Length=20),    Nullable]
		public string ClientIP { get; set; } // varchar(20)

		/// <summary>
		/// �汾��
		/// </summary>
		[Column("Version",             DataType=DataType.VarChar,  Length=20),    Nullable]
		public string Version { get; set; } // varchar(20)
	}

	/// <summary>
	/// ������
	/// </summary>
	[Table("orders")]
	public partial class Order : LinqToDBEntity
	{
		/// <summary>
		/// ��Ӧ��Tid
		/// </summary>
		[Column("ProviderTid",         DataType=DataType.Int64)   ,    Nullable]
		public long? ProviderTid { get; set; } // bigint(20)

		/// <summary>
		/// �û�Uid
		/// </summary>
		[Column("Uid",                 DataType=DataType.VarChar,  Length=36),    Nullable]
		public string Uid { get; set; } // varchar(36)

		/// <summary>
		/// �û�����
		/// </summary>
		[Column("UserName",            DataType=DataType.VarChar,  Length=50),    Nullable]
		public string UserName { get; set; } // varchar(50)

		/// <summary>
		/// �û��ֻ���
		/// </summary>
		[Column("UserPhone",           DataType=DataType.Char,     Length=24),    Nullable]
		public string UserPhone { get; set; } // char(24)

		/// <summary>
		/// �ļ�����Tid
		/// </summary>
		[Column("LocationTid",         DataType=DataType.Int64)   ,    Nullable]
		public long? LocationTid { get; set; } // bigint(20)

		/// <summary>
		/// �ļ���ϸ��ַ
		/// </summary>
		[Column("LocationDetail",      DataType=DataType.VarChar,  Length=250),    Nullable]
		public string LocationDetail { get; set; } // varchar(250)

		/// <summary>
		/// �ļ�ʱ��
		/// </summary>
		[Column("GetTime",             DataType=DataType.DateTime),    Nullable]
		public DateTime? GetTime { get; set; } // datetime

		/// <summary>
		/// �ļ����ӷ�ʽ
		/// </summary>
		[Column("GetTransferTid",      DataType=DataType.VarChar,  Length=250),    Nullable]
		public string GetTransferTid { get; set; } // varchar(250)

		/// <summary>
		/// �ļ�����( 0���� 1�� 2����)
		/// </summary>
		[Column("GetType",             DataType=DataType.Int32)   ,    Nullable]
		public int? GetType { get; set; } // int(11)

		/// <summary>
		/// �ռ�����Tid
		/// </summary>
		[Column("DestinationTid",      DataType=DataType.Int64)   ,    Nullable]
		public long? DestinationTid { get; set; } // bigint(20)

		/// <summary>
		/// �ռ���ϸ��ַ
		/// </summary>
		[Column("DestinationDetail",   DataType=DataType.VarChar,  Length=250),    Nullable]
		public string DestinationDetail { get; set; } // varchar(250)

		/// <summary>
		/// �ռ�ʱ��
		/// </summary>
		[Column("TakeTime",            DataType=DataType.DateTime),    Nullable]
		public DateTime? TakeTime { get; set; } // datetime

		/// <summary>
		/// �ռ����ӷ�ʽ
		/// </summary>
		[Column("TakeTransferTid",     DataType=DataType.VarChar,  Length=250),    Nullable]
		public string TakeTransferTid { get; set; } // varchar(250)

		/// <summary>
		/// �ռ�����( 0���� 1�� 2����)
		/// </summary>
		[Column("TakeType",            DataType=DataType.Int32)   ,    Nullable]
		public int? TakeType { get; set; } // int(11)

		/// <summary>
		/// ����
		/// </summary>
		[Column("Remark",              DataType=DataType.VarChar,  Length=500),    Nullable]
		public string Remark { get; set; } // varchar(500)

		/// <summary>
		/// ��ƷTid
		/// </summary>
		[Column("ProductTid",          DataType=DataType.Int64)   ,    Nullable]
		public long? ProductTid { get; set; } // bigint(20)

		/// <summary>
		/// ������
		/// </summary>
		[Column("OrderId",             DataType=DataType.Int64)   ,    Nullable]
		public long? OrderId { get; set; } // bigint(20)

		/// <summary>
		/// �����۸�
		/// </summary>
		[Column("OrderPrice",          DataType=DataType.Decimal,  Precision=10, Scale=3),    Nullable]
		public decimal? OrderPrice { get; set; } // decimal(10,3)

		/// <summary>
		/// ����״̬��1�������2������ȡ��3�������С�4�����ʹ5���ѳɽ���9����ȡ��
		/// </summary>
		[Column("OrderState",          DataType=DataType.Int32)   ,    Nullable]
		public int? OrderState { get; set; } // int(11)

		/// <summary>
		/// ��������ʱ��
		/// </summary>
		[Column("CreateTime",          DataType=DataType.DateTime),    Nullable]
		public DateTime? CreateTime { get; set; } // datetime

		/// <summary>
		/// �Ƿ��ʡ
		/// </summary>
		[Column("isOutside",           DataType=DataType.Boolean) , NotNull]
		public bool IsOutside { get; set; } // tinyint(1)

		/// <summary>
		/// ���۽��
		/// </summary>
		[Column("InsuranceFee",        DataType=DataType.Decimal,  Precision=10, Scale=3),    Nullable]
		public decimal? InsuranceFee { get; set; } // decimal(10,3)

		/// <summary>
		/// ����Tid
		/// </summary>
		[Column("InsuranceTid",        DataType=DataType.Int64)   ,    Nullable]
		public long? InsuranceTid { get; set; } // bigint(20)

		/// <summary>
		/// ֧��״̬��1:�����2���Ѹ��3�����˿4�������5��֧��ʧ�ܣ�6�����˿7��֧������
		/// </summary>
		[Column("PayState",            DataType=DataType.Int32)   ,    Nullable]
		public int? PayState { get; set; } // int(11)

		/// <summary>
		/// app�汾��
		/// </summary>
		[Column("AppVersion",          DataType=DataType.VarChar,  Length=50),    Nullable]
		public string AppVersion { get; set; } // varchar(50)

		/// <summary>
		/// ����
		/// </summary>
		[Column("Channel",             DataType=DataType.Int32)   ,    Nullable]
		public int? Channel { get; set; } // int(11)

		/// <summary>
		/// ���֧��ʱ��
		/// </summary>
		[Column("LastPayTime",         DataType=DataType.DateTime),    Nullable]
		public DateTime? LastPayTime { get; set; } // datetime

		/// <summary>
		/// �ն�(0:PC,1:APP��2:΢��,3:H5)
		/// </summary>
		[Column("Terminal",            DataType=DataType.Int32)   ,    Nullable]
		public int? Terminal { get; set; } // int(11)

		/// <summary>
		/// ȡ����
		/// </summary>
		[Column("TakeCode",            DataType=DataType.Int64)   ,    Nullable]
		public long? TakeCode { get; set; } // bigint(20)

		/// <summary>
		/// �û��Ƿ�ɾ��
		/// </summary>
		[Column("IsActive",            DataType=DataType.Boolean) , NotNull]
		public bool IsActive { get; set; } // tinyint(1)

		/// <summary>
		/// �û�����
		/// </summary>
		[Column("Email",               DataType=DataType.VarChar,  Length=50),    Nullable]
		public string Email { get; set; } // varchar(50)

		/// <summary>
		/// �û����֤�Ż��߻��պ�
		/// </summary>
		[Column("CardNo",              DataType=DataType.VarChar,  Length=50),    Nullable]
		public string CardNo { get; set; } // varchar(50)

		/// <summary>
		/// �������� 1����վ 2������ 3�ӻ�վ 4�ӻ���
		/// </summary>
		[Column("ServiceType",         DataType=DataType.Int32)   ,    Nullable]
		public int? ServiceType { get; set; } // int(11)
	}

	/// <summary>
	/// ����Ƕ����ŷ�������Ķ���������
	/// </summary>
	[Table("order_ids")]
	public partial class OrderIds : LinqToDBEntity
	{
		/// <summary>
		/// Ψһ������
		/// </summary>
		[Column("OrderId",             DataType=DataType.Int64)   ,    Nullable]
		public long? OrderId { get; set; } // bigint(20)
	}

	/// <summary>
	/// ����������Ϣ��
	/// </summary>
	[Table("order_message")]
	public partial class OrderMessage : LinqToDBEntity
	{
		/// <summary>
		/// ������
		/// </summary>
		[Column("OrderId",             DataType=DataType.Int64)   ,    Nullable]
		public long? OrderId { get; set; } // bigint(20)

		/// <summary>
		/// ���Ա�ע��������Ϣ
		/// </summary>
		[Column("Message",             DataType=DataType.VarChar,  Length=500),    Nullable]
		public string Message { get; set; } // varchar(500)

		/// <summary>
		/// 0��֧��ƽ̨ 1ϵͳ 2��Ӧ��ϵͳ 3����ϵͳ
		/// </summary>
		[Column("UserType",            DataType=DataType.Int32)   ,    Nullable]
		public int? UserType { get; set; } // int(11)

		/// <summary>
		/// ��Ӧ����ϵͳ���߹�Ӧ��ϵͳ�û���Tid
		/// </summary>
		[Column("UserTid",             DataType=DataType.Int64)   ,    Nullable]
		public long? UserTid { get; set; } // bigint(20)
	}

	/// <summary>
	/// �����µ�����ߴ�۸���ϸ��
	/// </summary>
	[Table("order_package_detail")]
	public partial class OrderPackageDetail : LinqToDBEntity
	{
		/// <summary>
		/// Ψһ������
		/// </summary>
		[Column("OrderId",               DataType=DataType.Int64)   ,    Nullable]
		public long? OrderId { get; set; } // bigint(20)

		/// <summary>
		/// ��Ʒ��Ӧ����ߴ�۸�����
		/// </summary>
		[Column("ProductPackageTypeTid", DataType=DataType.Int64)   ,    Nullable]
		public long? ProductPackageTypeTid { get; set; } // bigint(20)

		/// <summary>
		/// ����
		/// </summary>
		[Column("Amount",                DataType=DataType.Int32)   ,    Nullable]
		public int? Amount { get; set; } // int(11)

		/// <summary>
		/// �ܽ��
		/// </summary>
		[Column("TotalPackagePrice",     DataType=DataType.Decimal,  Precision=10, Scale=3),    Nullable]
		public decimal? TotalPackagePrice { get; set; } // decimal(10,3)

		/// <summary>
		/// �������ߴ����Ƶ���Ϣ
		/// </summary>
		[Column("PackageName",           DataType=DataType.VarChar,  Length=50),    Nullable]
		public string PackageName { get; set; } // varchar(50)

		/// <summary>
		/// �۸�
		/// </summary>
		[Column("Price",                 DataType=DataType.Decimal,  Precision=10, Scale=0),    Nullable]
		public decimal? Price { get; set; } // decimal(10,0)
	}

	/// <summary>
	/// ����֧����Ϣ��
	/// </summary>
	[Table("order_payment")]
	public partial class OrderPayment : LinqToDBEntity
	{
		/// <summary>
		/// ������
		/// </summary>
		[Column("OrderId",             DataType=DataType.Int64)   ,    Nullable]
		public long? OrderId { get; set; } // bigint(20)

		/// <summary>
		/// Ӧ�ս��
		/// </summary>
		[Column("OrderPrice",          DataType=DataType.Decimal,  Precision=10, Scale=3),    Nullable]
		public decimal? OrderPrice { get; set; } // decimal(10,3)

		/// <summary>
		/// ʵ�ս��
		/// </summary>
		[Column("UserPayFee",          DataType=DataType.Decimal,  Precision=10, Scale=3),    Nullable]
		public decimal? UserPayFee { get; set; } // decimal(10,3)

		/// <summary>
		/// ������ˮ��
		/// </summary>
		[Column("TradeNumber",         DataType=DataType.VarChar,  Length=32),    Nullable]
		public string TradeNumber { get; set; } // varchar(32)

		/// <summary>
		/// ֧��������ʱ��
		/// </summary>
		[Column("PayTime",             DataType=DataType.DateTime),    Nullable]
		public DateTime? PayTime { get; set; } // datetime

		/// <summary>
		/// ֧����������Ϣ
		/// </summary>
		[Column("ExtInfo",             DataType=DataType.VarChar,  Length=10240),    Nullable]
		public string ExtInfo { get; set; } // varchar(10240)

		/// <summary>
		/// �����
		/// </summary>
		[Column("RequestId",           DataType=DataType.VarChar,  Length=32),    Nullable]
		public string RequestId { get; set; } // varchar(32)
	}

	/// <summary>
	/// ��������
	/// </summary>
	[Table("order_rule")]
	public partial class OrderRule : LinqToDBEntity
	{
		/// <summary>
		/// ȡ����ʼʱ��� ��ʽΪ HH:mm
		/// </summary>
		[Column("GetRangeStart",       DataType=DataType.VarChar,  Length=50),    Nullable]
		public string GetRangeStart { get; set; } // varchar(50)

		/// <summary>
		/// ȡ������ʱ��� ��ʽΪ HH:mm
		/// </summary>
		[Column("GetRangeEnd",         DataType=DataType.VarChar,  Length=50),    Nullable]
		public string GetRangeEnd { get; set; } // varchar(50)

		/// <summary>
		/// ��ȡ��ʼʱ��� ��ʽΪ HH:mm
		/// </summary>
		[Column("TakeRangeStart",      DataType=DataType.VarChar,  Length=50),    Nullable]
		public string TakeRangeStart { get; set; } // varchar(50)

		/// <summary>
		/// ��ȡ����ʱ��� ��ʽΪ HH:mm
		/// </summary>
		[Column("TakeRangeEnd",        DataType=DataType.VarChar,  Length=50),    Nullable]
		public string TakeRangeEnd { get; set; } // varchar(50)

		/// <summary>
		/// ��������
		/// </summary>
		[Column("DistrictTid",         DataType=DataType.Int64)   ,    Nullable]
		public long? DistrictTid { get; set; } // bigint(20)

		/// <summary>
		/// ��Ʒ����
		/// </summary>
		[Column("ProductTid",          DataType=DataType.Int64)   ,    Nullable]
		public long? ProductTid { get; set; } // bigint(20)

		/// <summary>
		/// ��ȡ�����ǵڶ���
		/// </summary>
		[Column("TakeMustNextDay",     DataType=DataType.Boolean) , NotNull]
		public bool TakeMustNextDay { get; set; } // tinyint(1)

		/// <summary>
		/// �Ƿ���Ч
		/// </summary>
		[Column("IsActive",            DataType=DataType.Boolean) , NotNull]
		public bool IsActive { get; set; } // tinyint(1)
	}

	/// <summary>
	/// ����״̬���ļ�¼��
	/// </summary>
	[Table("order_state_change")]
	public partial class OrderStateChange : LinqToDBEntity
	{
		/// <summary>
		/// ������Ϣ
		/// </summary>
		[Column("Info",                DataType=DataType.VarChar,  Length=2000),    Nullable]
		public string Info { get; set; } // varchar(2000)

		/// <summary>
		/// ������
		/// </summary>
		[Column("OrderId",             DataType=DataType.Int64)   ,    Nullable]
		public long? OrderId { get; set; } // bigint(20)

		/// <summary>
		/// �ı�ǰ״̬
		/// </summary>
		[Column("Befor",               DataType=DataType.Int32)   ,    Nullable]
		public int? Befor { get; set; } // int(11)

		/// <summary>
		/// �ı��״̬
		/// </summary>
		[Column("After",               DataType=DataType.Int32)   ,    Nullable]
		public int? After { get; set; } // int(11)

		/// <summary>
		/// 0��֧��ƽ̨ 1ϵͳ 2��Ӧ��ϵͳ 3����ϵͳ
		/// </summary>
		[Column("UserType",            DataType=DataType.Int32)   ,    Nullable]
		public int? UserType { get; set; } // int(11)

		/// <summary>
		/// ��Ӧ����ϵͳ���߹�Ӧ��ϵͳ�û���Tid
		/// </summary>
		[Column("UserTid",             DataType=DataType.Int64)   ,    Nullable]
		public long? UserTid { get; set; } // bigint(20)
	}

	/// <summary>
	/// ����ϵͳ�û���
	/// </summary>
	[Table("order_user")]
	public partial class OrderUser : LinqToDBEntity
	{
		/// <summary>
		/// �ǳ�
		/// </summary>
		[Column("NickName",            DataType=DataType.VarChar,  Length=30),    Nullable]
		public string NickName { get; set; } // varchar(30)

		/// <summary>
		/// �Ƿ����
		/// </summary>
		[Column("IsActive",            DataType=DataType.Boolean) , NotNull]
		public bool IsActive { get; set; } // tinyint(1)

		/// <summary>
		/// ��½�˺�
		/// </summary>
		[Column("UserName",            DataType=DataType.VarChar,  Length=20),    Nullable]
		public string UserName { get; set; } // varchar(20)

		/// <summary>
		/// ��½����
		/// </summary>
		[Column("Pwd",                 DataType=DataType.VarChar,  Length=20),    Nullable]
		public string Pwd { get; set; } // varchar(20)

		/// <summary>
		/// ����Tid
		/// </summary>
		[Column("DistrictTid",         DataType=DataType.Int64)   ,    Nullable]
		public long? DistrictTid { get; set; } // bigint(20)
	}

	/// <summary>
	/// ����ߴ�۸���ϸ����
	/// </summary>
	[Table("package_type")]
	public partial class PackageType : LinqToDBEntity
	{
		/// <summary>
		/// �������ߴ����Ƶ���Ϣ
		/// </summary>
		[Column("PackageName",         DataType=DataType.VarChar,  Length=50),    Nullable]
		public string PackageName { get; set; } // varchar(50)

		/// <summary>
		/// �۸�
		/// </summary>
		[Column("Price",               DataType=DataType.Decimal,  Precision=10, Scale=0),    Nullable]
		public decimal? Price { get; set; } // decimal(10,0)

		/// <summary>
		/// �г�����
		/// </summary>
		[Column("MarketPrice",         DataType=DataType.Decimal,  Precision=10, Scale=0),    Nullable]
		public decimal? MarketPrice { get; set; } // decimal(10,0)

		/// <summary>
		/// ����
		/// </summary>
		[Column("OrderRule",           DataType=DataType.Int32)   , NotNull]
		public int OrderRule { get; set; } // int(11)

		/// <summary>
		/// ��ע˵��
		/// </summary>
		[Column("Description",         DataType=DataType.VarChar,  Length=500),    Nullable]
		public string Description { get; set; } // varchar(500)
	}

	/// <summary>
	/// �ṩ�ķ����Ʒ��
	/// </summary>
	[Table("product")]
	public partial class Product : LinqToDBEntity
	{
		/// <summary>
		/// 1����վ 2������ 3�ӻ�վ 4�ӻ���
		/// </summary>
		[Column("Type",                DataType=DataType.Int32)   ,    Nullable]
		public int? Type { get; set; } // int(11)

		/// <summary>
		/// ����Tid
		/// </summary>
		[Column("DistrictTid",         DataType=DataType.Int64)   ,    Nullable]
		public long? DistrictTid { get; set; } // bigint(20)

		/// <summary>
		/// ����(����T1��վ¥)
		/// </summary>
		[Column("ProductName",         DataType=DataType.VarChar,  Length=100),    Nullable]
		public string ProductName { get; set; } // varchar(100)

		/// <summary>
		/// ������Ϣ
		/// </summary>
		[Column("Description",         DataType=DataType.VarChar,  Length=1000),    Nullable]
		public string Description { get; set; } // varchar(1000)

		/// <summary>
		/// �Ƿ���Ч
		/// </summary>
		[Column("IsActive",            DataType=DataType.Boolean) , NotNull]
		public bool IsActive { get; set; } // tinyint(1)

		/// <summary>
		/// ��������µ�ʱ��
		/// </summary>
		[Column("LastAcceptTime",      DataType=DataType.DateTime),    Nullable]
		public DateTime? LastAcceptTime { get; set; } // datetime

		/// <summary>
		/// ȡ�����ӷ�ʽJSON����
		/// </summary>
		[Column("GetTransfer",         DataType=DataType.VarChar,  Length=5000),    Nullable]
		public string GetTransfer { get; set; } // varchar(5000)

		/// <summary>
		/// �ռ����ӷ�ʽJSON����
		/// </summary>
		[Column("TakeTransfer",        DataType=DataType.VarChar,  Length=5000),    Nullable]
		public string TakeTransfer { get; set; } // varchar(5000)
	}

	/// <summary>
	/// ��Ʒ��Ӧ����ߴ�۸����ñ�
	/// </summary>
	[Table("product_package_type")]
	public partial class ProductPackageType : LinqToDBEntity
	{
		/// <summary>
		/// ��ƷTid
		/// </summary>
		[Column("ProductTid",          DataType=DataType.Int64)   ,    Nullable]
		public long? ProductTid { get; set; } // bigint(20)

		/// <summary>
		/// ��������Tid
		/// </summary>
		[Column("PackageTypeTid",      DataType=DataType.Int64)   ,    Nullable]
		public long? PackageTypeTid { get; set; } // bigint(20)

		/// <summary>
		/// �Ƿ���Ч
		/// </summary>
		[Column("IsActive",            DataType=DataType.Boolean) , NotNull]
		public bool IsActive { get; set; } // tinyint(1)
	}

	/// <summary>
	/// ��Ӧ�̱�
	/// </summary>
	[Table("provider")]
	public partial class Provider : LinqToDBEntity
	{
		/// <summary>
		/// ��Ӧ������
		/// </summary>
		[Column("Name",                DataType=DataType.VarChar,  Length=200),    Nullable]
		public string Name { get; set; } // varchar(200)

		/// <summary>
		/// ��ϸ��ַ
		/// </summary>
		[Column("Address",             DataType=DataType.VarChar,  Length=200),    Nullable]
		public string Address { get; set; } // varchar(200)

		/// <summary>
		/// ��ϵ������
		/// </summary>
		[Column("ContactName",         DataType=DataType.VarChar,  Length=20),    Nullable]
		public string ContactName { get; set; } // varchar(20)

		/// <summary>
		/// ��ϵ��ʽ
		/// </summary>
		[Column("ContactPhone",        DataType=DataType.VarChar,  Length=20),    Nullable]
		public string ContactPhone { get; set; } // varchar(20)

		/// <summary>
		/// ˵��
		/// </summary>
		[Column("Description",         DataType=DataType.VarChar,  Length=500),    Nullable]
		public string Description { get; set; } // varchar(500)

		/// <summary>
		/// �Ƿ����
		/// </summary>
		[Column("IsActive",            DataType=DataType.Boolean) , NotNull]
		public bool IsActive { get; set; } // tinyint(1)

		/// <summary>
		/// ���ʵ�Json Web Token
		/// </summary>
		[Column("AccessJWT",           DataType=DataType.VarChar,  Length=10480),    Nullable]
		public string AccessJWT { get; set; } // varchar(10480)

		/// <summary>
		/// ������
		/// </summary>
		[Column("Code",                DataType=DataType.Int64)   ,    Nullable]
		public long? Code { get; set; } // bigint(20)
	}

	/// <summary>
	/// ��Ӧ�̶�����
	/// </summary>
	[Table("provider_order")]
	public partial class ProviderOrder : LinqToDBEntity
	{
		/// <summary>
		/// ��Ӧ��Tid
		/// </summary>
		[Column("ProviderTid",         DataType=DataType.Int64)   ,    Nullable]
		public long? ProviderTid { get; set; } // bigint(20)

		/// <summary>
		/// �û�Uid
		/// </summary>
		[Column("Uid",                 DataType=DataType.VarChar,  Length=36),    Nullable]
		public string Uid { get; set; } // varchar(36)

		/// <summary>
		/// �û�����
		/// </summary>
		[Column("UserName",            DataType=DataType.VarChar,  Length=50),    Nullable]
		public string UserName { get; set; } // varchar(50)

		/// <summary>
		/// �û��ֻ���
		/// </summary>
		[Column("UserPhone",           DataType=DataType.Char,     Length=24),    Nullable]
		public string UserPhone { get; set; } // char(24)

		/// <summary>
		/// ȡ������Tid
		/// </summary>
		[Column("LocationTid",         DataType=DataType.Int64)   ,    Nullable]
		public long? LocationTid { get; set; } // bigint(20)

		/// <summary>
		/// ȡ����ϸ��ַ
		/// </summary>
		[Column("LocationDetail",      DataType=DataType.VarChar,  Length=250),    Nullable]
		public string LocationDetail { get; set; } // varchar(250)

		/// <summary>
		/// ȡ��ʱ��
		/// </summary>
		[Column("GetTime",             DataType=DataType.DateTime),    Nullable]
		public DateTime? GetTime { get; set; } // datetime

		/// <summary>
		/// ȡ�����ӷ�ʽ
		/// </summary>
		[Column("GetTransferTid",      DataType=DataType.VarChar,  Length=250),    Nullable]
		public string GetTransferTid { get; set; } // varchar(250)

		/// <summary>
		/// ȡ������( 0���� 1�� 2����)
		/// </summary>
		[Column("GetType",             DataType=DataType.Int32)   ,    Nullable]
		public int? GetType { get; set; } // int(11)

		/// <summary>
		/// �ռ�����Tid
		/// </summary>
		[Column("DestinationTid",      DataType=DataType.Int64)   ,    Nullable]
		public long? DestinationTid { get; set; } // bigint(20)

		/// <summary>
		/// �ռ���ϸ��ַ
		/// </summary>
		[Column("DestinationDetail",   DataType=DataType.VarChar,  Length=250),    Nullable]
		public string DestinationDetail { get; set; } // varchar(250)

		/// <summary>
		/// �ռ�ʱ��
		/// </summary>
		[Column("TakeTime",            DataType=DataType.DateTime),    Nullable]
		public DateTime? TakeTime { get; set; } // datetime

		/// <summary>
		/// �ռ����ӷ�ʽ
		/// </summary>
		[Column("TakeTransferTid",     DataType=DataType.VarChar,  Length=250),    Nullable]
		public string TakeTransferTid { get; set; } // varchar(250)

		/// <summary>
		/// �ռ�����( 0���� 1�� 2����)
		/// </summary>
		[Column("TakeType",            DataType=DataType.Int32)   ,    Nullable]
		public int? TakeType { get; set; } // int(11)

		/// <summary>
		/// ����
		/// </summary>
		[Column("Remark",              DataType=DataType.VarChar,  Length=500),    Nullable]
		public string Remark { get; set; } // varchar(500)

		/// <summary>
		/// ��ƷTid
		/// </summary>
		[Column("ProductTid",          DataType=DataType.Int64)   ,    Nullable]
		public long? ProductTid { get; set; } // bigint(20)

		/// <summary>
		/// ������
		/// </summary>
		[Column("OrderId",             DataType=DataType.Int64)   ,    Nullable]
		public long? OrderId { get; set; } // bigint(20)

		/// <summary>
		/// �����۸�
		/// </summary>
		[Column("OrderPrice",          DataType=DataType.Decimal,  Precision=10, Scale=3),    Nullable]
		public decimal? OrderPrice { get; set; } // decimal(10,3)

		/// <summary>
		/// ����״̬��1�������2������ȡ��3�������С�4�����ʹ5���ѳɽ���9����ȡ��
		/// </summary>
		[Column("OrderState",          DataType=DataType.Int32)   ,    Nullable]
		public int? OrderState { get; set; } // int(11)

		/// <summary>
		/// ��������ʱ��
		/// </summary>
		[Column("CreateTime",          DataType=DataType.DateTime),    Nullable]
		public DateTime? CreateTime { get; set; } // datetime

		/// <summary>
		/// ���۽��
		/// </summary>
		[Column("InsuranceFee",        DataType=DataType.Decimal,  Precision=10, Scale=3),    Nullable]
		public decimal? InsuranceFee { get; set; } // decimal(10,3)

		/// <summary>
		/// ����Tid
		/// </summary>
		[Column("InsuranceTid",        DataType=DataType.Int64)   ,    Nullable]
		public long? InsuranceTid { get; set; } // bigint(20)

		/// <summary>
		/// �Ƿ��ʡ
		/// </summary>
		[Column("isOutside",           DataType=DataType.Boolean) , NotNull]
		public bool IsOutside { get; set; } // tinyint(1)

		/// <summary>
		/// ֧��״̬��1:�����2���Ѹ��3�����˿4�������5��֧��ʧ�ܣ�6�����˿7��֧������
		/// </summary>
		[Column("PayState",            DataType=DataType.Int32)   ,    Nullable]
		public int? PayState { get; set; } // int(11)

		/// <summary>
		/// app�汾��
		/// </summary>
		[Column("AppVersion",          DataType=DataType.VarChar,  Length=50),    Nullable]
		public string AppVersion { get; set; } // varchar(50)

		/// <summary>
		/// ����
		/// </summary>
		[Column("Channel",             DataType=DataType.Int32)   ,    Nullable]
		public int? Channel { get; set; } // int(11)

		/// <summary>
		/// ���֧��ʱ��
		/// </summary>
		[Column("LastPayTime",         DataType=DataType.DateTime),    Nullable]
		public DateTime? LastPayTime { get; set; } // datetime

		/// <summary>
		/// �ն�����
		/// </summary>
		[Column("Terminal",            DataType=DataType.Int32)   ,    Nullable]
		public int? Terminal { get; set; } // int(11)

		/// <summary>
		/// ȡ����
		/// </summary>
		[Column("TakeCode",            DataType=DataType.Int64)   ,    Nullable]
		public long? TakeCode { get; set; } // bigint(20)

		/// <summary>
		/// �û��Ƿ�ɾ��
		/// </summary>
		[Column("IsActive",            DataType=DataType.Boolean) , NotNull]
		public bool IsActive { get; set; } // tinyint(1)

		/// <summary>
		/// �û�����
		/// </summary>
		[Column("Email",               DataType=DataType.VarChar,  Length=50),    Nullable]
		public string Email { get; set; } // varchar(50)

		/// <summary>
		/// �û����֤�Ż��߻��պ�
		/// </summary>
		[Column("CardNo",              DataType=DataType.VarChar,  Length=50),    Nullable]
		public string CardNo { get; set; } // varchar(50)

		/// <summary>
		/// �������� 1����վ 2������ 3�ӻ�վ 4�ӻ���
		/// </summary>
		[Column("ServiceType",         DataType=DataType.Int32)   ,    Nullable]
		public int? ServiceType { get; set; } // int(11)
	}

	/// <summary>
	/// ��Ӧ���ṩ�ķ����Ʒ��
	/// </summary>
	[Table("provider_product")]
	public partial class ProviderProduct : LinqToDBEntity
	{
		/// <summary>
		/// ����Tid
		/// </summary>
		[Column("ProductTid",          DataType=DataType.Int64)   ,    Nullable]
		public long? ProductTid { get; set; } // bigint(20)

		/// <summary>
		/// ��Ӧ��Tid
		/// </summary>
		[Column("ProviderTid",         DataType=DataType.Int64)   ,    Nullable]
		public long? ProviderTid { get; set; } // bigint(20)

		/// <summary>
		/// �Ƿ���Ч
		/// </summary>
		[Column("IsActive",            DataType=DataType.Boolean) , NotNull]
		public bool IsActive { get; set; } // tinyint(1)

		/// <summary>
		/// ��ϵ������
		/// </summary>
		[Column("ContactName",         DataType=DataType.VarChar,  Length=20),    Nullable]
		public string ContactName { get; set; } // varchar(20)

		/// <summary>
		/// ��ϵ��ʽ
		/// </summary>
		[Column("ContactPhone",        DataType=DataType.VarChar,  Length=20),    Nullable]
		public string ContactPhone { get; set; } // varchar(20)

		/// <summary>
		/// ��������µ�ʱ��
		/// </summary>
		[Column("LastAcceptTime",      DataType=DataType.DateTime),    Nullable]
		public DateTime? LastAcceptTime { get; set; } // datetime
	}

	/// <summary>
	/// ��Ӧ���û���
	/// </summary>
	[Table("provider_user")]
	public partial class ProviderUser : LinqToDBEntity
	{
		/// <summary>
		/// �ǳ�
		/// </summary>
		[Column("NickName",            DataType=DataType.VarChar,  Length=30),    Nullable]
		public string NickName { get; set; } // varchar(30)

		/// <summary>
		/// �Ƿ����
		/// </summary>
		[Column("IsActive",            DataType=DataType.Boolean) , NotNull]
		public bool IsActive { get; set; } // tinyint(1)

		/// <summary>
		/// ��½�˺�
		/// </summary>
		[Column("UserName",            DataType=DataType.VarChar,  Length=20),    Nullable]
		public string UserName { get; set; } // varchar(20)

		/// <summary>
		/// ��½����
		/// </summary>
		[Column("Pwd",                 DataType=DataType.VarChar,  Length=20),    Nullable]
		public string Pwd { get; set; } // varchar(20)

		/// <summary>
		/// ��Ӧ��
		/// </summary>
		[Column("Providers",           DataType=DataType.VarChar,  Length=200),    Nullable]
		public string Providers { get; set; } // varchar(200)
	}

	[Table("system_menu")]
	public partial class SystemMenu : LinqToDBEntity
	{
		/// <summary>
		/// �Ƿ����
		/// </summary>
		[Column("IsActive",            DataType=DataType.Boolean) , NotNull]
		public bool IsActive { get; set; } // tinyint(1)

		/// <summary>
		/// ���ڵ�Id
		/// </summary>
		[Column("ParentTid",           DataType=DataType.Int64)   , NotNull]
		public long ParentTid { get; set; } // bigint(20)

		/// <summary>
		/// ����
		/// </summary>
		[Column("Name",                DataType=DataType.VarChar,  Length=50),    Nullable]
		public string Name { get; set; } // varchar(50)

		/// <summary>
		/// չʾ��ͼ��
		/// </summary>
		[Column("Ico",                 DataType=DataType.VarChar,  Length=100),    Nullable]
		public string Ico { get; set; } // varchar(100)

		/// <summary>
		/// ���ӵ�ַ
		/// </summary>
		[Column("Url",                 DataType=DataType.VarChar,  Length=200),    Nullable]
		public string Url { get; set; } // varchar(200)

		/// <summary>
		/// ����
		/// </summary>
		[Column("OrderRule",           DataType=DataType.Int32)   ,    Nullable]
		public int? OrderRule { get; set; } // int(11)

		/// <summary>
		/// ����
		/// </summary>
		[Column("MenuType",            DataType=DataType.Int32)   ,    Nullable]
		public int? MenuType { get; set; } // int(11)

		/// <summary>
		/// ��ʽ
		/// </summary>
		[Column("Class",               DataType=DataType.VarChar,  Length=100),    Nullable]
		public string Class { get; set; } // varchar(100)
	}

	[Table("system_role")]
	public partial class SystemRole : LinqToDBEntity
	{
		/// <summary>
		/// ��ɫ����
		/// </summary>
		[Column("RoleName",            DataType=DataType.VarChar,  Length=100),    Nullable]
		public string RoleName { get; set; } // varchar(100)

		/// <summary>
		/// ����
		/// </summary>
		[Column("Description",         DataType=DataType.VarChar,  Length=200),    Nullable]
		public string Description { get; set; } // varchar(200)

		/// <summary>
		/// �Ƿ����
		/// </summary>
		[Column("IsActive",            DataType=DataType.Boolean) , NotNull]
		public bool IsActive { get; set; } // tinyint(1)

		/// <summary>
		/// �˵�Ȩ��
		/// </summary>
		[Column("MenuRights",          DataType=DataType.VarChar,  Length=50),    Nullable]
		public string MenuRights { get; set; } // varchar(50)
	}

	[Table("system_user")]
	public partial class SystemUser : LinqToDBEntity
	{
		/// <summary>
		/// �Ƿ����
		/// </summary>
		[Column("IsActive",            DataType=DataType.Boolean) , NotNull]
		public bool IsActive { get; set; } // tinyint(1)

		/// <summary>
		/// ��½��
		/// </summary>
		[Column("Eid",                 DataType=DataType.VarChar,  Length=36),    Nullable]
		public string Eid { get; set; } // varchar(36)

		/// <summary>
		/// �û���
		/// </summary>
		[Column("UserName",            DataType=DataType.VarChar,  Length=50),    Nullable]
		public string UserName { get; set; } // varchar(50)

		/// <summary>
		/// ����
		/// </summary>
		[Column("Pwd",                 DataType=DataType.VarChar,  Length=20),    Nullable]
		public string Pwd { get; set; } // varchar(20)

		/// <summary>
		/// �ֻ���
		/// </summary>
		[Column("Phone",               DataType=DataType.VarChar,  Length=20),    Nullable]
		public string Phone { get; set; } // varchar(20)

		/// <summary>
		/// ��½IP
		/// </summary>
		[Column("LoginIp",             DataType=DataType.VarChar,  Length=30),    Nullable]
		public string LoginIp { get; set; } // varchar(30)

		/// <summary>
		/// �˵�Ȩ��
		/// </summary>
		[Column("MenuRights",          DataType=DataType.VarChar,  Length=50),    Nullable]
		public string MenuRights { get; set; } // varchar(50)

		/// <summary>
		/// ��ɫTid(һ����ֻ��һ����ɫ)
		/// </summary>
		[Column("RoleTid",             DataType=DataType.Int64)   ,    Nullable]
		public long? RoleTid { get; set; } // bigint(20)

		/// <summary>
		/// ����¼ϵͳʱ��
		/// </summary>
		[Column("LastLoginTime",       DataType=DataType.DateTime),    Nullable]
		public DateTime? LastLoginTime { get; set; } // datetime

		/// <summary>
		/// ��¼���������Ϣ
		/// </summary>
		[Column("UserAgent",           DataType=DataType.VarChar,  Length=500),    Nullable]
		public string UserAgent { get; set; } // varchar(500)
	}

	/// <summary>
	/// ���ӷ�ʽ���ñ�
	/// </summary>
	[Table("transfer_type")]
	public partial class TransferType : LinqToDBEntity
	{
		/// <summary>
		/// 1��ȡ���� 2��ȡ����
		/// </summary>
		[Column("Type",                DataType=DataType.Int32)   ,    Nullable]
		public int? Type { get; set; } // int(11)

		/// <summary>
		/// ���ӷ�ʽ
		/// </summary>
		[Column("Transfer",            DataType=DataType.VarChar,  Length=50),    Nullable]
		public string Transfer { get; set; } // varchar(50)

		/// <summary>
		/// ��ע��Ϣ
		/// </summary>
		[Column("Description",         DataType=DataType.VarChar,  Length=200),    Nullable]
		public string Description { get; set; } // varchar(200)

		/// <summary>
		/// ��ƷTid
		/// </summary>
		[Column("ProductTid",          DataType=DataType.Int64)   ,    Nullable]
		public long? ProductTid { get; set; } // bigint(20)

		/// <summary>
		/// �Ƿ���Ч
		/// </summary>
		[Column("IsActive",            DataType=DataType.Boolean) , NotNull]
		public bool IsActive { get; set; } // tinyint(1)

		/// <summary>
		/// ��������
		/// </summary>
		[Column("DistinctTid",         DataType=DataType.Int64)   ,    Nullable]
		public long? DistinctTid { get; set; } // bigint(20)

		/// <summary>
		/// ȡ�����ӷ�ʽJSON����
		/// </summary>
		[Column("GetTransfer",         DataType=DataType.VarChar,  Length=5000),    Nullable]
		public string GetTransfer { get; set; } // varchar(5000)

		/// <summary>
		/// �ռ����ӷ�ʽJSON����
		/// </summary>
		[Column("TakeTransfer",        DataType=DataType.VarChar,  Length=5000),    Nullable]
		public string TakeTransfer { get; set; } // varchar(5000)
	}
}

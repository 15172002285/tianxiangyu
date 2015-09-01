﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Sample_5.ORM
{
    #region 上下文
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    public partial class ChannelContainer : ObjectContext
    {
        #region 构造函数
    
        /// <summary>
        /// 请使用应用程序配置文件的“ChannelContainer”部分中的连接字符串初始化新 ChannelContainer 对象。
        /// </summary>
        public ChannelContainer() : base("name=ChannelContainer", "ChannelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 ChannelContainer 对象。
        /// </summary>
        public ChannelContainer(string connectionString) : base(connectionString, "ChannelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 ChannelContainer 对象。
        /// </summary>
        public ChannelContainer(EntityConnection connection) : base(connection, "ChannelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region 分部方法
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet 属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<Channel> Channel
        {
            get
            {
                if ((_Channel == null))
                {
                    _Channel = base.CreateObjectSet<Channel>("Channel");
                }
                return _Channel;
            }
        }
        private ObjectSet<Channel> _Channel;
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<ChannelType> ChannelType
        {
            get
            {
                if ((_ChannelType == null))
                {
                    _ChannelType = base.CreateObjectSet<ChannelType>("ChannelType");
                }
                return _ChannelType;
            }
        }
        private ObjectSet<ChannelType> _ChannelType;
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<ChannelScan> ChannelScan
        {
            get
            {
                if ((_ChannelScan == null))
                {
                    _ChannelScan = base.CreateObjectSet<ChannelScan>("ChannelScan");
                }
                return _ChannelScan;
            }
        }
        private ObjectSet<ChannelScan> _ChannelScan;
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<WeixinUserInfo> WeixinUserInfo
        {
            get
            {
                if ((_WeixinUserInfo == null))
                {
                    _WeixinUserInfo = base.CreateObjectSet<WeixinUserInfo>("WeixinUserInfo");
                }
                return _WeixinUserInfo;
            }
        }
        private ObjectSet<WeixinUserInfo> _WeixinUserInfo;

        #endregion

        #region AddTo 方法
    
        /// <summary>
        /// 用于向 Channel EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToChannel(Channel channel)
        {
            base.AddObject("Channel", channel);
        }
    
        /// <summary>
        /// 用于向 ChannelType EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToChannelType(ChannelType channelType)
        {
            base.AddObject("ChannelType", channelType);
        }
    
        /// <summary>
        /// 用于向 ChannelScan EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToChannelScan(ChannelScan channelScan)
        {
            base.AddObject("ChannelScan", channelScan);
        }
    
        /// <summary>
        /// 用于向 WeixinUserInfo EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToWeixinUserInfo(WeixinUserInfo weixinUserInfo)
        {
            base.AddObject("WeixinUserInfo", weixinUserInfo);
        }

        #endregion

    }

    #endregion

    #region 实体
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Channel", Name="Channel")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Channel : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 Channel 对象。
        /// </summary>
        /// <param name="id">ID 属性的初始值。</param>
        /// <param name="sceneId">SceneId 属性的初始值。</param>
        /// <param name="channelTypeId">ChannelTypeId 属性的初始值。</param>
        /// <param name="name">Name 属性的初始值。</param>
        /// <param name="qrcode">Qrcode 属性的初始值。</param>
        public static Channel CreateChannel(global::System.Int32 id, global::System.Int32 sceneId, global::System.Int32 channelTypeId, global::System.String name, global::System.String qrcode)
        {
            Channel channel = new Channel();
            channel.ID = id;
            channel.SceneId = sceneId;
            channel.ChannelTypeId = channelTypeId;
            channel.Name = name;
            channel.Qrcode = qrcode;
            return channel;
        }

        #endregion

        #region 简单属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value, "ID");
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 SceneId
        {
            get
            {
                return _SceneId;
            }
            set
            {
                OnSceneIdChanging(value);
                ReportPropertyChanging("SceneId");
                _SceneId = StructuralObject.SetValidValue(value, "SceneId");
                ReportPropertyChanged("SceneId");
                OnSceneIdChanged();
            }
        }
        private global::System.Int32 _SceneId;
        partial void OnSceneIdChanging(global::System.Int32 value);
        partial void OnSceneIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ChannelTypeId
        {
            get
            {
                return _ChannelTypeId;
            }
            set
            {
                OnChannelTypeIdChanging(value);
                ReportPropertyChanging("ChannelTypeId");
                _ChannelTypeId = StructuralObject.SetValidValue(value, "ChannelTypeId");
                ReportPropertyChanged("ChannelTypeId");
                OnChannelTypeIdChanged();
            }
        }
        private global::System.Int32 _ChannelTypeId;
        partial void OnChannelTypeIdChanging(global::System.Int32 value);
        partial void OnChannelTypeIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Qrcode
        {
            get
            {
                return _Qrcode;
            }
            set
            {
                OnQrcodeChanging(value);
                ReportPropertyChanging("Qrcode");
                _Qrcode = StructuralObject.SetValidValue(value, false, "Qrcode");
                ReportPropertyChanged("Qrcode");
                OnQrcodeChanged();
            }
        }
        private global::System.String _Qrcode;
        partial void OnQrcodeChanging(global::System.String value);
        partial void OnQrcodeChanged();

        #endregion

    }
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Channel", Name="ChannelScan")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ChannelScan : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 ChannelScan 对象。
        /// </summary>
        /// <param name="id">ID 属性的初始值。</param>
        /// <param name="openId">OpenId 属性的初始值。</param>
        /// <param name="scanType">ScanType 属性的初始值。</param>
        /// <param name="channelId">ChannelId 属性的初始值。</param>
        /// <param name="scanTime">ScanTime 属性的初始值。</param>
        public static ChannelScan CreateChannelScan(global::System.Int32 id, global::System.String openId, global::System.Int16 scanType, global::System.Int32 channelId, global::System.DateTime scanTime)
        {
            ChannelScan channelScan = new ChannelScan();
            channelScan.ID = id;
            channelScan.OpenId = openId;
            channelScan.ScanType = scanType;
            channelScan.ChannelId = channelId;
            channelScan.ScanTime = scanTime;
            return channelScan;
        }

        #endregion

        #region 简单属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value, "ID");
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String OpenId
        {
            get
            {
                return _OpenId;
            }
            set
            {
                OnOpenIdChanging(value);
                ReportPropertyChanging("OpenId");
                _OpenId = StructuralObject.SetValidValue(value, false, "OpenId");
                ReportPropertyChanged("OpenId");
                OnOpenIdChanged();
            }
        }
        private global::System.String _OpenId;
        partial void OnOpenIdChanging(global::System.String value);
        partial void OnOpenIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 ScanType
        {
            get
            {
                return _ScanType;
            }
            set
            {
                OnScanTypeChanging(value);
                ReportPropertyChanging("ScanType");
                _ScanType = StructuralObject.SetValidValue(value, "ScanType");
                ReportPropertyChanged("ScanType");
                OnScanTypeChanged();
            }
        }
        private global::System.Int16 _ScanType;
        partial void OnScanTypeChanging(global::System.Int16 value);
        partial void OnScanTypeChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ChannelId
        {
            get
            {
                return _ChannelId;
            }
            set
            {
                OnChannelIdChanging(value);
                ReportPropertyChanging("ChannelId");
                _ChannelId = StructuralObject.SetValidValue(value, "ChannelId");
                ReportPropertyChanged("ChannelId");
                OnChannelIdChanged();
            }
        }
        private global::System.Int32 _ChannelId;
        partial void OnChannelIdChanging(global::System.Int32 value);
        partial void OnChannelIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime ScanTime
        {
            get
            {
                return _ScanTime;
            }
            set
            {
                OnScanTimeChanging(value);
                ReportPropertyChanging("ScanTime");
                _ScanTime = StructuralObject.SetValidValue(value, "ScanTime");
                ReportPropertyChanged("ScanTime");
                OnScanTimeChanged();
            }
        }
        private global::System.DateTime _ScanTime;
        partial void OnScanTimeChanging(global::System.DateTime value);
        partial void OnScanTimeChanged();

        #endregion

    }
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Channel", Name="ChannelType")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ChannelType : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 ChannelType 对象。
        /// </summary>
        /// <param name="id">ID 属性的初始值。</param>
        /// <param name="name">Name 属性的初始值。</param>
        public static ChannelType CreateChannelType(global::System.Int32 id, global::System.String name)
        {
            ChannelType channelType = new ChannelType();
            channelType.ID = id;
            channelType.Name = name;
            return channelType;
        }

        #endregion

        #region 简单属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value, "ID");
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion

    }
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Channel", Name="WeixinUserInfo")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class WeixinUserInfo : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 WeixinUserInfo 对象。
        /// </summary>
        /// <param name="openId">OpenId 属性的初始值。</param>
        /// <param name="nickName">NickName 属性的初始值。</param>
        /// <param name="headImgUrl">HeadImgUrl 属性的初始值。</param>
        /// <param name="language">Language 属性的初始值。</param>
        /// <param name="sex">Sex 属性的初始值。</param>
        /// <param name="city">City 属性的初始值。</param>
        /// <param name="province">Province 属性的初始值。</param>
        /// <param name="country">Country 属性的初始值。</param>
        /// <param name="subscribe_time">Subscribe_time 属性的初始值。</param>
        /// <param name="id">ID 属性的初始值。</param>
        public static WeixinUserInfo CreateWeixinUserInfo(global::System.String openId, global::System.String nickName, global::System.String headImgUrl, global::System.String language, global::System.Int16 sex, global::System.String city, global::System.String province, global::System.String country, global::System.Int64 subscribe_time, global::System.Int32 id)
        {
            WeixinUserInfo weixinUserInfo = new WeixinUserInfo();
            weixinUserInfo.OpenId = openId;
            weixinUserInfo.NickName = nickName;
            weixinUserInfo.HeadImgUrl = headImgUrl;
            weixinUserInfo.Language = language;
            weixinUserInfo.Sex = sex;
            weixinUserInfo.City = city;
            weixinUserInfo.Province = province;
            weixinUserInfo.Country = country;
            weixinUserInfo.Subscribe_time = subscribe_time;
            weixinUserInfo.ID = id;
            return weixinUserInfo;
        }

        #endregion

        #region 简单属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String OpenId
        {
            get
            {
                return _OpenId;
            }
            set
            {
                OnOpenIdChanging(value);
                ReportPropertyChanging("OpenId");
                _OpenId = StructuralObject.SetValidValue(value, false, "OpenId");
                ReportPropertyChanged("OpenId");
                OnOpenIdChanged();
            }
        }
        private global::System.String _OpenId;
        partial void OnOpenIdChanging(global::System.String value);
        partial void OnOpenIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String NickName
        {
            get
            {
                return _NickName;
            }
            set
            {
                OnNickNameChanging(value);
                ReportPropertyChanging("NickName");
                _NickName = StructuralObject.SetValidValue(value, false, "NickName");
                ReportPropertyChanged("NickName");
                OnNickNameChanged();
            }
        }
        private global::System.String _NickName;
        partial void OnNickNameChanging(global::System.String value);
        partial void OnNickNameChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String HeadImgUrl
        {
            get
            {
                return _HeadImgUrl;
            }
            set
            {
                OnHeadImgUrlChanging(value);
                ReportPropertyChanging("HeadImgUrl");
                _HeadImgUrl = StructuralObject.SetValidValue(value, false, "HeadImgUrl");
                ReportPropertyChanged("HeadImgUrl");
                OnHeadImgUrlChanged();
            }
        }
        private global::System.String _HeadImgUrl;
        partial void OnHeadImgUrlChanging(global::System.String value);
        partial void OnHeadImgUrlChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Language
        {
            get
            {
                return _Language;
            }
            set
            {
                OnLanguageChanging(value);
                ReportPropertyChanging("Language");
                _Language = StructuralObject.SetValidValue(value, false, "Language");
                ReportPropertyChanged("Language");
                OnLanguageChanged();
            }
        }
        private global::System.String _Language;
        partial void OnLanguageChanging(global::System.String value);
        partial void OnLanguageChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int16 Sex
        {
            get
            {
                return _Sex;
            }
            set
            {
                OnSexChanging(value);
                ReportPropertyChanging("Sex");
                _Sex = StructuralObject.SetValidValue(value, "Sex");
                ReportPropertyChanged("Sex");
                OnSexChanged();
            }
        }
        private global::System.Int16 _Sex;
        partial void OnSexChanging(global::System.Int16 value);
        partial void OnSexChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, false, "City");
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Province
        {
            get
            {
                return _Province;
            }
            set
            {
                OnProvinceChanging(value);
                ReportPropertyChanging("Province");
                _Province = StructuralObject.SetValidValue(value, false, "Province");
                ReportPropertyChanged("Province");
                OnProvinceChanged();
            }
        }
        private global::System.String _Province;
        partial void OnProvinceChanging(global::System.String value);
        partial void OnProvinceChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Country
        {
            get
            {
                return _Country;
            }
            set
            {
                OnCountryChanging(value);
                ReportPropertyChanging("Country");
                _Country = StructuralObject.SetValidValue(value, false, "Country");
                ReportPropertyChanged("Country");
                OnCountryChanged();
            }
        }
        private global::System.String _Country;
        partial void OnCountryChanging(global::System.String value);
        partial void OnCountryChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Subscribe_time
        {
            get
            {
                return _Subscribe_time;
            }
            set
            {
                OnSubscribe_timeChanging(value);
                ReportPropertyChanging("Subscribe_time");
                _Subscribe_time = StructuralObject.SetValidValue(value, "Subscribe_time");
                ReportPropertyChanged("Subscribe_time");
                OnSubscribe_timeChanged();
            }
        }
        private global::System.Int64 _Subscribe_time;
        partial void OnSubscribe_timeChanging(global::System.Int64 value);
        partial void OnSubscribe_timeChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value, "ID");
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();

        #endregion

    }

    #endregion

}
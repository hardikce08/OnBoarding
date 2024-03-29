﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
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
namespace CU.OnBoarding.Model
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class OnBoardingEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new OnBoardingEntities object using the connection string found in the 'OnBoardingEntities' section of the application configuration file.
        /// </summary>
        public OnBoardingEntities() : base("name=OnBoardingEntities", "OnBoardingEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new OnBoardingEntities object.
        /// </summary>
        public OnBoardingEntities(string connectionString) : base(connectionString, "OnBoardingEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new OnBoardingEntities object.
        /// </summary>
        public OnBoardingEntities(EntityConnection connection) : base(connection, "OnBoardingEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<User> Users
        {
            get
            {
                if ((_Users == null))
                {
                    _Users = base.CreateObjectSet<User>("Users");
                }
                return _Users;
            }
        }
        private ObjectSet<User> _Users;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<DaysConfiguration> DaysConfiguration
        {
            get
            {
                if ((_DaysConfiguration == null))
                {
                    _DaysConfiguration = base.CreateObjectSet<DaysConfiguration>("DaysConfiguration");
                }
                return _DaysConfiguration;
            }
        }
        private ObjectSet<DaysConfiguration> _DaysConfiguration;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ListConfiguration> ListConfiguration
        {
            get
            {
                if ((_ListConfiguration == null))
                {
                    _ListConfiguration = base.CreateObjectSet<ListConfiguration>("ListConfiguration");
                }
                return _ListConfiguration;
            }
        }
        private ObjectSet<ListConfiguration> _ListConfiguration;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<OtherConfiguration> OtherConfiguration
        {
            get
            {
                if ((_OtherConfiguration == null))
                {
                    _OtherConfiguration = base.CreateObjectSet<OtherConfiguration>("OtherConfiguration");
                }
                return _OtherConfiguration;
            }
        }
        private ObjectSet<OtherConfiguration> _OtherConfiguration;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<EmailTemplate> EmailTemplate
        {
            get
            {
                if ((_EmailTemplate == null))
                {
                    _EmailTemplate = base.CreateObjectSet<EmailTemplate>("EmailTemplate");
                }
                return _EmailTemplate;
            }
        }
        private ObjectSet<EmailTemplate> _EmailTemplate;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsers(User user)
        {
            base.AddObject("Users", user);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the DaysConfiguration EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDaysConfiguration(DaysConfiguration daysConfiguration)
        {
            base.AddObject("DaysConfiguration", daysConfiguration);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ListConfiguration EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToListConfiguration(ListConfiguration listConfiguration)
        {
            base.AddObject("ListConfiguration", listConfiguration);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the OtherConfiguration EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToOtherConfiguration(OtherConfiguration otherConfiguration)
        {
            base.AddObject("OtherConfiguration", otherConfiguration);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the EmailTemplate EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmailTemplate(EmailTemplate emailTemplate)
        {
            base.AddObject("EmailTemplate", emailTemplate);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="OnBoardingModel", Name="DaysConfiguration")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class DaysConfiguration : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new DaysConfiguration object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="userId">Initial value of the UserId property.</param>
        /// <param name="createdDate">Initial value of the CreatedDate property.</param>
        public static DaysConfiguration CreateDaysConfiguration(global::System.Int32 id, global::System.Int32 userId, global::System.DateTime createdDate)
        {
            DaysConfiguration daysConfiguration = new DaysConfiguration();
            daysConfiguration.Id = id;
            daysConfiguration.UserId = userId;
            daysConfiguration.CreatedDate = createdDate;
            return daysConfiguration;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                OnUserIdChanging(value);
                ReportPropertyChanging("UserId");
                _UserId = StructuralObject.SetValidValue(value, "UserId");
                ReportPropertyChanged("UserId");
                OnUserIdChanged();
            }
        }
        private global::System.Int32 _UserId;
        partial void OnUserIdChanging(global::System.Int32 value);
        partial void OnUserIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Day
        {
            get
            {
                return _Day;
            }
            set
            {
                OnDayChanging(value);
                ReportPropertyChanging("Day");
                _Day = StructuralObject.SetValidValue(value, "Day");
                ReportPropertyChanged("Day");
                OnDayChanged();
            }
        }
        private Nullable<global::System.Int32> _Day;
        partial void OnDayChanging(Nullable<global::System.Int32> value);
        partial void OnDayChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Value
        {
            get
            {
                return _Value;
            }
            set
            {
                OnValueChanging(value);
                ReportPropertyChanging("Value");
                _Value = StructuralObject.SetValidValue(value, true, "Value");
                ReportPropertyChanged("Value");
                OnValueChanged();
            }
        }
        private global::System.String _Value;
        partial void OnValueChanging(global::System.String value);
        partial void OnValueChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreatedDate
        {
            get
            {
                return _CreatedDate;
            }
            set
            {
                OnCreatedDateChanging(value);
                ReportPropertyChanging("CreatedDate");
                _CreatedDate = StructuralObject.SetValidValue(value, "CreatedDate");
                ReportPropertyChanged("CreatedDate");
                OnCreatedDateChanged();
            }
        }
        private global::System.DateTime _CreatedDate;
        partial void OnCreatedDateChanging(global::System.DateTime value);
        partial void OnCreatedDateChanged();

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="OnBoardingModel", Name="EmailTemplate")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class EmailTemplate : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new EmailTemplate object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="createdDate">Initial value of the CreatedDate property.</param>
        public static EmailTemplate CreateEmailTemplate(global::System.Int32 id, global::System.String name, global::System.DateTime createdDate)
        {
            EmailTemplate emailTemplate = new EmailTemplate();
            emailTemplate.Id = id;
            emailTemplate.Name = name;
            emailTemplate.CreatedDate = createdDate;
            return emailTemplate;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
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
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SenderName
        {
            get
            {
                return _SenderName;
            }
            set
            {
                OnSenderNameChanging(value);
                ReportPropertyChanging("SenderName");
                _SenderName = StructuralObject.SetValidValue(value, true, "SenderName");
                ReportPropertyChanged("SenderName");
                OnSenderNameChanged();
            }
        }
        private global::System.String _SenderName;
        partial void OnSenderNameChanging(global::System.String value);
        partial void OnSenderNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SenderEmail
        {
            get
            {
                return _SenderEmail;
            }
            set
            {
                OnSenderEmailChanging(value);
                ReportPropertyChanging("SenderEmail");
                _SenderEmail = StructuralObject.SetValidValue(value, true, "SenderEmail");
                ReportPropertyChanged("SenderEmail");
                OnSenderEmailChanged();
            }
        }
        private global::System.String _SenderEmail;
        partial void OnSenderEmailChanging(global::System.String value);
        partial void OnSenderEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String EmailSubject
        {
            get
            {
                return _EmailSubject;
            }
            set
            {
                OnEmailSubjectChanging(value);
                ReportPropertyChanging("EmailSubject");
                _EmailSubject = StructuralObject.SetValidValue(value, true, "EmailSubject");
                ReportPropertyChanged("EmailSubject");
                OnEmailSubjectChanged();
            }
        }
        private global::System.String _EmailSubject;
        partial void OnEmailSubjectChanging(global::System.String value);
        partial void OnEmailSubjectChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String EmailBody
        {
            get
            {
                return _EmailBody;
            }
            set
            {
                OnEmailBodyChanging(value);
                ReportPropertyChanging("EmailBody");
                _EmailBody = StructuralObject.SetValidValue(value, true, "EmailBody");
                ReportPropertyChanged("EmailBody");
                OnEmailBodyChanged();
            }
        }
        private global::System.String _EmailBody;
        partial void OnEmailBodyChanging(global::System.String value);
        partial void OnEmailBodyChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreatedDate
        {
            get
            {
                return _CreatedDate;
            }
            set
            {
                OnCreatedDateChanging(value);
                ReportPropertyChanging("CreatedDate");
                _CreatedDate = StructuralObject.SetValidValue(value, "CreatedDate");
                ReportPropertyChanged("CreatedDate");
                OnCreatedDateChanged();
            }
        }
        private global::System.DateTime _CreatedDate;
        partial void OnCreatedDateChanging(global::System.DateTime value);
        partial void OnCreatedDateChanged();

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="OnBoardingModel", Name="ListConfiguration")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ListConfiguration : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ListConfiguration object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="userId">Initial value of the UserId property.</param>
        /// <param name="createdDate">Initial value of the CreatedDate property.</param>
        public static ListConfiguration CreateListConfiguration(global::System.Int32 id, global::System.Int32 userId, global::System.DateTime createdDate)
        {
            ListConfiguration listConfiguration = new ListConfiguration();
            listConfiguration.Id = id;
            listConfiguration.UserId = userId;
            listConfiguration.CreatedDate = createdDate;
            return listConfiguration;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                OnUserIdChanging(value);
                ReportPropertyChanging("UserId");
                _UserId = StructuralObject.SetValidValue(value, "UserId");
                ReportPropertyChanged("UserId");
                OnUserIdChanged();
            }
        }
        private global::System.Int32 _UserId;
        partial void OnUserIdChanging(global::System.Int32 value);
        partial void OnUserIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ListType
        {
            get
            {
                return _ListType;
            }
            set
            {
                OnListTypeChanging(value);
                ReportPropertyChanging("ListType");
                _ListType = StructuralObject.SetValidValue(value, true, "ListType");
                ReportPropertyChanged("ListType");
                OnListTypeChanged();
            }
        }
        private global::System.String _ListType;
        partial void OnListTypeChanging(global::System.String value);
        partial void OnListTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ListFrequency
        {
            get
            {
                return _ListFrequency;
            }
            set
            {
                OnListFrequencyChanging(value);
                ReportPropertyChanging("ListFrequency");
                _ListFrequency = StructuralObject.SetValidValue(value, true, "ListFrequency");
                ReportPropertyChanged("ListFrequency");
                OnListFrequencyChanged();
            }
        }
        private global::System.String _ListFrequency;
        partial void OnListFrequencyChanging(global::System.String value);
        partial void OnListFrequencyChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FrequencyDetail
        {
            get
            {
                return _FrequencyDetail;
            }
            set
            {
                OnFrequencyDetailChanging(value);
                ReportPropertyChanging("FrequencyDetail");
                _FrequencyDetail = StructuralObject.SetValidValue(value, true, "FrequencyDetail");
                ReportPropertyChanged("FrequencyDetail");
                OnFrequencyDetailChanged();
            }
        }
        private global::System.String _FrequencyDetail;
        partial void OnFrequencyDetailChanging(global::System.String value);
        partial void OnFrequencyDetailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreatedDate
        {
            get
            {
                return _CreatedDate;
            }
            set
            {
                OnCreatedDateChanging(value);
                ReportPropertyChanging("CreatedDate");
                _CreatedDate = StructuralObject.SetValidValue(value, "CreatedDate");
                ReportPropertyChanged("CreatedDate");
                OnCreatedDateChanged();
            }
        }
        private global::System.DateTime _CreatedDate;
        partial void OnCreatedDateChanging(global::System.DateTime value);
        partial void OnCreatedDateChanged();

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="OnBoardingModel", Name="OtherConfiguration")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class OtherConfiguration : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new OtherConfiguration object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="userId">Initial value of the UserId property.</param>
        /// <param name="createdDate">Initial value of the CreatedDate property.</param>
        public static OtherConfiguration CreateOtherConfiguration(global::System.Int32 id, global::System.Int32 userId, global::System.DateTime createdDate)
        {
            OtherConfiguration otherConfiguration = new OtherConfiguration();
            otherConfiguration.Id = id;
            otherConfiguration.UserId = userId;
            otherConfiguration.CreatedDate = createdDate;
            return otherConfiguration;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                OnUserIdChanging(value);
                ReportPropertyChanging("UserId");
                _UserId = StructuralObject.SetValidValue(value, "UserId");
                ReportPropertyChanged("UserId");
                OnUserIdChanged();
            }
        }
        private global::System.Int32 _UserId;
        partial void OnUserIdChanging(global::System.Int32 value);
        partial void OnUserIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CommunicationEmail
        {
            get
            {
                return _CommunicationEmail;
            }
            set
            {
                OnCommunicationEmailChanging(value);
                ReportPropertyChanging("CommunicationEmail");
                _CommunicationEmail = StructuralObject.SetValidValue(value, true, "CommunicationEmail");
                ReportPropertyChanged("CommunicationEmail");
                OnCommunicationEmailChanged();
            }
        }
        private global::System.String _CommunicationEmail;
        partial void OnCommunicationEmailChanging(global::System.String value);
        partial void OnCommunicationEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime CreatedDate
        {
            get
            {
                return _CreatedDate;
            }
            set
            {
                OnCreatedDateChanging(value);
                ReportPropertyChanging("CreatedDate");
                _CreatedDate = StructuralObject.SetValidValue(value, "CreatedDate");
                ReportPropertyChanged("CreatedDate");
                OnCreatedDateChanged();
            }
        }
        private global::System.DateTime _CreatedDate;
        partial void OnCreatedDateChanging(global::System.DateTime value);
        partial void OnCreatedDateChanged();

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="OnBoardingModel", Name="User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="userID">Initial value of the UserID property.</param>
        /// <param name="isSuperAdmin">Initial value of the IsSuperAdmin property.</param>
        /// <param name="companyId">Initial value of the CompanyId property.</param>
        public static User CreateUser(global::System.Int32 userID, global::System.Boolean isSuperAdmin, global::System.Int32 companyId)
        {
            User user = new User();
            user.UserID = userID;
            user.IsSuperAdmin = isSuperAdmin;
            user.CompanyId = companyId;
            return user;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                if (_UserID != value)
                {
                    OnUserIDChanging(value);
                    ReportPropertyChanging("UserID");
                    _UserID = StructuralObject.SetValidValue(value, "UserID");
                    ReportPropertyChanged("UserID");
                    OnUserIDChanged();
                }
            }
        }
        private global::System.Int32 _UserID;
        partial void OnUserIDChanging(global::System.Int32 value);
        partial void OnUserIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String EmailAddress
        {
            get
            {
                return _EmailAddress;
            }
            set
            {
                OnEmailAddressChanging(value);
                ReportPropertyChanging("EmailAddress");
                _EmailAddress = StructuralObject.SetValidValue(value, true, "EmailAddress");
                ReportPropertyChanged("EmailAddress");
                OnEmailAddressChanged();
            }
        }
        private global::System.String _EmailAddress;
        partial void OnEmailAddressChanging(global::System.String value);
        partial void OnEmailAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Password
        {
            get
            {
                return _Password;
            }
            set
            {
                OnPasswordChanging(value);
                ReportPropertyChanging("Password");
                _Password = StructuralObject.SetValidValue(value, true, "Password");
                ReportPropertyChanged("Password");
                OnPasswordChanged();
            }
        }
        private global::System.String _Password;
        partial void OnPasswordChanging(global::System.String value);
        partial void OnPasswordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, true, "FirstName");
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, true, "LastName");
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ContactNumber
        {
            get
            {
                return _ContactNumber;
            }
            set
            {
                OnContactNumberChanging(value);
                ReportPropertyChanging("ContactNumber");
                _ContactNumber = StructuralObject.SetValidValue(value, true, "ContactNumber");
                ReportPropertyChanged("ContactNumber");
                OnContactNumberChanged();
            }
        }
        private global::System.String _ContactNumber;
        partial void OnContactNumberChanging(global::System.String value);
        partial void OnContactNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ImageName
        {
            get
            {
                return _ImageName;
            }
            set
            {
                OnImageNameChanging(value);
                ReportPropertyChanging("ImageName");
                _ImageName = StructuralObject.SetValidValue(value, true, "ImageName");
                ReportPropertyChanged("ImageName");
                OnImageNameChanged();
            }
        }
        private global::System.String _ImageName;
        partial void OnImageNameChanging(global::System.String value);
        partial void OnImageNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsSuperAdmin
        {
            get
            {
                return _IsSuperAdmin;
            }
            set
            {
                OnIsSuperAdminChanging(value);
                ReportPropertyChanging("IsSuperAdmin");
                _IsSuperAdmin = StructuralObject.SetValidValue(value, "IsSuperAdmin");
                ReportPropertyChanged("IsSuperAdmin");
                OnIsSuperAdminChanged();
            }
        }
        private global::System.Boolean _IsSuperAdmin;
        partial void OnIsSuperAdminChanging(global::System.Boolean value);
        partial void OnIsSuperAdminChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CompanyId
        {
            get
            {
                return _CompanyId;
            }
            set
            {
                OnCompanyIdChanging(value);
                ReportPropertyChanging("CompanyId");
                _CompanyId = StructuralObject.SetValidValue(value, "CompanyId");
                ReportPropertyChanged("CompanyId");
                OnCompanyIdChanged();
            }
        }
        private global::System.Int32 _CompanyId;
        partial void OnCompanyIdChanging(global::System.Int32 value);
        partial void OnCompanyIdChanged();

        #endregion

    }

    #endregion

}

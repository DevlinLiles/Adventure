﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace Adventure.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class AdventureDBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new AdventureDBEntities object using the connection string found in the 'AdventureDBEntities' section of the application configuration file.
        /// </summary>
        public AdventureDBEntities() : base("name=AdventureDBEntities", "AdventureDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AdventureDBEntities object.
        /// </summary>
        public AdventureDBEntities(string connectionString) : base(connectionString, "AdventureDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AdventureDBEntities object.
        /// </summary>
        public AdventureDBEntities(EntityConnection connection) : base(connection, "AdventureDBEntities")
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
        public ObjectSet<Room> Rooms
        {
            get
            {
                if ((_Rooms == null))
                {
                    _Rooms = base.CreateObjectSet<Room>("Rooms");
                }
                return _Rooms;
            }
        }
        private ObjectSet<Room> _Rooms;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Rooms EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRooms(Room room)
        {
            base.AddObject("Rooms", room);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Adventure.Domain", Name="Room")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Room : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Room object.
        /// </summary>
        /// <param name="roomId">Initial value of the RoomId property.</param>
        public static Room CreateRoom(global::System.Int32 roomId)
        {
            Room room = new Room();
            room.RoomId = roomId;
            return room;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 RoomId
        {
            get
            {
                return _RoomId;
            }
            set
            {
                if (_RoomId != value)
                {
                    OnRoomIdChanging(value);
                    ReportPropertyChanging("RoomId");
                    _RoomId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("RoomId");
                    OnRoomIdChanged();
                }
            }
        }
        private global::System.Int32 _RoomId;
        partial void OnRoomIdChanging(global::System.Int32 value);
        partial void OnRoomIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String RoomName
        {
            get
            {
                return _RoomName;
            }
            set
            {
                OnRoomNameChanging(value);
                ReportPropertyChanging("RoomName");
                _RoomName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("RoomName");
                OnRoomNameChanged();
            }
        }
        private global::System.String _RoomName;
        partial void OnRoomNameChanging(global::System.String value);
        partial void OnRoomNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();

        #endregion
    
    }

    #endregion
    
}

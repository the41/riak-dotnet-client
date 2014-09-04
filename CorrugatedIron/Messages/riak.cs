//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: riak.proto
namespace CorrugatedIron.Messages
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbErrorResp")]
  public partial class RpbErrorResp : global::ProtoBuf.IExtensible
  {
    public RpbErrorResp() {}
    
    private byte[] _errmsg;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"errmsg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] errmsg
    {
      get { return _errmsg; }
      set { _errmsg = value; }
    }
    private uint _errcode;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"errcode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint errcode
    {
      get { return _errcode; }
      set { _errcode = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbGetServerInfoResp")]
  public partial class RpbGetServerInfoResp : global::ProtoBuf.IExtensible
  {
    public RpbGetServerInfoResp() {}
    
    private byte[] _node = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"node", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] node
    {
      get { return _node; }
      set { _node = value; }
    }
    private byte[] _server_version = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"server_version", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] server_version
    {
      get { return _server_version; }
      set { _server_version = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbPair")]
  public partial class RpbPair : global::ProtoBuf.IExtensible
  {
    public RpbPair() {}
    
    private byte[] _key;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] key
    {
      get { return _key; }
      set { _key = value; }
    }
    private byte[] _value = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] value
    {
      get { return _value; }
      set { _value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbGetBucketReq")]
  public partial class RpbGetBucketReq : global::ProtoBuf.IExtensible
  {
    public RpbGetBucketReq() {}
    
    private byte[] _bucket;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"bucket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] bucket
    {
      get { return _bucket; }
      set { _bucket = value; }
    }
    private byte[] _type = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbGetBucketResp")]
  public partial class RpbGetBucketResp : global::ProtoBuf.IExtensible
  {
    public RpbGetBucketResp() {}
    
    private RpbBucketProps _props;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"props", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public RpbBucketProps props
    {
      get { return _props; }
      set { _props = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbSetBucketReq")]
  public partial class RpbSetBucketReq : global::ProtoBuf.IExtensible
  {
    public RpbSetBucketReq() {}
    
    private byte[] _bucket;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"bucket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] bucket
    {
      get { return _bucket; }
      set { _bucket = value; }
    }
    private RpbBucketProps _props;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"props", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public RpbBucketProps props
    {
      get { return _props; }
      set { _props = value; }
    }
    private byte[] _type = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbResetBucketReq")]
  public partial class RpbResetBucketReq : global::ProtoBuf.IExtensible
  {
    public RpbResetBucketReq() {}
    
    private byte[] _bucket;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"bucket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] bucket
    {
      get { return _bucket; }
      set { _bucket = value; }
    }
    private byte[] _type = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbGetBucketTypeReq")]
  public partial class RpbGetBucketTypeReq : global::ProtoBuf.IExtensible
  {
    public RpbGetBucketTypeReq() {}
    
    private byte[] _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbSetBucketTypeReq")]
  public partial class RpbSetBucketTypeReq : global::ProtoBuf.IExtensible
  {
    public RpbSetBucketTypeReq() {}
    
    private byte[] _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] type
    {
      get { return _type; }
      set { _type = value; }
    }
    private RpbBucketProps _props;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"props", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public RpbBucketProps props
    {
      get { return _props; }
      set { _props = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbModFun")]
  public partial class RpbModFun : global::ProtoBuf.IExtensible
  {
    public RpbModFun() {}
    
    private byte[] _module;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"module", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] module
    {
      get { return _module; }
      set { _module = value; }
    }
    private byte[] _function;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"function", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] function
    {
      get { return _function; }
      set { _function = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbCommitHook")]
  public partial class RpbCommitHook : global::ProtoBuf.IExtensible
  {
    public RpbCommitHook() {}
    
    private RpbModFun _modfun = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"modfun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public RpbModFun modfun
    {
      get { return _modfun; }
      set { _modfun = value; }
    }
    private byte[] _name = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] name
    {
      get { return _name; }
      set { _name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbBucketProps")]
  public partial class RpbBucketProps : global::ProtoBuf.IExtensible
  {
    public RpbBucketProps() {}
    
    private uint _n_val = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"n_val", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint n_val
    {
      get { return _n_val; }
      set { _n_val = value; }
    }
    private bool _allow_mult = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"allow_mult", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool allow_mult
    {
      get { return _allow_mult; }
      set { _allow_mult = value; }
    }
    private bool _last_write_wins = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"last_write_wins", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool last_write_wins
    {
      get { return _last_write_wins; }
      set { _last_write_wins = value; }
    }
    private readonly global::System.Collections.Generic.List<RpbCommitHook> _precommit = new global::System.Collections.Generic.List<RpbCommitHook>();
    [global::ProtoBuf.ProtoMember(4, Name=@"precommit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RpbCommitHook> precommit
    {
      get { return _precommit; }
    }
  
    private bool _has_precommit = (bool)false;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"has_precommit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool has_precommit
    {
      get { return _has_precommit; }
      set { _has_precommit = value; }
    }
    private readonly global::System.Collections.Generic.List<RpbCommitHook> _postcommit = new global::System.Collections.Generic.List<RpbCommitHook>();
    [global::ProtoBuf.ProtoMember(6, Name=@"postcommit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RpbCommitHook> postcommit
    {
      get { return _postcommit; }
    }
  
    private bool _has_postcommit = (bool)false;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"has_postcommit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool has_postcommit
    {
      get { return _has_postcommit; }
      set { _has_postcommit = value; }
    }
    private RpbModFun _chash_keyfun = null;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"chash_keyfun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public RpbModFun chash_keyfun
    {
      get { return _chash_keyfun; }
      set { _chash_keyfun = value; }
    }
    private RpbModFun _linkfun = null;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"linkfun", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public RpbModFun linkfun
    {
      get { return _linkfun; }
      set { _linkfun = value; }
    }
    private uint _old_vclock = default(uint);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"old_vclock", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint old_vclock
    {
      get { return _old_vclock; }
      set { _old_vclock = value; }
    }
    private uint _young_vclock = default(uint);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"young_vclock", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint young_vclock
    {
      get { return _young_vclock; }
      set { _young_vclock = value; }
    }
    private uint _big_vclock = default(uint);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"big_vclock", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint big_vclock
    {
      get { return _big_vclock; }
      set { _big_vclock = value; }
    }
    private uint _small_vclock = default(uint);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"small_vclock", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint small_vclock
    {
      get { return _small_vclock; }
      set { _small_vclock = value; }
    }
    private uint _pr = default(uint);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"pr", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint pr
    {
      get { return _pr; }
      set { _pr = value; }
    }
    private uint _r = default(uint);
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"r", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint r
    {
      get { return _r; }
      set { _r = value; }
    }
    private uint _w = default(uint);
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"w", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint w
    {
      get { return _w; }
      set { _w = value; }
    }
    private uint _pw = default(uint);
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"pw", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint pw
    {
      get { return _pw; }
      set { _pw = value; }
    }
    private uint _dw = default(uint);
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"dw", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint dw
    {
      get { return _dw; }
      set { _dw = value; }
    }
    private uint _rw = default(uint);
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"rw", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rw
    {
      get { return _rw; }
      set { _rw = value; }
    }
    private bool _basic_quorum = default(bool);
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"basic_quorum", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool basic_quorum
    {
      get { return _basic_quorum; }
      set { _basic_quorum = value; }
    }
    private bool _notfound_ok = default(bool);
    [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"notfound_ok", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool notfound_ok
    {
      get { return _notfound_ok; }
      set { _notfound_ok = value; }
    }
    private byte[] _backend = null;
    [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"backend", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] backend
    {
      get { return _backend; }
      set { _backend = value; }
    }
    private bool _search = default(bool);
    [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"search", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool search
    {
      get { return _search; }
      set { _search = value; }
    }
    private RpbBucketProps.RpbReplMode? _repl;
    [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"repl", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(RpbBucketProps.RpbReplMode.FALSE)]
    public RpbBucketProps.RpbReplMode repl
    {
        get { return _repl.HasValue ? _repl.Value : RpbReplMode.FALSE; }
      set { _repl = value; }
    }
    private byte[] _search_index = null;
    [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"search_index", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] search_index
    {
      get { return _search_index; }
      set { _search_index = value; }
    }
    private byte[] _datatype = null;
    [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"datatype", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] datatype
    {
      get { return _datatype; }
      set { _datatype = value; }
    }
    private bool _consistent = default(bool);
    [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"consistent", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool consistent
    {
      get { return _consistent; }
      set { _consistent = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"RpbReplMode")]
    public enum RpbReplMode
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"FALSE", Value=0)]
      FALSE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"REALTIME", Value=1)]
      REALTIME = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FULLSYNC", Value=2)]
      FULLSYNC = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TRUE", Value=3)]
      TRUE = 3
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RpbAuthReq")]
  public partial class RpbAuthReq : global::ProtoBuf.IExtensible
  {
    public RpbAuthReq() {}
    
    private byte[] _user;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"user", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] user
    {
      get { return _user; }
      set { _user = value; }
    }
    private byte[] _password;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"password", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] password
    {
      get { return _password; }
      set { _password = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
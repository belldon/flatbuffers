// automatically generated, do not modify

namespace NamespaceA
{

using System;
using FlatBuffers;

public sealed class TableInFirstNS : Table {
  public static TableInFirstNS GetRootAsTableInFirstNS(ByteBuffer _bb) { return GetRootAsTableInFirstNS(_bb, new TableInFirstNS()); }
  public static TableInFirstNS GetRootAsTableInFirstNS(ByteBuffer _bb, TableInFirstNS obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public TableInFirstNS __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public NamespaceA.NamespaceB.TableInNestedNS FooTable { get { return GetFooTable(new NamespaceA.NamespaceB.TableInNestedNS()); } }
  public NamespaceA.NamespaceB.TableInNestedNS GetFooTable(NamespaceA.NamespaceB.TableInNestedNS obj) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(o + bb_pos), bb) : null; }
  public NamespaceA.NamespaceB.EnumInNestedNS FooEnum { get { int o = __offset(6); return o != 0 ? (NamespaceA.NamespaceB.EnumInNestedNS)bb.GetSbyte(o + bb_pos) : NamespaceA.NamespaceB.EnumInNestedNS.A; } }
  public bool MutateFooEnum(NamespaceA.NamespaceB.EnumInNestedNS foo_enum) { int o = __offset(6); if (o != 0) { bb.PutSbyte(o + bb_pos, (sbyte)foo_enum); return true; } else { return false; } }
  public NamespaceA.NamespaceB.StructInNestedNS FooStruct { get { return GetFooStruct(new NamespaceA.NamespaceB.StructInNestedNS()); } }
  public NamespaceA.NamespaceB.StructInNestedNS GetFooStruct(NamespaceA.NamespaceB.StructInNestedNS obj) { int o = __offset(8); return o != 0 ? obj.__init(o + bb_pos, bb) : null; }

  public static void StartTableInFirstNS(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddFooTable(FlatBufferBuilder builder, Offset<NamespaceA.NamespaceB.TableInNestedNS> fooTableOffset) { builder.AddOffset(0, fooTableOffset.Value, 0); }
  public static void AddFooEnum(FlatBufferBuilder builder, NamespaceA.NamespaceB.EnumInNestedNS fooEnum) { builder.AddSbyte(1, (sbyte)fooEnum, 0); }
  public static void AddFooStruct(FlatBufferBuilder builder, Offset<NamespaceA.NamespaceB.StructInNestedNS> fooStructOffset) { builder.AddStruct(2, fooStructOffset.Value, 0); }
  public static Offset<NamespaceA.TableInFirstNS> EndTableInFirstNS(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<NamespaceA.TableInFirstNS>(o);
  }
};


}

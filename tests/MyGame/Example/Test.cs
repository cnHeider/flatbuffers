// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace MyGame.Example
{

using global::System;
using global::FlatBuffers;

public struct Test : IFlatbufferObject
{
  private Struct __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Test __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public short A { get { return __p.bb.GetShort(__p.bb_pos + 0); } }
  public void MutateA(short a) { __p.bb.PutShort(__p.bb_pos + 0, a); }
  public sbyte B { get { return __p.bb.GetSbyte(__p.bb_pos + 2); } }
  public void MutateB(sbyte b) { __p.bb.PutSbyte(__p.bb_pos + 2, b); }

  public static Offset<Test> CreateTest(FlatBufferBuilder builder, short A, sbyte B) {
    builder.Prep(2, 4);
    builder.Pad(1);
    builder.PutSbyte(B);
    builder.PutShort(A);
    return new Offset<Test>(builder.Offset);
  }
};


}

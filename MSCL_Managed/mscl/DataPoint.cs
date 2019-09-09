//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace mscl {

public class DataPoint : Value {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal DataPoint(global::System.IntPtr cPtr, bool cMemoryOwn) : base(msclPINVOKE.DataPoint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DataPoint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          msclPINVOKE.delete_DataPoint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public Value channelProperty(DataPoint.ChannelPropertyId id) {
    Value ret = new Value(msclPINVOKE.DataPoint_channelProperty(swigCPtr, (int)id), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector as_Vector() {
    Vector ret = new Vector(msclPINVOKE.DataPoint_as_Vector(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix as_Matrix() {
    Matrix ret = new Matrix(msclPINVOKE.DataPoint_as_Matrix(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Timestamp as_Timestamp() {
    Timestamp ret = new Timestamp(msclPINVOKE.DataPoint_as_Timestamp(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Bytes as_Bytes() {
    Bytes ret = new Bytes(msclPINVOKE.DataPoint_as_Bytes(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StructuralHealth as_StructuralHealth() {
    StructuralHealth ret = new StructuralHealth(msclPINVOKE.DataPoint_as_StructuralHealth(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RfSweep as_RfSweep() {
    RfSweep ret = new RfSweep(msclPINVOKE.DataPoint_as_RfSweep(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string as_string() {
    string ret = msclPINVOKE.DataPoint_as_string(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum ChannelPropertyId {
    channelPropertyId_angle = 0,
    channelPropertyId_derivedFrom = 1,
    channelPropertyId_derivedAlgorithmId = 2
  }

}

}

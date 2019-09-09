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

public class BaseStationButton : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BaseStationButton(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BaseStationButton obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BaseStationButton() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          msclPINVOKE.delete_BaseStationButton(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public BaseStationButton() : this(msclPINVOKE.new_BaseStationButton__SWIG_0(), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public BaseStationButton(BaseStationButton.Command cmd, ushort nodeAddress) : this(msclPINVOKE.new_BaseStationButton__SWIG_1((int)cmd, nodeAddress), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public BaseStationButton(BaseStationButton.Command cmd) : this(msclPINVOKE.new_BaseStationButton__SWIG_2((int)cmd), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public BaseStationButton.Command command() {
    BaseStationButton.Command ret = (BaseStationButton.Command)msclPINVOKE.BaseStationButton_command__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void command(BaseStationButton.Command cmd) {
    msclPINVOKE.BaseStationButton_command__SWIG_1(swigCPtr, (int)cmd);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public ushort nodeAddress() {
    ushort ret = msclPINVOKE.BaseStationButton_nodeAddress__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void nodeAddress(ushort address) {
    msclPINVOKE.BaseStationButton_nodeAddress__SWIG_1(swigCPtr, address);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum Command {
    btn_nodeSleep = 0,
    btn_nodeStop = 1,
    btn_enableBeacon = 2,
    btn_disableBeacon = 3,
    btn_nodeNonSyncSampling = 4,
    btn_nodeSyncSampling = 5,
    btn_nodeArmedDatalogging = 6,
    btn_cyclePower = 7,
    btn_disabled = 65535
  }

}

}

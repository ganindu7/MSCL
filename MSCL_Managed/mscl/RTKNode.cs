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

public class RTKNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RTKNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RTKNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RTKNode() {
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
          msclPINVOKE.delete_RTKNode(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public RTKNode(Connection connection) : this(msclPINVOKE.new_RTKNode(Connection.getCPtr(connection)), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual Bytes doCommand(byte descriptorSet, byte cmdDescriptor, Bytes fieldData, bool ackNackResponse, bool dataResponse, byte responseDataDescriptor) {
    Bytes ret = new Bytes(msclPINVOKE.RTKNode_doCommand__SWIG_0(swigCPtr, descriptorSet, cmdDescriptor, Bytes.getCPtr(fieldData), ackNackResponse, dataResponse, responseDataDescriptor), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Bytes doCommand(byte descriptorSet, byte cmdDescriptor, Bytes fieldData, bool ackNackResponse, bool dataResponse) {
    Bytes ret = new Bytes(msclPINVOKE.RTKNode_doCommand__SWIG_1(swigCPtr, descriptorSet, cmdDescriptor, Bytes.getCPtr(fieldData), ackNackResponse, dataResponse), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string deviceName(string serial) {
    string ret = msclPINVOKE.RTKNode_deviceName(serial);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Connection connection() {
    Connection ret = new Connection(msclPINVOKE.RTKNode_connection(swigCPtr), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MipNodeFeatures features() {
    MipNodeFeatures ret = new MipNodeFeatures(msclPINVOKE.RTKNode_features(swigCPtr), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Timestamp lastCommunicationTime() {
    Timestamp ret = new Timestamp(msclPINVOKE.RTKNode_lastCommunicationTime(swigCPtr), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DeviceState lastDeviceState() {
    DeviceState ret = (DeviceState)msclPINVOKE.RTKNode_lastDeviceState(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Version firmwareVersion() {
    Version ret = new Version(msclPINVOKE.RTKNode_firmwareVersion(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RTKModels.NodeModel model() {
    RTKModels.NodeModel ret = (RTKModels.NodeModel)msclPINVOKE.RTKNode_model(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string modelName() {
    string ret = msclPINVOKE.RTKNode_modelName(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string modelNumber() {
    string ret = msclPINVOKE.RTKNode_modelNumber(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string serialNumber() {
    string ret = msclPINVOKE.RTKNode_serialNumber(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string lotNumber() {
    string ret = msclPINVOKE.RTKNode_lotNumber(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string deviceOptions() {
    string ret = msclPINVOKE.RTKNode_deviceOptions(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MipDataPackets getDataPackets(uint timeout, uint maxPackets) {
    MipDataPackets ret = new MipDataPackets(msclPINVOKE.RTKNode_getDataPackets__SWIG_0(swigCPtr, timeout, maxPackets), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MipDataPackets getDataPackets(uint timeout) {
    MipDataPackets ret = new MipDataPackets(msclPINVOKE.RTKNode_getDataPackets__SWIG_1(swigCPtr, timeout), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MipDataPackets getDataPackets() {
    MipDataPackets ret = new MipDataPackets(msclPINVOKE.RTKNode_getDataPackets__SWIG_2(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint totalPackets() {
    uint ret = msclPINVOKE.RTKNode_totalPackets(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void timeout(ulong timeout) {
    msclPINVOKE.RTKNode_timeout__SWIG_0(swigCPtr, timeout);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public ulong timeout() {
    ulong ret = msclPINVOKE.RTKNode_timeout__SWIG_1(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string name() {
    string ret = msclPINVOKE.RTKNode_name(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ping() {
    bool ret = msclPINVOKE.RTKNode_ping(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setToIdle() {
    msclPINVOKE.RTKNode_setToIdle(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool cyclePower() {
    bool ret = msclPINVOKE.RTKNode_cyclePower(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void resume() {
    msclPINVOKE.RTKNode_resume(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public RTKDeviceStatusFlags getDeviceStatusFlags() {
    RTKDeviceStatusFlags ret = new RTKDeviceStatusFlags(msclPINVOKE.RTKNode_getDeviceStatusFlags(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

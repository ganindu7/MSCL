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

public class NodeFeatures : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal NodeFeatures(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NodeFeatures obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NodeFeatures() {
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
          msclPINVOKE.delete_NodeFeatures(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint normalizeNumSweeps(uint sweeps) {
    uint ret = msclPINVOKE.NodeFeatures_normalizeNumSweeps(swigCPtr, sweeps);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TimeSpan normalizeTimeBetweenBursts(TimeSpan time) {
    TimeSpan ret = new TimeSpan(msclPINVOKE.NodeFeatures_normalizeTimeBetweenBursts(swigCPtr, TimeSpan.getCPtr(time)), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public WirelessChannels channels() {
    WirelessChannels ret = new WirelessChannels(msclPINVOKE.NodeFeatures_channels(swigCPtr), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ChannelGroups channelGroups() {
    ChannelGroups ret = new ChannelGroups(msclPINVOKE.NodeFeatures_channelGroups(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual WirelessTypes.ChannelType channelType(byte channelNumber) {
    WirelessTypes.ChannelType ret = (WirelessTypes.ChannelType)msclPINVOKE.NodeFeatures_channelType(swigCPtr, channelNumber);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsChannelSetting(WirelessTypes.ChannelGroupSetting setting, ChannelMask mask) {
    bool ret = msclPINVOKE.NodeFeatures_supportsChannelSetting(swigCPtr, (int)setting, ChannelMask.getCPtr(mask));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsInputRange() {
    bool ret = msclPINVOKE.NodeFeatures_supportsInputRange__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsInputRangePerExcitationVoltage() {
    bool ret = msclPINVOKE.NodeFeatures_supportsInputRangePerExcitationVoltage(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsHardwareOffset() {
    bool ret = msclPINVOKE.NodeFeatures_supportsHardwareOffset(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsAntiAliasingFilter() {
    bool ret = msclPINVOKE.NodeFeatures_supportsAntiAliasingFilter(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsLowPassFilter() {
    bool ret = msclPINVOKE.NodeFeatures_supportsLowPassFilter(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsHighPassFilter() {
    bool ret = msclPINVOKE.NodeFeatures_supportsHighPassFilter(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsGaugeFactor() {
    bool ret = msclPINVOKE.NodeFeatures_supportsGaugeFactor(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsGaugeResistance() {
    bool ret = msclPINVOKE.NodeFeatures_supportsGaugeResistance(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsNumActiveGauges() {
    bool ret = msclPINVOKE.NodeFeatures_supportsNumActiveGauges(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsLostBeaconTimeout() {
    bool ret = msclPINVOKE.NodeFeatures_supportsLostBeaconTimeout(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsPullUpResistor() {
    bool ret = msclPINVOKE.NodeFeatures_supportsPullUpResistor(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsFilterSettlingTime() {
    bool ret = msclPINVOKE.NodeFeatures_supportsFilterSettlingTime(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsThermocoupleType() {
    bool ret = msclPINVOKE.NodeFeatures_supportsThermocoupleType(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsTempSensorOptions() {
    bool ret = msclPINVOKE.NodeFeatures_supportsTempSensorOptions(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsDebounceFilter() {
    bool ret = msclPINVOKE.NodeFeatures_supportsDebounceFilter(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsFatigueConfig() {
    bool ret = msclPINVOKE.NodeFeatures_supportsFatigueConfig(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsYoungsModConfig() {
    bool ret = msclPINVOKE.NodeFeatures_supportsYoungsModConfig(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsPoissonsRatioConfig() {
    bool ret = msclPINVOKE.NodeFeatures_supportsPoissonsRatioConfig(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsFatigueDebugModeConfig() {
    bool ret = msclPINVOKE.NodeFeatures_supportsFatigueDebugModeConfig(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsFatigueModeConfig() {
    bool ret = msclPINVOKE.NodeFeatures_supportsFatigueModeConfig(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsHistogramConfig() {
    bool ret = msclPINVOKE.NodeFeatures_supportsHistogramConfig(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsHistogramRateConfig() {
    bool ret = msclPINVOKE.NodeFeatures_supportsHistogramRateConfig(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsHistogramEnableConfig() {
    bool ret = msclPINVOKE.NodeFeatures_supportsHistogramEnableConfig(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsActivitySense() {
    bool ret = msclPINVOKE.NodeFeatures_supportsActivitySense(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsAutoBalance() {
    bool ret = msclPINVOKE.NodeFeatures_supportsAutoBalance(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsLegacyShuntCal() {
    bool ret = msclPINVOKE.NodeFeatures_supportsLegacyShuntCal(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsAutoCal_shm() {
    bool ret = msclPINVOKE.NodeFeatures_supportsAutoCal_shm(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsAutoCal_shm201() {
    bool ret = msclPINVOKE.NodeFeatures_supportsAutoCal_shm201(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsAutoShuntCal() {
    bool ret = msclPINVOKE.NodeFeatures_supportsAutoShuntCal(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsLimitedDuration() {
    bool ret = msclPINVOKE.NodeFeatures_supportsLimitedDuration(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsEventTrigger() {
    bool ret = msclPINVOKE.NodeFeatures_supportsEventTrigger(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsDiagnosticInfo() {
    bool ret = msclPINVOKE.NodeFeatures_supportsDiagnosticInfo(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsLoggedData() {
    bool ret = msclPINVOKE.NodeFeatures_supportsLoggedData(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsSensorDelayConfig() {
    bool ret = msclPINVOKE.NodeFeatures_supportsSensorDelayConfig(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsSensorDelayAlwaysOn() {
    bool ret = msclPINVOKE.NodeFeatures_supportsSensorDelayAlwaysOn(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsSensorOutputMode() {
    bool ret = msclPINVOKE.NodeFeatures_supportsSensorOutputMode(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsChannel(byte channelNumber) {
    bool ret = msclPINVOKE.NodeFeatures_supportsChannel(swigCPtr, channelNumber);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsSamplingMode(WirelessTypes.SamplingMode samplingMode) {
    bool ret = msclPINVOKE.NodeFeatures_supportsSamplingMode(swigCPtr, (int)samplingMode);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsSampleRate(WirelessTypes.WirelessSampleRate sampleRate, WirelessTypes.SamplingMode samplingMode, WirelessTypes.DataCollectionMethod dataCollectionMethod, WirelessTypes.DataMode dataMode) {
    bool ret = msclPINVOKE.NodeFeatures_supportsSampleRate(swigCPtr, (int)sampleRate, (int)samplingMode, (int)dataCollectionMethod, (int)dataMode);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsCommunicationProtocol(WirelessTypes.CommProtocol protocol) {
    bool ret = msclPINVOKE.NodeFeatures_supportsCommunicationProtocol(swigCPtr, (int)protocol);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsDataFormat(WirelessTypes.DataFormat dataFormat) {
    bool ret = msclPINVOKE.NodeFeatures_supportsDataFormat(swigCPtr, (int)dataFormat);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsDefaultMode(WirelessTypes.DefaultMode mode) {
    bool ret = msclPINVOKE.NodeFeatures_supportsDefaultMode(swigCPtr, (int)mode);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsDataCollectionMethod(WirelessTypes.DataCollectionMethod collectionMethod) {
    bool ret = msclPINVOKE.NodeFeatures_supportsDataCollectionMethod(swigCPtr, (int)collectionMethod);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsTransmitPower(WirelessTypes.TransmitPower power, WirelessTypes.CommProtocol commProtocol) {
    bool ret = msclPINVOKE.NodeFeatures_supportsTransmitPower(swigCPtr, (int)power, (int)commProtocol);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsDataMode(WirelessTypes.DataMode dataMode) {
    bool ret = msclPINVOKE.NodeFeatures_supportsDataMode(swigCPtr, (int)dataMode);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsTransducerType(WirelessTypes.TransducerType transducerType) {
    bool ret = msclPINVOKE.NodeFeatures_supportsTransducerType(swigCPtr, (int)transducerType);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsFatigueMode(WirelessTypes.FatigueMode mode) {
    bool ret = msclPINVOKE.NodeFeatures_supportsFatigueMode(swigCPtr, (int)mode);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsInputRange(WirelessTypes.InputRange range, ChannelMask channels) {
    bool ret = msclPINVOKE.NodeFeatures_supportsInputRange__SWIG_1(swigCPtr, (int)range, ChannelMask.getCPtr(channels));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsInputRange(WirelessTypes.InputRange range, ChannelMask channels, WirelessTypes.Voltage excitationVoltage) {
    bool ret = msclPINVOKE.NodeFeatures_supportsInputRange__SWIG_2(swigCPtr, (int)range, ChannelMask.getCPtr(channels), (int)excitationVoltage);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsCentisecondEventDuration() {
    bool ret = msclPINVOKE.NodeFeatures_supportsCentisecondEventDuration(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsGetDiagnosticInfo() {
    bool ret = msclPINVOKE.NodeFeatures_supportsGetDiagnosticInfo(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsNonSyncLogWithTimestamps() {
    bool ret = msclPINVOKE.NodeFeatures_supportsNonSyncLogWithTimestamps(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsDerivedCategory(WirelessTypes.DerivedCategory category) {
    bool ret = msclPINVOKE.NodeFeatures_supportsDerivedCategory(swigCPtr, (int)category);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsRawDataMode() {
    bool ret = msclPINVOKE.NodeFeatures_supportsRawDataMode(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsDerivedDataMode() {
    bool ret = msclPINVOKE.NodeFeatures_supportsDerivedDataMode(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsDerivedVelocityUnitConfig() {
    bool ret = msclPINVOKE.NodeFeatures_supportsDerivedVelocityUnitConfig(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsExcitationVoltageConfig() {
    bool ret = msclPINVOKE.NodeFeatures_supportsExcitationVoltageConfig(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool supportsLowBatteryThresholdConfig() {
    bool ret = msclPINVOKE.NodeFeatures_supportsLowBatteryThresholdConfig(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual WirelessTypes.WirelessSampleRate maxSampleRate(WirelessTypes.SamplingMode samplingMode, ChannelMask channels, WirelessTypes.DataCollectionMethod dataCollectionMethod, WirelessTypes.DataMode dataMode) {
    WirelessTypes.WirelessSampleRate ret = (WirelessTypes.WirelessSampleRate)msclPINVOKE.NodeFeatures_maxSampleRate(swigCPtr, (int)samplingMode, ChannelMask.getCPtr(channels), (int)dataCollectionMethod, (int)dataMode);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual WirelessTypes.WirelessSampleRate maxSampleRateForSettlingTime(WirelessTypes.SettlingTime filterSettlingTime, WirelessTypes.SamplingMode samplingMode, WirelessTypes.DataCollectionMethod dataCollectionMethod, WirelessTypes.DataMode dataMode) {
    WirelessTypes.WirelessSampleRate ret = (WirelessTypes.WirelessSampleRate)msclPINVOKE.NodeFeatures_maxSampleRateForSettlingTime(swigCPtr, (int)filterSettlingTime, (int)samplingMode, (int)dataCollectionMethod, (int)dataMode);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual WirelessTypes.WirelessSampleRate maxSampleRateForLowPassFilter(WirelessTypes.Filter lowPassFilter, WirelessTypes.SamplingMode samplingMode, WirelessTypes.DataCollectionMethod dataCollectionMethod, WirelessTypes.DataMode dataMode, ChannelMask channels) {
    WirelessTypes.WirelessSampleRate ret = (WirelessTypes.WirelessSampleRate)msclPINVOKE.NodeFeatures_maxSampleRateForLowPassFilter(swigCPtr, (int)lowPassFilter, (int)samplingMode, (int)dataCollectionMethod, (int)dataMode, ChannelMask.getCPtr(channels));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual WirelessTypes.SettlingTime maxFilterSettlingTime(SampleRate rate) {
    WirelessTypes.SettlingTime ret = (WirelessTypes.SettlingTime)msclPINVOKE.NodeFeatures_maxFilterSettlingTime(swigCPtr, SampleRate.getCPtr(rate));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ushort minInactivityTimeout() {
    ushort ret = msclPINVOKE.NodeFeatures_minInactivityTimeout(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ushort minLostBeaconTimeout() {
    ushort ret = msclPINVOKE.NodeFeatures_minLostBeaconTimeout(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual ushort maxLostBeaconTimeout() {
    ushort ret = msclPINVOKE.NodeFeatures_maxLostBeaconTimeout(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual byte minCheckRadioInterval() {
    byte ret = msclPINVOKE.NodeFeatures_minCheckRadioInterval(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual byte maxCheckRadioInterval() {
    byte ret = msclPINVOKE.NodeFeatures_maxCheckRadioInterval(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual uint minSweeps() {
    uint ret = msclPINVOKE.NodeFeatures_minSweeps(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual uint maxSweeps(WirelessTypes.SamplingMode samplingMode, WirelessTypes.DataMode dataMode, WirelessTypes.DataFormat dataFormat, ChannelMask channels) {
    uint ret = msclPINVOKE.NodeFeatures_maxSweeps(swigCPtr, (int)samplingMode, (int)dataMode, (int)dataFormat, ChannelMask.getCPtr(channels));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual uint maxSweepsPerBurst(WirelessTypes.DataMode dataMode, WirelessTypes.DataFormat dataFormat, ChannelMask channels) {
    uint ret = msclPINVOKE.NodeFeatures_maxSweepsPerBurst(swigCPtr, (int)dataMode, (int)dataFormat, ChannelMask.getCPtr(channels));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual TimeSpan minTimeBetweenBursts(WirelessTypes.DataMode dataMode, WirelessTypes.DataFormat dataFormat, ChannelMask rawChannels, DerivedChannelMasks derivedChannelMasks, SampleRate rawSampleRate, uint sweepsPerBurst, WirelessTypes.CommProtocol commProtocol) {
    TimeSpan ret = new TimeSpan(msclPINVOKE.NodeFeatures_minTimeBetweenBursts(swigCPtr, (int)dataMode, (int)dataFormat, ChannelMask.getCPtr(rawChannels), DerivedChannelMasks.getCPtr(derivedChannelMasks), SampleRate.getCPtr(rawSampleRate), sweepsPerBurst, (int)commProtocol), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual uint minSensorDelay() {
    uint ret = msclPINVOKE.NodeFeatures_minSensorDelay(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual uint maxSensorDelay() {
    uint ret = msclPINVOKE.NodeFeatures_maxSensorDelay(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual uint maxEventTriggerTotalDuration(WirelessTypes.DataMode dataMode, WirelessTypes.DataFormat dataFormat, ChannelMask rawChannels, DerivedChannelMasks derivedChannelMasks, SampleRate rawSampleRate, SampleRate derivedDataRate) {
    uint ret = msclPINVOKE.NodeFeatures_maxEventTriggerTotalDuration(swigCPtr, (int)dataMode, (int)dataFormat, ChannelMask.getCPtr(rawChannels), DerivedChannelMasks.getCPtr(derivedChannelMasks), SampleRate.getCPtr(rawSampleRate), SampleRate.getCPtr(derivedDataRate));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual uint normalizeEventDuration(uint duration) {
    uint ret = msclPINVOKE.NodeFeatures_normalizeEventDuration(swigCPtr, duration);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual uint normalizeSensorDelay(uint delay) {
    uint ret = msclPINVOKE.NodeFeatures_normalizeSensorDelay(swigCPtr, delay);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual byte numDamageAngles() {
    byte ret = msclPINVOKE.NodeFeatures_numDamageAngles(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual byte numSnCurveSegments() {
    byte ret = msclPINVOKE.NodeFeatures_numSnCurveSegments(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual byte numEventTriggers() {
    byte ret = msclPINVOKE.NodeFeatures_numEventTriggers(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual DefaultModes defaultModes() {
    DefaultModes ret = new DefaultModes(msclPINVOKE.NodeFeatures_defaultModes(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual DataCollectionMethods dataCollectionMethods() {
    DataCollectionMethods ret = new DataCollectionMethods(msclPINVOKE.NodeFeatures_dataCollectionMethods(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual DataFormats dataFormats() {
    DataFormats ret = new DataFormats(msclPINVOKE.NodeFeatures_dataFormats(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SamplingModes samplingModes() {
    SamplingModes ret = new SamplingModes(msclPINVOKE.NodeFeatures_samplingModes(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual WirelessSampleRates sampleRates(WirelessTypes.SamplingMode samplingMode, WirelessTypes.DataCollectionMethod dataCollectionMethod, WirelessTypes.DataMode dataMode) {
    WirelessSampleRates ret = new WirelessSampleRates(msclPINVOKE.NodeFeatures_sampleRates(swigCPtr, (int)samplingMode, (int)dataCollectionMethod, (int)dataMode), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual WirelessSampleRates derivedDataRates() {
    WirelessSampleRates ret = new WirelessSampleRates(msclPINVOKE.NodeFeatures_derivedDataRates(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual TransmitPowers transmitPowers(WirelessTypes.CommProtocol commProtocol) {
    TransmitPowers ret = new TransmitPowers(msclPINVOKE.NodeFeatures_transmitPowers__SWIG_0(swigCPtr, (int)commProtocol), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual TransmitPowers transmitPowers(WirelessTypes.RegionCode region, WirelessTypes.CommProtocol commProtocol) {
    TransmitPowers ret = new TransmitPowers(msclPINVOKE.NodeFeatures_transmitPowers__SWIG_1(swigCPtr, (int)region, (int)commProtocol), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual CommProtocols commProtocols() {
    CommProtocols ret = new CommProtocols(msclPINVOKE.NodeFeatures_commProtocols(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SensorOutputModes sensorOutputModes() {
    SensorOutputModes ret = new SensorOutputModes(msclPINVOKE.NodeFeatures_sensorOutputModes(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual WirelessSampleRates histogramTransmitRates() {
    WirelessSampleRates ret = new WirelessSampleRates(msclPINVOKE.NodeFeatures_histogramTransmitRates(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual FatigueModes fatigueModes() {
    FatigueModes ret = new FatigueModes(msclPINVOKE.NodeFeatures_fatigueModes(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Filters antiAliasingFilters() {
    Filters ret = new Filters(msclPINVOKE.NodeFeatures_antiAliasingFilters(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Filters lowPassFilters() {
    Filters ret = new Filters(msclPINVOKE.NodeFeatures_lowPassFilters(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual HighPassFilters highPassFilters() {
    HighPassFilters ret = new HighPassFilters(msclPINVOKE.NodeFeatures_highPassFilters(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual StorageLimitModes storageLimitModes() {
    StorageLimitModes ret = new StorageLimitModes(msclPINVOKE.NodeFeatures_storageLimitModes(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual InputRanges inputRanges(ChannelMask channels) {
    InputRanges ret = new InputRanges(msclPINVOKE.NodeFeatures_inputRanges__SWIG_0(swigCPtr, ChannelMask.getCPtr(channels)), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual InputRanges inputRanges(ChannelMask channels, WirelessTypes.Voltage excitationVoltage) {
    InputRanges ret = new InputRanges(msclPINVOKE.NodeFeatures_inputRanges__SWIG_1(swigCPtr, ChannelMask.getCPtr(channels), (int)excitationVoltage), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual DataModes dataModes() {
    DataModes ret = new DataModes(msclPINVOKE.NodeFeatures_dataModes(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual TransducerTypes transducerTypes() {
    TransducerTypes ret = new TransducerTypes(msclPINVOKE.NodeFeatures_transducerTypes(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual DerivedChannelMasks channelsPerDerivedCategory() {
    DerivedChannelMasks ret = new DerivedChannelMasks(msclPINVOKE.NodeFeatures_channelsPerDerivedCategory(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Voltages excitationVoltages() {
    Voltages ret = new Voltages(msclPINVOKE.NodeFeatures_excitationVoltages(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual WirelessTypes.VoltageType adcVoltageInputType() {
    WirelessTypes.VoltageType ret = (WirelessTypes.VoltageType)msclPINVOKE.NodeFeatures_adcVoltageInputType(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual WirelessTypes.TransmitPower maxTransmitPower(WirelessTypes.RegionCode region, WirelessTypes.CommProtocol commProtocol) {
    WirelessTypes.TransmitPower ret = (WirelessTypes.TransmitPower)msclPINVOKE.NodeFeatures_maxTransmitPower__SWIG_0(swigCPtr, (int)region, (int)commProtocol);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual WirelessTypes.TransmitPower maxTransmitPower(WirelessTypes.CommProtocol commProtocol) {
    WirelessTypes.TransmitPower ret = (WirelessTypes.TransmitPower)msclPINVOKE.NodeFeatures_maxTransmitPower__SWIG_1(swigCPtr, (int)commProtocol);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual WirelessTypes.TransmitPower minTransmitPower(WirelessTypes.RegionCode region, WirelessTypes.CommProtocol commProtocol) {
    WirelessTypes.TransmitPower ret = (WirelessTypes.TransmitPower)msclPINVOKE.NodeFeatures_minTransmitPower__SWIG_0(swigCPtr, (int)region, (int)commProtocol);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual WirelessTypes.TransmitPower minTransmitPower(WirelessTypes.CommProtocol commProtocol) {
    WirelessTypes.TransmitPower ret = (WirelessTypes.TransmitPower)msclPINVOKE.NodeFeatures_minTransmitPower__SWIG_1(swigCPtr, (int)commProtocol);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

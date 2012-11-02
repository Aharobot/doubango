/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class ProxyAudioProducerCallback : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ProxyAudioProducerCallback(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ProxyAudioProducerCallback obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ProxyAudioProducerCallback() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tinyWRAPPINVOKE.delete_ProxyAudioProducerCallback(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public ProxyAudioProducerCallback() : this(tinyWRAPPINVOKE.new_ProxyAudioProducerCallback(), true) {
    SwigDirectorConnect();
  }

  public virtual int prepare(int ptime, int rate, int channels) {
    int ret = (SwigDerivedClassHasMethod("prepare", swigMethodTypes0) ? tinyWRAPPINVOKE.ProxyAudioProducerCallback_prepareSwigExplicitProxyAudioProducerCallback(swigCPtr, ptime, rate, channels) : tinyWRAPPINVOKE.ProxyAudioProducerCallback_prepare(swigCPtr, ptime, rate, channels));
    return ret;
  }

  public virtual int start() {
    int ret = (SwigDerivedClassHasMethod("start", swigMethodTypes1) ? tinyWRAPPINVOKE.ProxyAudioProducerCallback_startSwigExplicitProxyAudioProducerCallback(swigCPtr) : tinyWRAPPINVOKE.ProxyAudioProducerCallback_start(swigCPtr));
    return ret;
  }

  public virtual int pause() {
    int ret = (SwigDerivedClassHasMethod("pause", swigMethodTypes2) ? tinyWRAPPINVOKE.ProxyAudioProducerCallback_pauseSwigExplicitProxyAudioProducerCallback(swigCPtr) : tinyWRAPPINVOKE.ProxyAudioProducerCallback_pause(swigCPtr));
    return ret;
  }

  public virtual int stop() {
    int ret = (SwigDerivedClassHasMethod("stop", swigMethodTypes3) ? tinyWRAPPINVOKE.ProxyAudioProducerCallback_stopSwigExplicitProxyAudioProducerCallback(swigCPtr) : tinyWRAPPINVOKE.ProxyAudioProducerCallback_stop(swigCPtr));
    return ret;
  }

  public virtual int fillPushBuffer() {
    int ret = (SwigDerivedClassHasMethod("fillPushBuffer", swigMethodTypes4) ? tinyWRAPPINVOKE.ProxyAudioProducerCallback_fillPushBufferSwigExplicitProxyAudioProducerCallback(swigCPtr) : tinyWRAPPINVOKE.ProxyAudioProducerCallback_fillPushBuffer(swigCPtr));
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("prepare", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateProxyAudioProducerCallback_0(SwigDirectorprepare);
    if (SwigDerivedClassHasMethod("start", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateProxyAudioProducerCallback_1(SwigDirectorstart);
    if (SwigDerivedClassHasMethod("pause", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateProxyAudioProducerCallback_2(SwigDirectorpause);
    if (SwigDerivedClassHasMethod("stop", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateProxyAudioProducerCallback_3(SwigDirectorstop);
    if (SwigDerivedClassHasMethod("fillPushBuffer", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateProxyAudioProducerCallback_4(SwigDirectorfillPushBuffer);
    tinyWRAPPINVOKE.ProxyAudioProducerCallback_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(ProxyAudioProducerCallback));
    return hasDerivedMethod;
  }

  private int SwigDirectorprepare(int ptime, int rate, int channels) {
    return prepare(ptime, rate, channels);
  }

  private int SwigDirectorstart() {
    return start();
  }

  private int SwigDirectorpause() {
    return pause();
  }

  private int SwigDirectorstop() {
    return stop();
  }

  private int SwigDirectorfillPushBuffer() {
    return fillPushBuffer();
  }

  public delegate int SwigDelegateProxyAudioProducerCallback_0(int ptime, int rate, int channels);
  public delegate int SwigDelegateProxyAudioProducerCallback_1();
  public delegate int SwigDelegateProxyAudioProducerCallback_2();
  public delegate int SwigDelegateProxyAudioProducerCallback_3();
  public delegate int SwigDelegateProxyAudioProducerCallback_4();

  private SwigDelegateProxyAudioProducerCallback_0 swigDelegate0;
  private SwigDelegateProxyAudioProducerCallback_1 swigDelegate1;
  private SwigDelegateProxyAudioProducerCallback_2 swigDelegate2;
  private SwigDelegateProxyAudioProducerCallback_3 swigDelegate3;
  private SwigDelegateProxyAudioProducerCallback_4 swigDelegate4;

  private static Type[] swigMethodTypes0 = new Type[] { typeof(int), typeof(int), typeof(int) };
  private static Type[] swigMethodTypes1 = new Type[] {  };
  private static Type[] swigMethodTypes2 = new Type[] {  };
  private static Type[] swigMethodTypes3 = new Type[] {  };
  private static Type[] swigMethodTypes4 = new Type[] {  };
}

}

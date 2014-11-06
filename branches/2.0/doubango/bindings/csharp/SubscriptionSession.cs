/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class SubscriptionSession : SipSession {
  private HandleRef swigCPtr;

  internal SubscriptionSession(IntPtr cPtr, bool cMemoryOwn) : base(tinyWRAPPINVOKE.SubscriptionSessionUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(SubscriptionSession obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~SubscriptionSession() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tinyWRAPPINVOKE.delete_SubscriptionSession(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public SubscriptionSession(SipStack pStack) : this(tinyWRAPPINVOKE.new_SubscriptionSession(SipStack.getCPtr(pStack)), true) {
  }

  public bool subscribe() {
    bool ret = tinyWRAPPINVOKE.SubscriptionSession_subscribe(swigCPtr);
    return ret;
  }

  public bool unSubscribe() {
    bool ret = tinyWRAPPINVOKE.SubscriptionSession_unSubscribe(swigCPtr);
    return ret;
  }

}

}

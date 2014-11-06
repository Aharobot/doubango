/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.doubango.tinyWRAP;

public class SipSession {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected SipSession(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(SipSession obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        tinyWRAPJNI.delete_SipSession(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  protected java.nio.ByteBuffer getByteBuffer(byte[] bytes) {
    if(bytes != null){
		final java.nio.ByteBuffer byteBuffer = java.nio.ByteBuffer.allocateDirect(bytes.length);
        byteBuffer.put(bytes);
        return byteBuffer;
    }
    return null;
  }

  public SipSession(SipStack stack) {
    this(tinyWRAPJNI.new_SipSession(SipStack.getCPtr(stack), stack), true);
  }

  public boolean haveOwnership() {
    return tinyWRAPJNI.SipSession_haveOwnership(swigCPtr, this);
  }

  public boolean addHeader(String name, String value) {
    return tinyWRAPJNI.SipSession_addHeader(swigCPtr, this, name, value);
  }

  public boolean removeHeader(String name) {
    return tinyWRAPJNI.SipSession_removeHeader(swigCPtr, this, name);
  }

  public boolean addCaps(String name, String value) {
    return tinyWRAPJNI.SipSession_addCaps__SWIG_0(swigCPtr, this, name, value);
  }

  public boolean addCaps(String name) {
    return tinyWRAPJNI.SipSession_addCaps__SWIG_1(swigCPtr, this, name);
  }

  public boolean removeCaps(String name) {
    return tinyWRAPJNI.SipSession_removeCaps(swigCPtr, this, name);
  }

  public boolean setExpires(long expires) {
    return tinyWRAPJNI.SipSession_setExpires(swigCPtr, this, expires);
  }

  public boolean setFromUri(String fromUriString) {
    return tinyWRAPJNI.SipSession_setFromUri__SWIG_0(swigCPtr, this, fromUriString);
  }

  public boolean setFromUri(SipUri fromUri) {
    return tinyWRAPJNI.SipSession_setFromUri__SWIG_1(swigCPtr, this, SipUri.getCPtr(fromUri), fromUri);
  }

  public boolean setToUri(String toUriString) {
    return tinyWRAPJNI.SipSession_setToUri__SWIG_0(swigCPtr, this, toUriString);
  }

  public boolean setToUri(SipUri toUri) {
    return tinyWRAPJNI.SipSession_setToUri__SWIG_1(swigCPtr, this, SipUri.getCPtr(toUri), toUri);
  }

  public boolean setSilentHangup(boolean silent) {
    return tinyWRAPJNI.SipSession_setSilentHangup(swigCPtr, this, silent);
  }

  public boolean addSigCompCompartment(String compId) {
    return tinyWRAPJNI.SipSession_addSigCompCompartment(swigCPtr, this, compId);
  }

  public boolean removeSigCompCompartment() {
    return tinyWRAPJNI.SipSession_removeSigCompCompartment(swigCPtr, this);
  }

  public long getId() {
    return tinyWRAPJNI.SipSession_getId(swigCPtr, this);
  }

}

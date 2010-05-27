/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class aiNodeVector : IDisposable, System.Collections.IEnumerable
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IList<aiNode>
#endif
 {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiNodeVector(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(aiNodeVector obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiNodeVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Assimp_NETPINVOKE.delete_aiNodeVector(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public aiNodeVector(System.Collections.ICollection c) : this() {
    if (c == null)
      throw new ArgumentNullException("c");
    foreach (aiNode element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public aiNode this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array)
#else
  public void CopyTo(aiNode[] array)
#endif
  {
    CopyTo(0, array, 0, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(System.Array array, int arrayIndex)
#else
  public void CopyTo(aiNode[] array, int arrayIndex)
#endif
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

#if SWIG_DOTNET_1
  public void CopyTo(int index, System.Array array, int arrayIndex, int count)
#else
  public void CopyTo(int index, aiNode[] array, int arrayIndex, int count)
#endif
  {
    if (array == null)
      throw new ArgumentNullException("array");
    if (index < 0)
      throw new ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

#if !SWIG_DOTNET_1
  System.Collections.Generic.IEnumerator<aiNode> System.Collections.Generic.IEnumerable<aiNode>.GetEnumerator() {
    return new aiNodeVectorEnumerator(this);
  }
#endif

  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return new aiNodeVectorEnumerator(this);
  }

  public aiNodeVectorEnumerator GetEnumerator() {
    return new aiNodeVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class aiNodeVectorEnumerator : System.Collections.IEnumerator
#if !SWIG_DOTNET_1
    , System.Collections.Generic.IEnumerator<aiNode>
#endif
  {
    private aiNodeVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public aiNodeVectorEnumerator(aiNodeVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public aiNode Current {
      get {
        if (currentIndex == -1)
          throw new InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new InvalidOperationException("Collection modified.");
        return (aiNode)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new InvalidOperationException("Collection modified.");
      }
    }

#if !SWIG_DOTNET_1
    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
#endif
  }

  public void Clear() {
    Assimp_NETPINVOKE.aiNodeVector_Clear(swigCPtr);
  }

  public void Add(aiNode x) {
    Assimp_NETPINVOKE.aiNodeVector_Add(swigCPtr, aiNode.getCPtr(x));
  }

  private uint size() {
    uint ret = Assimp_NETPINVOKE.aiNodeVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = Assimp_NETPINVOKE.aiNodeVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    Assimp_NETPINVOKE.aiNodeVector_reserve(swigCPtr, n);
  }

  public aiNodeVector() : this(Assimp_NETPINVOKE.new_aiNodeVector__SWIG_0(), true) {
  }

  public aiNodeVector(aiNodeVector other) : this(Assimp_NETPINVOKE.new_aiNodeVector__SWIG_1(aiNodeVector.getCPtr(other)), true) {
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
  }

  public aiNodeVector(int capacity) : this(Assimp_NETPINVOKE.new_aiNodeVector__SWIG_2(capacity), true) {
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
  }

  private aiNode getitemcopy(int index) {
    IntPtr cPtr = Assimp_NETPINVOKE.aiNodeVector_getitemcopy(swigCPtr, index);
    aiNode ret = (cPtr == IntPtr.Zero) ? null : new aiNode(cPtr, false);
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private aiNode getitem(int index) {
    IntPtr cPtr = Assimp_NETPINVOKE.aiNodeVector_getitem(swigCPtr, index);
    aiNode ret = (cPtr == IntPtr.Zero) ? null : new aiNode(cPtr, false);
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, aiNode val) {
    Assimp_NETPINVOKE.aiNodeVector_setitem(swigCPtr, index, aiNode.getCPtr(val));
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(aiNodeVector values) {
    Assimp_NETPINVOKE.aiNodeVector_AddRange(swigCPtr, aiNodeVector.getCPtr(values));
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
  }

  public aiNodeVector GetRange(int index, int count) {
    IntPtr cPtr = Assimp_NETPINVOKE.aiNodeVector_GetRange(swigCPtr, index, count);
    aiNodeVector ret = (cPtr == IntPtr.Zero) ? null : new aiNodeVector(cPtr, true);
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, aiNode x) {
    Assimp_NETPINVOKE.aiNodeVector_Insert(swigCPtr, index, aiNode.getCPtr(x));
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, aiNodeVector values) {
    Assimp_NETPINVOKE.aiNodeVector_InsertRange(swigCPtr, index, aiNodeVector.getCPtr(values));
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    Assimp_NETPINVOKE.aiNodeVector_RemoveAt(swigCPtr, index);
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    Assimp_NETPINVOKE.aiNodeVector_RemoveRange(swigCPtr, index, count);
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
  }

  public static aiNodeVector Repeat(aiNode value, int count) {
    IntPtr cPtr = Assimp_NETPINVOKE.aiNodeVector_Repeat(aiNode.getCPtr(value), count);
    aiNodeVector ret = (cPtr == IntPtr.Zero) ? null : new aiNodeVector(cPtr, true);
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    Assimp_NETPINVOKE.aiNodeVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    Assimp_NETPINVOKE.aiNodeVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, aiNodeVector values) {
    Assimp_NETPINVOKE.aiNodeVector_SetRange(swigCPtr, index, aiNodeVector.getCPtr(values));
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(aiNode value) {
    bool ret = Assimp_NETPINVOKE.aiNodeVector_Contains(swigCPtr, aiNode.getCPtr(value));
    return ret;
  }

  public int IndexOf(aiNode value) {
    int ret = Assimp_NETPINVOKE.aiNodeVector_IndexOf(swigCPtr, aiNode.getCPtr(value));
    return ret;
  }

  public int LastIndexOf(aiNode value) {
    int ret = Assimp_NETPINVOKE.aiNodeVector_LastIndexOf(swigCPtr, aiNode.getCPtr(value));
    return ret;
  }

  public bool Remove(aiNode value) {
    bool ret = Assimp_NETPINVOKE.aiNodeVector_Remove(swigCPtr, aiNode.getCPtr(value));
    return ret;
  }

}

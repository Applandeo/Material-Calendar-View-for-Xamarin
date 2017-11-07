using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applandeo.Materialcalendarview.Listeners {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.applandeo.materialcalendarview.listeners']/interface[@name='OnSelectDateListener']"
	[Register ("com/applandeo/materialcalendarview/listeners/OnSelectDateListener", "", "Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListenerInvoker")]
	public partial interface IOnSelectDateListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.listeners']/interface[@name='OnSelectDateListener']/method[@name='onSelect' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.util.Calendar&gt;']]"
		[Register ("onSelect", "(Ljava/util/List;)V", "GetOnSelect_Ljava_util_List_Handler:Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListenerInvoker, Material-Calendar-View-for-Xamarin")]
		void OnSelect (global::System.Collections.Generic.IList<global::Java.Util.Calendar> p0);

	}

	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/listeners/OnSelectDateListener", DoNotGenerateAcw=true)]
	internal class IOnSelectDateListenerInvoker : global::Java.Lang.Object, IOnSelectDateListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/applandeo/materialcalendarview/listeners/OnSelectDateListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnSelectDateListenerInvoker); }
		}

		IntPtr class_ref;

		public static IOnSelectDateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnSelectDateListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.applandeo.materialcalendarview.listeners.OnSelectDateListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnSelectDateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSelect_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnSelect_Ljava_util_List_Handler ()
		{
			if (cb_onSelect_Ljava_util_List_ == null)
				cb_onSelect_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSelect_Ljava_util_List_);
			return cb_onSelect_Ljava_util_List_;
		}

		static void n_OnSelect_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSelect (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSelect_Ljava_util_List_;
		public unsafe void OnSelect (global::System.Collections.Generic.IList<global::Java.Util.Calendar> p0)
		{
			if (id_onSelect_Ljava_util_List_ == IntPtr.Zero)
				id_onSelect_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onSelect", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSelect_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	public partial class SelectDateEventArgs : global::System.EventArgs {

		public SelectDateEventArgs (global::System.Collections.Generic.IList<global::Java.Util.Calendar> p0)
		{
			this.p0 = p0;
		}

		global::System.Collections.Generic.IList<global::Java.Util.Calendar> p0;
		public global::System.Collections.Generic.IList<global::Java.Util.Calendar> P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/applandeo/materialcalendarview/listeners/OnSelectDateListenerImplementor")]
	internal sealed partial class IOnSelectDateListenerImplementor : global::Java.Lang.Object, IOnSelectDateListener {

		object sender;

		public IOnSelectDateListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/applandeo/materialcalendarview/listeners/OnSelectDateListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<SelectDateEventArgs> Handler;
#pragma warning restore 0649

		public void OnSelect (global::System.Collections.Generic.IList<global::Java.Util.Calendar> p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new SelectDateEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnSelectDateListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}

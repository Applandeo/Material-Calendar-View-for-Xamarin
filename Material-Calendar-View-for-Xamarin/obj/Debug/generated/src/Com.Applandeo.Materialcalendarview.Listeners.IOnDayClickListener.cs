using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applandeo.Materialcalendarview.Listeners {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.applandeo.materialcalendarview.listeners']/interface[@name='OnDayClickListener']"
	[Register ("com/applandeo/materialcalendarview/listeners/OnDayClickListener", "", "Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerInvoker")]
	public partial interface IOnDayClickListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.listeners']/interface[@name='OnDayClickListener']/method[@name='onDayClick' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.EventDay']]"
		[Register ("onDayClick", "(Lcom/applandeo/materialcalendarview/EventDay;)V", "GetOnDayClick_Lcom_applandeo_materialcalendarview_EventDay_Handler:Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerInvoker, Material-Calendar-View-for-Xamarin")]
		void OnDayClick (global::Com.Applandeo.Materialcalendarview.EventDay p0);

	}

	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/listeners/OnDayClickListener", DoNotGenerateAcw=true)]
	internal class IOnDayClickListenerInvoker : global::Java.Lang.Object, IOnDayClickListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/applandeo/materialcalendarview/listeners/OnDayClickListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnDayClickListenerInvoker); }
		}

		IntPtr class_ref;

		public static IOnDayClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnDayClickListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.applandeo.materialcalendarview.listeners.OnDayClickListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnDayClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDayClick_Lcom_applandeo_materialcalendarview_EventDay_;
#pragma warning disable 0169
		static Delegate GetOnDayClick_Lcom_applandeo_materialcalendarview_EventDay_Handler ()
		{
			if (cb_onDayClick_Lcom_applandeo_materialcalendarview_EventDay_ == null)
				cb_onDayClick_Lcom_applandeo_materialcalendarview_EventDay_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDayClick_Lcom_applandeo_materialcalendarview_EventDay_);
			return cb_onDayClick_Lcom_applandeo_materialcalendarview_EventDay_;
		}

		static void n_OnDayClick_Lcom_applandeo_materialcalendarview_EventDay_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.EventDay p0 = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.EventDay> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDayClick (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDayClick_Lcom_applandeo_materialcalendarview_EventDay_;
		public unsafe void OnDayClick (global::Com.Applandeo.Materialcalendarview.EventDay p0)
		{
			if (id_onDayClick_Lcom_applandeo_materialcalendarview_EventDay_ == IntPtr.Zero)
				id_onDayClick_Lcom_applandeo_materialcalendarview_EventDay_ = JNIEnv.GetMethodID (class_ref, "onDayClick", "(Lcom/applandeo/materialcalendarview/EventDay;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDayClick_Lcom_applandeo_materialcalendarview_EventDay_, __args);
		}

	}

	public partial class DayClickEventArgs : global::System.EventArgs {

		public DayClickEventArgs (global::Com.Applandeo.Materialcalendarview.EventDay p0)
		{
			this.p0 = p0;
		}

		global::Com.Applandeo.Materialcalendarview.EventDay p0;
		public global::Com.Applandeo.Materialcalendarview.EventDay P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/applandeo/materialcalendarview/listeners/OnDayClickListenerImplementor")]
	internal sealed partial class IOnDayClickListenerImplementor : global::Java.Lang.Object, IOnDayClickListener {

		object sender;

		public IOnDayClickListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/applandeo/materialcalendarview/listeners/OnDayClickListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<DayClickEventArgs> Handler;
#pragma warning restore 0649

		public void OnDayClick (global::Com.Applandeo.Materialcalendarview.EventDay p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new DayClickEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnDayClickListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}

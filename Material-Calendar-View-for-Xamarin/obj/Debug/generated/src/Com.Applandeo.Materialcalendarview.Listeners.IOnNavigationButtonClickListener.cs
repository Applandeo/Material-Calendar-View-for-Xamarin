using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applandeo.Materialcalendarview.Listeners {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.applandeo.materialcalendarview.listeners']/interface[@name='OnNavigationButtonClickListener']"
	[Register ("com/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener", "", "Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerInvoker")]
	public partial interface IOnNavigationButtonClickListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.listeners']/interface[@name='OnNavigationButtonClickListener']/method[@name='onClick' and count(parameter)=0]"
		[Register ("onClick", "()V", "GetOnClickHandler:Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerInvoker, Material-Calendar-View-for-Xamarin")]
		void OnClick ();

	}

	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener", DoNotGenerateAcw=true)]
	internal class IOnNavigationButtonClickListenerInvoker : global::Java.Lang.Object, IOnNavigationButtonClickListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnNavigationButtonClickListenerInvoker); }
		}

		IntPtr class_ref;

		public static IOnNavigationButtonClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnNavigationButtonClickListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.applandeo.materialcalendarview.listeners.OnNavigationButtonClickListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnNavigationButtonClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onClick;
#pragma warning disable 0169
		static Delegate GetOnClickHandler ()
		{
			if (cb_onClick == null)
				cb_onClick = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnClick);
			return cb_onClick;
		}

		static void n_OnClick (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnClick ();
		}
#pragma warning restore 0169

		IntPtr id_onClick;
		public unsafe void OnClick ()
		{
			if (id_onClick == IntPtr.Zero)
				id_onClick = JNIEnv.GetMethodID (class_ref, "onClick", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick);
		}

	}

	[global::Android.Runtime.Register ("mono/com/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListenerImplementor")]
	internal sealed partial class IOnNavigationButtonClickListenerImplementor : global::Java.Lang.Object, IOnNavigationButtonClickListener {

		object sender;

		public IOnNavigationButtonClickListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnClick ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IOnNavigationButtonClickListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applandeo.Materialcalendarview.Listeners {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.applandeo.materialcalendarview.listeners']/interface[@name='OnSelectionAbilityListener']"
	[Register ("com/applandeo/materialcalendarview/listeners/OnSelectionAbilityListener", "", "Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListenerInvoker")]
	public partial interface IOnSelectionAbilityListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.listeners']/interface[@name='OnSelectionAbilityListener']/method[@name='onChange' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onChange", "(Z)V", "GetOnChange_ZHandler:Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListenerInvoker, Material-Calendar-View-for-Xamarin")]
		void OnChange (bool p0);

	}

	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/listeners/OnSelectionAbilityListener", DoNotGenerateAcw=true)]
	internal class IOnSelectionAbilityListenerInvoker : global::Java.Lang.Object, IOnSelectionAbilityListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/applandeo/materialcalendarview/listeners/OnSelectionAbilityListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnSelectionAbilityListenerInvoker); }
		}

		IntPtr class_ref;

		public static IOnSelectionAbilityListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnSelectionAbilityListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.applandeo.materialcalendarview.listeners.OnSelectionAbilityListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnSelectionAbilityListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onChange_Z;
#pragma warning disable 0169
		static Delegate GetOnChange_ZHandler ()
		{
			if (cb_onChange_Z == null)
				cb_onChange_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnChange_Z);
			return cb_onChange_Z;
		}

		static void n_OnChange_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnChange (p0);
		}
#pragma warning restore 0169

		IntPtr id_onChange_Z;
		public unsafe void OnChange (bool p0)
		{
			if (id_onChange_Z == IntPtr.Zero)
				id_onChange_Z = JNIEnv.GetMethodID (class_ref, "onChange", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChange_Z, __args);
		}

	}

	public partial class SelectionAbilityEventArgs : global::System.EventArgs {

		public SelectionAbilityEventArgs (bool p0)
		{
			this.p0 = p0;
		}

		bool p0;
		public bool P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/applandeo/materialcalendarview/listeners/OnSelectionAbilityListenerImplementor")]
	internal sealed partial class IOnSelectionAbilityListenerImplementor : global::Java.Lang.Object, IOnSelectionAbilityListener {

		object sender;

		public IOnSelectionAbilityListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/applandeo/materialcalendarview/listeners/OnSelectionAbilityListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<SelectionAbilityEventArgs> Handler;
#pragma warning restore 0649

		public void OnChange (bool p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new SelectionAbilityEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnSelectionAbilityListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}

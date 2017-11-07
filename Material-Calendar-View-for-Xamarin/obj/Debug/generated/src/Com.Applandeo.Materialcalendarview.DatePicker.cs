using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applandeo.Materialcalendarview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='DatePicker']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/DatePicker", DoNotGenerateAcw=true)]
	public partial class DatePicker : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applandeo/materialcalendarview/DatePicker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DatePicker); }
		}

		protected DatePicker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_applandeo_materialcalendarview_utils_CalendarProperties_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='DatePicker']/constructor[@name='DatePicker' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applandeo.materialcalendarview.utils.CalendarProperties']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/applandeo/materialcalendarview/utils/CalendarProperties;)V", "")]
		public unsafe DatePicker (global::Android.Content.Context context, global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties calendarProperties)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (calendarProperties);
				if (((object) this).GetType () != typeof (DatePicker)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/applandeo/materialcalendarview/utils/CalendarProperties;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/applandeo/materialcalendarview/utils/CalendarProperties;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_applandeo_materialcalendarview_utils_CalendarProperties_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_applandeo_materialcalendarview_utils_CalendarProperties_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/applandeo/materialcalendarview/utils/CalendarProperties;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_applandeo_materialcalendarview_utils_CalendarProperties_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_applandeo_materialcalendarview_utils_CalendarProperties_, __args);
			} finally {
			}
		}

		static Delegate cb_show;
#pragma warning disable 0169
		static Delegate GetShowHandler ()
		{
			if (cb_show == null)
				cb_show = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Show);
			return cb_show;
		}

		static IntPtr n_Show (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.DatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.DatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Show ());
		}
#pragma warning restore 0169

		static IntPtr id_show;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='DatePicker']/method[@name='show' and count(parameter)=0]"
		[Register ("show", "()Lcom/applandeo/materialcalendarview/DatePicker;", "GetShowHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.DatePicker Show ()
		{
			if (id_show == IntPtr.Zero)
				id_show = JNIEnv.GetMethodID (class_ref, "show", "()Lcom/applandeo/materialcalendarview/DatePicker;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.DatePicker> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_show), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.DatePicker> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "show", "()Lcom/applandeo/materialcalendarview/DatePicker;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}

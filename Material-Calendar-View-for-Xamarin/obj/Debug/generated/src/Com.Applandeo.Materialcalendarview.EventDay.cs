using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applandeo.Materialcalendarview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='EventDay']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/EventDay", DoNotGenerateAcw=true)]
	public partial class EventDay : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applandeo/materialcalendarview/EventDay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EventDay); }
		}

		protected EventDay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_Calendar_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='EventDay']/constructor[@name='EventDay' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register (".ctor", "(Ljava/util/Calendar;)V", "")]
		public unsafe EventDay (global::Java.Util.Calendar day)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (day);
				if (((object) this).GetType () != typeof (EventDay)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/Calendar;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/Calendar;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Calendar_ == IntPtr.Zero)
					id_ctor_Ljava_util_Calendar_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Calendar;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Calendar_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_Calendar_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_util_Calendar_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='EventDay']/constructor[@name='EventDay' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/util/Calendar;I)V", "")]
		public unsafe EventDay (global::Java.Util.Calendar day, int imageResource)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (day);
				__args [1] = new JValue (imageResource);
				if (((object) this).GetType () != typeof (EventDay)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/Calendar;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/Calendar;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Calendar_I == IntPtr.Zero)
					id_ctor_Ljava_util_Calendar_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Calendar;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Calendar_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_Calendar_I, __args);
			} finally {
			}
		}

		static Delegate cb_getCalendar;
#pragma warning disable 0169
		static Delegate GetGetCalendarHandler ()
		{
			if (cb_getCalendar == null)
				cb_getCalendar = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCalendar);
			return cb_getCalendar;
		}

		static IntPtr n_GetCalendar (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.EventDay __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.EventDay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Calendar);
		}
#pragma warning restore 0169

		static IntPtr id_getCalendar;
		public virtual unsafe global::Java.Util.Calendar Calendar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='EventDay']/method[@name='getCalendar' and count(parameter)=0]"
			[Register ("getCalendar", "()Ljava/util/Calendar;", "GetGetCalendarHandler")]
			get {
				if (id_getCalendar == IntPtr.Zero)
					id_getCalendar = JNIEnv.GetMethodID (class_ref, "getCalendar", "()Ljava/util/Calendar;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCalendar), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCalendar", "()Ljava/util/Calendar;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImageResource;
#pragma warning disable 0169
		static Delegate GetGetImageResourceHandler ()
		{
			if (cb_getImageResource == null)
				cb_getImageResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetImageResource);
			return cb_getImageResource;
		}

		static int n_GetImageResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.EventDay __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.EventDay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageResource;
		}
#pragma warning restore 0169

		static IntPtr id_getImageResource;
		public virtual unsafe int ImageResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='EventDay']/method[@name='getImageResource' and count(parameter)=0]"
			[Register ("getImageResource", "()I", "GetGetImageResourceHandler")]
			get {
				if (id_getImageResource == IntPtr.Zero)
					id_getImageResource = JNIEnv.GetMethodID (class_ref, "getImageResource", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getImageResource);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageResource", "()I"));
				} finally {
				}
			}
		}

	}
}

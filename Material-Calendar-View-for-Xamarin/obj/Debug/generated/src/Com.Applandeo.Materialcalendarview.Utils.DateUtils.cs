using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applandeo.Materialcalendarview.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DateUtils']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/utils/DateUtils", DoNotGenerateAcw=true)]
	public partial class DateUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applandeo/materialcalendarview/utils/DateUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DateUtils); }
		}

		protected DateUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DateUtils']/constructor[@name='DateUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DateUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DateUtils)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getCalendar;
		public static unsafe global::Java.Util.Calendar Calendar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DateUtils']/method[@name='getCalendar' and count(parameter)=0]"
			[Register ("getCalendar", "()Ljava/util/Calendar;", "GetGetCalendarHandler")]
			get {
				if (id_getCalendar == IntPtr.Zero)
					id_getCalendar = JNIEnv.GetStaticMethodID (class_ref, "getCalendar", "()Ljava/util/Calendar;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCalendar), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDatesRange_Ljava_util_Calendar_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DateUtils']/method[@name='getDatesRange' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.util.Calendar']]"
		[Register ("getDatesRange", "(Ljava/util/Calendar;Ljava/util/Calendar;)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Util.Calendar> GetDatesRange (global::Java.Util.Calendar firstDay, global::Java.Util.Calendar lastDay)
		{
			if (id_getDatesRange_Ljava_util_Calendar_Ljava_util_Calendar_ == IntPtr.Zero)
				id_getDatesRange_Ljava_util_Calendar_Ljava_util_Calendar_ = JNIEnv.GetStaticMethodID (class_ref, "getDatesRange", "(Ljava/util/Calendar;Ljava/util/Calendar;)Ljava/util/ArrayList;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (firstDay);
				__args [1] = new JValue (lastDay);
				global::System.Collections.Generic.IList<global::Java.Util.Calendar> __ret = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDatesRange_Ljava_util_Calendar_Ljava_util_Calendar_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getMonthAndYearDate_Landroid_content_Context_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DateUtils']/method[@name='getMonthAndYearDate' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Calendar']]"
		[Register ("getMonthAndYearDate", "(Landroid/content/Context;Ljava/util/Calendar;)Ljava/lang/String;", "")]
		public static unsafe string GetMonthAndYearDate (global::Android.Content.Context context, global::Java.Util.Calendar calendar)
		{
			if (id_getMonthAndYearDate_Landroid_content_Context_Ljava_util_Calendar_ == IntPtr.Zero)
				id_getMonthAndYearDate_Landroid_content_Context_Ljava_util_Calendar_ = JNIEnv.GetStaticMethodID (class_ref, "getMonthAndYearDate", "(Landroid/content/Context;Ljava/util/Calendar;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (calendar);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMonthAndYearDate_Landroid_content_Context_Ljava_util_Calendar_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getMonthsBetweenDates_Ljava_util_Calendar_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DateUtils']/method[@name='getMonthsBetweenDates' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.util.Calendar']]"
		[Register ("getMonthsBetweenDates", "(Ljava/util/Calendar;Ljava/util/Calendar;)I", "")]
		public static unsafe int GetMonthsBetweenDates (global::Java.Util.Calendar startCalendar, global::Java.Util.Calendar endCalendar)
		{
			if (id_getMonthsBetweenDates_Ljava_util_Calendar_Ljava_util_Calendar_ == IntPtr.Zero)
				id_getMonthsBetweenDates_Ljava_util_Calendar_Ljava_util_Calendar_ = JNIEnv.GetStaticMethodID (class_ref, "getMonthsBetweenDates", "(Ljava/util/Calendar;Ljava/util/Calendar;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (startCalendar);
				__args [1] = new JValue (endCalendar);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getMonthsBetweenDates_Ljava_util_Calendar_Ljava_util_Calendar_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isMonthAfter_Ljava_util_Calendar_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DateUtils']/method[@name='isMonthAfter' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.util.Calendar']]"
		[Register ("isMonthAfter", "(Ljava/util/Calendar;Ljava/util/Calendar;)Z", "")]
		public static unsafe bool IsMonthAfter (global::Java.Util.Calendar firstCalendar, global::Java.Util.Calendar secondCalendar)
		{
			if (id_isMonthAfter_Ljava_util_Calendar_Ljava_util_Calendar_ == IntPtr.Zero)
				id_isMonthAfter_Ljava_util_Calendar_Ljava_util_Calendar_ = JNIEnv.GetStaticMethodID (class_ref, "isMonthAfter", "(Ljava/util/Calendar;Ljava/util/Calendar;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (firstCalendar);
				__args [1] = new JValue (secondCalendar);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isMonthAfter_Ljava_util_Calendar_Ljava_util_Calendar_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isMonthBefore_Ljava_util_Calendar_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DateUtils']/method[@name='isMonthBefore' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.util.Calendar']]"
		[Register ("isMonthBefore", "(Ljava/util/Calendar;Ljava/util/Calendar;)Z", "")]
		public static unsafe bool IsMonthBefore (global::Java.Util.Calendar firstCalendar, global::Java.Util.Calendar secondCalendar)
		{
			if (id_isMonthBefore_Ljava_util_Calendar_Ljava_util_Calendar_ == IntPtr.Zero)
				id_isMonthBefore_Ljava_util_Calendar_Ljava_util_Calendar_ = JNIEnv.GetStaticMethodID (class_ref, "isMonthBefore", "(Ljava/util/Calendar;Ljava/util/Calendar;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (firstCalendar);
				__args [1] = new JValue (secondCalendar);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isMonthBefore_Ljava_util_Calendar_Ljava_util_Calendar_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setMidnight_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DateUtils']/method[@name='setMidnight' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("setMidnight", "(Ljava/util/Calendar;)V", "")]
		public static unsafe void SetMidnight (global::Java.Util.Calendar calendar)
		{
			if (id_setMidnight_Ljava_util_Calendar_ == IntPtr.Zero)
				id_setMidnight_Ljava_util_Calendar_ = JNIEnv.GetStaticMethodID (class_ref, "setMidnight", "(Ljava/util/Calendar;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (calendar);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setMidnight_Ljava_util_Calendar_, __args);
			} finally {
			}
		}

	}
}

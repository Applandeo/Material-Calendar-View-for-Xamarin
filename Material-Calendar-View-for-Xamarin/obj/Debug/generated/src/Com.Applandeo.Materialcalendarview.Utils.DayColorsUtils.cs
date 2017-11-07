using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applandeo.Materialcalendarview.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DayColorsUtils']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/utils/DayColorsUtils", DoNotGenerateAcw=true)]
	public partial class DayColorsUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applandeo/materialcalendarview/utils/DayColorsUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DayColorsUtils); }
		}

		protected DayColorsUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DayColorsUtils']/constructor[@name='DayColorsUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DayColorsUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DayColorsUtils)) {
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

		static IntPtr id_setCurrentMonthDayColors_Landroid_content_Context_Ljava_util_Calendar_Ljava_util_Calendar_Landroid_widget_TextView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DayColorsUtils']/method[@name='setCurrentMonthDayColors' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Calendar'] and parameter[3][@type='java.util.Calendar'] and parameter[4][@type='android.widget.TextView'] and parameter[5][@type='int']]"
		[Register ("setCurrentMonthDayColors", "(Landroid/content/Context;Ljava/util/Calendar;Ljava/util/Calendar;Landroid/widget/TextView;I)V", "")]
		public static unsafe void SetCurrentMonthDayColors (global::Android.Content.Context context, global::Java.Util.Calendar day, global::Java.Util.Calendar today, global::Android.Widget.TextView dayLabel, int todayLabelColor)
		{
			if (id_setCurrentMonthDayColors_Landroid_content_Context_Ljava_util_Calendar_Ljava_util_Calendar_Landroid_widget_TextView_I == IntPtr.Zero)
				id_setCurrentMonthDayColors_Landroid_content_Context_Ljava_util_Calendar_Ljava_util_Calendar_Landroid_widget_TextView_I = JNIEnv.GetStaticMethodID (class_ref, "setCurrentMonthDayColors", "(Landroid/content/Context;Ljava/util/Calendar;Ljava/util/Calendar;Landroid/widget/TextView;I)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (context);
				__args [1] = new JValue (day);
				__args [2] = new JValue (today);
				__args [3] = new JValue (dayLabel);
				__args [4] = new JValue (todayLabelColor);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCurrentMonthDayColors_Landroid_content_Context_Ljava_util_Calendar_Ljava_util_Calendar_Landroid_widget_TextView_I, __args);
			} finally {
			}
		}

		static IntPtr id_setDayColors_Landroid_widget_TextView_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DayColorsUtils']/method[@name='setDayColors' and count(parameter)=4 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setDayColors", "(Landroid/widget/TextView;III)V", "")]
		public static unsafe void SetDayColors (global::Android.Widget.TextView textView, int textColor, int typeface, int background)
		{
			if (id_setDayColors_Landroid_widget_TextView_III == IntPtr.Zero)
				id_setDayColors_Landroid_widget_TextView_III = JNIEnv.GetStaticMethodID (class_ref, "setDayColors", "(Landroid/widget/TextView;III)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (textView);
				__args [1] = new JValue (textColor);
				__args [2] = new JValue (typeface);
				__args [3] = new JValue (background);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDayColors_Landroid_widget_TextView_III, __args);
			} finally {
			}
		}

		static IntPtr id_setSelectedDayColors_Landroid_content_Context_Landroid_widget_TextView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DayColorsUtils']/method[@name='setSelectedDayColors' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.widget.TextView'] and parameter[3][@type='int']]"
		[Register ("setSelectedDayColors", "(Landroid/content/Context;Landroid/widget/TextView;I)V", "")]
		public static unsafe void SetSelectedDayColors (global::Android.Content.Context context, global::Android.Widget.TextView dayLabel, int selectionColor)
		{
			if (id_setSelectedDayColors_Landroid_content_Context_Landroid_widget_TextView_I == IntPtr.Zero)
				id_setSelectedDayColors_Landroid_content_Context_Landroid_widget_TextView_I = JNIEnv.GetStaticMethodID (class_ref, "setSelectedDayColors", "(Landroid/content/Context;Landroid/widget/TextView;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (dayLabel);
				__args [2] = new JValue (selectionColor);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setSelectedDayColors_Landroid_content_Context_Landroid_widget_TextView_I, __args);
			} finally {
			}
		}

	}
}

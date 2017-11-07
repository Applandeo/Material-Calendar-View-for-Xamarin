using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applandeo.Materialcalendarview.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='SelectedDay']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/utils/SelectedDay", DoNotGenerateAcw=true)]
	public partial class SelectedDay : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applandeo/materialcalendarview/utils/SelectedDay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SelectedDay); }
		}

		protected SelectedDay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_Ljava_util_Calendar_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='SelectedDay']/constructor[@name='SelectedDay' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.util.Calendar']]"
		[Register (".ctor", "(Landroid/view/View;Ljava/util/Calendar;)V", "")]
		public unsafe SelectedDay (global::Android.Views.View view, global::Java.Util.Calendar calendar)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (view);
				__args [1] = new JValue (calendar);
				if (((object) this).GetType () != typeof (SelectedDay)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/view/View;Ljava/util/Calendar;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/view/View;Ljava/util/Calendar;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_View_Ljava_util_Calendar_ == IntPtr.Zero)
					id_ctor_Landroid_view_View_Ljava_util_Calendar_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;Ljava/util/Calendar;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_Ljava_util_Calendar_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_view_View_Ljava_util_Calendar_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_util_Calendar_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='SelectedDay']/constructor[@name='SelectedDay' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register (".ctor", "(Ljava/util/Calendar;)V", "")]
		public unsafe SelectedDay (global::Java.Util.Calendar calendar)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (calendar);
				if (((object) this).GetType () != typeof (SelectedDay)) {
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
			global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Calendar);
		}
#pragma warning restore 0169

		static IntPtr id_getCalendar;
		public virtual unsafe global::Java.Util.Calendar Calendar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='SelectedDay']/method[@name='getCalendar' and count(parameter)=0]"
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

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		static Delegate cb_setView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetView_Landroid_view_View_Handler ()
		{
			if (cb_setView_Landroid_view_View_ == null)
				cb_setView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetView_Landroid_view_View_);
			return cb_setView_Landroid_view_View_;
		}

		static void n_SetView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.View = view;
		}
#pragma warning restore 0169

		static IntPtr id_getView;
		static IntPtr id_setView_Landroid_view_View_;
		public virtual unsafe global::Android.Views.View View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='SelectedDay']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get {
				if (id_getView == IntPtr.Zero)
					id_getView = JNIEnv.GetMethodID (class_ref, "getView", "()Landroid/view/View;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='SelectedDay']/method[@name='setView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setView", "(Landroid/view/View;)V", "GetSetView_Landroid_view_View_Handler")]
			set {
				if (id_setView_Landroid_view_View_ == IntPtr.Zero)
					id_setView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setView", "(Landroid/view/View;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setView_Landroid_view_View_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setView", "(Landroid/view/View;)V"), __args);
				} finally {
				}
			}
		}

	}
}

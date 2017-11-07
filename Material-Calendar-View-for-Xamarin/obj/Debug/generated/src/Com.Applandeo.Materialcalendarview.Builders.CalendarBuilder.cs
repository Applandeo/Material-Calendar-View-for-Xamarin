using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applandeo.Materialcalendarview.Builders {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='CalendarBuilder']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/builders/CalendarBuilder", DoNotGenerateAcw=true)]
	public partial class CalendarBuilder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applandeo/materialcalendarview/builders/CalendarBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CalendarBuilder); }
		}

		protected CalendarBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='CalendarBuilder']/constructor[@name='CalendarBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CalendarBuilder (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				if (((object) this).GetType () != typeof (CalendarBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_create;
#pragma warning disable 0169
		static Delegate GetCreateHandler ()
		{
			if (cb_create == null)
				cb_create = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Create);
			return cb_create;
		}

		static IntPtr n_Create (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Create ());
		}
#pragma warning restore 0169

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='CalendarBuilder']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/applandeo/materialcalendarview/CalendarView;", "GetCreateHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.CalendarView Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetMethodID (class_ref, "create", "()Lcom/applandeo/materialcalendarview/CalendarView;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "()Lcom/applandeo/materialcalendarview/CalendarView;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_datePicker_Z;
#pragma warning disable 0169
		static Delegate GetDatePicker_ZHandler ()
		{
			if (cb_datePicker_Z == null)
				cb_datePicker_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_DatePicker_Z);
			return cb_datePicker_Z;
		}

		static IntPtr n_DatePicker_Z (IntPtr jnienv, IntPtr native__this, bool isDatePicker)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DatePicker (isDatePicker));
		}
#pragma warning restore 0169

		static IntPtr id_datePicker_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='CalendarBuilder']/method[@name='datePicker' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("datePicker", "(Z)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;", "GetDatePicker_ZHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder DatePicker (bool isDatePicker)
		{
			if (id_datePicker_Z == IntPtr.Zero)
				id_datePicker_Z = JNIEnv.GetMethodID (class_ref, "datePicker", "(Z)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (isDatePicker);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_datePicker_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "datePicker", "(Z)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_forwardButtonSrc_I;
#pragma warning disable 0169
		static Delegate GetForwardButtonSrc_IHandler ()
		{
			if (cb_forwardButtonSrc_I == null)
				cb_forwardButtonSrc_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ForwardButtonSrc_I);
			return cb_forwardButtonSrc_I;
		}

		static IntPtr n_ForwardButtonSrc_I (IntPtr jnienv, IntPtr native__this, int drawable)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ForwardButtonSrc (drawable));
		}
#pragma warning restore 0169

		static IntPtr id_forwardButtonSrc_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='CalendarBuilder']/method[@name='forwardButtonSrc' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("forwardButtonSrc", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;", "GetForwardButtonSrc_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder ForwardButtonSrc (int drawable)
		{
			if (id_forwardButtonSrc_I == IntPtr.Zero)
				id_forwardButtonSrc_I = JNIEnv.GetMethodID (class_ref, "forwardButtonSrc", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (drawable);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_forwardButtonSrc_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "forwardButtonSrc", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_headerColor_I;
#pragma warning disable 0169
		static Delegate GetHeaderColor_IHandler ()
		{
			if (cb_headerColor_I == null)
				cb_headerColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_HeaderColor_I);
			return cb_headerColor_I;
		}

		static IntPtr n_HeaderColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeaderColor (color));
		}
#pragma warning restore 0169

		static IntPtr id_headerColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='CalendarBuilder']/method[@name='headerColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("headerColor", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;", "GetHeaderColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder HeaderColor (int color)
		{
			if (id_headerColor_I == IntPtr.Zero)
				id_headerColor_I = JNIEnv.GetMethodID (class_ref, "headerColor", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (color);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_headerColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "headerColor", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_headerLabelColor_I;
#pragma warning disable 0169
		static Delegate GetHeaderLabelColor_IHandler ()
		{
			if (cb_headerLabelColor_I == null)
				cb_headerLabelColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_HeaderLabelColor_I);
			return cb_headerLabelColor_I;
		}

		static IntPtr n_HeaderLabelColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeaderLabelColor (color));
		}
#pragma warning restore 0169

		static IntPtr id_headerLabelColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='CalendarBuilder']/method[@name='headerLabelColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("headerLabelColor", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;", "GetHeaderLabelColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder HeaderLabelColor (int color)
		{
			if (id_headerLabelColor_I == IntPtr.Zero)
				id_headerLabelColor_I = JNIEnv.GetMethodID (class_ref, "headerLabelColor", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (color);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_headerLabelColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "headerLabelColor", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_maximumDate_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetMaximumDate_Ljava_util_Calendar_Handler ()
		{
			if (cb_maximumDate_Ljava_util_Calendar_ == null)
				cb_maximumDate_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MaximumDate_Ljava_util_Calendar_);
			return cb_maximumDate_Ljava_util_Calendar_;
		}

		static IntPtr n_MaximumDate_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calendar)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MaximumDate (calendar));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_maximumDate_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='CalendarBuilder']/method[@name='maximumDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("maximumDate", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;", "GetMaximumDate_Ljava_util_Calendar_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder MaximumDate (global::Java.Util.Calendar calendar)
		{
			if (id_maximumDate_Ljava_util_Calendar_ == IntPtr.Zero)
				id_maximumDate_Ljava_util_Calendar_ = JNIEnv.GetMethodID (class_ref, "maximumDate", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (calendar);

				global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_maximumDate_Ljava_util_Calendar_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "maximumDate", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_minimumDate_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetMinimumDate_Ljava_util_Calendar_Handler ()
		{
			if (cb_minimumDate_Ljava_util_Calendar_ == null)
				cb_minimumDate_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MinimumDate_Ljava_util_Calendar_);
			return cb_minimumDate_Ljava_util_Calendar_;
		}

		static IntPtr n_MinimumDate_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calendar)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MinimumDate (calendar));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_minimumDate_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='CalendarBuilder']/method[@name='minimumDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("minimumDate", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;", "GetMinimumDate_Ljava_util_Calendar_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder MinimumDate (global::Java.Util.Calendar calendar)
		{
			if (id_minimumDate_Ljava_util_Calendar_ == IntPtr.Zero)
				id_minimumDate_Ljava_util_Calendar_ = JNIEnv.GetMethodID (class_ref, "minimumDate", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (calendar);

				global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_minimumDate_Ljava_util_Calendar_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "minimumDate", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_previousButtonSrc_I;
#pragma warning disable 0169
		static Delegate GetPreviousButtonSrc_IHandler ()
		{
			if (cb_previousButtonSrc_I == null)
				cb_previousButtonSrc_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_PreviousButtonSrc_I);
			return cb_previousButtonSrc_I;
		}

		static IntPtr n_PreviousButtonSrc_I (IntPtr jnienv, IntPtr native__this, int drawable)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PreviousButtonSrc (drawable));
		}
#pragma warning restore 0169

		static IntPtr id_previousButtonSrc_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='CalendarBuilder']/method[@name='previousButtonSrc' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("previousButtonSrc", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;", "GetPreviousButtonSrc_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder PreviousButtonSrc (int drawable)
		{
			if (id_previousButtonSrc_I == IntPtr.Zero)
				id_previousButtonSrc_I = JNIEnv.GetMethodID (class_ref, "previousButtonSrc", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (drawable);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_previousButtonSrc_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "previousButtonSrc", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_selectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_;
#pragma warning disable 0169
		static Delegate GetSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_Handler ()
		{
			if (cb_selectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_ == null)
				cb_selectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_);
			return cb_selectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_;
		}

		static IntPtr n_SelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onSelectionAbilityListener)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener onSelectionAbilityListener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener> (native_onSelectionAbilityListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SelectionAbilityListener (onSelectionAbilityListener));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_selectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='CalendarBuilder']/method[@name='selectionAbilityListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnSelectionAbilityListener']]"
		[Register ("selectionAbilityListener", "(Lcom/applandeo/materialcalendarview/listeners/OnSelectionAbilityListener;)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;", "GetSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder SelectionAbilityListener (global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener onSelectionAbilityListener)
		{
			if (id_selectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_ == IntPtr.Zero)
				id_selectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_ = JNIEnv.GetMethodID (class_ref, "selectionAbilityListener", "(Lcom/applandeo/materialcalendarview/listeners/OnSelectionAbilityListener;)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onSelectionAbilityListener);

				global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_selectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "selectionAbilityListener", "(Lcom/applandeo/materialcalendarview/listeners/OnSelectionAbilityListener;)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_selectionColor_I;
#pragma warning disable 0169
		static Delegate GetSelectionColor_IHandler ()
		{
			if (cb_selectionColor_I == null)
				cb_selectionColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SelectionColor_I);
			return cb_selectionColor_I;
		}

		static IntPtr n_SelectionColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectionColor (color));
		}
#pragma warning restore 0169

		static IntPtr id_selectionColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='CalendarBuilder']/method[@name='selectionColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("selectionColor", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;", "GetSelectionColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder SelectionColor (int color)
		{
			if (id_selectionColor_I == IntPtr.Zero)
				id_selectionColor_I = JNIEnv.GetMethodID (class_ref, "selectionColor", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (color);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_selectionColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "selectionColor", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setType_I;
#pragma warning disable 0169
		static Delegate GetSetType_IHandler ()
		{
			if (cb_setType_I == null)
				cb_setType_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetType_I);
			return cb_setType_I;
		}

		static IntPtr n_SetType_I (IntPtr jnienv, IntPtr native__this, int calendarType)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetType (calendarType));
		}
#pragma warning restore 0169

		static IntPtr id_setType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='CalendarBuilder']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setType", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;", "GetSetType_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder SetType (int calendarType)
		{
			if (id_setType_I == IntPtr.Zero)
				id_setType_I = JNIEnv.GetMethodID (class_ref, "setType", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (calendarType);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setType_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_todayLabelColor_I;
#pragma warning disable 0169
		static Delegate GetTodayLabelColor_IHandler ()
		{
			if (cb_todayLabelColor_I == null)
				cb_todayLabelColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_TodayLabelColor_I);
			return cb_todayLabelColor_I;
		}

		static IntPtr n_TodayLabelColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TodayLabelColor (color));
		}
#pragma warning restore 0169

		static IntPtr id_todayLabelColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='CalendarBuilder']/method[@name='todayLabelColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("todayLabelColor", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;", "GetTodayLabelColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder TodayLabelColor (int color)
		{
			if (id_todayLabelColor_I == IntPtr.Zero)
				id_todayLabelColor_I = JNIEnv.GetMethodID (class_ref, "todayLabelColor", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (color);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_todayLabelColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.CalendarBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "todayLabelColor", "(I)Lcom/applandeo/materialcalendarview/builders/CalendarBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}

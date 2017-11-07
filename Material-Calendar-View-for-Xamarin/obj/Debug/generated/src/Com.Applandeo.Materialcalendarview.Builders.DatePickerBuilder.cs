using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applandeo.Materialcalendarview.Builders {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/builders/DatePickerBuilder", DoNotGenerateAcw=true)]
	public partial class DatePickerBuilder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applandeo/materialcalendarview/builders/DatePickerBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DatePickerBuilder); }
		}

		protected DatePickerBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/constructor[@name='DatePickerBuilder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applandeo.materialcalendarview.listeners.OnSelectDateListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/applandeo/materialcalendarview/listeners/OnSelectDateListener;)V", "")]
		public unsafe DatePickerBuilder (global::Android.Content.Context context, global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener onSelectDateListener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (onSelectDateListener);
				if (((object) this).GetType () != typeof (DatePickerBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/applandeo/materialcalendarview/listeners/OnSelectDateListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/applandeo/materialcalendarview/listeners/OnSelectDateListener;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/applandeo/materialcalendarview/listeners/OnSelectDateListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_, __args);
			} finally {
			}
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/applandeo/materialcalendarview/DatePicker;", "GetBuildHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.DatePicker Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/applandeo/materialcalendarview/DatePicker;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.DatePicker> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.DatePicker> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/applandeo/materialcalendarview/DatePicker;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_date_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetDate_Ljava_util_Calendar_Handler ()
		{
			if (cb_date_Ljava_util_Calendar_ == null)
				cb_date_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Date_Ljava_util_Calendar_);
			return cb_date_Ljava_util_Calendar_;
		}

		static IntPtr n_Date_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calendar)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Date (calendar));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_date_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='date' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("date", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetDate_Ljava_util_Calendar_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder Date (global::Java.Util.Calendar calendar)
		{
			if (id_date_Ljava_util_Calendar_ == IntPtr.Zero)
				id_date_Ljava_util_Calendar_ = JNIEnv.GetMethodID (class_ref, "date", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (calendar);

				global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_date_Ljava_util_Calendar_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "date", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_dialogButtonsColor_I;
#pragma warning disable 0169
		static Delegate GetDialogButtonsColor_IHandler ()
		{
			if (cb_dialogButtonsColor_I == null)
				cb_dialogButtonsColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_DialogButtonsColor_I);
			return cb_dialogButtonsColor_I;
		}

		static IntPtr n_DialogButtonsColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DialogButtonsColor (color));
		}
#pragma warning restore 0169

		static IntPtr id_dialogButtonsColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='dialogButtonsColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("dialogButtonsColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetDialogButtonsColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder DialogButtonsColor (int color)
		{
			if (id_dialogButtonsColor_I == IntPtr.Zero)
				id_dialogButtonsColor_I = JNIEnv.GetMethodID (class_ref, "dialogButtonsColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (color);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dialogButtonsColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dialogButtonsColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ForwardButtonSrc (drawable));
		}
#pragma warning restore 0169

		static IntPtr id_forwardButtonSrc_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='forwardButtonSrc' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("forwardButtonSrc", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetForwardButtonSrc_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder ForwardButtonSrc (int drawable)
		{
			if (id_forwardButtonSrc_I == IntPtr.Zero)
				id_forwardButtonSrc_I = JNIEnv.GetMethodID (class_ref, "forwardButtonSrc", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (drawable);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_forwardButtonSrc_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "forwardButtonSrc", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeaderColor (color));
		}
#pragma warning restore 0169

		static IntPtr id_headerColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='headerColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("headerColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetHeaderColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder HeaderColor (int color)
		{
			if (id_headerColor_I == IntPtr.Zero)
				id_headerColor_I = JNIEnv.GetMethodID (class_ref, "headerColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (color);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_headerColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "headerColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeaderLabelColor (color));
		}
#pragma warning restore 0169

		static IntPtr id_headerLabelColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='headerLabelColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("headerLabelColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetHeaderLabelColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder HeaderLabelColor (int color)
		{
			if (id_headerLabelColor_I == IntPtr.Zero)
				id_headerLabelColor_I = JNIEnv.GetMethodID (class_ref, "headerLabelColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (color);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_headerLabelColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "headerLabelColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MaximumDate (calendar));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_maximumDate_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='maximumDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("maximumDate", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetMaximumDate_Ljava_util_Calendar_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder MaximumDate (global::Java.Util.Calendar calendar)
		{
			if (id_maximumDate_Ljava_util_Calendar_ == IntPtr.Zero)
				id_maximumDate_Ljava_util_Calendar_ = JNIEnv.GetMethodID (class_ref, "maximumDate", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (calendar);

				global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_maximumDate_Ljava_util_Calendar_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "maximumDate", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MinimumDate (calendar));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_minimumDate_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='minimumDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("minimumDate", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetMinimumDate_Ljava_util_Calendar_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder MinimumDate (global::Java.Util.Calendar calendar)
		{
			if (id_minimumDate_Ljava_util_Calendar_ == IntPtr.Zero)
				id_minimumDate_Ljava_util_Calendar_ = JNIEnv.GetMethodID (class_ref, "minimumDate", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (calendar);

				global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_minimumDate_Ljava_util_Calendar_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "minimumDate", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_pickerType_I;
#pragma warning disable 0169
		static Delegate GetPickerType_IHandler ()
		{
			if (cb_pickerType_I == null)
				cb_pickerType_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_PickerType_I);
			return cb_pickerType_I;
		}

		static IntPtr n_PickerType_I (IntPtr jnienv, IntPtr native__this, int calendarType)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PickerType (calendarType));
		}
#pragma warning restore 0169

		static IntPtr id_pickerType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='pickerType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pickerType", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetPickerType_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder PickerType (int calendarType)
		{
			if (id_pickerType_I == IntPtr.Zero)
				id_pickerType_I = JNIEnv.GetMethodID (class_ref, "pickerType", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (calendarType);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pickerType_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pickerType", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PreviousButtonSrc (drawable));
		}
#pragma warning restore 0169

		static IntPtr id_previousButtonSrc_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='previousButtonSrc' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("previousButtonSrc", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetPreviousButtonSrc_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder PreviousButtonSrc (int drawable)
		{
			if (id_previousButtonSrc_I == IntPtr.Zero)
				id_previousButtonSrc_I = JNIEnv.GetMethodID (class_ref, "previousButtonSrc", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (drawable);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_previousButtonSrc_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "previousButtonSrc", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectionColor (color));
		}
#pragma warning restore 0169

		static IntPtr id_selectionColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='selectionColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("selectionColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSelectionColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SelectionColor (int color)
		{
			if (id_selectionColor_I == IntPtr.Zero)
				id_selectionColor_I = JNIEnv.GetMethodID (class_ref, "selectionColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (color);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_selectionColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "selectionColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Show ());
		}
#pragma warning restore 0169

		static IntPtr id_show;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='show' and count(parameter)=0]"
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
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TodayLabelColor (color));
		}
#pragma warning restore 0169

		static IntPtr id_todayLabelColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='todayLabelColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("todayLabelColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetTodayLabelColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder TodayLabelColor (int color)
		{
			if (id_todayLabelColor_I == IntPtr.Zero)
				id_todayLabelColor_I = JNIEnv.GetMethodID (class_ref, "todayLabelColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (color);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_todayLabelColor_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "todayLabelColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}

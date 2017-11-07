using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applandeo.Materialcalendarview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/CalendarView", DoNotGenerateAcw=true)]
	public partial class CalendarView : global::Android.Widget.LinearLayout {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/field[@name='CLASSIC']"
		[Register ("CLASSIC")]
		public const int Classic = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/field[@name='MANY_DAYS_PICKER']"
		[Register ("MANY_DAYS_PICKER")]
		public const int ManyDaysPicker = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/field[@name='ONE_DAY_PICKER']"
		[Register ("ONE_DAY_PICKER")]
		public const int OneDayPicker = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/field[@name='RANGE_PICKER']"
		[Register ("RANGE_PICKER")]
		public const int RangePicker = (int) 3;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applandeo/materialcalendarview/CalendarView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CalendarView); }
		}

		protected CalendarView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/constructor[@name='CalendarView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe CalendarView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (attrs);
				if (((object) this).GetType () != typeof (CalendarView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/constructor[@name='CalendarView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe CalendarView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (context);
				__args [1] = new JValue (attrs);
				__args [2] = new JValue (defStyleAttr);
				if (((object) this).GetType () != typeof (CalendarView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_applandeo_materialcalendarview_utils_CalendarProperties_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/constructor[@name='CalendarView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applandeo.materialcalendarview.utils.CalendarProperties']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/applandeo/materialcalendarview/utils/CalendarProperties;)V", "")]
		public unsafe CalendarView (global::Android.Content.Context context, global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties calendarProperties)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (calendarProperties);
				if (((object) this).GetType () != typeof (CalendarView)) {
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

		static Delegate cb_getCurrentPageDate;
#pragma warning disable 0169
		static Delegate GetGetCurrentPageDateHandler ()
		{
			if (cb_getCurrentPageDate == null)
				cb_getCurrentPageDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentPageDate);
			return cb_getCurrentPageDate;
		}

		static IntPtr n_GetCurrentPageDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentPageDate);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentPageDate;
		public virtual unsafe global::Java.Util.Calendar CurrentPageDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='getCurrentPageDate' and count(parameter)=0]"
			[Register ("getCurrentPageDate", "()Ljava/util/Calendar;", "GetGetCurrentPageDateHandler")]
			get {
				if (id_getCurrentPageDate == IntPtr.Zero)
					id_getCurrentPageDate = JNIEnv.GetMethodID (class_ref, "getCurrentPageDate", "()Ljava/util/Calendar;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentPageDate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentPageDate", "()Ljava/util/Calendar;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFirstSelectedDate;
#pragma warning disable 0169
		static Delegate GetGetFirstSelectedDateHandler ()
		{
			if (cb_getFirstSelectedDate == null)
				cb_getFirstSelectedDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirstSelectedDate);
			return cb_getFirstSelectedDate;
		}

		static IntPtr n_GetFirstSelectedDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FirstSelectedDate);
		}
#pragma warning restore 0169

		static IntPtr id_getFirstSelectedDate;
		public virtual unsafe global::Java.Util.Calendar FirstSelectedDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='getFirstSelectedDate' and count(parameter)=0]"
			[Register ("getFirstSelectedDate", "()Ljava/util/Calendar;", "GetGetFirstSelectedDateHandler")]
			get {
				if (id_getFirstSelectedDate == IntPtr.Zero)
					id_getFirstSelectedDate = JNIEnv.GetMethodID (class_ref, "getFirstSelectedDate", "()Ljava/util/Calendar;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirstSelectedDate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstSelectedDate", "()Ljava/util/Calendar;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedDate;
#pragma warning disable 0169
		static Delegate GetGetSelectedDateHandler ()
		{
			if (cb_getSelectedDate == null)
				cb_getSelectedDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedDate);
			return cb_getSelectedDate;
		}

		static IntPtr n_GetSelectedDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectedDate);
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedDate;
		[Obsolete (@"deprecated")]
		public virtual unsafe global::Java.Util.Calendar SelectedDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='getSelectedDate' and count(parameter)=0]"
			[Register ("getSelectedDate", "()Ljava/util/Calendar;", "GetGetSelectedDateHandler")]
			get {
				if (id_getSelectedDate == IntPtr.Zero)
					id_getSelectedDate = JNIEnv.GetMethodID (class_ref, "getSelectedDate", "()Ljava/util/Calendar;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedDate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedDate", "()Ljava/util/Calendar;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedDates;
#pragma warning disable 0169
		static Delegate GetGetSelectedDatesHandler ()
		{
			if (cb_getSelectedDates == null)
				cb_getSelectedDates = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedDates);
			return cb_getSelectedDates;
		}

		static IntPtr n_GetSelectedDates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Util.Calendar>.ToLocalJniHandle (__this.SelectedDates);
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedDates;
		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Util.Calendar> SelectedDates {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='getSelectedDates' and count(parameter)=0]"
			[Register ("getSelectedDates", "()Ljava/util/List;", "GetGetSelectedDatesHandler")]
			get {
				if (id_getSelectedDates == IntPtr.Zero)
					id_getSelectedDates = JNIEnv.GetMethodID (class_ref, "getSelectedDates", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Java.Util.Calendar>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedDates), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Java.Util.Calendar>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedDates", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Create ());
		}
#pragma warning restore 0169

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='create' and count(parameter)=0]"
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

		static Delegate cb_setDate_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetSetDate_Ljava_util_Calendar_Handler ()
		{
			if (cb_setDate_Ljava_util_Calendar_ == null)
				cb_setDate_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDate_Ljava_util_Calendar_);
			return cb_setDate_Ljava_util_Calendar_;
		}

		static void n_SetDate_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar date = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_date, JniHandleOwnership.DoNotTransfer);
			__this.SetDate (date);
		}
#pragma warning restore 0169

		static IntPtr id_setDate_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("setDate", "(Ljava/util/Calendar;)V", "GetSetDate_Ljava_util_Calendar_Handler")]
		public virtual unsafe void SetDate (global::Java.Util.Calendar date)
		{
			if (id_setDate_Ljava_util_Calendar_ == IntPtr.Zero)
				id_setDate_Ljava_util_Calendar_ = JNIEnv.GetMethodID (class_ref, "setDate", "(Ljava/util/Calendar;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (date);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDate_Ljava_util_Calendar_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDate", "(Ljava/util/Calendar;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDate_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetDate_Ljava_util_Date_Handler ()
		{
			if (cb_setDate_Ljava_util_Date_ == null)
				cb_setDate_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDate_Ljava_util_Date_);
			return cb_setDate_Ljava_util_Date_;
		}

		static void n_SetDate_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_currentDate)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date currentDate = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_currentDate, JniHandleOwnership.DoNotTransfer);
			__this.SetDate (currentDate);
		}
#pragma warning restore 0169

		static IntPtr id_setDate_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setDate' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("setDate", "(Ljava/util/Date;)V", "GetSetDate_Ljava_util_Date_Handler")]
		public virtual unsafe void SetDate (global::Java.Util.Date currentDate)
		{
			if (id_setDate_Ljava_util_Date_ == IntPtr.Zero)
				id_setDate_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setDate", "(Ljava/util/Date;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (currentDate);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDate_Ljava_util_Date_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDate", "(Ljava/util/Date;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setEvents_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetEvents_Ljava_util_List_Handler ()
		{
			if (cb_setEvents_Ljava_util_List_ == null)
				cb_setEvents_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEvents_Ljava_util_List_);
			return cb_setEvents_Ljava_util_List_;
		}

		static void n_SetEvents_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventDays)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var eventDays = global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.EventDay>.FromJniHandle (native_eventDays, JniHandleOwnership.DoNotTransfer);
			__this.SetEvents (eventDays);
		}
#pragma warning restore 0169

		static IntPtr id_setEvents_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setEvents' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applandeo.materialcalendarview.EventDay&gt;']]"
		[Register ("setEvents", "(Ljava/util/List;)V", "GetSetEvents_Ljava_util_List_Handler")]
		public virtual unsafe void SetEvents (global::System.Collections.Generic.IList<global::Com.Applandeo.Materialcalendarview.EventDay> eventDays)
		{
			if (id_setEvents_Ljava_util_List_ == IntPtr.Zero)
				id_setEvents_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setEvents", "(Ljava/util/List;)V");
			IntPtr native_eventDays = global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.EventDay>.ToLocalJniHandle (eventDays);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_eventDays);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEvents_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEvents", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_eventDays);
			}
		}

		static Delegate cb_setMaximumDate_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetSetMaximumDate_Ljava_util_Calendar_Handler ()
		{
			if (cb_setMaximumDate_Ljava_util_Calendar_ == null)
				cb_setMaximumDate_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMaximumDate_Ljava_util_Calendar_);
			return cb_setMaximumDate_Ljava_util_Calendar_;
		}

		static void n_SetMaximumDate_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calendar)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			__this.SetMaximumDate (calendar);
		}
#pragma warning restore 0169

		static IntPtr id_setMaximumDate_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setMaximumDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("setMaximumDate", "(Ljava/util/Calendar;)V", "GetSetMaximumDate_Ljava_util_Calendar_Handler")]
		public virtual unsafe void SetMaximumDate (global::Java.Util.Calendar calendar)
		{
			if (id_setMaximumDate_Ljava_util_Calendar_ == IntPtr.Zero)
				id_setMaximumDate_Ljava_util_Calendar_ = JNIEnv.GetMethodID (class_ref, "setMaximumDate", "(Ljava/util/Calendar;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (calendar);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaximumDate_Ljava_util_Calendar_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaximumDate", "(Ljava/util/Calendar;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMinimumDate_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetSetMinimumDate_Ljava_util_Calendar_Handler ()
		{
			if (cb_setMinimumDate_Ljava_util_Calendar_ == null)
				cb_setMinimumDate_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMinimumDate_Ljava_util_Calendar_);
			return cb_setMinimumDate_Ljava_util_Calendar_;
		}

		static void n_SetMinimumDate_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calendar)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			__this.SetMinimumDate (calendar);
		}
#pragma warning restore 0169

		static IntPtr id_setMinimumDate_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setMinimumDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("setMinimumDate", "(Ljava/util/Calendar;)V", "GetSetMinimumDate_Ljava_util_Calendar_Handler")]
		public virtual unsafe void SetMinimumDate (global::Java.Util.Calendar calendar)
		{
			if (id_setMinimumDate_Ljava_util_Calendar_ == IntPtr.Zero)
				id_setMinimumDate_Ljava_util_Calendar_ = JNIEnv.GetMethodID (class_ref, "setMinimumDate", "(Ljava/util/Calendar;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (calendar);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMinimumDate_Ljava_util_Calendar_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinimumDate", "(Ljava/util/Calendar;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_Handler ()
		{
			if (cb_setOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_ == null)
				cb_setOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_);
			return cb_setOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_;
		}

		static void n_SetOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onDayClickListener)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener onDayClickListener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener> (native_onDayClickListener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnDayClickListener (onDayClickListener);
		}
#pragma warning restore 0169

		static IntPtr id_setOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setOnDayClickListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnDayClickListener']]"
		[Register ("setOnDayClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnDayClickListener;)V", "GetSetOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_Handler")]
		public virtual unsafe void SetOnDayClickListener (global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener onDayClickListener)
		{
			if (id_setOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_ == IntPtr.Zero)
				id_setOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnDayClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnDayClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (onDayClickListener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnDayClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnDayClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_Handler ()
		{
			if (cb_setOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_ == null)
				cb_setOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_);
			return cb_setOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_;
		}

		static void n_SetOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener listener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnForwardButtonClickListener (listener);
		}
#pragma warning restore 0169

		static IntPtr id_setOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setOnForwardButtonClickListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnNavigationButtonClickListener']]"
		[Register ("setOnForwardButtonClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener;)V", "GetSetOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_Handler")]
		public virtual unsafe void SetOnForwardButtonClickListener (global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener listener)
		{
			if (id_setOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_ == IntPtr.Zero)
				id_setOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnForwardButtonClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnForwardButtonClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_Handler ()
		{
			if (cb_setOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_ == null)
				cb_setOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_);
			return cb_setOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_;
		}

		static void n_SetOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener listener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnPreviousButtonClickListener (listener);
		}
#pragma warning restore 0169

		static IntPtr id_setOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setOnPreviousButtonClickListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnNavigationButtonClickListener']]"
		[Register ("setOnPreviousButtonClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener;)V", "GetSetOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_Handler")]
		public virtual unsafe void SetOnPreviousButtonClickListener (global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener listener)
		{
			if (id_setOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_ == IntPtr.Zero)
				id_setOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnPreviousButtonClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnPreviousButtonClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_showCurrentMonthPage;
#pragma warning disable 0169
		static Delegate GetShowCurrentMonthPageHandler ()
		{
			if (cb_showCurrentMonthPage == null)
				cb_showCurrentMonthPage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowCurrentMonthPage);
			return cb_showCurrentMonthPage;
		}

		static void n_ShowCurrentMonthPage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowCurrentMonthPage ();
		}
#pragma warning restore 0169

		static IntPtr id_showCurrentMonthPage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='showCurrentMonthPage' and count(parameter)=0]"
		[Register ("showCurrentMonthPage", "()V", "GetShowCurrentMonthPageHandler")]
		public virtual unsafe void ShowCurrentMonthPage ()
		{
			if (id_showCurrentMonthPage == IntPtr.Zero)
				id_showCurrentMonthPage = JNIEnv.GetMethodID (class_ref, "showCurrentMonthPage", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showCurrentMonthPage);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showCurrentMonthPage", "()V"));
			} finally {
			}
		}

#region "Event implementation for Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener"
		public event EventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.DayClickEventArgs> DayClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor>(
						ref weak_implementor_SetOnDayClickListener,
						__CreateIOnDayClickListenerImplementor,
						SetOnDayClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor>(
						ref weak_implementor_SetOnDayClickListener,
						global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor.__IsEmpty,
						__v => SetOnDayClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnDayClickListener;

		global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor __CreateIOnDayClickListenerImplementor ()
		{
			return new global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener"
		public event EventHandler ForwardButtonClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerImplementor>(
						ref weak_implementor_SetOnForwardButtonClickListener,
						__CreateIOnNavigationButtonClickListenerImplementor,
						SetOnForwardButtonClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerImplementor>(
						ref weak_implementor_SetOnForwardButtonClickListener,
						global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerImplementor.__IsEmpty,
						__v => SetOnForwardButtonClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		public event EventHandler PreviousButtonClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerImplementor>(
						ref weak_implementor_SetOnPreviousButtonClickListener,
						__CreateIOnNavigationButtonClickListenerImplementor,
						SetOnPreviousButtonClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerImplementor>(
						ref weak_implementor_SetOnPreviousButtonClickListener,
						global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerImplementor.__IsEmpty,
						__v => SetOnPreviousButtonClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnForwardButtonClickListener;
		WeakReference weak_implementor_SetOnPreviousButtonClickListener;

		global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerImplementor __CreateIOnNavigationButtonClickListenerImplementor ()
		{
			return new global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerImplementor (this);
		}
#endregion
	}
}

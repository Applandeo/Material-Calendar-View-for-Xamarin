using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applandeo.Materialcalendarview.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/utils/CalendarProperties", DoNotGenerateAcw=true)]
	public partial class CalendarProperties : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applandeo/materialcalendarview/utils/CalendarProperties", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CalendarProperties); }
		}

		protected CalendarProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/constructor[@name='CalendarProperties' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CalendarProperties ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CalendarProperties)) {
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
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Calendar);
		}
#pragma warning restore 0169

		static Delegate cb_setCalendar_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetSetCalendar_Ljava_util_Calendar_Handler ()
		{
			if (cb_setCalendar_Ljava_util_Calendar_ == null)
				cb_setCalendar_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCalendar_Ljava_util_Calendar_);
			return cb_setCalendar_Ljava_util_Calendar_;
		}

		static void n_SetCalendar_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calendar)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			__this.Calendar = calendar;
		}
#pragma warning restore 0169

		static IntPtr id_getCalendar;
		static IntPtr id_setCalendar_Ljava_util_Calendar_;
		public virtual unsafe global::Java.Util.Calendar Calendar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getCalendar' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setCalendar' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
			[Register ("setCalendar", "(Ljava/util/Calendar;)V", "GetSetCalendar_Ljava_util_Calendar_Handler")]
			set {
				if (id_setCalendar_Ljava_util_Calendar_ == IntPtr.Zero)
					id_setCalendar_Ljava_util_Calendar_ = JNIEnv.GetMethodID (class_ref, "setCalendar", "(Ljava/util/Calendar;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCalendar_Ljava_util_Calendar_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCalendar", "(Ljava/util/Calendar;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCalendarType;
#pragma warning disable 0169
		static Delegate GetGetCalendarTypeHandler ()
		{
			if (cb_getCalendarType == null)
				cb_getCalendarType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCalendarType);
			return cb_getCalendarType;
		}

		static int n_GetCalendarType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CalendarType;
		}
#pragma warning restore 0169

		static Delegate cb_setCalendarType_I;
#pragma warning disable 0169
		static Delegate GetSetCalendarType_IHandler ()
		{
			if (cb_setCalendarType_I == null)
				cb_setCalendarType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCalendarType_I);
			return cb_setCalendarType_I;
		}

		static void n_SetCalendarType_I (IntPtr jnienv, IntPtr native__this, int calendarType)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalendarType = calendarType;
		}
#pragma warning restore 0169

		static IntPtr id_getCalendarType;
		static IntPtr id_setCalendarType_I;
		public virtual unsafe int CalendarType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getCalendarType' and count(parameter)=0]"
			[Register ("getCalendarType", "()I", "GetGetCalendarTypeHandler")]
			get {
				if (id_getCalendarType == IntPtr.Zero)
					id_getCalendarType = JNIEnv.GetMethodID (class_ref, "getCalendarType", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCalendarType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCalendarType", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setCalendarType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCalendarType", "(I)V", "GetSetCalendarType_IHandler")]
			set {
				if (id_setCalendarType_I == IntPtr.Zero)
					id_setCalendarType_I = JNIEnv.GetMethodID (class_ref, "setCalendarType", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCalendarType_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCalendarType", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentDate;
#pragma warning disable 0169
		static Delegate GetGetCurrentDateHandler ()
		{
			if (cb_getCurrentDate == null)
				cb_getCurrentDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentDate);
			return cb_getCurrentDate;
		}

		static IntPtr n_GetCurrentDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentDate);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentDate;
		public virtual unsafe global::Java.Util.Calendar CurrentDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getCurrentDate' and count(parameter)=0]"
			[Register ("getCurrentDate", "()Ljava/util/Calendar;", "GetGetCurrentDateHandler")]
			get {
				if (id_getCurrentDate == IntPtr.Zero)
					id_getCurrentDate = JNIEnv.GetMethodID (class_ref, "getCurrentDate", "()Ljava/util/Calendar;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentDate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentDate", "()Ljava/util/Calendar;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDialogButtonsColor;
#pragma warning disable 0169
		static Delegate GetGetDialogButtonsColorHandler ()
		{
			if (cb_getDialogButtonsColor == null)
				cb_getDialogButtonsColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDialogButtonsColor);
			return cb_getDialogButtonsColor;
		}

		static int n_GetDialogButtonsColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DialogButtonsColor;
		}
#pragma warning restore 0169

		static Delegate cb_setDialogButtonsColor_I;
#pragma warning disable 0169
		static Delegate GetSetDialogButtonsColor_IHandler ()
		{
			if (cb_setDialogButtonsColor_I == null)
				cb_setDialogButtonsColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDialogButtonsColor_I);
			return cb_setDialogButtonsColor_I;
		}

		static void n_SetDialogButtonsColor_I (IntPtr jnienv, IntPtr native__this, int dialogButtonsColor)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DialogButtonsColor = dialogButtonsColor;
		}
#pragma warning restore 0169

		static IntPtr id_getDialogButtonsColor;
		static IntPtr id_setDialogButtonsColor_I;
		public virtual unsafe int DialogButtonsColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getDialogButtonsColor' and count(parameter)=0]"
			[Register ("getDialogButtonsColor", "()I", "GetGetDialogButtonsColorHandler")]
			get {
				if (id_getDialogButtonsColor == IntPtr.Zero)
					id_getDialogButtonsColor = JNIEnv.GetMethodID (class_ref, "getDialogButtonsColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDialogButtonsColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDialogButtonsColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setDialogButtonsColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDialogButtonsColor", "(I)V", "GetSetDialogButtonsColor_IHandler")]
			set {
				if (id_setDialogButtonsColor_I == IntPtr.Zero)
					id_setDialogButtonsColor_I = JNIEnv.GetMethodID (class_ref, "setDialogButtonsColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDialogButtonsColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDialogButtonsColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEventDays;
#pragma warning disable 0169
		static Delegate GetGetEventDaysHandler ()
		{
			if (cb_getEventDays == null)
				cb_getEventDays = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventDays);
			return cb_getEventDays;
		}

		static IntPtr n_GetEventDays (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.EventDay>.ToLocalJniHandle (__this.EventDays);
		}
#pragma warning restore 0169

		static Delegate cb_setEventDays_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetEventDays_Ljava_util_List_Handler ()
		{
			if (cb_setEventDays_Ljava_util_List_ == null)
				cb_setEventDays_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEventDays_Ljava_util_List_);
			return cb_setEventDays_Ljava_util_List_;
		}

		static void n_SetEventDays_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventDays)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var eventDays = global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.EventDay>.FromJniHandle (native_eventDays, JniHandleOwnership.DoNotTransfer);
			__this.EventDays = eventDays;
		}
#pragma warning restore 0169

		static IntPtr id_getEventDays;
		static IntPtr id_setEventDays_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applandeo.Materialcalendarview.EventDay> EventDays {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getEventDays' and count(parameter)=0]"
			[Register ("getEventDays", "()Ljava/util/List;", "GetGetEventDaysHandler")]
			get {
				if (id_getEventDays == IntPtr.Zero)
					id_getEventDays = JNIEnv.GetMethodID (class_ref, "getEventDays", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.EventDay>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEventDays), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.EventDay>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventDays", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setEventDays' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applandeo.materialcalendarview.EventDay&gt;']]"
			[Register ("setEventDays", "(Ljava/util/List;)V", "GetSetEventDays_Ljava_util_List_Handler")]
			set {
				if (id_setEventDays_Ljava_util_List_ == IntPtr.Zero)
					id_setEventDays_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setEventDays", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.EventDay>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEventDays_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEventDays", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getForwardButtonSrc;
#pragma warning disable 0169
		static Delegate GetGetForwardButtonSrcHandler ()
		{
			if (cb_getForwardButtonSrc == null)
				cb_getForwardButtonSrc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetForwardButtonSrc);
			return cb_getForwardButtonSrc;
		}

		static int n_GetForwardButtonSrc (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ForwardButtonSrc;
		}
#pragma warning restore 0169

		static Delegate cb_setForwardButtonSrc_I;
#pragma warning disable 0169
		static Delegate GetSetForwardButtonSrc_IHandler ()
		{
			if (cb_setForwardButtonSrc_I == null)
				cb_setForwardButtonSrc_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetForwardButtonSrc_I);
			return cb_setForwardButtonSrc_I;
		}

		static void n_SetForwardButtonSrc_I (IntPtr jnienv, IntPtr native__this, int forwardButtonSrc)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ForwardButtonSrc = forwardButtonSrc;
		}
#pragma warning restore 0169

		static IntPtr id_getForwardButtonSrc;
		static IntPtr id_setForwardButtonSrc_I;
		public virtual unsafe int ForwardButtonSrc {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getForwardButtonSrc' and count(parameter)=0]"
			[Register ("getForwardButtonSrc", "()I", "GetGetForwardButtonSrcHandler")]
			get {
				if (id_getForwardButtonSrc == IntPtr.Zero)
					id_getForwardButtonSrc = JNIEnv.GetMethodID (class_ref, "getForwardButtonSrc", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getForwardButtonSrc);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getForwardButtonSrc", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setForwardButtonSrc' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setForwardButtonSrc", "(I)V", "GetSetForwardButtonSrc_IHandler")]
			set {
				if (id_setForwardButtonSrc_I == IntPtr.Zero)
					id_setForwardButtonSrc_I = JNIEnv.GetMethodID (class_ref, "setForwardButtonSrc", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setForwardButtonSrc_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setForwardButtonSrc", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeaderColor;
#pragma warning disable 0169
		static Delegate GetGetHeaderColorHandler ()
		{
			if (cb_getHeaderColor == null)
				cb_getHeaderColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeaderColor);
			return cb_getHeaderColor;
		}

		static int n_GetHeaderColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderColor;
		}
#pragma warning restore 0169

		static Delegate cb_setHeaderColor_I;
#pragma warning disable 0169
		static Delegate GetSetHeaderColor_IHandler ()
		{
			if (cb_setHeaderColor_I == null)
				cb_setHeaderColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHeaderColor_I);
			return cb_setHeaderColor_I;
		}

		static void n_SetHeaderColor_I (IntPtr jnienv, IntPtr native__this, int headerColor)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HeaderColor = headerColor;
		}
#pragma warning restore 0169

		static IntPtr id_getHeaderColor;
		static IntPtr id_setHeaderColor_I;
		public virtual unsafe int HeaderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getHeaderColor' and count(parameter)=0]"
			[Register ("getHeaderColor", "()I", "GetGetHeaderColorHandler")]
			get {
				if (id_getHeaderColor == IntPtr.Zero)
					id_getHeaderColor = JNIEnv.GetMethodID (class_ref, "getHeaderColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeaderColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaderColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setHeaderColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHeaderColor", "(I)V", "GetSetHeaderColor_IHandler")]
			set {
				if (id_setHeaderColor_I == IntPtr.Zero)
					id_setHeaderColor_I = JNIEnv.GetMethodID (class_ref, "setHeaderColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeaderColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeaderColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeaderLabelColor;
#pragma warning disable 0169
		static Delegate GetGetHeaderLabelColorHandler ()
		{
			if (cb_getHeaderLabelColor == null)
				cb_getHeaderLabelColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeaderLabelColor);
			return cb_getHeaderLabelColor;
		}

		static int n_GetHeaderLabelColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderLabelColor;
		}
#pragma warning restore 0169

		static Delegate cb_setHeaderLabelColor_I;
#pragma warning disable 0169
		static Delegate GetSetHeaderLabelColor_IHandler ()
		{
			if (cb_setHeaderLabelColor_I == null)
				cb_setHeaderLabelColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHeaderLabelColor_I);
			return cb_setHeaderLabelColor_I;
		}

		static void n_SetHeaderLabelColor_I (IntPtr jnienv, IntPtr native__this, int headerLabelColor)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HeaderLabelColor = headerLabelColor;
		}
#pragma warning restore 0169

		static IntPtr id_getHeaderLabelColor;
		static IntPtr id_setHeaderLabelColor_I;
		public virtual unsafe int HeaderLabelColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getHeaderLabelColor' and count(parameter)=0]"
			[Register ("getHeaderLabelColor", "()I", "GetGetHeaderLabelColorHandler")]
			get {
				if (id_getHeaderLabelColor == IntPtr.Zero)
					id_getHeaderLabelColor = JNIEnv.GetMethodID (class_ref, "getHeaderLabelColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeaderLabelColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaderLabelColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setHeaderLabelColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHeaderLabelColor", "(I)V", "GetSetHeaderLabelColor_IHandler")]
			set {
				if (id_setHeaderLabelColor_I == IntPtr.Zero)
					id_setHeaderLabelColor_I = JNIEnv.GetMethodID (class_ref, "setHeaderLabelColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeaderLabelColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeaderLabelColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getItemLayoutResource;
#pragma warning disable 0169
		static Delegate GetGetItemLayoutResourceHandler ()
		{
			if (cb_getItemLayoutResource == null)
				cb_getItemLayoutResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemLayoutResource);
			return cb_getItemLayoutResource;
		}

		static int n_GetItemLayoutResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemLayoutResource;
		}
#pragma warning restore 0169

		static Delegate cb_setItemLayoutResource_I;
#pragma warning disable 0169
		static Delegate GetSetItemLayoutResource_IHandler ()
		{
			if (cb_setItemLayoutResource_I == null)
				cb_setItemLayoutResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetItemLayoutResource_I);
			return cb_setItemLayoutResource_I;
		}

		static void n_SetItemLayoutResource_I (IntPtr jnienv, IntPtr native__this, int itemLayoutResource)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemLayoutResource = itemLayoutResource;
		}
#pragma warning restore 0169

		static IntPtr id_getItemLayoutResource;
		static IntPtr id_setItemLayoutResource_I;
		public virtual unsafe int ItemLayoutResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getItemLayoutResource' and count(parameter)=0]"
			[Register ("getItemLayoutResource", "()I", "GetGetItemLayoutResourceHandler")]
			get {
				if (id_getItemLayoutResource == IntPtr.Zero)
					id_getItemLayoutResource = JNIEnv.GetMethodID (class_ref, "getItemLayoutResource", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemLayoutResource);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemLayoutResource", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setItemLayoutResource' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemLayoutResource", "(I)V", "GetSetItemLayoutResource_IHandler")]
			set {
				if (id_setItemLayoutResource_I == IntPtr.Zero)
					id_setItemLayoutResource_I = JNIEnv.GetMethodID (class_ref, "setItemLayoutResource", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setItemLayoutResource_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItemLayoutResource", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaximumDate;
#pragma warning disable 0169
		static Delegate GetGetMaximumDateHandler ()
		{
			if (cb_getMaximumDate == null)
				cb_getMaximumDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMaximumDate);
			return cb_getMaximumDate;
		}

		static IntPtr n_GetMaximumDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MaximumDate);
		}
#pragma warning restore 0169

		static Delegate cb_setMaximumDate_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetSetMaximumDate_Ljava_util_Calendar_Handler ()
		{
			if (cb_setMaximumDate_Ljava_util_Calendar_ == null)
				cb_setMaximumDate_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMaximumDate_Ljava_util_Calendar_);
			return cb_setMaximumDate_Ljava_util_Calendar_;
		}

		static void n_SetMaximumDate_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_maximumDate)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar maximumDate = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_maximumDate, JniHandleOwnership.DoNotTransfer);
			__this.MaximumDate = maximumDate;
		}
#pragma warning restore 0169

		static IntPtr id_getMaximumDate;
		static IntPtr id_setMaximumDate_Ljava_util_Calendar_;
		public virtual unsafe global::Java.Util.Calendar MaximumDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getMaximumDate' and count(parameter)=0]"
			[Register ("getMaximumDate", "()Ljava/util/Calendar;", "GetGetMaximumDateHandler")]
			get {
				if (id_getMaximumDate == IntPtr.Zero)
					id_getMaximumDate = JNIEnv.GetMethodID (class_ref, "getMaximumDate", "()Ljava/util/Calendar;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMaximumDate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaximumDate", "()Ljava/util/Calendar;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setMaximumDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
			[Register ("setMaximumDate", "(Ljava/util/Calendar;)V", "GetSetMaximumDate_Ljava_util_Calendar_Handler")]
			set {
				if (id_setMaximumDate_Ljava_util_Calendar_ == IntPtr.Zero)
					id_setMaximumDate_Ljava_util_Calendar_ = JNIEnv.GetMethodID (class_ref, "setMaximumDate", "(Ljava/util/Calendar;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaximumDate_Ljava_util_Calendar_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaximumDate", "(Ljava/util/Calendar;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinimumDate;
#pragma warning disable 0169
		static Delegate GetGetMinimumDateHandler ()
		{
			if (cb_getMinimumDate == null)
				cb_getMinimumDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMinimumDate);
			return cb_getMinimumDate;
		}

		static IntPtr n_GetMinimumDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MinimumDate);
		}
#pragma warning restore 0169

		static Delegate cb_setMinimumDate_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetSetMinimumDate_Ljava_util_Calendar_Handler ()
		{
			if (cb_setMinimumDate_Ljava_util_Calendar_ == null)
				cb_setMinimumDate_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMinimumDate_Ljava_util_Calendar_);
			return cb_setMinimumDate_Ljava_util_Calendar_;
		}

		static void n_SetMinimumDate_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_minimumDate)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar minimumDate = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_minimumDate, JniHandleOwnership.DoNotTransfer);
			__this.MinimumDate = minimumDate;
		}
#pragma warning restore 0169

		static IntPtr id_getMinimumDate;
		static IntPtr id_setMinimumDate_Ljava_util_Calendar_;
		public virtual unsafe global::Java.Util.Calendar MinimumDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getMinimumDate' and count(parameter)=0]"
			[Register ("getMinimumDate", "()Ljava/util/Calendar;", "GetGetMinimumDateHandler")]
			get {
				if (id_getMinimumDate == IntPtr.Zero)
					id_getMinimumDate = JNIEnv.GetMethodID (class_ref, "getMinimumDate", "()Ljava/util/Calendar;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMinimumDate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinimumDate", "()Ljava/util/Calendar;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setMinimumDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
			[Register ("setMinimumDate", "(Ljava/util/Calendar;)V", "GetSetMinimumDate_Ljava_util_Calendar_Handler")]
			set {
				if (id_setMinimumDate_Ljava_util_Calendar_ == IntPtr.Zero)
					id_setMinimumDate_Ljava_util_Calendar_ = JNIEnv.GetMethodID (class_ref, "setMinimumDate", "(Ljava/util/Calendar;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMinimumDate_Ljava_util_Calendar_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinimumDate", "(Ljava/util/Calendar;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOnDayClickListener;
#pragma warning disable 0169
		static Delegate GetGetOnDayClickListenerHandler ()
		{
			if (cb_getOnDayClickListener == null)
				cb_getOnDayClickListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnDayClickListener);
			return cb_getOnDayClickListener;
		}

		static IntPtr n_GetOnDayClickListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnDayClickListener);
		}
#pragma warning restore 0169

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
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener onDayClickListener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener> (native_onDayClickListener, JniHandleOwnership.DoNotTransfer);
			__this.OnDayClickListener = onDayClickListener;
		}
#pragma warning restore 0169

		static IntPtr id_getOnDayClickListener;
		static IntPtr id_setOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_;
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener OnDayClickListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getOnDayClickListener' and count(parameter)=0]"
			[Register ("getOnDayClickListener", "()Lcom/applandeo/materialcalendarview/listeners/OnDayClickListener;", "GetGetOnDayClickListenerHandler")]
			get {
				if (id_getOnDayClickListener == IntPtr.Zero)
					id_getOnDayClickListener = JNIEnv.GetMethodID (class_ref, "getOnDayClickListener", "()Lcom/applandeo/materialcalendarview/listeners/OnDayClickListener;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnDayClickListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnDayClickListener", "()Lcom/applandeo/materialcalendarview/listeners/OnDayClickListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setOnDayClickListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnDayClickListener']]"
			[Register ("setOnDayClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnDayClickListener;)V", "GetSetOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_Handler")]
			set {
				if (id_setOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_ == IntPtr.Zero)
					id_setOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnDayClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnDayClickListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnDayClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnDayClickListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOnForwardButtonClickListener;
#pragma warning disable 0169
		static Delegate GetGetOnForwardButtonClickListenerHandler ()
		{
			if (cb_getOnForwardButtonClickListener == null)
				cb_getOnForwardButtonClickListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnForwardButtonClickListener);
			return cb_getOnForwardButtonClickListener;
		}

		static IntPtr n_GetOnForwardButtonClickListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnForwardButtonClickListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_Handler ()
		{
			if (cb_setOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_ == null)
				cb_setOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_);
			return cb_setOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_;
		}

		static void n_SetOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onForwardButtonClickListener)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener onForwardButtonClickListener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener> (native_onForwardButtonClickListener, JniHandleOwnership.DoNotTransfer);
			__this.OnForwardButtonClickListener = onForwardButtonClickListener;
		}
#pragma warning restore 0169

		static IntPtr id_getOnForwardButtonClickListener;
		static IntPtr id_setOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_;
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener OnForwardButtonClickListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getOnForwardButtonClickListener' and count(parameter)=0]"
			[Register ("getOnForwardButtonClickListener", "()Lcom/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener;", "GetGetOnForwardButtonClickListenerHandler")]
			get {
				if (id_getOnForwardButtonClickListener == IntPtr.Zero)
					id_getOnForwardButtonClickListener = JNIEnv.GetMethodID (class_ref, "getOnForwardButtonClickListener", "()Lcom/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnForwardButtonClickListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnForwardButtonClickListener", "()Lcom/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setOnForwardButtonClickListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnNavigationButtonClickListener']]"
			[Register ("setOnForwardButtonClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener;)V", "GetSetOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_Handler")]
			set {
				if (id_setOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_ == IntPtr.Zero)
					id_setOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnForwardButtonClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnForwardButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnForwardButtonClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOnPreviousButtonClickListener;
#pragma warning disable 0169
		static Delegate GetGetOnPreviousButtonClickListenerHandler ()
		{
			if (cb_getOnPreviousButtonClickListener == null)
				cb_getOnPreviousButtonClickListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnPreviousButtonClickListener);
			return cb_getOnPreviousButtonClickListener;
		}

		static IntPtr n_GetOnPreviousButtonClickListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnPreviousButtonClickListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_Handler ()
		{
			if (cb_setOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_ == null)
				cb_setOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_);
			return cb_setOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_;
		}

		static void n_SetOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onPreviousButtonClickListener)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener onPreviousButtonClickListener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener> (native_onPreviousButtonClickListener, JniHandleOwnership.DoNotTransfer);
			__this.OnPreviousButtonClickListener = onPreviousButtonClickListener;
		}
#pragma warning restore 0169

		static IntPtr id_getOnPreviousButtonClickListener;
		static IntPtr id_setOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_;
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener OnPreviousButtonClickListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getOnPreviousButtonClickListener' and count(parameter)=0]"
			[Register ("getOnPreviousButtonClickListener", "()Lcom/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener;", "GetGetOnPreviousButtonClickListenerHandler")]
			get {
				if (id_getOnPreviousButtonClickListener == IntPtr.Zero)
					id_getOnPreviousButtonClickListener = JNIEnv.GetMethodID (class_ref, "getOnPreviousButtonClickListener", "()Lcom/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnPreviousButtonClickListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnPreviousButtonClickListener", "()Lcom/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setOnPreviousButtonClickListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnNavigationButtonClickListener']]"
			[Register ("setOnPreviousButtonClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener;)V", "GetSetOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_Handler")]
			set {
				if (id_setOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_ == IntPtr.Zero)
					id_setOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnPreviousButtonClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnPreviousButtonClickListener_Lcom_applandeo_materialcalendarview_listeners_OnNavigationButtonClickListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnPreviousButtonClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnNavigationButtonClickListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOnSelectDateListener;
#pragma warning disable 0169
		static Delegate GetGetOnSelectDateListenerHandler ()
		{
			if (cb_getOnSelectDateListener == null)
				cb_getOnSelectDateListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnSelectDateListener);
			return cb_getOnSelectDateListener;
		}

		static IntPtr n_GetOnSelectDateListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnSelectDateListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnSelectDateListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_;
#pragma warning disable 0169
		static Delegate GetSetOnSelectDateListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_Handler ()
		{
			if (cb_setOnSelectDateListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_ == null)
				cb_setOnSelectDateListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnSelectDateListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_);
			return cb_setOnSelectDateListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_;
		}

		static void n_SetOnSelectDateListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onSelectDateListener)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener onSelectDateListener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener> (native_onSelectDateListener, JniHandleOwnership.DoNotTransfer);
			__this.OnSelectDateListener = onSelectDateListener;
		}
#pragma warning restore 0169

		static IntPtr id_getOnSelectDateListener;
		static IntPtr id_setOnSelectDateListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_;
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener OnSelectDateListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getOnSelectDateListener' and count(parameter)=0]"
			[Register ("getOnSelectDateListener", "()Lcom/applandeo/materialcalendarview/listeners/OnSelectDateListener;", "GetGetOnSelectDateListenerHandler")]
			get {
				if (id_getOnSelectDateListener == IntPtr.Zero)
					id_getOnSelectDateListener = JNIEnv.GetMethodID (class_ref, "getOnSelectDateListener", "()Lcom/applandeo/materialcalendarview/listeners/OnSelectDateListener;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnSelectDateListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnSelectDateListener", "()Lcom/applandeo/materialcalendarview/listeners/OnSelectDateListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setOnSelectDateListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnSelectDateListener']]"
			[Register ("setOnSelectDateListener", "(Lcom/applandeo/materialcalendarview/listeners/OnSelectDateListener;)V", "GetSetOnSelectDateListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_Handler")]
			set {
				if (id_setOnSelectDateListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_ == IntPtr.Zero)
					id_setOnSelectDateListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_ = JNIEnv.GetMethodID (class_ref, "setOnSelectDateListener", "(Lcom/applandeo/materialcalendarview/listeners/OnSelectDateListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnSelectDateListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnSelectDateListener", "(Lcom/applandeo/materialcalendarview/listeners/OnSelectDateListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOnSelectionAbilityListener;
#pragma warning disable 0169
		static Delegate GetGetOnSelectionAbilityListenerHandler ()
		{
			if (cb_getOnSelectionAbilityListener == null)
				cb_getOnSelectionAbilityListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnSelectionAbilityListener);
			return cb_getOnSelectionAbilityListener;
		}

		static IntPtr n_GetOnSelectionAbilityListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnSelectionAbilityListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_;
#pragma warning disable 0169
		static Delegate GetSetOnSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_Handler ()
		{
			if (cb_setOnSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_ == null)
				cb_setOnSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_);
			return cb_setOnSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_;
		}

		static void n_SetOnSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onSelectionAbilityListener)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener onSelectionAbilityListener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener> (native_onSelectionAbilityListener, JniHandleOwnership.DoNotTransfer);
			__this.OnSelectionAbilityListener = onSelectionAbilityListener;
		}
#pragma warning restore 0169

		static IntPtr id_getOnSelectionAbilityListener;
		static IntPtr id_setOnSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_;
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener OnSelectionAbilityListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getOnSelectionAbilityListener' and count(parameter)=0]"
			[Register ("getOnSelectionAbilityListener", "()Lcom/applandeo/materialcalendarview/listeners/OnSelectionAbilityListener;", "GetGetOnSelectionAbilityListenerHandler")]
			get {
				if (id_getOnSelectionAbilityListener == IntPtr.Zero)
					id_getOnSelectionAbilityListener = JNIEnv.GetMethodID (class_ref, "getOnSelectionAbilityListener", "()Lcom/applandeo/materialcalendarview/listeners/OnSelectionAbilityListener;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnSelectionAbilityListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnSelectionAbilityListener", "()Lcom/applandeo/materialcalendarview/listeners/OnSelectionAbilityListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setOnSelectionAbilityListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnSelectionAbilityListener']]"
			[Register ("setOnSelectionAbilityListener", "(Lcom/applandeo/materialcalendarview/listeners/OnSelectionAbilityListener;)V", "GetSetOnSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_Handler")]
			set {
				if (id_setOnSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_ == IntPtr.Zero)
					id_setOnSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_ = JNIEnv.GetMethodID (class_ref, "setOnSelectionAbilityListener", "(Lcom/applandeo/materialcalendarview/listeners/OnSelectionAbilityListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnSelectionAbilityListener", "(Lcom/applandeo/materialcalendarview/listeners/OnSelectionAbilityListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPreviousButtonSrc;
#pragma warning disable 0169
		static Delegate GetGetPreviousButtonSrcHandler ()
		{
			if (cb_getPreviousButtonSrc == null)
				cb_getPreviousButtonSrc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPreviousButtonSrc);
			return cb_getPreviousButtonSrc;
		}

		static int n_GetPreviousButtonSrc (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreviousButtonSrc;
		}
#pragma warning restore 0169

		static Delegate cb_setPreviousButtonSrc_I;
#pragma warning disable 0169
		static Delegate GetSetPreviousButtonSrc_IHandler ()
		{
			if (cb_setPreviousButtonSrc_I == null)
				cb_setPreviousButtonSrc_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPreviousButtonSrc_I);
			return cb_setPreviousButtonSrc_I;
		}

		static void n_SetPreviousButtonSrc_I (IntPtr jnienv, IntPtr native__this, int previousButtonSrc)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PreviousButtonSrc = previousButtonSrc;
		}
#pragma warning restore 0169

		static IntPtr id_getPreviousButtonSrc;
		static IntPtr id_setPreviousButtonSrc_I;
		public virtual unsafe int PreviousButtonSrc {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getPreviousButtonSrc' and count(parameter)=0]"
			[Register ("getPreviousButtonSrc", "()I", "GetGetPreviousButtonSrcHandler")]
			get {
				if (id_getPreviousButtonSrc == IntPtr.Zero)
					id_getPreviousButtonSrc = JNIEnv.GetMethodID (class_ref, "getPreviousButtonSrc", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPreviousButtonSrc);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreviousButtonSrc", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setPreviousButtonSrc' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPreviousButtonSrc", "(I)V", "GetSetPreviousButtonSrc_IHandler")]
			set {
				if (id_setPreviousButtonSrc_I == IntPtr.Zero)
					id_setPreviousButtonSrc_I = JNIEnv.GetMethodID (class_ref, "setPreviousButtonSrc", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPreviousButtonSrc_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPreviousButtonSrc", "(I)V"), __args);
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
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectedDate);
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedDate;
		public virtual unsafe global::Java.Util.Calendar SelectedDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getSelectedDate' and count(parameter)=0]"
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

		static Delegate cb_getSelectionColor;
#pragma warning disable 0169
		static Delegate GetGetSelectionColorHandler ()
		{
			if (cb_getSelectionColor == null)
				cb_getSelectionColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectionColor);
			return cb_getSelectionColor;
		}

		static int n_GetSelectionColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectionColor;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectionColor_I;
#pragma warning disable 0169
		static Delegate GetSetSelectionColor_IHandler ()
		{
			if (cb_setSelectionColor_I == null)
				cb_setSelectionColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectionColor_I);
			return cb_setSelectionColor_I;
		}

		static void n_SetSelectionColor_I (IntPtr jnienv, IntPtr native__this, int selectionColor)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectionColor = selectionColor;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectionColor;
		static IntPtr id_setSelectionColor_I;
		public virtual unsafe int SelectionColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getSelectionColor' and count(parameter)=0]"
			[Register ("getSelectionColor", "()I", "GetGetSelectionColorHandler")]
			get {
				if (id_getSelectionColor == IntPtr.Zero)
					id_getSelectionColor = JNIEnv.GetMethodID (class_ref, "getSelectionColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSelectionColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectionColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setSelectionColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectionColor", "(I)V", "GetSetSelectionColor_IHandler")]
			set {
				if (id_setSelectionColor_I == IntPtr.Zero)
					id_setSelectionColor_I = JNIEnv.GetMethodID (class_ref, "setSelectionColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectionColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectionColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTodayLabelColor;
#pragma warning disable 0169
		static Delegate GetGetTodayLabelColorHandler ()
		{
			if (cb_getTodayLabelColor == null)
				cb_getTodayLabelColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTodayLabelColor);
			return cb_getTodayLabelColor;
		}

		static int n_GetTodayLabelColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TodayLabelColor;
		}
#pragma warning restore 0169

		static Delegate cb_setTodayLabelColor_I;
#pragma warning disable 0169
		static Delegate GetSetTodayLabelColor_IHandler ()
		{
			if (cb_setTodayLabelColor_I == null)
				cb_setTodayLabelColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTodayLabelColor_I);
			return cb_setTodayLabelColor_I;
		}

		static void n_SetTodayLabelColor_I (IntPtr jnienv, IntPtr native__this, int todayLabelColor)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TodayLabelColor = todayLabelColor;
		}
#pragma warning restore 0169

		static IntPtr id_getTodayLabelColor;
		static IntPtr id_setTodayLabelColor_I;
		public virtual unsafe int TodayLabelColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getTodayLabelColor' and count(parameter)=0]"
			[Register ("getTodayLabelColor", "()I", "GetGetTodayLabelColorHandler")]
			get {
				if (id_getTodayLabelColor == IntPtr.Zero)
					id_getTodayLabelColor = JNIEnv.GetMethodID (class_ref, "getTodayLabelColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTodayLabelColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTodayLabelColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setTodayLabelColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTodayLabelColor", "(I)V", "GetSetTodayLabelColor_IHandler")]
			set {
				if (id_setTodayLabelColor_I == IntPtr.Zero)
					id_setTodayLabelColor_I = JNIEnv.GetMethodID (class_ref, "setTodayLabelColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTodayLabelColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTodayLabelColor", "(I)V"), __args);
				} finally {
				}
			}
		}

#region "Event implementation for Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener"
		public event EventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.DayClickEventArgs> DayClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor>(
						ref weak_implementor___SetOnDayClickListener,
						__CreateIOnDayClickListenerImplementor,
						__v => OnDayClickListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor>(
						ref weak_implementor___SetOnDayClickListener,
						global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor.__IsEmpty,
						__v => OnDayClickListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnDayClickListener;

		global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor __CreateIOnDayClickListenerImplementor ()
		{
			return new global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener"
		public event EventHandler ForwardButtonClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerImplementor>(
						ref weak_implementor___SetOnForwardButtonClickListener,
						__CreateIOnNavigationButtonClickListenerImplementor,
						__v => OnForwardButtonClickListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerImplementor>(
						ref weak_implementor___SetOnForwardButtonClickListener,
						global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerImplementor.__IsEmpty,
						__v => OnForwardButtonClickListener = null,
						__h => __h.Handler -= value);
			}
		}

		public event EventHandler PreviousButtonClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerImplementor>(
						ref weak_implementor___SetOnPreviousButtonClickListener,
						__CreateIOnNavigationButtonClickListenerImplementor,
						__v => OnPreviousButtonClickListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerImplementor>(
						ref weak_implementor___SetOnPreviousButtonClickListener,
						global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerImplementor.__IsEmpty,
						__v => OnPreviousButtonClickListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnForwardButtonClickListener;
		WeakReference weak_implementor___SetOnPreviousButtonClickListener;

		global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerImplementor __CreateIOnNavigationButtonClickListenerImplementor ()
		{
			return new global::Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener"
		public event EventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.SelectDateEventArgs> SelectDate {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListenerImplementor>(
						ref weak_implementor___SetOnSelectDateListener,
						__CreateIOnSelectDateListenerImplementor,
						__v => OnSelectDateListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListenerImplementor>(
						ref weak_implementor___SetOnSelectDateListener,
						global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListenerImplementor.__IsEmpty,
						__v => OnSelectDateListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnSelectDateListener;

		global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListenerImplementor __CreateIOnSelectDateListenerImplementor ()
		{
			return new global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener"
		public event EventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.SelectionAbilityEventArgs> SelectionAbility {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListenerImplementor>(
						ref weak_implementor___SetOnSelectionAbilityListener,
						__CreateIOnSelectionAbilityListenerImplementor,
						__v => OnSelectionAbilityListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListenerImplementor>(
						ref weak_implementor___SetOnSelectionAbilityListener,
						global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListenerImplementor.__IsEmpty,
						__v => OnSelectionAbilityListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnSelectionAbilityListener;

		global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListenerImplementor __CreateIOnSelectionAbilityListenerImplementor ()
		{
			return new global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListenerImplementor (this);
		}
#endregion
	}
}

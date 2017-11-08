using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applandeo.Materialcalendarview.Adapters {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.adapters']/class[@name='CalendarPageAdapter']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/adapters/CalendarPageAdapter", DoNotGenerateAcw=true)]
	public partial class CalendarPageAdapter : global::Android.Support.V4.View.PagerAdapter {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applandeo.materialcalendarview.adapters']/class[@name='CalendarPageAdapter']/field[@name='CALENDAR_SIZE']"
		[Register ("CALENDAR_SIZE")]
		public const int CalendarSize = (int) 2401;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applandeo/materialcalendarview/adapters/CalendarPageAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CalendarPageAdapter); }
		}

		protected CalendarPageAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_applandeo_materialcalendarview_utils_CalendarProperties_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview.adapters']/class[@name='CalendarPageAdapter']/constructor[@name='CalendarPageAdapter' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applandeo.materialcalendarview.utils.CalendarProperties']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/applandeo/materialcalendarview/utils/CalendarProperties;)V", "")]
		public unsafe CalendarPageAdapter (global::Android.Content.Context context, global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties calendarProperties)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (calendarProperties);
				if (((object) this).GetType () != typeof (CalendarPageAdapter)) {
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

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Adapters.CalendarPageAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Adapters.CalendarPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		static IntPtr id_getCount;
		public override unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.adapters']/class[@name='CalendarPageAdapter']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedDay;
#pragma warning disable 0169
		static Delegate GetGetSelectedDayHandler ()
		{
			if (cb_getSelectedDay == null)
				cb_getSelectedDay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedDay);
			return cb_getSelectedDay;
		}

		static IntPtr n_GetSelectedDay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Adapters.CalendarPageAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Adapters.CalendarPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectedDay);
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_;
#pragma warning disable 0169
		static Delegate GetSetSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_Handler ()
		{
			if (cb_setSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_ == null)
				cb_setSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_);
			return cb_setSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_;
		}

		static void n_SetSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_ (IntPtr jnienv, IntPtr native__this, IntPtr native_selectedDay)
		{
			global::Com.Applandeo.Materialcalendarview.Adapters.CalendarPageAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Adapters.CalendarPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay selectedDay = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay> (native_selectedDay, JniHandleOwnership.DoNotTransfer);
			__this.SelectedDay = selectedDay;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedDay;
		static IntPtr id_setSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_;
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay SelectedDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.adapters']/class[@name='CalendarPageAdapter']/method[@name='getSelectedDay' and count(parameter)=0]"
			[Register ("getSelectedDay", "()Lcom/applandeo/materialcalendarview/utils/SelectedDay;", "GetGetSelectedDayHandler")]
			get {
				if (id_getSelectedDay == IntPtr.Zero)
					id_getSelectedDay = JNIEnv.GetMethodID (class_ref, "getSelectedDay", "()Lcom/applandeo/materialcalendarview/utils/SelectedDay;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedDay), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedDay", "()Lcom/applandeo/materialcalendarview/utils/SelectedDay;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.adapters']/class[@name='CalendarPageAdapter']/method[@name='setSelectedDay' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.utils.SelectedDay']]"
			[Register ("setSelectedDay", "(Lcom/applandeo/materialcalendarview/utils/SelectedDay;)V", "GetSetSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_Handler")]
			set {
				if (id_setSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_ == IntPtr.Zero)
					id_setSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_ = JNIEnv.GetMethodID (class_ref, "setSelectedDay", "(Lcom/applandeo/materialcalendarview/utils/SelectedDay;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectedDay", "(Lcom/applandeo/materialcalendarview/utils/SelectedDay;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedDays;
#pragma warning disable 0169
		static Delegate GetGetSelectedDaysHandler ()
		{
			if (cb_getSelectedDays == null)
				cb_getSelectedDays = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedDays);
			return cb_getSelectedDays;
		}

		static IntPtr n_GetSelectedDays (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Adapters.CalendarPageAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Adapters.CalendarPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay>.ToLocalJniHandle (__this.SelectedDays);
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedDays;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay> SelectedDays {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.adapters']/class[@name='CalendarPageAdapter']/method[@name='getSelectedDays' and count(parameter)=0]"
			[Register ("getSelectedDays", "()Ljava/util/List;", "GetGetSelectedDaysHandler")]
			get {
				if (id_getSelectedDays == IntPtr.Zero)
					id_getSelectedDays = JNIEnv.GetMethodID (class_ref, "getSelectedDays", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedDays), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedDays", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_;
#pragma warning disable 0169
		static Delegate GetAddSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_Handler ()
		{
			if (cb_addSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_ == null)
				cb_addSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_);
			return cb_addSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_;
		}

		static void n_AddSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_ (IntPtr jnienv, IntPtr native__this, IntPtr native_selectedDay)
		{
			global::Com.Applandeo.Materialcalendarview.Adapters.CalendarPageAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Adapters.CalendarPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay selectedDay = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay> (native_selectedDay, JniHandleOwnership.DoNotTransfer);
			__this.AddSelectedDay (selectedDay);
		}
#pragma warning restore 0169

		static IntPtr id_addSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.adapters']/class[@name='CalendarPageAdapter']/method[@name='addSelectedDay' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.utils.SelectedDay']]"
		[Register ("addSelectedDay", "(Lcom/applandeo/materialcalendarview/utils/SelectedDay;)V", "GetAddSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_Handler")]
		public virtual unsafe void AddSelectedDay (global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay selectedDay)
		{
			if (id_addSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_ == IntPtr.Zero)
				id_addSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_ = JNIEnv.GetMethodID (class_ref, "addSelectedDay", "(Lcom/applandeo/materialcalendarview/utils/SelectedDay;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (selectedDay);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addSelectedDay", "(Lcom/applandeo/materialcalendarview/utils/SelectedDay;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetIsViewFromObject_Landroid_view_View_Ljava_lang_Object_Handler ()
		{
			if (cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_ == null)
				cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsViewFromObject_Landroid_view_View_Ljava_lang_Object_);
			return cb_isViewFromObject_Landroid_view_View_Ljava_lang_Object_;
		}

		static bool n_IsViewFromObject_Landroid_view_View_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native__object)
		{
			global::Com.Applandeo.Materialcalendarview.Adapters.CalendarPageAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Adapters.CalendarPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object @object = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__object, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsViewFromObject (view, @object);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isViewFromObject_Landroid_view_View_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.adapters']/class[@name='CalendarPageAdapter']/method[@name='isViewFromObject' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.Object']]"
		[Register ("isViewFromObject", "(Landroid/view/View;Ljava/lang/Object;)Z", "GetIsViewFromObject_Landroid_view_View_Ljava_lang_Object_Handler")]
		public override unsafe bool IsViewFromObject (global::Android.Views.View view, global::Java.Lang.Object @object)
		{
			if (id_isViewFromObject_Landroid_view_View_Ljava_lang_Object_ == IntPtr.Zero)
				id_isViewFromObject_Landroid_view_View_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "isViewFromObject", "(Landroid/view/View;Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (view);
				__args [1] = new JValue (@object);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isViewFromObject_Landroid_view_View_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isViewFromObject", "(Landroid/view/View;Ljava/lang/Object;)Z"), __args);
				return __ret;
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
			global::Com.Applandeo.Materialcalendarview.Adapters.CalendarPageAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Adapters.CalendarPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var eventDays = global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.EventDay>.FromJniHandle (native_eventDays, JniHandleOwnership.DoNotTransfer);
			__this.SetEvents (eventDays);
		}
#pragma warning restore 0169

		static IntPtr id_setEvents_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.adapters']/class[@name='CalendarPageAdapter']/method[@name='setEvents' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applandeo.materialcalendarview.EventDay&gt;']]"
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
			global::Com.Applandeo.Materialcalendarview.Adapters.CalendarPageAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Adapters.CalendarPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			__this.SetMaximumDate (calendar);
		}
#pragma warning restore 0169

		static IntPtr id_setMaximumDate_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.adapters']/class[@name='CalendarPageAdapter']/method[@name='setMaximumDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
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
			global::Com.Applandeo.Materialcalendarview.Adapters.CalendarPageAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Adapters.CalendarPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			__this.SetMinimumDate (calendar);
		}
#pragma warning restore 0169

		static IntPtr id_setMinimumDate_Ljava_util_Calendar_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.adapters']/class[@name='CalendarPageAdapter']/method[@name='setMinimumDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
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

		static void n_SetOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Applandeo.Materialcalendarview.Adapters.CalendarPageAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Adapters.CalendarPageAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener listener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnDayClickListener (listener);
		}
#pragma warning restore 0169

		static IntPtr id_setOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.adapters']/class[@name='CalendarPageAdapter']/method[@name='setOnDayClickListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnDayClickListener']]"
		[Register ("setOnDayClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnDayClickListener;)V", "GetSetOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_Handler")]
		public virtual unsafe void SetOnDayClickListener (global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener listener)
		{
			if (id_setOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_ == IntPtr.Zero)
				id_setOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnDayClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnDayClickListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnDayClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnDayClickListener;)V"), __args);
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
	}
}

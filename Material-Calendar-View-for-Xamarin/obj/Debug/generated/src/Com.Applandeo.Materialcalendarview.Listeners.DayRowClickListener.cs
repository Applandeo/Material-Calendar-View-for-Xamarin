using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applandeo.Materialcalendarview.Listeners {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.listeners']/class[@name='DayRowClickListener']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/listeners/DayRowClickListener", DoNotGenerateAcw=true)]
	public partial class DayRowClickListener : global::Java.Lang.Object, global::Android.Widget.AdapterView.IOnItemClickListener {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applandeo/materialcalendarview/listeners/DayRowClickListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DayRowClickListener); }
		}

		protected DayRowClickListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ;
#pragma warning disable 0169
		static Delegate GetOnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJHandler ()
		{
			if (cb_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ == null)
				cb_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, long>) n_OnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ);
			return cb_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ;
		}

		static void n_OnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ (IntPtr jnienv, IntPtr native__this, IntPtr native_adapterView, IntPtr native_view, int position, long id)
		{
			global::Com.Applandeo.Materialcalendarview.Listeners.DayRowClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.DayRowClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AdapterView adapterView = global::Java.Lang.Object.GetObject<global::Android.Widget.AdapterView> (native_adapterView, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.OnItemClick (adapterView, view, position, id);
		}
#pragma warning restore 0169

		static IntPtr id_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.listeners']/class[@name='DayRowClickListener']/method[@name='onItemClick' and count(parameter)=4 and parameter[1][@type='android.widget.AdapterView&lt;?&gt;'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", "GetOnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJHandler")]
		public virtual unsafe void OnItemClick (global::Android.Widget.AdapterView adapterView, global::Android.Views.View view, int position, long id)
		{
			if (id_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ == IntPtr.Zero)
				id_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ = JNIEnv.GetMethodID (class_ref, "onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (adapterView);
				__args [1] = new JValue (view);
				__args [2] = new JValue (position);
				__args [3] = new JValue (id);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V"), __args);
			} finally {
			}
		}

	}
}

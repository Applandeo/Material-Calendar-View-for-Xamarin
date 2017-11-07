using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applandeo.Materialcalendarview.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='ImageUtils']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/utils/ImageUtils", DoNotGenerateAcw=true)]
	public partial class ImageUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applandeo/materialcalendarview/utils/ImageUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageUtils); }
		}

		protected ImageUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='ImageUtils']/constructor[@name='ImageUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImageUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ImageUtils)) {
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

		static IntPtr id_loadResource_Landroid_widget_ImageView_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='ImageUtils']/method[@name='loadResource' and count(parameter)=2 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='int']]"
		[Register ("loadResource", "(Landroid/widget/ImageView;I)V", "")]
		public static unsafe void LoadResource (global::Android.Widget.ImageView imageView, int resource)
		{
			if (id_loadResource_Landroid_widget_ImageView_I == IntPtr.Zero)
				id_loadResource_Landroid_widget_ImageView_I = JNIEnv.GetStaticMethodID (class_ref, "loadResource", "(Landroid/widget/ImageView;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (imageView);
				__args [1] = new JValue (resource);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_loadResource_Landroid_widget_ImageView_I, __args);
			} finally {
			}
		}

	}
}

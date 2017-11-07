using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applandeo.Materialcalendarview.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.exceptions']/class[@name='OutOfDateRangeException']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/exceptions/OutOfDateRangeException", DoNotGenerateAcw=true)]
	public partial class OutOfDateRangeException : global::Java.Lang.Exception {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applandeo/materialcalendarview/exceptions/OutOfDateRangeException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OutOfDateRangeException); }
		}

		protected OutOfDateRangeException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview.exceptions']/class[@name='OutOfDateRangeException']/constructor[@name='OutOfDateRangeException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe OutOfDateRangeException (string message)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_message);
				if (((object) this).GetType () != typeof (OutOfDateRangeException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

	}
}

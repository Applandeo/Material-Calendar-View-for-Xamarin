package mono.com.applandeo.materialcalendarview.listeners;


public class OnDayClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.applandeo.materialcalendarview.listeners.OnDayClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDayClick:(Lcom/applandeo/materialcalendarview/EventDay;)V:GetOnDayClick_Lcom_applandeo_materialcalendarview_EventDay_Handler:Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerInvoker, Material-Calendar-View-for-Xamarin\n" +
			"";
		mono.android.Runtime.register ("Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor, Material-Calendar-View-for-Xamarin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnDayClickListenerImplementor.class, __md_methods);
	}


	public OnDayClickListenerImplementor ()
	{
		super ();
		if (getClass () == OnDayClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor, Material-Calendar-View-for-Xamarin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onDayClick (com.applandeo.materialcalendarview.EventDay p0)
	{
		n_onDayClick (p0);
	}

	private native void n_onDayClick (com.applandeo.materialcalendarview.EventDay p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}

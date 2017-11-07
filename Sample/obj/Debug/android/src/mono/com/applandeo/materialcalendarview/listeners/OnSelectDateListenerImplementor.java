package mono.com.applandeo.materialcalendarview.listeners;


public class OnSelectDateListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.applandeo.materialcalendarview.listeners.OnSelectDateListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSelect:(Ljava/util/List;)V:GetOnSelect_Ljava_util_List_Handler:Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListenerInvoker, Material-Calendar-View-for-Xamarin\n" +
			"";
		mono.android.Runtime.register ("Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListenerImplementor, Material-Calendar-View-for-Xamarin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnSelectDateListenerImplementor.class, __md_methods);
	}


	public OnSelectDateListenerImplementor ()
	{
		super ();
		if (getClass () == OnSelectDateListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListenerImplementor, Material-Calendar-View-for-Xamarin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onSelect (java.util.List p0)
	{
		n_onSelect (p0);
	}

	private native void n_onSelect (java.util.List p0);

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

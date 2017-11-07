package mono.com.applandeo.materialcalendarview.listeners;


public class OnNavigationButtonClickListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.applandeo.materialcalendarview.listeners.OnNavigationButtonClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClick:()V:GetOnClickHandler:Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerInvoker, Material-Calendar-View-for-Xamarin\n" +
			"";
		mono.android.Runtime.register ("Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerImplementor, Material-Calendar-View-for-Xamarin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnNavigationButtonClickListenerImplementor.class, __md_methods);
	}


	public OnNavigationButtonClickListenerImplementor ()
	{
		super ();
		if (getClass () == OnNavigationButtonClickListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Applandeo.Materialcalendarview.Listeners.IOnNavigationButtonClickListenerImplementor, Material-Calendar-View-for-Xamarin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onClick ()
	{
		n_onClick ();
	}

	private native void n_onClick ();

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

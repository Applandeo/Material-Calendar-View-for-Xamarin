package mono.com.applandeo.materialcalendarview.listeners;


public class OnSelectionAbilityListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.applandeo.materialcalendarview.listeners.OnSelectionAbilityListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onChange:(Z)V:GetOnChange_ZHandler:Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListenerInvoker, Material-Calendar-View-for-Xamarin\n" +
			"";
		mono.android.Runtime.register ("Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListenerImplementor, Material-Calendar-View-for-Xamarin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnSelectionAbilityListenerImplementor.class, __md_methods);
	}


	public OnSelectionAbilityListenerImplementor ()
	{
		super ();
		if (getClass () == OnSelectionAbilityListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListenerImplementor, Material-Calendar-View-for-Xamarin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onChange (boolean p0)
	{
		n_onChange (p0);
	}

	private native void n_onChange (boolean p0);

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

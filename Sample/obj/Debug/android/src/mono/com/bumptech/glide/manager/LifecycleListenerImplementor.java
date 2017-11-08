package mono.com.bumptech.glide.manager;


public class LifecycleListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.bumptech.glide.manager.LifecycleListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDestroy:()V:GetOnDestroyHandler:Com.Bumptech.Glide.Manager.ILifecycleListenerInvoker, Glide\n" +
			"n_onStart:()V:GetOnStartHandler:Com.Bumptech.Glide.Manager.ILifecycleListenerInvoker, Glide\n" +
			"n_onStop:()V:GetOnStopHandler:Com.Bumptech.Glide.Manager.ILifecycleListenerInvoker, Glide\n" +
			"";
		mono.android.Runtime.register ("Com.Bumptech.Glide.Manager.ILifecycleListenerImplementor, Glide, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", LifecycleListenerImplementor.class, __md_methods);
	}


	public LifecycleListenerImplementor ()
	{
		super ();
		if (getClass () == LifecycleListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Bumptech.Glide.Manager.ILifecycleListenerImplementor, Glide, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onDestroy ()
	{
		n_onDestroy ();
	}

	private native void n_onDestroy ();


	public void onStart ()
	{
		n_onStart ();
	}

	private native void n_onStart ();


	public void onStop ()
	{
		n_onStop ();
	}

	private native void n_onStop ();

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

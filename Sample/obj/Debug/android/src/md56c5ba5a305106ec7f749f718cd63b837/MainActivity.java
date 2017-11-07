package md56c5ba5a305106ec7f749f718cd63b837;


public class MainActivity
	extends android.support.v7.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer,
		com.applandeo.materialcalendarview.listeners.OnSelectDateListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onSelect:(Ljava/util/List;)V:GetOnSelect_Ljava_util_List_Handler:Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListenerInvoker, Material-Calendar-View-for-Xamarin\n" +
			"";
		mono.android.Runtime.register ("MaterialCalendar.MainActivity, Sample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity.class, __md_methods);
	}


	public MainActivity ()
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("MaterialCalendar.MainActivity, Sample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


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

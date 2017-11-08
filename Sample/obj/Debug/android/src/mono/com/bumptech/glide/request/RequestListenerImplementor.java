package mono.com.bumptech.glide.request;


public class RequestListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.bumptech.glide.request.RequestListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onException:(Ljava/lang/Exception;Ljava/lang/Object;Lcom/bumptech/glide/request/target/Target;Z)Z:GetOnException_Ljava_lang_Exception_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_ZHandler:Com.Bumptech.Glide.Request.IRequestListenerInvoker, Glide\n" +
			"n_onResourceReady:(Ljava/lang/Object;Ljava/lang/Object;Lcom/bumptech/glide/request/target/Target;ZZ)Z:GetOnResourceReady_Ljava_lang_Object_Ljava_lang_Object_Lcom_bumptech_glide_request_target_Target_ZZHandler:Com.Bumptech.Glide.Request.IRequestListenerInvoker, Glide\n" +
			"";
		mono.android.Runtime.register ("Com.Bumptech.Glide.Request.IRequestListenerImplementor, Glide, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RequestListenerImplementor.class, __md_methods);
	}


	public RequestListenerImplementor ()
	{
		super ();
		if (getClass () == RequestListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Bumptech.Glide.Request.IRequestListenerImplementor, Glide, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onException (java.lang.Exception p0, java.lang.Object p1, com.bumptech.glide.request.target.Target p2, boolean p3)
	{
		return n_onException (p0, p1, p2, p3);
	}

	private native boolean n_onException (java.lang.Exception p0, java.lang.Object p1, com.bumptech.glide.request.target.Target p2, boolean p3);


	public boolean onResourceReady (java.lang.Object p0, java.lang.Object p1, com.bumptech.glide.request.target.Target p2, boolean p3, boolean p4)
	{
		return n_onResourceReady (p0, p1, p2, p3, p4);
	}

	private native boolean n_onResourceReady (java.lang.Object p0, java.lang.Object p1, com.bumptech.glide.request.target.Target p2, boolean p3, boolean p4);

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

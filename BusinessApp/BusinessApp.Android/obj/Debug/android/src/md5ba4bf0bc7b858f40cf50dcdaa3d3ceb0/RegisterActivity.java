package md5ba4bf0bc7b858f40cf50dcdaa3d3ceb0;


public class RegisterActivity
	extends mvvmcross.droid.views.MvxActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("BusinessApp.Droid.RegisterActivity, BusinessApp.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RegisterActivity.class, __md_methods);
	}


	public RegisterActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RegisterActivity.class)
			mono.android.TypeManager.Activate ("BusinessApp.Droid.RegisterActivity, BusinessApp.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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

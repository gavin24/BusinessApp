package md5036185647410a84e7c615908213d2b3a;


public class MvxJavaContainer_1
	extends md5036185647410a84e7c615908213d2b3a.MvxJavaContainer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MvvmCross.Platform.Droid.MvxJavaContainer`1, MvvmCross.Platform.Droid, Version=5.0.1.0, Culture=neutral, PublicKeyToken=null", MvxJavaContainer_1.class, __md_methods);
	}


	public MvxJavaContainer_1 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MvxJavaContainer_1.class)
			mono.android.TypeManager.Activate ("MvvmCross.Platform.Droid.MvxJavaContainer`1, MvvmCross.Platform.Droid, Version=5.0.1.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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

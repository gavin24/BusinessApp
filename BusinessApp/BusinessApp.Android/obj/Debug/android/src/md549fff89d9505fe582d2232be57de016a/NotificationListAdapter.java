package md549fff89d9505fe582d2232be57de016a;


public class NotificationListAdapter
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("BusinessApp.Droid.Resources.layout.NotificationListAdapter, BusinessApp.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", NotificationListAdapter.class, __md_methods);
	}


	public NotificationListAdapter () throws java.lang.Throwable
	{
		super ();
		if (getClass () == NotificationListAdapter.class)
			mono.android.TypeManager.Activate ("BusinessApp.Droid.Resources.layout.NotificationListAdapter, BusinessApp.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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

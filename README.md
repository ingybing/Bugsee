# Getting Started
<ol>
  <li>
    Download the release binary from the releases binary or clone this repo and build the Bugsee-Binding project.
  </li>
  <li>
    Copy the Bugsee-Binding.dll to your solution structure and reference it from you iOS UI Project.
  </li>
  <li>
    Open a text editor and add the following element to the iOS UI Project:
    <pre>&lt;ItemGroup&gt;
  &lt;NativeReference Include="..\{PathToFramework}\Bugsee.framework"&gt;
  &lt;IsCxx&gt;False&lt;/IsCxx&gt;
  &lt;Kind&gt;Framework&lt;/Kind&gt;
  &lt;/NativeReference&gt;
&lt;/ItemGroup&gt;</pre>
    This currently needs to be done manually. Xamarin have no UI in the IDE for this.
  </li>
  <li>
    In your AppDelegate FinishedLoading method add the Bugsee initialisation.
    <pre>public override bool FinishedLaunching (UIApplication app, NSDictionary options)
{
  ...
  var options = new NSDictionary(Com.Bugsee.Constants.BugseeShakeToReportKey, true);
  Bugsee.LaunchWithToken("INSERT TOKEN HERE", options);
  ...
}</pre>
	</li>
</ol>

Thats it you should be good to go.

#Known Issues:

<ol>
  <li>Log does not appear to be logging to the console messages.</li>
  <li>Private Views<br/>
      In the native library these are implemented by a category adding a property, 'bugseeProtectedView'. The only way this could
      be implemented that i could get working is to subclass the view type you want to protect. In InterfaceBuilder set the control
      class to be the appropriate view from Com.Bugsee such as BugseePrivateLabel for a UILabel etc. This should now hide the field
      from the recordings.
  </li>
</ol>

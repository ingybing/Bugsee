using Com.Bugsee;

using UIKit;
using SystemConfiguration;
using CoreMotion;
using CoreMedia;
using Foundation;
using CoreFoundation;
using AVFoundation;
using CoreTelephony;

namespace Com.Bugsee 
{
	// @interface BugseeLogger : NSObject
	[BaseType (typeof(NSObject))]
	interface BugseeLogger
	{
		// +(instancetype)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		BugseeLogger SharedInstance ();
	}

    [Static]
    partial interface Constants
    {
        // extern NSString *const BugseeShakeToReportKey;
        [Field("BugseeShakeToReportKey", "__Internal")]
        NSString BugseeShakeToReportKey { get; }

        // extern NSString *const BugseeMaxRecordingTimeKey;
        [Field("BugseeMaxRecordingTimeKey", "__Internal")]
        NSString BugseeMaxRecordingTimeKey { get; }

        // extern NSString *const BugseeScreenshotToReportKey;
        [Field("BugseeScreenshotToReportKey", "__Internal")]
        NSString BugseeScreenshotToReportKey { get; }

        // extern NSString *const BugseeCrashReportKey;
        [Field("BugseeCrashReportKey", "__Internal")]
        NSString BugseeCrashReportKey { get; }

        // extern NSString *const BugseeMaxFrameRateKey;
        [Field("BugseeMaxFrameRateKey", "__Internal")]
        NSString BugseeMaxFrameRateKey { get; }

        // extern NSString *const BugseeMinFrameRateKey;
        [Field("BugseeMinFrameRateKey", "__Internal")]
        NSString BugseeMinFrameRateKey { get; }

        // extern NSString *const BugseeMonitorNetworkKey;
        [Field("BugseeMonitorNetworkKey", "__Internal")]
        NSString BugseeMonitorNetworkKey { get; }

        // extern NSString *const BugseeStatusBarInfoKey;
        [Field("BugseeStatusBarInfoKey", "__Internal")]
        NSString BugseeStatusBarInfoKey { get; }

        // extern NSString *const BugseeVideoEnabledKey;
        [Field("BugseeVideoEnabledKey", "__Internal")]
		NSString BugseeVideoEnabledKey { get; }
    }

    // @interface Bugsee : NSObject
    [BaseType(typeof(NSObject))]
    interface Bugsee
    {
        // @property (readonly, assign, nonatomic) BOOL launched;
        [Export("launched")]
        bool Launched { get; }

        // +(Bugsee *)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        Bugsee SharedInstance();

        // +(Bugsee *)launchWithToken:(NSString *)appToken;
        [Static]
        [Export("launchWithToken:")]
        Bugsee LaunchWithToken(string appToken);

        // +(Bugsee *)launchWithToken:(NSString *)appToken andOptions:(NSDictionary *)options;
        [Static]
        [Export("launchWithToken:andOptions:")]
        Bugsee LaunchWithToken(string appToken, NSDictionary options);

        // +(void)showReportController;
        [Static]
        [Export("showReportController")]
        void ShowReportController();

        // +(void)showReportControllerWithSummary:(NSString *)summ description:(NSString *)descr severity:(BugseeSeverityLevel)level;
        [Static]
        [Export("showReportControllerWithSummary:description:severity:")]
        void ShowReportControllerWithSummary(string summ, string descr, BugseeSeverityLevel level);

        // +(void)pause;
        [Static]
        [Export("pause")]
        void Pause();

        // +(void)resume;
        [Static]
        [Export("resume")]
        void Resume();

        // +(void)traceKey:(NSString *)traceKey withValue:(id)value;
        [Static]
        [Export("traceKey:withValue:")]
        void TraceKey(string traceKey, NSObject value);

        // +(void)registerEvent:(NSString *)eventName withParams:(NSDictionary *)params;
        [Static]
        [Export("registerEvent:withParams:")]
        void RegisterEvent(string eventName, NSDictionary @params);

        // +(void)tracePropertyOfObject:(NSObject *)object forKey:(NSString *)key;
        [Static]
        [Export("tracePropertyOfObject:forKey:")]
        void TracePropertyOfObject(NSObject @object, string key);

        // +(void)tracePropertyOfObject:(NSObject *)object forKey:(NSString *)key withName:(NSString *)name;
        [Static]
        [Export("tracePropertyOfObject:forKey:withName:")]
        void TracePropertyOfObject(NSObject @object, string key, string name);

        // +(void)stopTracePropertyOfObject:(NSObject *)object forKey:(NSString *)key;
        [Static]
        [Export("stopTracePropertyOfObject:forKey:")]
        void StopTracePropertyOfObject(NSObject @object, string key);

        // +(void)uploadWithSummary:(NSString *)summary description:(NSString *)descr severity:(BugseeSeverityLevel)severity;
        [Static]
        [Export("uploadWithSummary:description:severity:")]
        void UploadWithSummary(string summary, string descr, BugseeSeverityLevel severity);

        // +(void)validateAssert:(BOOL)assert withSummary:(NSString *)summary andDescription:(NSString *)description;
        [Static]
        [Export("validateAssert:withSummary:andDescription:")]
        void ValidateAssert(bool assert, string summary, string description);

        // +(void)log:(NSString *)message;
        [Static]
        [Export("log:")]
        void Log(string message);

        // +(void)log:(NSString *)message level:(BugseeLogLevel)level;
        [Static]
        [Export("log:level:")]
        void Log(string message, BugseeLogLevel level);

        // +(void)log:(NSString *)message level:(BugseeLogLevel)level timestamp:(int64_t)timestamp;
        [Static]
        [Export("log:level:timestamp:")]
        void Log(string message, BugseeLogLevel level, long timestamp);

        // +(void)addNetworkFilter:(NSString *)URLString;
        [Static]
        [Export("addNetworkFilter:")]
        void AddNetworkFilter(string URLString);

        // +(void)addNetworkFilters:(NSArray<NSString *> *)URLStrings;
        [Static]
        [Export("addNetworkFilters:")]
        void AddNetworkFilters(string[] URLStrings);

        // +(NSString *)accessToken;
        [Static]
        [Export("accessToken")]
        string AccessToken();

        // +(BOOL)setEmail:(NSString *)email;
        [Static]
        [Export("setEmail:")]
        bool SetEmail(string email);

        // +(NSString *)getEmail;
        [Static]
        [Export("getEmail")]
        string GetEmail();

        // +(BOOL)clearEmail;
        [Static]
        [Export("clearEmail")]
        bool ClearEmail();

        // + (void) setView:(UIView*)view asHidden:(BOOL) isHidden;
        [Static]
        [Export("setView:asHidden:")]
        void SetViewAsHidden(UIView view, bool isHidden);
    }
}
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Com.Bugsee
{
    // typedef void (^BugseeNetworkFilterDecisionBlock)(BugseeNetworkEvent * _Nullable);
    //delegate void BugseeNetworkFilterDecisionBlock([NullAllowed] BugseeNetworkEvent arg0);

    // typedef void (^BugseeNetworkEventFilterBlock)(BugseeNetworkEvent * _Nonnull, BugseeNetworkFilterDecisionBlock _Nonnull);
    //delegate void BugseeNetworkEventFilterBlock(BugseeNetworkEvent arg0, BugseeNetworkFilterDecisionBlock arg1);

    [Static]
    partial interface Constants
    {
        // extern NSString *const _Nonnull BugseeStyleDefault;
        [Field("BugseeStyleDefault", "__Internal")]
        NSString BugseeStyleDefault { get; }

        // extern NSString *const _Nonnull BugseeStyleDark;
        [Field("BugseeStyleDark", "__Internal")]
        NSString BugseeStyleDark { get; }

        // extern NSString *const _Nonnull BugseeStyleBasedOnStatusBarStyle;
        [Field("BugseeStyleBasedOnStatusBarStyle", "__Internal")]
        NSString BugseeStyleBasedOnStatusBarStyle { get; }

        // extern NSString *const _Nonnull BugseeShakeToReportKey;
        [Field("BugseeShakeToReportKey", "__Internal")]
        NSString BugseeShakeToReportKey { get; }

        // extern NSString *const _Nonnull BugseeMaxRecordingTimeKey;
        [Field("BugseeMaxRecordingTimeKey", "__Internal")]
        NSString BugseeMaxRecordingTimeKey { get; }

        // extern NSString *const _Nonnull BugseeScreenshotToReportKey;
        [Field("BugseeScreenshotToReportKey", "__Internal")]
        NSString BugseeScreenshotToReportKey { get; }

        // extern NSString *const _Nonnull BugseeCrashReportKey;
        [Field("BugseeCrashReportKey", "__Internal")]
        NSString BugseeCrashReportKey { get; }

        // extern NSString *const _Nonnull BugseeKillDetectionKey;
        [Field("BugseeKillDetectionKey", "__Internal")]
        NSString BugseeKillDetectionKey { get; }

        // extern NSString *const _Nonnull BugseeMaxFrameRateKey;
        [Field("BugseeMaxFrameRateKey", "__Internal")]
        NSString BugseeMaxFrameRateKey { get; }

        // extern NSString *const _Nonnull BugseeMinFrameRateKey;
        [Field("BugseeMinFrameRateKey", "__Internal")]
        NSString BugseeMinFrameRateKey { get; }

        // extern NSString *const _Nonnull BugseeMonitorNetworkKey;
        [Field("BugseeMonitorNetworkKey", "__Internal")]
        NSString BugseeMonitorNetworkKey { get; }

        // extern NSString *const _Nonnull BugseeStatusBarInfoKey;
        [Field("BugseeStatusBarInfoKey", "__Internal")]
        NSString BugseeStatusBarInfoKey { get; }

        // extern NSString *const _Nonnull BugseeVideoEnabledKey;
        [Field("BugseeVideoEnabledKey", "__Internal")]
        NSString BugseeVideoEnabledKey { get; }

        // extern NSString *const _Nonnull BugseeStyleKey;
        [Field("BugseeStyleKey", "__Internal")]
        NSString BugseeStyleKey { get; }

        // extern NSString *const _Nonnull BugseeNetworkBodySizeTooLarge;
        [Field("BugseeNetworkBodySizeTooLarge", "__Internal")]
        NSString BugseeNetworkBodySizeTooLarge { get; }

        // extern NSString *const _Nonnull BugseeNetworkBodyUnsupportedContentType;
        [Field("BugseeNetworkBodyUnsupportedContentType", "__Internal")]
        NSString BugseeNetworkBodyUnsupportedContentType { get; }

        // extern NSString *const _Nonnull BugseeNetworkBodyNoContentType;
        [Field("BugseeNetworkBodyNoContentType", "__Internal")]
        NSString BugseeNetworkBodyNoContentType { get; }

        // extern NSString *const _Nonnull BugseeNetworkBodyCantReadData;
        [Field("BugseeNetworkBodyCantReadData", "__Internal")]
        NSString BugseeNetworkBodyCantReadData { get; }

        // extern NSString *const _Nonnull BugseeNetworkEventBegin;
        [Field("BugseeNetworkEventBegin", "__Internal")]
        NSString BugseeNetworkEventBegin { get; }

        // extern NSString *const _Nonnull BugseeNetworkEventComplete;
        [Field("BugseeNetworkEventComplete", "__Internal")]
        NSString BugseeNetworkEventComplete { get; }

        // extern NSString *const _Nonnull BugseeNetworkEventCancel;
        [Field("BugseeNetworkEventCancel", "__Internal")]
        NSString BugseeNetworkEventCancel { get; }

        // extern NSString *const _Nonnull BugseeNetworkEventError;
        [Field("BugseeNetworkEventError", "__Internal")]
        NSString BugseeNetworkEventError { get; }

        // extern NSString *const _Nonnull BugseeReportTypeBug;
        [Field("BugseeReportTypeBug", "__Internal")]
        NSString BugseeReportTypeBug { get; }

        // extern NSString *const _Nonnull BugseeReportTypeCrash;
        [Field("BugseeReportTypeCrash", "__Internal")]
        NSString BugseeReportTypeCrash { get; }

        // extern NSString *const _Nonnull BugseeReportTypeError;
        [Field("BugseeReportTypeError", "__Internal")]
        NSString BugseeReportTypeError { get; }
    }

    //// @protocol BugseeDelegate <NSObject>
    //[Protocol, Model]
    //[BaseType(typeof(NSObject))]
    //interface BugseeDelegate
    //{
    //    // @optional -(void)bugseeFilterNetworkEvent:(BugseeNetworkEvent * _Nonnull)event completionHandler:(BugseeNetworkFilterDecisionBlock _Nonnull)decisionBlock;
    //    [Export("bugseeFilterNetworkEvent:completionHandler:")]
    //    void BugseeFilterNetworkEvent(BugseeNetworkEvent @event, BugseeNetworkFilterDecisionBlock decisionBlock);

    //    // @optional -(NSArray<BugseeAttachment *> * _Nonnull)bugseeAttachmentsForReport:(BugseeReport * _Nonnull)report;
    //    [Export("bugseeAttachmentsForReport:")]
    //    BugseeAttachment[] BugseeAttachmentsForReport(BugseeReport report);
    //}

    // @interface Bugsee : NSObject
    [BaseType(typeof(NSObject))]
    interface Bugsee
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        NSObject Delegate { get; set; }

        // @property (nonatomic, weak) id _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, assign, nonatomic) BOOL launched;
        [Export("launched")]
        bool Launched { get; }

        // +(Bugsee * _Nullable)sharedInstance;
        [Static]
        [NullAllowed, Export("sharedInstance")]
        Bugsee SharedInstance { get; }

        // +(Bugsee * _Nullable)launchWithToken:(NSString * _Nonnull)appToken;
        [Static]
        [Export("launchWithToken:")]
        [return: NullAllowed]
        Bugsee LaunchWithToken(string appToken);

        // +(Bugsee * _Nullable)launchWithToken:(NSString * _Nonnull)appToken andOptions:(NSDictionary * _Nonnull)options;
        [Static]
        [Export("launchWithToken:andOptions:")]
        [return: NullAllowed]
        Bugsee LaunchWithToken(string appToken, NSDictionary options);

        // +(void)showReportController;
        [Static]
        [Export("showReportController")]
        void ShowReportController();

        // +(void)showReportControllerWithSummary:(NSString * _Nonnull)summ description:(NSString * _Nonnull)descr severity:(BugseeSeverityLevel)level;
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

        // +(void)traceKey:(NSString * _Nonnull)traceKey withValue:(id _Nonnull)value;
        [Static]
        [Export("traceKey:withValue:")]
        void TraceKey(string traceKey, NSObject value);

        // +(void)registerEvent:(NSString * _Nonnull)eventName;
        [Static]
        [Export("registerEvent:")]
        void RegisterEvent(string eventName);

        // +(void)registerEvent:(NSString * _Nonnull)eventName withParams:(NSDictionary * _Nonnull)params;
        [Static]
        [Export("registerEvent:withParams:")]
        void RegisterEvent(string eventName, NSDictionary @params);

        // +(void)tracePropertyOfObject:(NSObject * _Nonnull)object forKey:(NSString * _Nonnull)key;
        [Static]
        [Export("tracePropertyOfObject:forKey:")]
        void TracePropertyOfObject(NSObject @object, string key);

        // +(void)tracePropertyOfObject:(NSObject * _Nonnull)object forKey:(NSString * _Nonnull)key withName:(NSString * _Nonnull)name;
        [Static]
        [Export("tracePropertyOfObject:forKey:withName:")]
        void TracePropertyOfObject(NSObject @object, string key, string name);

        // +(void)stopTracePropertyOfObject:(NSObject * _Nonnull)object forKey:(NSString * _Nonnull)key;
        [Static]
        [Export("stopTracePropertyOfObject:forKey:")]
        void StopTracePropertyOfObject(NSObject @object, string key);

        // +(void)uploadWithSummary:(NSString * _Nonnull)summary description:(NSString * _Nonnull)descr severity:(BugseeSeverityLevel)severity;
        [Static]
        [Export("uploadWithSummary:description:severity:")]
        void UploadWithSummary(string summary, string descr, BugseeSeverityLevel severity);

        // +(void)logError:(NSError * _Nonnull)error;
        [Static]
        [Export("logError:")]
        void LogError(NSError error);

        // +(void)logAssert:(NSString * _Nonnull)description withLocation:(NSString * _Nonnull)location;
        [Static]
        [Export("logAssert:withLocation:")]
        void LogAssert(string description, string location);

        // +(void)log:(NSString * _Nonnull)message;
        [Static]
        [Export("log:")]
        void Log(string message);

        // +(void)log:(NSString * _Nonnull)message level:(BugseeLogLevel)level;
        [Static]
        [Export("log:level:")]
        void Log(string message, BugseeLogLevel level);

        // +(void)log:(NSString * _Nonnull)message level:(BugseeLogLevel)level timestamp:(int64_t)timestamp;
        [Static]
        [Export("log:level:timestamp:")]
        void Log(string message, BugseeLogLevel level, long timestamp);

        // +(void)logEx:(NSDictionary * _Nonnull)entry;
        [Static]
        [Export("logEx:")]
        void LogEx(NSDictionary entry);

        // +(void)setNetworkEventFilter:(BugseeNetworkEventFilterBlock _Nonnull)filterBlock;
        //[Static]
        //[Export("setNetworkEventFilter:")]
        //void SetNetworkEventFilter(BugseeNetworkEventFilterBlock filterBlock);

        // +(void)removeNetworkEventFilter;
        [Static]
        [Export("removeNetworkEventFilter")]
        void RemoveNetworkEventFilter();

        // +(NSString * _Nonnull)accessToken;
        [Static]
        [Export("accessToken")]
        string AccessToken { get; }

        // +(BOOL)setEmail:(NSString * _Nonnull)email;
        [Static]
        [Export("setEmail:")]
        bool SetEmail(string email);

        // +(NSString * _Nullable)getEmail;
        [Static]
        [NullAllowed, Export("getEmail")]
        string Email { get; }

        // +(BOOL)clearEmail;
        [Static]
        [Export("clearEmail")]
        bool ClearEmail();

        // +(void)setView:(UIView * _Nonnull)view asHidden:(BOOL)isHidden;
        [Static]
        [Export("setView:asHidden:")]
        void SetView(UIView view, bool isHidden);

        // +(BOOL)isViewHidden:(UIView * _Nonnull)view;
        [Static]
        [Export("isViewHidden:")]
        bool IsViewHidden(UIView view);
    }
}
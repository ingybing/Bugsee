//
//  Bugsee.h
//  Pods
//
//  Created by Dmitry Fink on 11/10/15.
//
//

#import <Foundation/Foundation.h>
#import <TargetConditionals.h>
#import <UIKit/UIKit.h>
#import <CoreMotion/CoreMotion.h>
#import "BugseeLogger.h"

#define BugseeTrue @(YES)
#define BugseeFalse @(NO)

typedef enum : NSUInteger {
    BugseeSeverityLow = 1,
    BugseeSeverityMedium = 2,
    BugseeSeverityHigh = 3,
    BugseeSeverityCritical = 4,
    BugseeSeverityBlocker = 5
} BugseeSeverityLevel;

extern NSString *const BugseeShakeToReportKey;
extern NSString *const BugseeMaxRecordingTimeKey;
extern NSString *const BugseeScreenshotToReportKey;
extern NSString *const BugseeCrashReportKey;
extern NSString *const BugseeMaxFrameRateKey;
extern NSString *const BugseeMinFrameRateKey;
extern NSString *const BugseeMonitorNetworkKey;
extern NSString *const BugseeStatusBarInfoKey;
extern NSString *const BugseeVideoEnabledKey;

@interface Bugsee : NSObject

@property (assign, nonatomic, readonly) BOOL launched;

+ (Bugsee *)sharedInstance;
+ (Bugsee *)launchWithToken:(NSString*)appToken;
+ (Bugsee *)launchWithToken:(NSString*)appToken andOptions:(NSDictionary *) options;

+ (void) showReportController;
+ (void) showReportControllerWithSummary:(NSString *)summ description:(NSString*)descr severity:(BugseeSeverityLevel)level;

/**
 *  Pause bugsee video and loggers
 */
+ (void) pause;
/**
 *  Resume bugsee video and loggers
 */
+ (void) resume;

+ (void) traceKey:(NSString*)traceKey withValue:(id)value;
+ (void) registerEvent:(NSString*)eventName withParams:(NSDictionary*)params;

/**
 *  Observe all property changes, please don't forget remove observer with stopTracePropertyOfObject:forKey:
 *
 *  @param object object with property
 *  @param key    property name
 */
+ (void) tracePropertyOfObject:(NSObject*)object forKey:(NSString*)key;

/**
 *  Observe all property changes, please don't forget remove observer with stopTracePropertyOfObject:forKey:
 *
 *  @param object object with property
 *  @param key    property name
 *  @param name   the name that will be shown on web interface
 */
+ (void) tracePropertyOfObject:(NSObject*)object forKey:(NSString*)key withName:(NSString*)name;

/**
 *  Remove observer from object's property
 *
 *  @param object object with property
 *  @param key    property name. Same name will be used in the traces
 */
+ (void) stopTracePropertyOfObject:(NSObject*)object forKey:(NSString*)key;

+ (void) uploadWithSummary:(NSString*)summary description:(NSString*)descr severity:(BugseeSeverityLevel)severity;

+ (void) validateAssert:(BOOL)assert withSummary:(NSString*)summary  andDescription:(NSString*)description;

+ (void) log:(NSString*)message;

+ (void) log:(NSString*)message level:(BugseeLogLevel)level;

+ (void) log:(NSString*)message level:(BugseeLogLevel)level timestamp:(int64_t)timestamp;

/**
 *  exclude URLs starting with the following URLString from network logs
 *
 *  @param URLString @"http://www.example.com"
 */
+ (void) addNetworkFilter:(NSString*)URLString;
/**
 *  exclude URLs starting with the following URLStrings from network logs
 *
 *  @param URLStrings @[ @"http://www.example.com?name=", @"http://www.example.com?pass="]
 */
+ (void) addNetworkFilters:(NSArray<NSString*>*)URLStrings;

+ (NSString*) accessToken;

/**
 *  Set reporter's email
 *
 *  @param email string with email
 *  @return YES on success, NO on falure
 */
+ (BOOL) setEmail:(NSString *)email;

/**
 *  Get reporter's email
 *
 *  @return NSString* with email on success, or nil on failure
 */
+ (NSString *) getEmail;

/**
 *  Clear reporter's email
 *
 *  @return YES on success, NO on falure
 */
+ (BOOL) clearEmail;

/**
 *  Hides your view on video
 *
 *  @param view     view that you need to protect
 *  @param isHidden bool value
 */
+ (void) setView:(UIView*)view asHidden:(BOOL) isHidden;


@end

@interface UIView (Bugsee)

/**
 *  Hides your view on video
 */
@property (nonatomic, assign) BOOL bugseeProtectedView;

@end

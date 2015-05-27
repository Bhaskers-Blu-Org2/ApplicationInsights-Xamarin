﻿using System;
using Foundation;
using ObjCRuntime;
using CoreTelephony;

namespace ApplicationInsightsIOS
{
	// @interface MSAIApplicationInsights : NSObject
	[BaseType (typeof(NSObject))]
	interface MSAIApplicationInsights
	{
		// +(void)setup;
		[Static]
		[Export ("setup")]
		void Setup ();

		// +(void)setupWithInstrumentationKey:(NSString *)instrumentationKey;
		[Static]
		[Export ("setupWithInstrumentationKey:")]
		void SetupWithInstrumentationKey (string instrumentationKey);

		// +(void)start;
		[Static]
		[Export ("start")]
		void Start ();

		// +(MSAIApplicationInsights *)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		MSAIApplicationInsights SharedInstance { get; }

		// @property (nonatomic, strong) NSString * serverURL;
		[Export ("serverURL", ArgumentSemantic.Strong)]
		string ServerURL { get; set; }

		// @property (getter = isCrashManagerDisabled, nonatomic) BOOL crashManagerDisabled;
		[Export ("crashManagerDisabled")]
		bool CrashManagerDisabled { [Bind ("isCrashManagerDisabled")] get; set; }

		// +(void)setCrashManagerDisabled:(BOOL)crashManagerDisabled;
		[Static]
		[Export ("setCrashManagerDisabled:")]
		void SetCrashManagerDisabled (bool crashManagerDisabled);

		// @property (getter = isTelemetryManagerDisabled, nonatomic) BOOL telemetryManagerDisabled;
		[Export ("telemetryManagerDisabled")]
		bool TelemetryManagerDisabled { [Bind ("isTelemetryManagerDisabled")] get; set; }

		// +(void)setTelemetryManagerDisabled:(BOOL)telemetryManagerDisabled;
		[Static]
		[Export ("setTelemetryManagerDisabled:")]
		void SetTelemetryManagerDisabled (bool telemetryManagerDisabled);

		// @property (getter = isAutoPageViewTrackingDisabled, nonatomic) BOOL autoPageViewTrackingDisabled;
		[Export ("autoPageViewTrackingDisabled")]
		bool AutoPageViewTrackingDisabled { [Bind ("isAutoPageViewTrackingDisabled")] get; set; }

		// +(void)setAutoPageViewTrackingDisabled:(BOOL)autoPageViewTrackingDisabled;
		[Static]
		[Export ("setAutoPageViewTrackingDisabled:")]
		void SetAutoPageViewTrackingDisabled (bool autoPageViewTrackingDisabled);

		// @property (getter = isAutoSessionManagementDisabled, nonatomic) BOOL autoSessionManagementDisabled;
		[Export ("autoSessionManagementDisabled")]
		bool AutoSessionManagementDisabled { [Bind ("isAutoSessionManagementDisabled")] get; set; }

		// +(void)setAutoSessionManagementDisabled:(BOOL)autoSessionManagementDisabled;
		[Static]
		[Export ("setAutoSessionManagementDisabled:")]
		void SetAutoSessionManagementDisabled (bool autoSessionManagementDisabled);

		// +(void)setUserId:(NSString *)userId;
		[Static]
		[Export ("setUserId:")]
		void SetUserId (string userId);

		// +(void)startNewSession;
		[Static]
		[Export ("startNewSession")]
		void StartNewSession ();

		// +(void)setAppBackgroundTimeBeforeSessionExpires:(NSUInteger)appBackgroundTimeBeforeSessionExpires;
		[Static]
		[Export ("setAppBackgroundTimeBeforeSessionExpires:")]
		void SetAppBackgroundTimeBeforeSessionExpires (nuint appBackgroundTimeBeforeSessionExpires);

		// +(void)renewSessionWithId:(NSString *)sessionId;
		[Static]
		[Export ("renewSessionWithId:")]
		void RenewSessionWithId (string sessionId);

		// @property (readonly, getter = isAppStoreEnvironment, nonatomic) BOOL appStoreEnvironment;
		[Export ("appStoreEnvironment")]
		bool AppStoreEnvironment { [Bind ("isAppStoreEnvironment")] get; }

		// @property (getter = isDebugLogEnabled, assign, nonatomic) BOOL debugLogEnabled;
		[Export ("debugLogEnabled")]
		bool DebugLogEnabled { [Bind ("isDebugLogEnabled")] get; set; }

		// +(void)testIdentifier;
		[Static]
		[Export ("testIdentifier")]
		void TestIdentifier ();

		// +(NSString *)version;
		[Static]
		[Export ("version")]
		string Version { get; }

		// +(NSString *)build;
		[Static]
		[Export ("build")]
		string Build { get; }
	}

	// @interface MSAICrashManager : NSObject
	[BaseType (typeof(NSObject))]
	interface MSAICrashManager
	{
		// +(instancetype)sharedManager;
		[Static]
		[Export ("sharedManager")]
		MSAICrashManager SharedManager ();

		// @property (assign, nonatomic) BOOL isSetupCorrectly;
		[Export ("isSetupCorrectly")]
		bool IsSetupCorrectly { get; set; }

		// @property (assign, nonatomic, setter = setCrashManagerDisabled:) BOOL isCrashManagerDisabled;
		[Export ("isCrashManagerDisabled")]
		bool IsCrashManagerDisabled { get; [Bind ("setCrashManagerDisabled:")] set; }

		// @property (assign, nonatomic) BOOL machExceptionHandlerEnabled;
		[Export ("machExceptionHandlerEnabled")]
		bool MachExceptionHandlerEnabled { get; set; }

		// @property (assign, nonatomic) BOOL onDeviceSymbolicationEnabled;
		[Export ("onDeviceSymbolicationEnabled")]
		bool OnDeviceSymbolicationEnabled { get; set; }

		// @property (assign, nonatomic) BOOL appNotTerminatingCleanlyDetectionEnabled;
		[Export ("appNotTerminatingCleanlyDetectionEnabled")]
		bool AppNotTerminatingCleanlyDetectionEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL didCrashInLastSession;
		[Export ("didCrashInLastSession")]
		bool DidCrashInLastSession { get; }

		// @property (readonly, nonatomic) NSTimeInterval timeintervalCrashInLastSessionOccured;
		[Export ("timeintervalCrashInLastSessionOccured")]
		double TimeintervalCrashInLastSessionOccured { get; }

		// @property (readonly, nonatomic) BOOL didReceiveMemoryWarningInLastSession;
		[Export ("didReceiveMemoryWarningInLastSession")]
		bool DidReceiveMemoryWarningInLastSession { get; }

		// @property (readonly, getter = getIsDebuggerAttached, nonatomic) BOOL debuggerIsAttached;
		[Export ("debuggerIsAttached")]
		bool DebuggerIsAttached { [Bind ("getIsDebuggerAttached")] get; }

		// -(void)generateTestCrash;
		[Export ("generateTestCrash")]
		void GenerateTestCrash ();
	}

	// @interface MSAITelemetryManager : NSObject
	[BaseType (typeof(NSObject))]
	interface MSAITelemetryManager
	{
		// +(void)trackEventWithName:(NSString *)eventName;
		[Static]
		[Export ("trackEventWithName:")]
		void TrackEventWithName (string eventName);

		// +(void)trackEventWithName:(NSString *)eventName properties:(NSDictionary *)properties;
		[Static]
		[Export ("trackEventWithName:properties:")]
		void TrackEventWithName (string eventName, NSDictionary properties);

		// +(void)trackEventWithName:(NSString *)eventName properties:(NSDictionary *)properties measurements:(NSDictionary *)measurements;
		[Static]
		[Export ("trackEventWithName:properties:measurements:")]
		void TrackEventWithName (string eventName, NSDictionary properties, NSDictionary measurements);

		// +(void)trackTraceWithMessage:(NSString *)message;
		[Static]
		[Export ("trackTraceWithMessage:")]
		void TrackTraceWithMessage (string message);

		// +(void)trackTraceWithMessage:(NSString *)message properties:(NSDictionary *)properties;
		[Static]
		[Export ("trackTraceWithMessage:properties:")]
		void TrackTraceWithMessage (string message, NSDictionary properties);

		// +(void)trackMetricWithName:(NSString *)metricName value:(double)value;
		[Static]
		[Export ("trackMetricWithName:value:")]
		void TrackMetricWithName (string metricName, double value);

		// +(void)trackMetricWithName:(NSString *)metricName value:(double)value properties:(NSDictionary *)properties;
		[Static]
		[Export ("trackMetricWithName:value:properties:")]
		void TrackMetricWithName (string metricName, double value, NSDictionary properties);

		// +(void)trackPageView:(NSString *)pageName;
		[Static]
		[Export ("trackPageView:")]
		void TrackPageView (string pageName);

		// +(void)trackPageView:(NSString *)pageName duration:(long)duration;
		[Static]
		[Export ("trackPageView:duration:")]
		void TrackPageView (string pageName, nint duration);

		// +(void)trackPageView:(NSString *)pageName duration:(long)duration properties:(NSDictionary *)properties;
		[Static]
		[Export ("trackPageView:duration:properties:")]
		void TrackPageView (string pageName, nint duration, NSDictionary properties);

		// +(void)trackException:(NSException *)exception;
		[Static]
		[Export ("trackException:")]
		void TrackException (NSException exception);
	}
}

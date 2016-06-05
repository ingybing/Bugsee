using System;
using ObjCRuntime;

namespace Com.Bugsee
{
    [Native]
    public enum BugseeLogLevel : ulong
    {
    	Low = 0,
    	Error,
    	Warning,
    	Info,
    	Debug,
    	Verbose
    }

    [Native]
    public enum BugseeSeverityLevel : ulong
    {
    	Low = 1,
    	Medium = 2,
    	High = 3,
    	Critical = 4,
    	Blocker = 5
    }
}
//
//  BGSNetworkFilter.h
//  Bugsee
//
//  Created by ANDREY KOVALEV on 01.03.16.
//  Copyright © 2016 Bugsee. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface BGSNetworkFilter : NSObject

@property (nonatomic, strong, readonly) NSString * filterString;

+ (instancetype) filterWithURLString:(NSString*)URLString;

@end

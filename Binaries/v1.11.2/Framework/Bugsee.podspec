Pod::Spec.new do |s|
  s.name         = "Bugsee"
  s.version      = "1.11.2"
  s.summary      = "Bug reporting for mobile apps. Learn more at https://www.bugsee.com"
  s.homepage     = "https://www.bugsee.com"
  s.license      = {
      :type => 'Commercial',
      :text => <<-LICENSE
                Copyright (C) 2016 Bugsee

                Permission is hereby granted to use this framework as is, modification are not allowed.

                All rights reserved.
				
				THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
				IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
				FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
				AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
				LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
				OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
				THE SOFTWARE.
      LICENSE
    }
  s.author       = { "Bugsee" => "contact@bugsee.com" }
  s.platform     = :ios, '5.0'
  s.source       = { :http => "http://download.bugsee.com/sdk/ios/Bugsee-1.11.2.zip" }
  s.source_files = 'Bugsee.framework/Versions/A/Headers/*.h'
  s.preserve_paths =  'Bugsee.framework/*'
  s.ios.vendored_frameworks = 'Bugsee.framework'
  s.frameworks   = 'QuartzCore', 'CoreGraphics', 'AVFoundation', 'CoreMedia', 'CoreMotion', 'SystemConfiguration', 'Foundation', 'OpenGLES', 'AudioToolbox', 'GLKit', 'CoreTelephony', 'UIKit', 'MessageUI', 'Bugsee'
  s.libraries    = 'c++'
  s.xcconfig     =  { 'FRAMEWORK_SEARCH_PATHS' => '"$(PODS_ROOT)/Bugsee/"' }
  s.requires_arc = true
end

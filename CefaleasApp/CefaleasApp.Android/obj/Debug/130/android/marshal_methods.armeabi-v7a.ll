; ModuleID = 'obj\Debug\130\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Debug\130\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [260 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 79
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 111
	i32 57263871, ; 2: Xamarin.Forms.Core.dll => 0x369c6ff => 106
	i32 88799905, ; 3: Acr.UserDialogs => 0x54afaa1 => 9
	i32 101534019, ; 4: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 95
	i32 120558881, ; 5: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 95
	i32 134690465, ; 6: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 115
	i32 159306688, ; 7: System.ComponentModel.Annotations => 0x97ed3c0 => 3
	i32 165246403, ; 8: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 56
	i32 182336117, ; 9: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 97
	i32 187944459, ; 10: Pitasoft.Result => 0xb33ce0b => 28
	i32 209399409, ; 11: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 54
	i32 230216969, ; 12: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 73
	i32 232815796, ; 13: System.Web.Services => 0xde07cb4 => 125
	i32 261689757, ; 14: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 59
	i32 278686392, ; 15: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 77
	i32 280482487, ; 16: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 71
	i32 318968648, ; 17: Xamarin.AndroidX.Activity.dll => 0x13031348 => 46
	i32 321597661, ; 18: System.Numerics => 0x132b30dd => 37
	i32 342366114, ; 19: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 75
	i32 385762202, ; 20: System.Memory.dll => 0x16fe439a => 35
	i32 441335492, ; 21: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 58
	i32 442521989, ; 22: Xamarin.Essentials => 0x1a605985 => 105
	i32 446678622, ; 23: CefaleasApp => 0x1a9fc65e => 11
	i32 450948140, ; 24: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 70
	i32 465846621, ; 25: mscorlib => 0x1bc4415d => 21
	i32 469710990, ; 26: System.dll => 0x1bff388e => 34
	i32 476646585, ; 27: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 71
	i32 486930444, ; 28: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 83
	i32 513247710, ; 29: Microsoft.Extensions.Primitives.dll => 0x1e9789de => 19
	i32 526420162, ; 30: System.Transactions.dll => 0x1f6088c2 => 120
	i32 527452488, ; 31: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 115
	i32 548916678, ; 32: Microsoft.Bcl.AsyncInterfaces => 0x20b7cdc6 => 14
	i32 552071795, ; 33: Pitasoft.Result.dll => 0x20e7f273 => 28
	i32 605376203, ; 34: System.IO.Compression.FileSystem => 0x24154ecb => 123
	i32 606307422, ; 35: Pitasoft.Shell => 0x2423845e => 29
	i32 610194910, ; 36: System.Reactive.dll => 0x245ed5de => 39
	i32 627609679, ; 37: Xamarin.AndroidX.CustomView => 0x2568904f => 64
	i32 638989360, ; 38: Pitasoft.MVVM.dll => 0x26163430 => 27
	i32 639843206, ; 39: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x26233b86 => 69
	i32 662205335, ; 40: System.Text.Encodings.Web.dll => 0x27787397 => 42
	i32 663517072, ; 41: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 102
	i32 666292255, ; 42: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 51
	i32 690569205, ; 43: System.Xml.Linq.dll => 0x29293ff5 => 45
	i32 691348768, ; 44: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 117
	i32 691439157, ; 45: Acr.UserDialogs.dll => 0x29368635 => 9
	i32 700284507, ; 46: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 112
	i32 720511267, ; 47: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 116
	i32 775507847, ; 48: System.IO.Compression => 0x2e394f87 => 122
	i32 809851609, ; 49: System.Drawing.Common.dll => 0x30455ad9 => 5
	i32 843511501, ; 50: Xamarin.AndroidX.Print => 0x3246f6cd => 90
	i32 878954865, ; 51: System.Net.Http.Json => 0x3463c971 => 36
	i32 928116545, ; 52: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 111
	i32 956575887, ; 53: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 116
	i32 967690846, ; 54: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 75
	i32 974778368, ; 55: FormsViewGroup.dll => 0x3a19f000 => 12
	i32 1012816738, ; 56: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 94
	i32 1028951442, ; 57: Microsoft.Extensions.DependencyInjection.Abstractions => 0x3d548d92 => 17
	i32 1035644815, ; 58: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 50
	i32 1042160112, ; 59: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 108
	i32 1052210849, ; 60: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 80
	i32 1084122840, ; 61: Xamarin.Kotlin.StdLib => 0x409e66d8 => 114
	i32 1098259244, ; 62: System => 0x41761b2c => 34
	i32 1138761583, ; 63: Pitasoft.dll => 0x43e01f6f => 25
	i32 1175144683, ; 64: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 100
	i32 1178241025, ; 65: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 87
	i32 1204270330, ; 66: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 51
	i32 1264511973, ; 67: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 96
	i32 1267360935, ; 68: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 101
	i32 1275534314, ; 69: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 117
	i32 1280496266, ; 70: Pitasoft.Shell.Xamarin.dll => 0x4c52d28a => 30
	i32 1293217323, ; 71: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 66
	i32 1350810665, ; 72: Pitasoft.Shell.Xamarin => 0x5083bc29 => 30
	i32 1365406463, ; 73: System.ServiceModel.Internals.dll => 0x516272ff => 127
	i32 1376866003, ; 74: Xamarin.AndroidX.SavedState => 0x52114ed3 => 94
	i32 1395857551, ; 75: Xamarin.AndroidX.Media.dll => 0x5333188f => 84
	i32 1406073936, ; 76: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 60
	i32 1411638395, ; 77: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 40
	i32 1454406777, ; 78: CefaleasApp.DataAccess => 0x56b07c79 => 4
	i32 1460219004, ; 79: Xamarin.Forms.Xaml => 0x57092c7c => 109
	i32 1462112819, ; 80: System.IO.Compression.dll => 0x57261233 => 122
	i32 1469204771, ; 81: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 49
	i32 1470490898, ; 82: Microsoft.Extensions.Primitives => 0x57a5e912 => 19
	i32 1582372066, ; 83: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 65
	i32 1592978981, ; 84: System.Runtime.Serialization.dll => 0x5ef2ee25 => 8
	i32 1622152042, ; 85: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 82
	i32 1624863272, ; 86: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 104
	i32 1635184631, ; 87: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x6176eff7 => 69
	i32 1636350590, ; 88: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 63
	i32 1639515021, ; 89: System.Net.Http.dll => 0x61b9038d => 7
	i32 1657153582, ; 90: System.Runtime => 0x62c6282e => 41
	i32 1658241508, ; 91: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 98
	i32 1658251792, ; 92: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 110
	i32 1670060433, ; 93: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 59
	i32 1697770098, ; 94: CefaleasApp.Entities.dll => 0x6531ea72 => 2
	i32 1698840827, ; 95: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 113
	i32 1729485958, ; 96: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 55
	i32 1731075164, ; 97: Pitasoft.Shell.dll => 0x672e1c5c => 29
	i32 1766324549, ; 98: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 97
	i32 1776026572, ; 99: System.Core.dll => 0x69dc03cc => 33
	i32 1788241197, ; 100: Xamarin.AndroidX.Fragment => 0x6a96652d => 70
	i32 1796167890, ; 101: Microsoft.Bcl.AsyncInterfaces.dll => 0x6b0f58d2 => 14
	i32 1808609942, ; 102: Xamarin.AndroidX.Loader => 0x6bcd3296 => 82
	i32 1813058853, ; 103: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 114
	i32 1813201214, ; 104: Xamarin.Google.Android.Material => 0x6c13413e => 110
	i32 1818569960, ; 105: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 88
	i32 1867746548, ; 106: Xamarin.Essentials.dll => 0x6f538cf4 => 105
	i32 1878053835, ; 107: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 109
	i32 1885316902, ; 108: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 52
	i32 1904755420, ; 109: System.Runtime.InteropServices.WindowsRuntime.dll => 0x718842dc => 6
	i32 1919157823, ; 110: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 85
	i32 1968388702, ; 111: Microsoft.Extensions.Configuration.dll => 0x75533a5e => 16
	i32 1983156543, ; 112: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 113
	i32 2011961780, ; 113: System.Buffers.dll => 0x77ec19b4 => 32
	i32 2019465201, ; 114: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 80
	i32 2028135870, ; 115: Pitasoft.Error => 0x78e2e5be => 26
	i32 2055257422, ; 116: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 76
	i32 2079903147, ; 117: System.Runtime.dll => 0x7bf8cdab => 41
	i32 2090596640, ; 118: System.Numerics.Vectors => 0x7c9bf920 => 38
	i32 2097448633, ; 119: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 72
	i32 2123282432, ; 120: Pitasoft.Client => 0x7e8eb800 => 22
	i32 2126786730, ; 121: Xamarin.Forms.Platform.Android => 0x7ec430aa => 107
	i32 2195305037, ; 122: Pitasoft.Validations.dll => 0x82d9b24d => 31
	i32 2201107256, ; 123: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 118
	i32 2201231467, ; 124: System.Net.Http => 0x8334206b => 7
	i32 2217644978, ; 125: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 100
	i32 2244775296, ; 126: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 83
	i32 2256548716, ; 127: Xamarin.AndroidX.MultiDex => 0x8680336c => 85
	i32 2261435625, ; 128: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 74
	i32 2266799131, ; 129: Microsoft.Extensions.Configuration.Abstractions => 0x871c9c1b => 15
	i32 2279755925, ; 130: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 92
	i32 2315684594, ; 131: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 47
	i32 2371007202, ; 132: Microsoft.Extensions.Configuration => 0x8d52b2e2 => 16
	i32 2403452196, ; 133: Xamarin.AndroidX.Emoji2.dll => 0x8f41c524 => 68
	i32 2409053734, ; 134: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 89
	i32 2435904999, ; 135: System.ComponentModel.DataAnnotations.dll => 0x9130f5e7 => 126
	i32 2465532216, ; 136: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 58
	i32 2471841756, ; 137: netstandard.dll => 0x93554fdc => 1
	i32 2475788418, ; 138: Java.Interop.dll => 0x93918882 => 13
	i32 2477910958, ; 139: Pitasoft.Commands.dll => 0x93b1ebae => 24
	i32 2501346920, ; 140: System.Data.DataSetExtensions => 0x95178668 => 121
	i32 2505896520, ; 141: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 79
	i32 2563143864, ; 142: AndHUD.dll => 0x98c678b8 => 10
	i32 2570120770, ; 143: System.Text.Encodings.Web => 0x9930ee42 => 42
	i32 2581819634, ; 144: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 101
	i32 2605712449, ; 145: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 118
	i32 2620871830, ; 146: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 63
	i32 2624644809, ; 147: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 67
	i32 2633051222, ; 148: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 77
	i32 2701096212, ; 149: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 98
	i32 2732626843, ; 150: Xamarin.AndroidX.Activity => 0xa2e0939b => 46
	i32 2737747696, ; 151: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 49
	i32 2766581644, ; 152: Xamarin.Forms.Core => 0xa4e6af8c => 106
	i32 2770495804, ; 153: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 112
	i32 2778768386, ; 154: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 103
	i32 2779977773, ; 155: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0xa5b3182d => 93
	i32 2803647631, ; 156: Pitasoft => 0xa71c448f => 25
	i32 2810250172, ; 157: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 60
	i32 2819470561, ; 158: System.Xml.dll => 0xa80db4e1 => 44
	i32 2821294376, ; 159: Xamarin.AndroidX.ResourceInspection.Annotation => 0xa8298928 => 93
	i32 2853208004, ; 160: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 103
	i32 2855708567, ; 161: Xamarin.AndroidX.Transition => 0xaa36a797 => 99
	i32 2903344695, ; 162: System.ComponentModel.Composition => 0xad0d8637 => 124
	i32 2905242038, ; 163: mscorlib.dll => 0xad2a79b6 => 21
	i32 2916838712, ; 164: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 104
	i32 2918797391, ; 165: Pitasoft.Collections.dll => 0xadf9504f => 23
	i32 2919462931, ; 166: System.Numerics.Vectors.dll => 0xae037813 => 38
	i32 2919904212, ; 167: CefaleasApp.dll => 0xae0a33d4 => 11
	i32 2921128767, ; 168: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 48
	i32 2978675010, ; 169: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 66
	i32 2996846495, ; 170: Xamarin.AndroidX.Lifecycle.Process.dll => 0xb2a03f9f => 78
	i32 3016983068, ; 171: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 96
	i32 3024354802, ; 172: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 73
	i32 3044182254, ; 173: FormsViewGroup => 0xb57288ee => 12
	i32 3057625584, ; 174: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 86
	i32 3105841721, ; 175: Pitasoft.MVVM => 0xb91f6239 => 27
	i32 3111772706, ; 176: System.Runtime.Serialization => 0xb979e222 => 8
	i32 3124832203, ; 177: System.Threading.Tasks.Extensions => 0xba4127cb => 129
	i32 3204380047, ; 178: System.Data.dll => 0xbefef58f => 119
	i32 3211777861, ; 179: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 65
	i32 3212247081, ; 180: Pitasoft.Validations => 0xbf770029 => 31
	i32 3247949154, ; 181: Mono.Security => 0xc197c562 => 128
	i32 3258312781, ; 182: Xamarin.AndroidX.CardView => 0xc235e84d => 55
	i32 3265893370, ; 183: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 129
	i32 3267021929, ; 184: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 53
	i32 3280506390, ; 185: System.ComponentModel.Annotations.dll => 0xc3888e16 => 3
	i32 3317135071, ; 186: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 64
	i32 3317144872, ; 187: System.Data => 0xc5b79d28 => 119
	i32 3340431453, ; 188: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 52
	i32 3345895724, ; 189: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 91
	i32 3346324047, ; 190: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 87
	i32 3353484488, ; 191: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 72
	i32 3358260929, ; 192: System.Text.Json => 0xc82afec1 => 43
	i32 3362522851, ; 193: Xamarin.AndroidX.Core => 0xc86c06e3 => 62
	i32 3366347497, ; 194: Java.Interop => 0xc8a662e9 => 13
	i32 3374999561, ; 195: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 92
	i32 3395150330, ; 196: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 40
	i32 3404865022, ; 197: System.ServiceModel.Internals => 0xcaf21dfe => 127
	i32 3428513518, ; 198: Microsoft.Extensions.DependencyInjection.dll => 0xcc5af6ee => 18
	i32 3429136800, ; 199: System.Xml => 0xcc6479a0 => 44
	i32 3430777524, ; 200: netstandard => 0xcc7d82b4 => 1
	i32 3441283291, ; 201: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 67
	i32 3442543374, ; 202: AndHUD => 0xcd310b0e => 10
	i32 3476120550, ; 203: Mono.Android => 0xcf3163e6 => 20
	i32 3485117614, ; 204: System.Text.Json.dll => 0xcfbaacae => 43
	i32 3486566296, ; 205: System.Transactions => 0xcfd0c798 => 120
	i32 3493954962, ; 206: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 57
	i32 3501239056, ; 207: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 53
	i32 3509114376, ; 208: System.Xml.Linq => 0xd128d608 => 45
	i32 3536029504, ; 209: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 107
	i32 3554870718, ; 210: Pitasoft.Error.dll => 0xd3e305be => 26
	i32 3567349600, ; 211: System.ComponentModel.Composition.dll => 0xd4a16f60 => 124
	i32 3573295437, ; 212: CefaleasApp.Android => 0xd4fc294d => 0
	i32 3618140916, ; 213: Xamarin.AndroidX.Preference => 0xd7a872f4 => 89
	i32 3627220390, ; 214: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 90
	i32 3632359727, ; 215: Xamarin.Forms.Platform => 0xd881692f => 108
	i32 3633644679, ; 216: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 48
	i32 3641597786, ; 217: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 76
	i32 3645089577, ; 218: System.ComponentModel.DataAnnotations => 0xd943a729 => 126
	i32 3651804146, ; 219: Pitasoft.Client.dll => 0xd9aa1bf2 => 22
	i32 3657292374, ; 220: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd9fdda56 => 15
	i32 3672681054, ; 221: Mono.Android.dll => 0xdae8aa5e => 20
	i32 3676310014, ; 222: System.Web.Services.dll => 0xdb2009fe => 125
	i32 3682565725, ; 223: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 54
	i32 3684561358, ; 224: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 57
	i32 3684933406, ; 225: System.Runtime.InteropServices.WindowsRuntime => 0xdba39f1e => 6
	i32 3689375977, ; 226: System.Drawing.Common => 0xdbe768e9 => 5
	i32 3706696989, ; 227: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 61
	i32 3718780102, ; 228: Xamarin.AndroidX.Annotation => 0xdda814c6 => 47
	i32 3724971120, ; 229: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 86
	i32 3731644420, ; 230: System.Reactive => 0xde6c6004 => 39
	i32 3737834244, ; 231: System.Net.Http.Json.dll => 0xdecad304 => 36
	i32 3758932259, ; 232: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 74
	i32 3779253275, ; 233: Pitasoft.Commands => 0xe142d41b => 24
	i32 3786282454, ; 234: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 56
	i32 3822602673, ; 235: Xamarin.AndroidX.Media => 0xe3d849b1 => 84
	i32 3829621856, ; 236: System.Numerics.dll => 0xe4436460 => 37
	i32 3841636137, ; 237: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xe4fab729 => 17
	i32 3860621202, ; 238: CefaleasApp.Android.dll => 0xe61c6792 => 0
	i32 3885922214, ; 239: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 99
	i32 3888767677, ; 240: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 91
	i32 3896760992, ; 241: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 62
	i32 3903737819, ; 242: Pitasoft.Collections => 0xe8ae4fdb => 23
	i32 3920810846, ; 243: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 123
	i32 3921031405, ; 244: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 102
	i32 3931092270, ; 245: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 88
	i32 3945713374, ; 246: System.Data.DataSetExtensions.dll => 0xeb2ecede => 121
	i32 3955647286, ; 247: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 50
	i32 3959773229, ; 248: Xamarin.AndroidX.Lifecycle.Process => 0xec05582d => 78
	i32 4025784931, ; 249: System.Memory => 0xeff49a63 => 35
	i32 4101593132, ; 250: Xamarin.AndroidX.Emoji2 => 0xf479582c => 68
	i32 4105002889, ; 251: Mono.Security.dll => 0xf4ad5f89 => 128
	i32 4126470640, ; 252: Microsoft.Extensions.DependencyInjection => 0xf5f4f1f0 => 18
	i32 4130916939, ; 253: CefaleasApp.DataAccess.dll => 0xf638ca4b => 4
	i32 4151237749, ; 254: System.Core => 0xf76edc75 => 33
	i32 4182413190, ; 255: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 81
	i32 4256097574, ; 256: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 61
	i32 4260525087, ; 257: System.Buffers => 0xfdf2741f => 32
	i32 4280205690, ; 258: CefaleasApp.Entities => 0xff1ec17a => 2
	i32 4292120959 ; 259: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 81
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [260 x i32] [
	i32 79, i32 111, i32 106, i32 9, i32 95, i32 95, i32 115, i32 3, ; 0..7
	i32 56, i32 97, i32 28, i32 54, i32 73, i32 125, i32 59, i32 77, ; 8..15
	i32 71, i32 46, i32 37, i32 75, i32 35, i32 58, i32 105, i32 11, ; 16..23
	i32 70, i32 21, i32 34, i32 71, i32 83, i32 19, i32 120, i32 115, ; 24..31
	i32 14, i32 28, i32 123, i32 29, i32 39, i32 64, i32 27, i32 69, ; 32..39
	i32 42, i32 102, i32 51, i32 45, i32 117, i32 9, i32 112, i32 116, ; 40..47
	i32 122, i32 5, i32 90, i32 36, i32 111, i32 116, i32 75, i32 12, ; 48..55
	i32 94, i32 17, i32 50, i32 108, i32 80, i32 114, i32 34, i32 25, ; 56..63
	i32 100, i32 87, i32 51, i32 96, i32 101, i32 117, i32 30, i32 66, ; 64..71
	i32 30, i32 127, i32 94, i32 84, i32 60, i32 40, i32 4, i32 109, ; 72..79
	i32 122, i32 49, i32 19, i32 65, i32 8, i32 82, i32 104, i32 69, ; 80..87
	i32 63, i32 7, i32 41, i32 98, i32 110, i32 59, i32 2, i32 113, ; 88..95
	i32 55, i32 29, i32 97, i32 33, i32 70, i32 14, i32 82, i32 114, ; 96..103
	i32 110, i32 88, i32 105, i32 109, i32 52, i32 6, i32 85, i32 16, ; 104..111
	i32 113, i32 32, i32 80, i32 26, i32 76, i32 41, i32 38, i32 72, ; 112..119
	i32 22, i32 107, i32 31, i32 118, i32 7, i32 100, i32 83, i32 85, ; 120..127
	i32 74, i32 15, i32 92, i32 47, i32 16, i32 68, i32 89, i32 126, ; 128..135
	i32 58, i32 1, i32 13, i32 24, i32 121, i32 79, i32 10, i32 42, ; 136..143
	i32 101, i32 118, i32 63, i32 67, i32 77, i32 98, i32 46, i32 49, ; 144..151
	i32 106, i32 112, i32 103, i32 93, i32 25, i32 60, i32 44, i32 93, ; 152..159
	i32 103, i32 99, i32 124, i32 21, i32 104, i32 23, i32 38, i32 11, ; 160..167
	i32 48, i32 66, i32 78, i32 96, i32 73, i32 12, i32 86, i32 27, ; 168..175
	i32 8, i32 129, i32 119, i32 65, i32 31, i32 128, i32 55, i32 129, ; 176..183
	i32 53, i32 3, i32 64, i32 119, i32 52, i32 91, i32 87, i32 72, ; 184..191
	i32 43, i32 62, i32 13, i32 92, i32 40, i32 127, i32 18, i32 44, ; 192..199
	i32 1, i32 67, i32 10, i32 20, i32 43, i32 120, i32 57, i32 53, ; 200..207
	i32 45, i32 107, i32 26, i32 124, i32 0, i32 89, i32 90, i32 108, ; 208..215
	i32 48, i32 76, i32 126, i32 22, i32 15, i32 20, i32 125, i32 54, ; 216..223
	i32 57, i32 6, i32 5, i32 61, i32 47, i32 86, i32 39, i32 36, ; 224..231
	i32 74, i32 24, i32 56, i32 84, i32 37, i32 17, i32 0, i32 99, ; 232..239
	i32 91, i32 62, i32 23, i32 123, i32 102, i32 88, i32 121, i32 50, ; 240..247
	i32 78, i32 35, i32 68, i32 128, i32 18, i32 4, i32 33, i32 81, ; 248..255
	i32 61, i32 32, i32 2, i32 81 ; 256..259
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}

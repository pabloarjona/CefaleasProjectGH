; ModuleID = 'obj\Debug\130\android\marshal_methods.x86_64.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86_64.ll"
target datalayout = "e-m:e-p270:32:32-p271:32:32-p272:64:64-i64:64-f80:128-n8:16:32:64-S128"
target triple = "x86_64-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [260 x i64] [
	i64 24362543149721218, ; 0: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 67
	i64 98382396393917666, ; 1: Microsoft.Extensions.Primitives.dll => 0x15d8644ad360ce2 => 19
	i64 120698629574877762, ; 2: Mono.Android => 0x1accec39cafe242 => 20
	i64 210515253464952879, ; 3: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 56
	i64 232391251801502327, ; 4: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 94
	i64 295915112840604065, ; 5: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 95
	i64 297431411859317107, ; 6: Pitasoft => 0x420b04b10eae173 => 25
	i64 316157742385208084, ; 7: Xamarin.AndroidX.Core.Core.Ktx.dll => 0x46337caa7dc1b14 => 61
	i64 464346026994987652, ; 8: System.Reactive.dll => 0x671b04057e67284 => 39
	i64 564148115380777761, ; 9: CefaleasApp.dll => 0x7d441b8d1fa3321 => 11
	i64 634308326490598313, ; 10: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 79
	i64 702024105029695270, ; 11: System.Drawing.Common => 0x9be17343c0e7726 => 5
	i64 720058930071658100, ; 12: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 72
	i64 797848633438282310, ; 13: CefaleasApp.Entities.dll => 0xb12871adc9ea246 => 2
	i64 872800313462103108, ; 14: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 66
	i64 940822596282819491, ; 15: System.Transactions => 0xd0e792aa81923a3 => 120
	i64 996343623809489702, ; 16: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 108
	i64 1000557547492888992, ; 17: Mono.Security.dll => 0xde2b1c9cba651a0 => 128
	i64 1120440138749646132, ; 18: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 110
	i64 1315114680217950157, ; 19: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 51
	i64 1365182572388100002, ; 20: CefaleasApp.Entities => 0x12f21a5108bf27a2 => 2
	i64 1425944114962822056, ; 21: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 8
	i64 1553634045424954888, ; 22: Pitasoft.Shell => 0x158f9deecc81ee08 => 29
	i64 1556063002408531761, ; 23: CefaleasApp.Android => 0x15983f0e6ab03731 => 0
	i64 1607464855600062325, ; 24: CefaleasApp => 0x164edcc4faf75f75 => 11
	i64 1624659445732251991, ; 25: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 49
	i64 1628611045998245443, ; 26: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 81
	i64 1636321030536304333, ; 27: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 73
	i64 1640006970122925627, ; 28: Pitasoft.Result => 0x16c279a67357763b => 28
	i64 1685234414467133967, ; 29: Pitasoft.Error => 0x176327c56d93b20f => 26
	i64 1743969030606105336, ; 30: System.Memory.dll => 0x1833d297e88f2af8 => 35
	i64 1795316252682057001, ; 31: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 50
	i64 1836611346387731153, ; 32: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 94
	i64 1865037103900624886, ; 33: Microsoft.Bcl.AsyncInterfaces => 0x19e1f15d56eb87f6 => 14
	i64 1875917498431009007, ; 34: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 47
	i64 1981742497975770890, ; 35: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 80
	i64 2040001226662520565, ; 36: System.Threading.Tasks.Extensions.dll => 0x1c4f8a4ea894a6f5 => 129
	i64 2064708342624596306, ; 37: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x1ca7514c5eecb152 => 115
	i64 2136356949452311481, ; 38: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 85
	i64 2165725771938924357, ; 39: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 54
	i64 2262844636196693701, ; 40: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 66
	i64 2284400282711631002, ; 41: System.Web.Services => 0x1fb3d1f42fd4249a => 125
	i64 2287887973817120656, ; 42: System.ComponentModel.DataAnnotations.dll => 0x1fc035fd8d41f790 => 126
	i64 2304837677853103545, ; 43: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0x1ffc6da80d5ed5b9 => 93
	i64 2329709569556905518, ; 44: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 76
	i64 2335503487726329082, ; 45: System.Text.Encodings.Web => 0x2069600c4d9d1cfa => 42
	i64 2337758774805907496, ; 46: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 40
	i64 2470498323731680442, ; 47: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 60
	i64 2479423007379663237, ; 48: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 100
	i64 2489738558632930771, ; 49: Acr.UserDialogs.dll => 0x228d540722e8add3 => 9
	i64 2497223385847772520, ; 50: System.Runtime => 0x22a7eb7046413568 => 41
	i64 2547086958574651984, ; 51: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 46
	i64 2592350477072141967, ; 52: System.Xml.dll => 0x23f9e10627330e8f => 44
	i64 2624866290265602282, ; 53: mscorlib.dll => 0x246d65fbde2db8ea => 21
	i64 2656907746661064104, ; 54: Microsoft.Extensions.DependencyInjection => 0x24df3b84c8b75da8 => 18
	i64 2694427813909235223, ; 55: Xamarin.AndroidX.Preference.dll => 0x256487d230fe0617 => 89
	i64 2783046991838674048, ; 56: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 40
	i64 2787234703088983483, ; 57: Xamarin.AndroidX.Startup.StartupRuntime => 0x26ae3f31ef429dbb => 96
	i64 2960931600190307745, ; 58: Xamarin.Forms.Core => 0x2917579a49927da1 => 106
	i64 3017704767998173186, ; 59: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 110
	i64 3289520064315143713, ; 60: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 75
	i64 3303437397778967116, ; 61: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 48
	i64 3311221304742556517, ; 62: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 38
	i64 3344514922410554693, ; 63: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x2e6a1a9a18463545 => 118
	i64 3493805808809882663, ; 64: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 98
	i64 3494946837667399002, ; 65: Microsoft.Extensions.Configuration => 0x30808ba1c00a455a => 16
	i64 3522470458906976663, ; 66: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 97
	i64 3531994851595924923, ; 67: System.Numerics => 0x31042a9aade235bb => 37
	i64 3571415421602489686, ; 68: System.Runtime.dll => 0x319037675df7e556 => 41
	i64 3638003163729360188, ; 69: Microsoft.Extensions.Configuration.Abstractions => 0x327cc89a39d5f53c => 15
	i64 3655542548057982301, ; 70: Microsoft.Extensions.Configuration.dll => 0x32bb18945e52855d => 16
	i64 3716579019761409177, ; 71: netstandard.dll => 0x3393f0ed5c8c5c99 => 1
	i64 3727469159507183293, ; 72: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 92
	i64 3772598417116884899, ; 73: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 67
	i64 3966267475168208030, ; 74: System.Memory => 0x370b03412596249e => 35
	i64 4201423742386704971, ; 75: Xamarin.AndroidX.Core.Core.Ktx => 0x3a4e74a233da124b => 61
	i64 4369456391352213204, ; 76: CefaleasApp.DataAccess => 0x3ca36d70041bded4 => 4
	i64 4525561845656915374, ; 77: System.ServiceModel.Internals => 0x3ece06856b710dae => 127
	i64 4589875537677736143, ; 78: CefaleasApp.Android.dll => 0x3fb2837bba8958cf => 0
	i64 4636684751163556186, ; 79: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 102
	i64 4743821336939966868, ; 80: System.ComponentModel.Annotations => 0x41d5705f4239b194 => 3
	i64 4759461199762736555, ; 81: Xamarin.AndroidX.Lifecycle.Process.dll => 0x420d00be961cc5ab => 78
	i64 4782108999019072045, ; 82: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 53
	i64 4794310189461587505, ; 83: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 46
	i64 4795410492532947900, ; 84: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 97
	i64 4964642320636185212, ; 85: Pitasoft.Shell.dll => 0x44e5f3e306640a7c => 29
	i64 5142919913060024034, ; 86: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 107
	i64 5203618020066742981, ; 87: Xamarin.Essentials => 0x4836f704f0e652c5 => 105
	i64 5205316157927637098, ; 88: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 83
	i64 5348796042099802469, ; 89: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 84
	i64 5376510917114486089, ; 90: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 100
	i64 5380421753271135352, ; 91: Pitasoft.Collections.dll => 0x4aab1913f182ac78 => 23
	i64 5408338804355907810, ; 92: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 99
	i64 5451019430259338467, ; 93: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 59
	i64 5507995362134886206, ; 94: System.Core.dll => 0x4c705499688c873e => 33
	i64 5692067934154308417, ; 95: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 104
	i64 5719487239155078365, ; 96: Pitasoft.Client => 0x4f5fb3574337d4dd => 22
	i64 5757522595884336624, ; 97: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 57
	i64 5814345312393086621, ; 98: Xamarin.AndroidX.Preference => 0x50b0b44182a5c69d => 89
	i64 5896680224035167651, ; 99: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x51d5376bfbafdda3 => 77
	i64 6085203216496545422, ; 100: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 108
	i64 6086316965293125504, ; 101: FormsViewGroup.dll => 0x5476f10882baef80 => 12
	i64 6222399776351216807, ; 102: System.Text.Json.dll => 0x565a67a0ffe264a7 => 43
	i64 6319713645133255417, ; 103: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 79
	i64 6401687960814735282, ; 104: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 76
	i64 6504860066809920875, ; 105: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 54
	i64 6548213210057960872, ; 106: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 64
	i64 6591024623626361694, ; 107: System.Web.Services.dll => 0x5b7805f9751a1b5e => 125
	i64 6659513131007730089, ; 108: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 72
	i64 6876862101832370452, ; 109: System.Xml.Linq => 0x5f6f85a57d108914 => 45
	i64 6894844156784520562, ; 110: System.Numerics.Vectors => 0x5faf683aead1ad72 => 38
	i64 7036436454368433159, ; 111: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x61a671acb33d5407 => 74
	i64 7103753931438454322, ; 112: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 71
	i64 7141577505875122296, ; 113: System.Runtime.InteropServices.WindowsRuntime.dll => 0x631bfae7659b5878 => 6
	i64 7275204167063126552, ; 114: Pitasoft.Collections => 0x64f6b7a4ee3d4218 => 23
	i64 7488575175965059935, ; 115: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 45
	i64 7602111570124318452, ; 116: System.Reactive => 0x698020320025a6f4 => 39
	i64 7635363394907363464, ; 117: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 106
	i64 7637365915383206639, ; 118: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 105
	i64 7654504624184590948, ; 119: System.Net.Http => 0x6a3a4366801b8264 => 7
	i64 7735352534559001595, ; 120: Xamarin.Kotlin.StdLib.dll => 0x6b597e2582ce8bfb => 114
	i64 7820441508502274321, ; 121: System.Data => 0x6c87ca1e14ff8111 => 119
	i64 7836164640616011524, ; 122: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 49
	i64 7875371864198757046, ; 123: AndHUD.dll => 0x6d4af0fc27ac3ab6 => 10
	i64 8044118961405839122, ; 124: System.ComponentModel.Composition => 0x6fa2739369944712 => 124
	i64 8083354569033831015, ; 125: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 75
	i64 8085230611270010360, ; 126: System.Net.Http.Json.dll => 0x703482674fdd05f8 => 36
	i64 8103644804370223335, ; 127: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 121
	i64 8167236081217502503, ; 128: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 13
	i64 8187640529827139739, ; 129: Xamarin.KotlinX.Coroutines.Android => 0x71a057ae90f0109b => 117
	i64 8318905602908530212, ; 130: System.ComponentModel.DataAnnotations => 0x7372b092055ea624 => 126
	i64 8398329775253868912, ; 131: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 58
	i64 8400357532724379117, ; 132: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 88
	i64 8426919725312979251, ; 133: Xamarin.AndroidX.Lifecycle.Process => 0x74f26ed7aa033133 => 78
	i64 8598790081731763592, ; 134: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x77550a055fc61d88 => 69
	i64 8601935802264776013, ; 135: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 99
	i64 8626175481042262068, ; 136: Java.Interop => 0x77b654e585b55834 => 13
	i64 8639588376636138208, ; 137: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 87
	i64 8684531736582871431, ; 138: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 123
	i64 8853378295825400934, ; 139: Xamarin.Kotlin.StdLib.Common.dll => 0x7add84a720d38466 => 113
	i64 8951477988056063522, ; 140: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0x7c3a09cd9ccf5e22 => 91
	i64 9312692141327339315, ; 141: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 104
	i64 9324707631942237306, ; 142: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 50
	i64 9603478802268342847, ; 143: Pitasoft.dll => 0x85466916d932ca3f => 25
	i64 9662334977499516867, ; 144: System.Numerics.dll => 0x8617827802b0cfc3 => 37
	i64 9678050649315576968, ; 145: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 60
	i64 9711637524876806384, ; 146: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 84
	i64 9780723996889434231, ; 147: AndHUD => 0x87bc1ca798bbc877 => 10
	i64 9808709177481450983, ; 148: Mono.Android.dll => 0x881f890734e555e7 => 20
	i64 9825649861376906464, ; 149: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 57
	i64 9834056768316610435, ; 150: System.Transactions.dll => 0x8879968718899783 => 120
	i64 9907349773706910547, ; 151: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x897dfa20b758db53 => 69
	i64 9998632235833408227, ; 152: Mono.Security => 0x8ac2470b209ebae3 => 128
	i64 10038780035334861115, ; 153: System.Net.Http.dll => 0x8b50e941206af13b => 7
	i64 10226222362177979215, ; 154: Xamarin.Kotlin.StdLib.Jdk7 => 0x8dead70ebbc6434f => 115
	i64 10229024438826829339, ; 155: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 64
	i64 10321854143672141184, ; 156: Xamarin.Jetbrains.Annotations.dll => 0x8f3e97a7f8f8c580 => 112
	i64 10376576884623852283, ; 157: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 98
	i64 10406448008575299332, ; 158: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x906b2153fcb3af04 => 118
	i64 10430153318873392755, ; 159: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 62
	i64 10447083246144586668, ; 160: Microsoft.Bcl.AsyncInterfaces.dll => 0x90fb7edc816203ac => 14
	i64 10481878657258167364, ; 161: Pitasoft.Validations.dll => 0x91771d1a789f1c44 => 31
	i64 10847732767863316357, ; 162: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 51
	i64 11023048688141570732, ; 163: System.Core => 0x98f9bc61168392ac => 33
	i64 11037814507248023548, ; 164: System.Xml => 0x992e31d0412bf7fc => 44
	i64 11162124722117608902, ; 165: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 103
	i64 11340910727871153756, ; 166: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 63
	i64 11392833485892708388, ; 167: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 90
	i64 11529969570048099689, ; 168: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 103
	i64 11578238080964724296, ; 169: Xamarin.AndroidX.Legacy.Support.V4 => 0xa0ae2a30c4cd8648 => 74
	i64 11580057168383206117, ; 170: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 47
	i64 11591352189662810718, ; 171: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0xa0dcc167234c525e => 96
	i64 11597940890313164233, ; 172: netstandard => 0xa0f429ca8d1805c9 => 1
	i64 11672361001936329215, ; 173: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 71
	i64 12102847907131387746, ; 174: System.Buffers => 0xa7f5f40c43256f62 => 32
	i64 12137774235383566651, ; 175: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 101
	i64 12145679461940342714, ; 176: System.Text.Json => 0xa88e1f1ebcb62fba => 43
	i64 12451044538927396471, ; 177: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 70
	i64 12466513435562512481, ; 178: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 82
	i64 12487638416075308985, ; 179: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 65
	i64 12538491095302438457, ; 180: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 55
	i64 12550732019250633519, ; 181: System.IO.Compression => 0xae2d28465e8e1b2f => 122
	i64 12700543734426720211, ; 182: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 56
	i64 12828192437253469131, ; 183: Xamarin.Kotlin.StdLib.Jdk8.dll => 0xb206e50e14d873cb => 116
	i64 12843321153144804894, ; 184: Microsoft.Extensions.Primitives => 0xb23ca48abd74d61e => 19
	i64 12880969010102794471, ; 185: Pitasoft.Commands.dll => 0xb2c2651181fdf8e7 => 24
	i64 12935009578440986116, ; 186: Pitasoft.Error.dll => 0xb38262add1400e04 => 26
	i64 12963446364377008305, ; 187: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 5
	i64 13129914918964716986, ; 188: Xamarin.AndroidX.Emoji2.dll => 0xb636d40db3fe65ba => 68
	i64 13370592475155966277, ; 189: System.Runtime.Serialization => 0xb98de304062ea945 => 8
	i64 13383983804623641455, ; 190: Pitasoft.Commands => 0xb9bd765be22c5b6f => 24
	i64 13401370062847626945, ; 191: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 101
	i64 13404347523447273790, ; 192: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 58
	i64 13454009404024712428, ; 193: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 111
	i64 13465488254036897740, ; 194: Xamarin.Kotlin.StdLib => 0xbadf06394d106fcc => 114
	i64 13491513212026656886, ; 195: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 52
	i64 13572454107664307259, ; 196: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 92
	i64 13606761789537074844, ; 197: CefaleasApp.DataAccess.dll => 0xbcd4edc180b73e9c => 4
	i64 13647894001087880694, ; 198: System.Data.dll => 0xbd670f48cb071df6 => 119
	i64 13706410092292941103, ; 199: Pitasoft.Client.dll => 0xbe36f35bf8f3252f => 22
	i64 13828521679616088467, ; 200: Xamarin.Kotlin.StdLib.Common => 0xbfe8c733724e1993 => 113
	i64 13959074834287824816, ; 201: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 70
	i64 13967638549803255703, ; 202: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 107
	i64 14124974489674258913, ; 203: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 55
	i64 14161076099266624234, ; 204: Acr.UserDialogs => 0xc4863faf060fbaea => 9
	i64 14172845254133543601, ; 205: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 85
	i64 14261073672896646636, ; 206: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 90
	i64 14360971211913849788, ; 207: Pitasoft.Validations => 0xc74c6b3ac3bc6bbc => 31
	i64 14486659737292545672, ; 208: Xamarin.AndroidX.Lifecycle.LiveData => 0xc90af44707469e88 => 77
	i64 14495724990987328804, ; 209: Xamarin.AndroidX.ResourceInspection.Annotation => 0xc92b2913e18d5d24 => 93
	i64 14551742072151931844, ; 210: System.Text.Encodings.Web.dll => 0xc9f22c50f1b8fbc4 => 42
	i64 14644440854989303794, ; 211: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 83
	i64 14669215534098758659, ; 212: Microsoft.Extensions.DependencyInjection.dll => 0xcb9385ceb3993c03 => 18
	i64 14792063746108907174, ; 213: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 111
	i64 14852515768018889994, ; 214: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 63
	i64 14954917835170835695, ; 215: Microsoft.Extensions.DependencyInjection.Abstractions.dll => 0xcf8a8a895a82ecef => 17
	i64 14987728460634540364, ; 216: System.IO.Compression.dll => 0xcfff1ba06622494c => 122
	i64 14988210264188246988, ; 217: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 65
	i64 15024878362326791334, ; 218: System.Net.Http.Json => 0xd0831743ebf0f4a6 => 36
	i64 15150743910298169673, ; 219: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xd2424150783c3149 => 91
	i64 15227001540531775957, ; 220: Microsoft.Extensions.Configuration.Abstractions.dll => 0xd3512d3999b8e9d5 => 15
	i64 15279429628684179188, ; 221: Xamarin.KotlinX.Coroutines.Android.dll => 0xd40b704b1c4c96f4 => 117
	i64 15307487799862361161, ; 222: Pitasoft.Shell.Xamarin.dll => 0xd46f1f0d2a6bfc49 => 30
	i64 15370334346939861994, ; 223: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 62
	i64 15391712275433856905, ; 224: Microsoft.Extensions.DependencyInjection.Abstractions => 0xd59a58c406411f89 => 17
	i64 15582737692548360875, ; 225: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 81
	i64 15609085926864131306, ; 226: System.dll => 0xd89e9cf3334914ea => 34
	i64 15777549416145007739, ; 227: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 95
	i64 15810740023422282496, ; 228: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 109
	i64 15963349826457351533, ; 229: System.Threading.Tasks.Extensions => 0xdd893616f748b56d => 129
	i64 16154507427712707110, ; 230: System => 0xe03056ea4e39aa26 => 34
	i64 16289451480353727344, ; 231: Pitasoft.MVVM => 0xe20fc1d0f071e370 => 27
	i64 16423015068819898779, ; 232: Xamarin.Kotlin.StdLib.Jdk8 => 0xe3ea453135e5c19b => 116
	i64 16565028646146589191, ; 233: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 124
	i64 16621146507174665210, ; 234: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 59
	i64 16677317093839702854, ; 235: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 88
	i64 16822611501064131242, ; 236: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 121
	i64 16833383113903931215, ; 237: mscorlib => 0xe99c30c1484d7f4f => 21
	i64 16866861824412579935, ; 238: System.Runtime.InteropServices.WindowsRuntime => 0xea132176ffb5785f => 6
	i64 17024911836938395553, ; 239: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 48
	i64 17031351772568316411, ; 240: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 86
	i64 17037200463775726619, ; 241: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 73
	i64 17187273293601214786, ; 242: System.ComponentModel.Annotations.dll => 0xee8575ff9aa89142 => 3
	i64 17544493274320527064, ; 243: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 53
	i64 17704177640604968747, ; 244: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 82
	i64 17710060891934109755, ; 245: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 80
	i64 17838668724098252521, ; 246: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 32
	i64 17882897186074144999, ; 247: FormsViewGroup => 0xf82cd03e3ac830e7 => 12
	i64 17891337867145587222, ; 248: Xamarin.Jetbrains.Annotations => 0xf84accff6fb52a16 => 112
	i64 17892495832318972303, ; 249: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 109
	i64 17909947175903573254, ; 250: Pitasoft.Shell.Xamarin => 0xf88cea10c5be3506 => 30
	i64 17928294245072900555, ; 251: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 123
	i64 18116111925905154859, ; 252: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 52
	i64 18121036031235206392, ; 253: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 86
	i64 18129453464017766560, ; 254: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 127
	i64 18260797123374478311, ; 255: Xamarin.AndroidX.Emoji2 => 0xfd6b623bde35f3e7 => 68
	i64 18305135509493619199, ; 256: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 87
	i64 18319010843337868949, ; 257: Pitasoft.MVVM.dll => 0xfe3a334dc1aec695 => 27
	i64 18365472625039093317, ; 258: Pitasoft.Result.dll => 0xfedf440c4b9dae45 => 28
	i64 18380184030268848184 ; 259: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 102
], align 16
@assembly_image_cache_indices = local_unnamed_addr constant [260 x i32] [
	i32 67, i32 19, i32 20, i32 56, i32 94, i32 95, i32 25, i32 61, ; 0..7
	i32 39, i32 11, i32 79, i32 5, i32 72, i32 2, i32 66, i32 120, ; 8..15
	i32 108, i32 128, i32 110, i32 51, i32 2, i32 8, i32 29, i32 0, ; 16..23
	i32 11, i32 49, i32 81, i32 73, i32 28, i32 26, i32 35, i32 50, ; 24..31
	i32 94, i32 14, i32 47, i32 80, i32 129, i32 115, i32 85, i32 54, ; 32..39
	i32 66, i32 125, i32 126, i32 93, i32 76, i32 42, i32 40, i32 60, ; 40..47
	i32 100, i32 9, i32 41, i32 46, i32 44, i32 21, i32 18, i32 89, ; 48..55
	i32 40, i32 96, i32 106, i32 110, i32 75, i32 48, i32 38, i32 118, ; 56..63
	i32 98, i32 16, i32 97, i32 37, i32 41, i32 15, i32 16, i32 1, ; 64..71
	i32 92, i32 67, i32 35, i32 61, i32 4, i32 127, i32 0, i32 102, ; 72..79
	i32 3, i32 78, i32 53, i32 46, i32 97, i32 29, i32 107, i32 105, ; 80..87
	i32 83, i32 84, i32 100, i32 23, i32 99, i32 59, i32 33, i32 104, ; 88..95
	i32 22, i32 57, i32 89, i32 77, i32 108, i32 12, i32 43, i32 79, ; 96..103
	i32 76, i32 54, i32 64, i32 125, i32 72, i32 45, i32 38, i32 74, ; 104..111
	i32 71, i32 6, i32 23, i32 45, i32 39, i32 106, i32 105, i32 7, ; 112..119
	i32 114, i32 119, i32 49, i32 10, i32 124, i32 75, i32 36, i32 121, ; 120..127
	i32 13, i32 117, i32 126, i32 58, i32 88, i32 78, i32 69, i32 99, ; 128..135
	i32 13, i32 87, i32 123, i32 113, i32 91, i32 104, i32 50, i32 25, ; 136..143
	i32 37, i32 60, i32 84, i32 10, i32 20, i32 57, i32 120, i32 69, ; 144..151
	i32 128, i32 7, i32 115, i32 64, i32 112, i32 98, i32 118, i32 62, ; 152..159
	i32 14, i32 31, i32 51, i32 33, i32 44, i32 103, i32 63, i32 90, ; 160..167
	i32 103, i32 74, i32 47, i32 96, i32 1, i32 71, i32 32, i32 101, ; 168..175
	i32 43, i32 70, i32 82, i32 65, i32 55, i32 122, i32 56, i32 116, ; 176..183
	i32 19, i32 24, i32 26, i32 5, i32 68, i32 8, i32 24, i32 101, ; 184..191
	i32 58, i32 111, i32 114, i32 52, i32 92, i32 4, i32 119, i32 22, ; 192..199
	i32 113, i32 70, i32 107, i32 55, i32 9, i32 85, i32 90, i32 31, ; 200..207
	i32 77, i32 93, i32 42, i32 83, i32 18, i32 111, i32 63, i32 17, ; 208..215
	i32 122, i32 65, i32 36, i32 91, i32 15, i32 117, i32 30, i32 62, ; 216..223
	i32 17, i32 81, i32 34, i32 95, i32 109, i32 129, i32 34, i32 27, ; 224..231
	i32 116, i32 124, i32 59, i32 88, i32 121, i32 21, i32 6, i32 48, ; 232..239
	i32 86, i32 73, i32 3, i32 53, i32 82, i32 80, i32 32, i32 12, ; 240..247
	i32 112, i32 109, i32 30, i32 123, i32 52, i32 86, i32 127, i32 68, ; 248..255
	i32 87, i32 27, i32 28, i32 102 ; 256..259
], align 16

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 16; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="x86-64" "target-features"="+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1}
!llvm.ident = !{!2}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}

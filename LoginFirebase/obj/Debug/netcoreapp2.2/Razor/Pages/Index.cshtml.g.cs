#pragma checksum "D:\FPTU_7\SWD\LoginAppFirebase\LoginFirebase\LoginFirebase\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f682b06a854b999c46b8a964f4efad2df6574379"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LoginFirebase.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(LoginFirebase.Pages.Pages_Index), null)]
namespace LoginFirebase.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\FPTU_7\SWD\LoginAppFirebase\LoginFirebase\LoginFirebase\Pages\_ViewImports.cshtml"
using LoginFirebase;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f682b06a854b999c46b8a964f4efad2df6574379", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aafee3cac42a0fbb31b7bea121a0efeaa31eccd5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\FPTU_7\SWD\LoginAppFirebase\LoginFirebase\LoginFirebase\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 171, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1>Welcome to My Awesome App</h1>\r\n    <div id=\"firebaseui-auth-container\"></div>\r\n    <div id=\"loader\">Loading....</div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(260, 4187, true);
                WriteLiteral(@"
    <!-- Firebase -->
    <script src=""https://www.gstatic.com/firebasejs/7.14.5/firebase-app.js""></script>
    <script src=""https://www.gstatic.com/firebasejs/7.14.5/firebase-analytics.js""></script>
    <script src=""https://www.gstatic.com/firebasejs/7.14.5/firebase-auth.js""></script>
    <script src=""https://www.gstatic.com/firebasejs/7.14.5/firebase-firestore.js""></script>
    <script>
        var firebaseConfig = {
            apiKey: ""AIzaSyDd9nAR91xMHxJHB4jj2qx7ldtL3QK59CI"",
            authDomain: ""my-login-project-haipm.firebaseapp.com"",
            databaseURL: ""https://my-login-project-haipm.firebaseio.com"",
            projectId: ""my-login-project-haipm"",
            storageBucket: ""my-login-project-haipm.appspot.com"",
            messagingSenderId: ""898831670308"",
            appId: ""1:898831670308:web:f088a5613037f2be540cb1""
        };
        firebase.initializeApp(firebaseConfig);


        var provider = new firebase.auth.GoogleAuthProvider();
        provider.addScope('ht");
                WriteLiteral(@"tps://www.googleapis.com/auth/contacts.readonly');
        firebase.auth().signInWithPopup(provider).then(function (result) {
            // This gives you a Google Access Token. You can use it to access the Google API.
            var token = result.credential.accessToken;
            // The signed-in user info.
            var user = result.user;
            // ...
        }).catch(function (error) {
            // Handle Errors here.
            var errorCode = error.code;
            var errorMessage = error.message;
            // The email of the user's account used.
            var email = error.email;
            // The firebase.auth.AuthCredential type that was used.
            var credential = error.credential;
            // ...
        });



        var ui = new firebaseui.auth.AuthUI(firebase.auth());
        var uiConfig = {
            callbacks: {
                signInSuccessWithAuthResult: function (authResult, redirectUrl) {
                    console.log(authResu");
                WriteLiteral(@"lt);
                    console.log(authResult.idToken);
                    window.preventDefault();
                    // User successfully signed in.
                    // Return type determines whether we continue the redirect automatically
                    // or whether we leave that to developer to handle.
                    return true;
                },
                uiShown: function () {
                    // The widget is rendered.
                    // Hide the loader.
                    document.getElementById('loader').style.display = 'none';
                }
            },
            // Will use popup for IDP Providers sign-in flow instead of the default, redirect.
            signInFlow: 'popup',
            signInSuccessUrl: '/success_page',
            signInOptions: [
                // Leave the lines as is for the providers you want to offer your users.
                firebase.auth.GoogleAuthProvider.PROVIDER_ID,
                firebase.auth.FacebookAu");
                WriteLiteral(@"thProvider.PROVIDER_ID,
                firebase.auth.TwitterAuthProvider.PROVIDER_ID,
                firebase.auth.GithubAuthProvider.PROVIDER_ID,
                firebase.auth.EmailAuthProvider.PROVIDER_ID,
                firebase.auth.PhoneAuthProvider.PROVIDER_ID
            ],
            // Terms of service url.
            tosUrl: '<your-tos-url>',
            // Privacy policy url.
            privacyPolicyUrl: '<your-privacy-policy-url>'
        };
        ui.start('#firebaseui-auth-container', uiConfig);

        function createNew() {
            var email = document.getElementById(""username"").value;
            var password = document.getElementById(""password"").value;
            console.log(email);
            firebase.auth().signInWithEmailAndPassword(email, password).catch(function (error) {
                alert(""fail"");
                // Handle Errors here.
                var errorCode = error.code;
                var errorMessage = error.message;
                wi");
                WriteLiteral("ndow.preventDefault();\r\n                // ...\r\n            });\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

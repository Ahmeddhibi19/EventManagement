#pragma checksum "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\MyEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8d0ca05b3b774366fd975cc47a22e501ae0d71e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_MyEvents), @"mvc.1.0.view", @"/Views/Event/MyEvents.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\_ViewImports.cshtml"
using TSEventApp.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\_ViewImports.cshtml"
using TSEventApp.Core.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\MyEvents.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8d0ca05b3b774366fd975cc47a22e501ae0d71e", @"/Views/Event/MyEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d132f9d95a98e70773a3876bd0f1c58bfcfc755", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_MyEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EventViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_EventDetailsIndexPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\MyEvents.cshtml"
  
    ViewData["Title"] = "My Events";

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\MyEvents.cshtml"
  
    var user = await _userManager.GetUserAsync(User);
    var email = user != null ? user.Email : "";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""home-container p-4"">
    <div class=""row"">
        <h1 class=""text-center"">My Events</h1>
        <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
            <li class=""nav-item"" role=""presentation"">
                <button class=""nav-link active"" id=""past-tab"" data-bs-toggle=""tab"" data-bs-target=""#past"" type=""button"" role=""tab"" aria-controls=""past"" aria-selected=""true"">Past</button>
            </li>
            <li class=""nav-item"" role=""presentation"">
                <button class=""nav-link"" id=""upcoming-tab"" data-bs-toggle=""tab"" data-bs-target=""#upcoming"" type=""button"" role=""tab"" aria-controls=""upcoming"" aria-selected=""false"">Upcoming</button>
            </li>
        </ul>
        <div class=""tab-content"" id=""myTabContent"">
            <div class=""tab-pane fade show active"" id=""past"" role=""tabpanel"" aria-labelledby=""past-tab"">
                <ul class=""list-group pt-4"">
");
#nullable restore
#line 27 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\MyEvents.cshtml"
                       int eventIterator = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\MyEvents.cshtml"
                     foreach (var bookEvent in Model)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\MyEvents.cshtml"
                         if (bookEvent.Date < DateTime.Now && bookEvent.Organiser == User.Identity.Name)
                        {
                            ViewData["PositionFromStart"] = ++eventIterator;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c8d0ca05b3b774366fd975cc47a22e501ae0d71e5956", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 33 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\MyEvents.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = bookEvent;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 33 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\MyEvents.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 34 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\MyEvents.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\MyEvents.cshtml"
                         

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n            <div class=\"tab-pane fade\" id=\"upcoming\" role=\"tabpanel\" aria-labelledby=\"upcoming-tab\">\r\n                <ul class=\"list-group pt-4\">\r\n");
#nullable restore
#line 41 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\MyEvents.cshtml"
                       eventIterator = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\MyEvents.cshtml"
                     foreach (var bookEvent in Model)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\MyEvents.cshtml"
                         if (bookEvent.Date > DateTime.Now && bookEvent.Organiser==User.Identity.Name)
                        {
                            ViewData["PositionFromStart"] = ++eventIterator;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c8d0ca05b3b774366fd975cc47a22e501ae0d71e9509", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 47 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\MyEvents.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = bookEvent;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 47 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\MyEvents.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 48 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\MyEvents.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\MyEvents.cshtml"
                         

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> _signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EventViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
